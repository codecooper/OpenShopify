using Microsoft.AspNetCore.Mvc;
using OpenShopify.Admin.Builder.Models;
using OpenShopify.Common.Attributes;
using OpenShopify.Common.Data;

namespace OpenShopify.Admin.Builder.Controllers.Orders;

/// <inheritdoc />
[ApiGroup(ApiGroupNames.Orders)]
[ApiController]
public class RefundController : RefundControllerBase
{
    /// <inheritdoc />
    [HttpGet, Route("orders/{order_id:long}/refunds.json")]
    public override Task RetrieveListOfRefundsForOrder(long order_id, string? fields, bool? in_shop_currency, int? limit, string? page_info)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpPost, Route("orders/{order_id:long}/refunds.json")]
    public override Task CreateRefund(RefundItem request, long order_id, string? currency, string? discrepancy_reason, string? note,
        string? notify, string? refund_line_items, string? restock, string? shipping, string? transactions)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpGet, Route("orders/{order_id:long}/refunds/{refund_id:long}.json")]
    public override Task RetrieveSpecificRefund(long order_id, long refund_id, string? fields, bool? in_shop_currency)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpPost, Route("orders/{order_id:long}/refunds/calculate.json")]
    public override Task CalculateRefund(long order_id, string? currency, string? refund_line_items, string? shipping)
    {
        throw new NotImplementedException();
    }
}