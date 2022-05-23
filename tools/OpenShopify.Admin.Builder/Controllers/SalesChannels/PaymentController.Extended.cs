using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using OpenShopify.Common.Attributes;
using OpenShopify.Common.Data;
using OpenShopify.Admin.Builder.Models;

namespace OpenShopify.Admin.Builder.Controllers.SalesChannels;

/// <inheritdoc />
[ApiGroup(ApiGroupNames.SalesChannels)]
[ApiController]
public class PaymentController : PaymentControllerBase
{
    ///TODO: different URLs https://shopify.dev/api/admin-rest/2022-04/resources/payment#post-https:-elb.deposit.shopifycs.com-sessions
    /// <inheritdoc />
    [IgnoreApi]
    [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("elb.deposit.shopifycs.com/sessions")]
    public override Task StoreCreditCardInCardVault(string credit_card)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpPost, Route("checkouts/{token:long}/payments.json")]
    public override Task CreatePayment(CreatePaymentRequest request, decimal? amount = null, string? request_details = null,
        long? session_id = null, string? token = null, string? unique_token = null)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpGet, Route("checkouts/{token:long}/payments.json")]
    public override Task ListPaymentsOnParticularCheckout(string token)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpGet, Route("checkouts/{token:long}/payments/{payment_id:long}.json")]

    public override Task GetPayment([Required] long payment_id, string token)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [HttpGet, Route("checkouts/{token:long}/payments/count.json")]
    [ProducesResponseType(typeof(CountItem), StatusCodes.Status200OK)]
    public override Task CountNumberOfPaymentsAttemptedOnCheckout(string token)
    {
        throw new NotImplementedException();
    }
}
