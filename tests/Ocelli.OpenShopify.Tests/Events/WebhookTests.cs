﻿namespace Ocelli.OpenShopify.Tests.Events;

public class WebhookFixture : SharedFixture, IAsyncLifetime
{
    public IEventsService Service;
    public List<Webhook> CreatedWebhooks = new();

    public WebhookFixture()
    {
        Service = new EventsService(MyShopifyUrl, AccessToken);
    }
    public Task InitializeAsync() => Task.CompletedTask;

    async Task IAsyncLifetime.DisposeAsync()
    {
        await DeleteWebhookAsync_CanDelete();
    }

    public async Task DeleteWebhookAsync_CanDelete()
    {
        foreach (var webhook in CreatedWebhooks)
        {
            _ = await Service.Webhook.DeleteWebhookAsync(webhook.Id);
        }
        CreatedWebhooks.Clear();
    }
}

[TestCaseOrderer("Ocelli.OpenShopify.Tests.Fixtures.PriorityOrderer", "Ocelli.OpenShopify.Tests")]
//[Collection("WebhookTests")]
public class WebhookTests : IClassFixture<WebhookFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly WebhookMockClient _badRequestMockClient;
    private readonly WebhookMockClient _okEmptyMockClient;
    private readonly WebhookMockClient _okInvalidJsonMockClient;

    public WebhookTests(WebhookFixture fixture, ITestOutputHelper testOutputHelper)
    {
        Fixture = fixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
        _badRequestMockClient = new WebhookMockClient(fixture.BadRequestMockHttpClient, fixture);
        _okEmptyMockClient = new WebhookMockClient(fixture.OkEmptyMockHttpClient, fixture);
        _okInvalidJsonMockClient = new WebhookMockClient(fixture.OkInvalidJsonMockHttpClient, fixture);
    }

    private WebhookFixture Fixture { get; }

    #region Create

    [SkippableFact, TestPriority(10)]
    public async Task CreateWebhookAsync_CanCreate()
    {
        var request = Fixture.CreateWebhookRequest();
        var response = await Fixture.Service.Webhook.CreateWebhookAsync(request);
        _additionalPropertiesHelper.CheckAdditionalProperties(response, Fixture.MyShopifyUrl);

        Fixture.CreatedWebhooks.Add(response.Result.Webhook);
    }

    [SkippableFact]
    [TestPriority(10)]
    public async Task CreateWebhookAsync_EmptyBody_IsError()
    {
        var request = new CreateWebhookRequest
        {
            Webhook = new CreateWebhook()
        };
        await Assert.ThrowsAsync<ApiException<WebhookError>>(async () =>
            await Fixture.Service.Webhook.CreateWebhookAsync(request));
    }

    [SkippableFact]
    [TestPriority(10)]
    public async Task CreateWebhookAsync_IsUnprocessableEntityError()
    {
        var request = new CreateWebhookRequest
        {
            Webhook = new CreateWebhook()
            {
                Topic = WebhookTopic.AppUninstalled
            }
        };
        await Assert.ThrowsAsync<ApiException<WebhookError>>(async () =>
            await Fixture.Service.Webhook.CreateWebhookAsync(request));
    }

    #endregion Create

    #region Read

    [SkippableFact, TestPriority(20)]
    public async Task CountWebhooksAsync_CanGet()
    {
        var response = await Fixture.Service.Webhook.CountWebhooksAsync();
        _additionalPropertiesHelper.CheckAdditionalProperties(response, Fixture.MyShopifyUrl);
        var count = response.Result.Count;
        Skip.If(count == 0, "No results returned. Unable to test");
    }

    [SkippableFact, TestPriority(20)]
    public async Task ListWebhooksAsync_AdditionalPropertiesAreEmpty()
    {
        var response = await Fixture.Service.Webhook.ListWebhooksAsync();
        _additionalPropertiesHelper.CheckAdditionalProperties(response, Fixture.MyShopifyUrl);
        foreach (var webhook in response.Result.Webhooks)
        {
            _additionalPropertiesHelper.CheckAdditionalProperties(webhook, Fixture.MyShopifyUrl);
        }

        Skip.If(!response.Result.Webhooks.Any(), "No results returned. Unable to test");
    }

    [SkippableFact, TestPriority(20)]
    public async Task GetWebhookAsync_TestCreated_AdditionalPropertiesAreEmpty()
    {
        Skip.If(!Fixture.CreatedWebhooks.Any(), "Must be run with create test");
        var webhook = Fixture.CreatedWebhooks.First();
        var response = await Fixture.Service.Webhook.GetWebhookAsync(webhook.Id);
        _additionalPropertiesHelper.CheckAdditionalProperties(response, Fixture.MyShopifyUrl);
        _additionalPropertiesHelper.CheckAdditionalProperties(response.Result.Webhook, Fixture.MyShopifyUrl);
    }

    #endregion Read

    #region Update

    [SkippableFact, TestPriority(30)]
    public async Task UpdateWebhookAsync_CanUpdate()
    {
        var originalWebhook = Fixture.CreatedWebhooks.First();
        var request = new UpdateWebhookRequest()
        {
            Webhook = new()
            {
                Id = originalWebhook.Id,
                Fields = new List<string> { "id" }
            }
        };
        var response = await Fixture.Service.Webhook.UpdateWebhookAsync(originalWebhook.Id, request);
        _additionalPropertiesHelper.CheckAdditionalProperties(response, Fixture.MyShopifyUrl);

        Fixture.CreatedWebhooks.Remove(originalWebhook);
        Fixture.CreatedWebhooks.Add(response.Result.Webhook);
    }

    #endregion Update

    #region Delete

    [SkippableFact, TestPriority(99)]
    public async Task DeleteWebhookAsync_CanDelete()
    {
        await Fixture.DeleteWebhookAsync_CanDelete();
    }

    #endregion Delete

    [SkippableFact]
    public async Task BadRequestResponses() => await _badRequestMockClient.TestAllMethodsThatReturnData();

    [SkippableFact]
    public async Task OkEmptyResponses() => await _okEmptyMockClient.TestAllMethodsThatReturnData();

    [SkippableFact]
    public async Task OkInvalidJsonResponses() => await _okInvalidJsonMockClient.TestAllMethodsThatReturnData();
}

internal class WebhookMockClient : WebhookClient, IMockTests
{
    public WebhookMockClient(HttpClient httpClient, SharedFixture fixture) : base(httpClient)
    {
        BaseUrl = AuthorizationService.BuildShopUri(fixture.MyShopifyUrl, true).ToString();
    }

    public Task TestAllMethodsThatReturnData()
    {
        Skip.If(0==1,"Not implemented.");
        return Task.CompletedTask;
    }
}
