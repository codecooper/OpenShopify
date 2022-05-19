using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using OpenShopify.Admin.Builder.Models;
using OpenShopify.Common.Attributes;
using OpenShopify.Common.Data;

namespace OpenShopify.Admin.Builder.Controllers.Products;

/// <inheritdoc />
[ApiGroup(ApiGroupNames.Products)]
[ApiController]
public class CollectController : CollectControllerBase
{
    /// <inheritdoc />
    [IgnoreApi, HttpPost, Route("collects.invalid")]
    [ProducesResponseType(typeof(CollectItem), StatusCodes.Status201Created)]
    public override Task AddProductToCustomCollection()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="CollectControllerBase.AddProductToCustomCollection" />
    [HttpPost, Route("collects.json")]
    [ProducesResponseType(typeof(CollectItem), StatusCodes.Status201Created)]
    public Task AddProductToCustomCollection([Required] CollectItem request)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpGet, Route("collects.json")]
    [ProducesResponseType(typeof(CollectList), StatusCodes.Status200OK)]
    public override Task RetrieveListOfCollects(string? fields, int? limit, string? page_info, int? since_id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpDelete, Route("collects/{collect_id:long}.json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public override Task RemoveProductFromCollection([Required] long collect_id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpGet, Route("collects/{collect_id:long}.json")]
    [ProducesResponseType(typeof(CollectItem), StatusCodes.Status200OK)]
    public override Task RetrieveSpecificCollectByItsID([Required] long collect_id, string? fields)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpGet, Route("collects/count.json")]
    [ProducesResponseType(typeof(CollectCount), StatusCodes.Status200OK)]
    public override Task RetrieveCountOfCollects()
    {
        throw new NotImplementedException();
    }
}