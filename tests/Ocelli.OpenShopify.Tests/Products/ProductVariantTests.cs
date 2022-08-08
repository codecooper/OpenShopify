﻿namespace Ocelli.OpenShopify.Tests.Products;

public class ProductVariantFixture : SharedFixture, IAsyncLifetime
{
    public List<ProductVariant> CreatedProductVariants = new();
    public Product Product = new();
    public IProductsService Service;

    public ProductVariantFixture() =>
        Service = new ProductsService(MyShopifyUrl, AccessToken);

    public async Task InitializeAsync() => await CreateProduct();

    async Task IAsyncLifetime.DisposeAsync()
    {
        await DeleteProductVariantAsync_CanDelete();

        if (Product.Id > 0)
        {
            await Service.Product.DeleteProductAsync(Product.Id);
        }
    }

    public async Task CreateProduct()
    {
        var request = CreateProductRequest();
        var productResponse = await Service.Product.CreateProductAsync(request);
        Product = productResponse.Result.Product;
    }
    
    public async Task DeleteProductVariantAsync_CanDelete()
    {
        foreach (var productVariant in CreatedProductVariants)
        {
            _ = await Service.ProductVariant.DeleteProductVariantAsync(Product.Id, productVariant.Id);
        }
        CreatedProductVariants.Clear();
    }
}

[TestCaseOrderer("Ocelli.OpenShopify.Tests.Fixtures.PriorityOrderer", "Ocelli.OpenShopify.Tests")]
//[Collection("ProductVariantTests")]
public class ProductVariantTests : IClassFixture<ProductVariantFixture>
{
    private readonly AdditionalPropertiesHelper _additionalPropertiesHelper;
    private readonly ProductVariantMockClient _badRequestMockClient;
    private readonly ProductVariantMockClient _okEmptyMockClient;
    private readonly ProductVariantMockClient _okInvalidJsonMockClient;

    public ProductVariantTests(ProductVariantFixture fixture, ITestOutputHelper testOutputHelper)
    {
        Fixture = fixture;
        _additionalPropertiesHelper = new AdditionalPropertiesHelper(testOutputHelper);
        _badRequestMockClient = new ProductVariantMockClient(fixture.BadRequestMockHttpClient, fixture);
        _okEmptyMockClient = new ProductVariantMockClient(fixture.OkEmptyMockHttpClient, fixture);
        _okInvalidJsonMockClient = new ProductVariantMockClient(fixture.OkInvalidJsonMockHttpClient, fixture);
    }

    private ProductVariantFixture Fixture { get; }

    #region Update

    [SkippableFact]
    [TestPriority(30)]
    public async Task UpdateProductVariantAsync_CanUpdate()
    {
        Skip.If(!Fixture.CreatedProductVariants.Any(), "Must be run with create test");
        var originalProductVariant = Fixture.CreatedProductVariants.First();
        var request = new UpdateProductVariantRequest
        {
            Variant = new UpdateProductVariant
            {
                Id = originalProductVariant.Id,
                Option1 = "Not Pink",
                Price = (decimal)99.00
            }
        };
        var response =
            await Fixture.Service.ProductVariant.UpdateProductVariantAsync(originalProductVariant.Id, request);
        _additionalPropertiesHelper.CheckAdditionalProperties(response, Fixture.MyShopifyUrl);

        Fixture.CreatedProductVariants.Remove(originalProductVariant);
        Fixture.CreatedProductVariants.Add(response.Result.Variant);
    }

    #endregion Update

    #region Create

    [SkippableFact]
    [TestPriority(10)]
    public async Task CreateProductVariantAsync_CanCreate()
    {
        var request = Fixture.CreateProductVariantRequest();
        var response = await Fixture.Service.ProductVariant.CreateProductVariantAsync(Fixture.Product.Id, request);
        _additionalPropertiesHelper.CheckAdditionalProperties(response, Fixture.MyShopifyUrl);

        Fixture.CreatedProductVariants.Add(response.Result.Variant);
    }

    [SkippableFact]
    [TestPriority(10)]
    public async Task CreateProductVariantAsync_IsUnprocessableEntityError()
    {
        var request = new CreateProductVariantRequest
        {
            Variant = new CreateProductVariant()
        };
        await Assert.ThrowsAsync<ApiException<ProductVariantError>>(async () =>
            await Fixture.Service.ProductVariant.CreateProductVariantAsync(Fixture.Product.Id, request));
    }

    #endregion Create

    #region Read

    [SkippableFact]
    [TestPriority(20)]
    public async Task CountProductVariantsAsync_CanGet()
    {
        var response = await Fixture.Service.ProductVariant.CountProductVariantsAsync(Fixture.Product.Id);
        _additionalPropertiesHelper.CheckAdditionalProperties(response, Fixture.MyShopifyUrl);
        var count = response.Result.Count;
        Skip.If(count == 0, "No results returned. Unable to test");
    }

    [SkippableFact]
    [TestPriority(20)]
    public async Task ListProductVariantsAsync_AdditionalPropertiesAreEmpty()
    {
        var response = await Fixture.Service.ProductVariant.ListProductVariantsAsync(Fixture.Product.Id);
        _additionalPropertiesHelper.CheckAdditionalProperties(response, Fixture.MyShopifyUrl);
        foreach (var productVariant in response.Result.Variants)
        {
            _additionalPropertiesHelper.CheckAdditionalProperties(productVariant, Fixture.MyShopifyUrl);
        }

        Skip.If(!response.Result.Variants.Any(), "No results returned. Unable to test");
    }

    [SkippableFact]
    [TestPriority(20)]
    public async Task GetProductVariantAsync_TestCreated_AdditionalPropertiesAreEmpty()
    {
        Skip.If(!Fixture.CreatedProductVariants.Any(), "Must be run with create test");
        var productVariant = Fixture.CreatedProductVariants.First();
        var response = await Fixture.Service.ProductVariant.GetProductVariantAsync(productVariant.Id);
        _additionalPropertiesHelper.CheckAdditionalProperties(response, Fixture.MyShopifyUrl);
        _additionalPropertiesHelper.CheckAdditionalProperties(response.Result.Variant, Fixture.MyShopifyUrl);
    }

    #endregion Read

    #region Delete

    [SkippableFact]
    [TestPriority(99)]
    public async Task DeleteProductVariantAsync_CanDelete()
    {
        await Fixture.DeleteProductVariantAsync_CanDelete();
    }

    #endregion Delete


    [SkippableFact]
    public async Task BadRequestResponses() => await _badRequestMockClient.TestAllMethodsThatReturnData();

    [SkippableFact]
    public async Task OkEmptyResponses() => await _okEmptyMockClient.TestAllMethodsThatReturnData();

    [SkippableFact]
    public async Task OkInvalidJsonResponses() => await _okInvalidJsonMockClient.TestAllMethodsThatReturnData();
}

internal class ProductVariantMockClient : ProductVariantClient, IMockTests
{
    public ProductVariantMockClient(HttpClient httpClient, SharedFixture fixture) : base(httpClient)
    {
        BaseUrl = AuthorizationService.BuildShopUri(fixture.MyShopifyUrl, true).ToString();
    }

    public Task TestAllMethodsThatReturnData()
    {
        Skip.If(0==1,"Not implemented.");
        return Task.CompletedTask;
    }
}
