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

namespace OpenShopify.Admin.Builder
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]

    public abstract class FulfillmentControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves fulfillments associated with an order
        /// </summary>
        /// <param name="created_at_max">Show fulfillments created before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="created_at_min">Show fulfillments created after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="fields">A comma-separated list of fields to include in the response.</param>
        /// <param name="limit">Limit the amount of results.</param>
        /// <param name="since_id">Restrict results to after the specified ID.</param>
        /// <param name="updated_at_max">Show fulfillments last updated before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="updated_at_min">Show fulfillments last updated after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <returns>Retrieves fulfillments associated with an order</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/fulfillments.json")]
        public abstract System.Threading.Tasks.Task RetrieveFulfillmentsAssociatedWithOrder(string order_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? created_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? created_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? limit = "50", [Microsoft.AspNetCore.Mvc.FromQuery] string? since_id = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? updated_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? updated_at_min = null);

        /// <summary>
        /// Create a new Fulfillment
        /// </summary>
        /// <returns>Create a new Fulfillment</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/fulfillments.json")]
        public abstract System.Threading.Tasks.Task CreateNewFulfillment(string order_id);

        /// <summary>
        /// Retrieves fulfillments associated with a fulfillment order
        /// </summary>
        /// <returns>Retrieves fulfillments associated with a fulfillment order</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("fulfillment_orders/{fulfillment_order_id}/fulfillments.json")]
        public abstract System.Threading.Tasks.Task RetrieveFulfillmentsAssociatedWithFulfillmentOrder(string fulfillment_order_id);

        /// <summary>
        /// Retrieves a count of fulfillments associated with a specific order
        /// </summary>
        /// <param name="created_at_max">Count fulfillments created before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="created_at_min">Count fulfillments created after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="updated_at_max">Count fulfillments last updated before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="updated_at_min">Count fulfillments last updated after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <returns>Retrieves a count of fulfillments associated with a specific order</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/fulfillments/count.json")]
        public abstract System.Threading.Tasks.Task RetrieveCountOfFulfillmentsAssociatedWithSpecificOrder(string order_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? created_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? created_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? updated_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? updated_at_min = null);

        /// <summary>
        /// Receive a single Fulfillment
        /// </summary>
        /// <param name="fields">Comma-separated list of fields to include in the response.</param>
        /// <returns>Receive a single Fulfillment</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/fulfillments/{fulfillment_id}.json")]
        public abstract System.Threading.Tasks.Task ReceiveSingleFulfillment(string fulfillment_id, string order_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null);

        /// <summary>
        /// Modify an existing Fulfillment
        /// </summary>
        /// <returns>Modify an existing Fulfillment</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/fulfillments/{fulfillment_id}.json")]
        public abstract System.Threading.Tasks.Task ModifyExistingFulfillment(string fulfillment_id, string order_id);

        /// <summary>
        /// Creates a fulfillment for one or many fulfillment orders
        /// </summary>
        /// <returns>Creates a fulfillment for one or many fulfillment orders</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("fulfillments.json")]
        public abstract System.Threading.Tasks.Task CreateFulfillmentForOneOrManyFulfillmentOrders();

        /// <summary>
        /// Updates the tracking information for a fulfillment
        /// </summary>
        /// <returns>Updates the tracking information for a fulfillment</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("fulfillments/{fulfillment_id}/update_tracking.json")]
        public abstract System.Threading.Tasks.Task UpdateTheTrackingInformationForFulfillment(string fulfillment_id);

        /// <summary>
        /// Complete a fulfillment
        /// </summary>
        /// <returns>Complete a fulfillment</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/fulfillments/{fulfillment_id}/complete.json")]
        public abstract System.Threading.Tasks.Task CompleteFulfillment(string fulfillment_id, string order_id);

        /// <summary>
        /// Transition a fulfillment from pending to open.
        /// </summary>
        /// <returns>Transition a fulfillment from pending to open.</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/fulfillments/{fulfillment_id}/open.json")]
        public abstract System.Threading.Tasks.Task TransitionFulfillmentFromPendingToOpen(string fulfillment_id, string order_id);

        /// <summary>
        /// Cancel a fulfillment for a specific order ID
        /// </summary>
        /// <returns>Cancel a fulfillment for a specific order ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/fulfillments/{fulfillment_id}/cancel.json")]
        public abstract System.Threading.Tasks.Task CancelFulfillmentForSpecificOrderID(string fulfillment_id, string order_id);

        /// <summary>
        /// Cancels a fulfillment
        /// </summary>
        /// <returns>Cancels a fulfillment</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("fulfillments/{fulfillment_id}/cancel.json")]
        public abstract System.Threading.Tasks.Task CancelFulfillment(string fulfillment_id);

    }

    


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603