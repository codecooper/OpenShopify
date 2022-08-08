﻿namespace Ocelli.OpenShopify.Tests.ShopifyPayments;

public class BalanceFixture : SharedFixture, IAsyncLifetime
{
    public BalanceFixture() =>
        Service = new ShopifyPaymentsService(MyShopifyUrl, AccessToken);

    public IShopifyPaymentsService Service { get; set; }

    public Task InitializeAsync() => Task.CompletedTask;

    Task IAsyncLifetime.DisposeAsync() => Task.CompletedTask;
}

[TestCaseOrderer("Ocelli.OpenShopify.Tests.Fixtures.PriorityOrderer", "Ocelli.OpenShopify.Tests")]
//[Collection("BalanceTests")]
public class BalanceTests : IClassFixture<BalanceFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly BalanceMockClient _badRequestMockClient;
    private readonly BalanceMockClient _okEmptyMockClient;
    private readonly BalanceMockClient _okInvalidJsonMockClient;

    public BalanceTests(BalanceFixture fixture, ITestOutputHelper testOutputHelper)
    {
        Fixture = fixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
        _badRequestMockClient = new BalanceMockClient(fixture.BadRequestMockHttpClient, fixture);
        _okEmptyMockClient = new BalanceMockClient(fixture.OkEmptyMockHttpClient, fixture);
        _okInvalidJsonMockClient = new BalanceMockClient(fixture.OkInvalidJsonMockHttpClient, fixture);
    }

    public BalanceFixture Fixture { get; set; }


    #region Create

    #endregion Create

    #region Read

    #endregion Read

    #region Update

    #endregion Update

    #region Delete

    #endregion Delete

    [SkippableFact]
    public async Task BadRequestResponses() => await _badRequestMockClient.TestAllMethodsThatReturnData();

    [SkippableFact]
    public async Task OkEmptyResponses() => await _okEmptyMockClient.TestAllMethodsThatReturnData();

    [SkippableFact]
    public async Task OkInvalidJsonResponses() => await _okInvalidJsonMockClient.TestAllMethodsThatReturnData();
}

internal class BalanceMockClient : BalanceClient, IMockTests
{
    public BalanceMockClient(HttpClient httpClient, SharedFixture fixture) : base(httpClient)
    {
        BaseUrl = AuthorizationService.BuildShopUri(fixture.MyShopifyUrl, true).ToString();
    }

    public Task TestAllMethodsThatReturnData()
    {
        Skip.If(0==1,"Not implemented.");
        return Task.CompletedTask;
    }
}
