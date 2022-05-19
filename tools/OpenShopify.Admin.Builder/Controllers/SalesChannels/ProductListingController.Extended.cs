using Microsoft.AspNetCore.Mvc;
using OpenShopify.Common.Attributes;
using OpenShopify.Common.Data;
using OpenShopify.Admin.Builder.Models;

namespace OpenShopify.Admin.Builder.Controllers.SalesChannels;

/// <inheritdoc />
[ApiGroup(ApiGroupNames.SalesChannels)]
[ApiController]
public class ProductListingController : ProductListingControllerBase
{
    /// <inheritdoc />
    [HttpGet, Route("product_listings.json")]
    public override Task RetrieveProductListingsThatArePublishedToYourApp(long? collection_id, string? handle, int? limit, string? page_info,
        long? product_ids, DateTime? updated_at_min)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpGet, Route("product_listings/product_ids.json")]
    public override Task RetrieveProductIdsThatArePublishedToYourApp(int? limit, string? page_info)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpGet, Route("product_listings/count.json")]
    [ProducesResponseType(typeof(PublishedProductCount), StatusCodes.Status200OK)]
    public override Task RetrieveCountOfProductsThatArePublishedToYourApp()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpGet, Route("product_listings/{product_listing_id:long}.json")]
    public override Task RetrieveSpecificProductListingThatIsPublishedToYourApp(long product_listing_id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpPut, Route("product_listings/{product_listing_id:long}.json")]
    public override Task CreateProductListingToPublishProductToYourApp(ProductListingItem request, long product_listing_id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpDelete, Route("product_listings/{product_listing_id:long}.json")]
    public override Task DeleteProductListingToUnpublishProductFromYourApp(long product_listing_id)
    {
        throw new NotImplementedException();
    }
}