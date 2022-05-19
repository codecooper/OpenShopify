//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

using System.Text.Json;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"

namespace OpenShopify.Admin.Builder.Controllers
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]

    public abstract class RefundControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves a list of refunds for an order
        /// </summary>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        /// <param name="in_shop_currency">Show amounts in the shop currency for the underlying transaction.</param>
        /// <param name="limit">The maximum number of results to retrieve.</param>
        /// <returns>Retrieves a list of refunds for an order</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/refunds.json")]
        public abstract System.Threading.Tasks.Task RetrieveListOfRefundsForOrder(long order_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields, [Microsoft.AspNetCore.Mvc.FromQuery] bool? in_shop_currency, [Microsoft.AspNetCore.Mvc.FromQuery] int? limit, string? page_info);

        /// <summary>
        /// Creates a refund
        /// </summary>
        /// <param name="currency">&lt;p&gt;The three-letter code (&lt;a href="https://en.wikipedia.org/wiki/ISO_4217" target="_blank"&gt;ISO 4217&lt;/a&gt; format) for the currency used for the refund.&lt;/p&gt;</param>
        /// <param name="discrepancy_reason">An optional comment that explains a discrepancy between calculated and actual refund amounts. Used to populate the &lt;code&gt;reason&lt;/code&gt; property of the resulting &lt;code&gt;order_adjustment&lt;/code&gt; object attached to the refund. Valid values: &lt;code&gt;restock&lt;/code&gt;, &lt;code&gt;damage&lt;/code&gt;, &lt;code&gt;customer&lt;/code&gt;, and &lt;code&gt;other&lt;/code&gt;.</param>
        /// <param name="note">An optional note attached to a refund.</param>
        /// <param name="notify">Whether to send a refund notification to the customer.</param>
        /// <param name="refund_line_items">A list of line item IDs, quantities to refund, and restock instructions. Each entry has the following properties:</param>
        /// <param name="restock">Whether to add the line items back to the store inventory. Use &lt;code&gt;restock_type&lt;/code&gt; for refund line items instead.</param>
        /// <param name="shipping">Specify how much shipping to refund. It has the following properties:</param>
        /// <param name="transactions">A list of &lt;a href="/api/admin-rest/current/resources/transaction"&gt;transactions&lt;/a&gt;
        /// <br/>          to process as refunds. Use the &lt;code&gt;calculate&lt;/code&gt; endpoint to obtain these transactions.</param>
        /// <returns>Creates a refund</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/refunds.json")]
        public abstract System.Threading.Tasks.Task CreateRefund([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.RefundItem request, long order_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? currency, [Microsoft.AspNetCore.Mvc.FromQuery] string? discrepancy_reason, [Microsoft.AspNetCore.Mvc.FromQuery] string? note, [Microsoft.AspNetCore.Mvc.FromQuery] string? notify, [Microsoft.AspNetCore.Mvc.FromQuery] string? refund_line_items, [Microsoft.AspNetCore.Mvc.FromQuery] string? restock, [Microsoft.AspNetCore.Mvc.FromQuery] string? shipping, [Microsoft.AspNetCore.Mvc.FromQuery] string? transactions);

        /// <summary>
        /// Retrieves a specific refund
        /// </summary>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        /// <param name="in_shop_currency">Show amounts in the shop currency for the underlying transaction.</param>
        /// <returns>Retrieves a specific refund</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/refunds/{refund_id}.json")]
        public abstract System.Threading.Tasks.Task RetrieveSpecificRefund(long order_id, long refund_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields, [Microsoft.AspNetCore.Mvc.FromQuery] bool? in_shop_currency);

        /// <summary>
        /// Calculates a refund
        /// </summary>
        /// <param name="currency">&lt;p&gt;The three-letter code (&lt;a href="https://en.wikipedia.org/wiki/ISO_4217" target="_blank"&gt;ISO 4217&lt;/a&gt; format) for the
        /// <br/>          currency used for the refund. &lt;strong&gt;Note:&lt;/strong&gt; Required whenever the shipping &lt;code&gt;amount&lt;/code&gt; property is provided.&lt;/p&gt;</param>
        /// <param name="refund_line_items">A list of line item IDs, quantities to refund, and restock instructions. Each entry has the following properties:</param>
        /// <param name="shipping">Specify how much shipping to refund. It has the following properties:</param>
        /// <returns>Calculates a refund</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/refunds/calculate.json")]
        public abstract System.Threading.Tasks.Task CalculateRefund(long order_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? currency, [Microsoft.AspNetCore.Mvc.FromQuery] string? refund_line_items, [Microsoft.AspNetCore.Mvc.FromQuery] string? shipping);

    }

    


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603