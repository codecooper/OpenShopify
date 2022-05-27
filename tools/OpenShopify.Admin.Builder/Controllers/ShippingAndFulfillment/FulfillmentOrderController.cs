//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.16.0.0 (NJsonSchema v10.7.1.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
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

namespace OpenShopify.Admin.Builder.Models
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.16.0.0 (NJsonSchema v10.7.1.0 (Newtonsoft.Json v13.0.0.0))")]

    public abstract class FulfillmentOrderControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves a list of fulfillment orders for a specific order
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("orders/{order_id}/fulfillment_orders.json")]
        public abstract System.Threading.Tasks.Task ListFulfillmentOrdersForSpecificOrder(long order_idUndefined);

        /// <summary>
        /// Retrieves a specific fulfillment order
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("fulfillment_orders/{fulfillment_order_id}.json")]
        public abstract System.Threading.Tasks.Task GetFulfillmentOrder(long fulfillment_order_id);

        /// <summary>
        /// Cancel a fulfillment order
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("fulfillment_orders/{fulfillment_order_id}/cancel.json")]
        public abstract System.Threading.Tasks.Task CancelFulfillmentOrder([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CancelFulfillmentOrderRequest request, long fulfillment_order_id);

        /// <summary>
        /// Marks a fulfillment order as incomplete
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("fulfillment_orders/{fulfillment_order_id}/close.json")]
        public abstract System.Threading.Tasks.Task MarkFulfillmentOrderAsIncomplete(long fulfillment_order_id);

        /// <summary>
        /// Moves a fulfillment order to a new location
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("fulfillment_orders/{fulfillment_order_id}/move.json")]
        public abstract System.Threading.Tasks.Task MoveFulfillmentOrderToNewLocation([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.MoveFulfillmentOrderToNewLocationRequest request, long fulfillment_order_id);

        /// <summary>
        /// Marks the fulfillment order as open
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("fulfillment_orders/{fulfillment_order_id}/open.json")]
        public abstract System.Threading.Tasks.Task MarkFulfillmentOrderAsOpen(long fulfillment_order_id);

        /// <summary>
        /// Reschedules the fulfill_at time of a scheduled fulfillment order
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("fulfillment_orders/{fulfillment_order_id}/reschedule.json")]
        public abstract System.Threading.Tasks.Task RescheduleFulfillAtTimeOfScheduledFulfillmentOrder([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.RescheduleFulfillAtTimeOfScheduledFulfillmentOrderRequest request, long fulfillment_order_id);

        /// <summary>
        /// Applies a fulfillment hold on a fulfillment order with status &lt;code&gt;OPEN&lt;/code&gt;
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("fulfillment_orders/{fulfillment_order_id}/hold.json")]
        public abstract System.Threading.Tasks.Task ApplyFulfillmentHoldOnFulfillmentOrder([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.ApplyFulfillmentHoldOnFulfillmentOrderRequest request, long fulfillment_order_id);

        /// <summary>
        /// Releases the fulfillment hold on a fulfillment order
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("fulfillment_orders/{fulfillment_order_id}/release_hold.json")]
        public abstract System.Threading.Tasks.Task ReleaseFulfillmentHoldOnFulfillmentOrder([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.ReleaseFulfillmentHoldOnFulfillmentOrderRequest request, long fulfillment_order_id);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.0.0 (NJsonSchema v10.7.1.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record FulfillmentOrderOrig
    {
        /// <summary>
        /// The ID of the location that has been assigned to do the work.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("assigned_location_id")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public long? AssignedLocationId { get; set; } = default!;

        /// <summary>
        /// The destination where the items should be sent.
        /// 
        /// *   **id**: The ID of the fulfillment order destination. 
        /// *   **address1**: The street address of the assigned location. 
        /// *   **address2**: An optional additional field for the street address of the assigned location. 
        /// *   **city**: The city of the destination. 
        /// *   **company**: The company of the destination. 
        /// *   **country**: The country of the destination. 
        /// *   **email**: The email of the customer at the destination. 
        /// *   **first_name**: The first name of the customer at the destination. 
        /// *   **last_name**: The last name of the customer at the destination. 
        /// *   **phone**: The phone number of the customer at the destination. 
        /// *   **province**: The province of the destination. 
        /// *   **zip**: The ZIP code of the destination. 
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("destination")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Destination { get; set; } = default!;

        /// <summary>
        /// The type of method used to transfer a product or service to a customer.
        /// 
        /// *   **id**: The ID of the delivery method. 
        /// *   **method_type**: The type of delivery method. Valid values: 
        /// 
        ///     *   **local**: A delivery to a customer's doorstep. 
        ///     *   **none**: No delivery method. 
        ///     *   **pick_up**: A delivery that a customer picks up at your retail store, curbside, or any location that you choose. 
        ///     *   **retail**: Items delivered immediately in a retail store. 
        ///     *   **shipping**: A delivery to a customer using a shipping carrier.   
        /// *   **min_delivery_date_time**: The minimum date and time by which the delivery is expected to be completed. 
        /// *   **max_delivery_date_time**: The maximum date and time by which the delivery is expected to be completed. 
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("delivery_method")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? DeliveryMethod { get; set; } = default!;

        /// <summary>
        /// The date and time at which the fulfillment order will be fulfillable. When this date and time is reached, a `scheduled` fulfillment order is automatically transitioned to `open`. For more information about fulfillment statuses, refer to the **status** property.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fulfill_at")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public System.DateTimeOffset? FulfillAt { get; set; } = default!;

        /// <summary>
        /// The latest date and time by which all items in the fulfillment order need to be fulfilled.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fulfill_by")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? FulfillBy { get; set; } = default!;

        /// <summary>
        /// Represents the fulfillment holds applied on the fulfillment order.
        /// 
        /// *   **reason**: The reason for the fulfillment hold. 
        /// *   **reason_notes**: Additional information about the fulfillment hold reason.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fulfillment_holds")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public System.Collections.Generic.List<string>? FulfillmentHolds { get; set; } = default!;

        /// <summary>
        /// The international duties relevant to the fulfillment order.
        /// 
        /// *   **incoterm**: The method of duties payment. Valid values: 
        /// 
        ///     *   **DAP**: Delivered at place. 
        ///     *   **DDP**: Delivered duty paid.  
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("international_duties")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? InternationalDuties { get; set; } = default!;

        /// <summary>
        /// Represents line items belonging to a fulfillment order:
        /// 
        /// *   **id**: The ID of the fulfillment order line item. 
        /// *   **shop_id**: The ID of the shop associated with the fulfillment order line item. 
        /// *   **fulfillment_order_id**: The ID of the fulfillment order associated with this line item. 
        /// *   **line_item_id**: The ID of the line item associated with this fulfillment order line item. 
        /// *   **inventory_item_id**: The ID of the inventory item associated with this fulfillment order line item. 
        /// *   **quantity**: The total number of units to be fulfilled. 
        /// *   **fulfillable_quantity**: The number of units remaining to be fulfilled. 
        /// *   **variant_id**: The ID of the variant associated with this fulfillment order line item.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("line_items")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? LineItems { get; set; } = default!;

        /// <summary>
        /// The ID of the order that's associated with the fulfillment order.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("order_id")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public long? OrderId { get; set; } = default!;

        /// <summary>
        /// The request status of the fulfillment order. Valid values:
        /// 
        /// *   **unsubmitted**: The initial request status for newly-created fulfillment orders. This is the only valid request status for fulfillment orders that aren't assigned to a fulfillment service.  
        /// *   **submitted**: The merchant requested fulfillment for this fulfillment order.  
        /// *   **accepted**: The fulfillment service accepted the merchant's fulfillment request.  
        /// *   **rejected**: The fulfillment service rejected the merchant's fulfillment request.  
        /// *   **cancellation_requested**: The merchant requested a cancellation of the fulfillment request for this fulfillment order.  
        /// *   **cancellation_accepted**: The fulfillment service accepted the merchant's fulfillment cancellation request.  
        /// *   **cancellation_rejected**: The fulfillment service rejected the merchant's fulfillment cancellation request.  
        /// *   **closed**: The fulfillment service closed the fulfillment order without completing it.  
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("request_status")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? RequestStatus { get; set; } = default!;

        /// <summary>
        /// The ID of the shop that's associated with the fulfillment order.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public long? ShopId { get; set; } = default!;

        /// <summary>
        /// The status of the fulfillment order. Valid values:
        /// 
        /// *   **open**: The fulfillment order is ready for fulfillment.  
        /// *   **in_progress**: The fulfillment order is being processed.  
        /// *   **scheduled**: The fulfillment order is deferred and will be ready for fulfillment after the datetime specified in `fulfill_at`.  
        /// *   **cancelled**: The fulfillment order has been cancelled by the merchant.  
        /// *   **on_hold**: The fulfillment order is on hold. The fulfillment process can't be initiated until the hold on the fulfillment order is released.  
        /// *   **incomplete**: The fulfillment order cannot be completed as requested.  
        /// *   **closed**: The fulfillment order has been completed and closed.  
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("status")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Status { get; set; } = default!;

        /// <summary>
        /// The actions that can be performed on this fulfillment order.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("supported_actions")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public System.Collections.Generic.List<string>? SupportedActions { get; set; } = default!;

        /// <summary>
        /// A list of requests sent by the merchant to the fulfillment service for this fulfillment order.
        /// 
        /// *   **message**: The message returned by the merchant, if any. 
        /// *   **request_options**: The request options returned by the merchant, if any. 
        /// *   **kind**: The kind of request. Valid values: *fulfillment_request*, *cancellation_request*, or *legacy_fulfill_request*. 
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("merchant_requests")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? MerchantRequests { get; set; } = default!;

        /// <summary>
        /// The fulfillment order's assigned location. This is the location expected to perform fulfillment.
        /// 
        /// *   **address1**: The street address of the assigned location. 
        /// *   **address2**: An optional additional field for the street address of the assigned location. 
        /// *   **city**: The city of the assigned location. 
        /// *   **country_code**: The two-letter code for the country of the assigned location. 
        /// *   **location_id**: The ID of the assigned location. 
        /// *   **name**: The name of the assigned location. 
        /// *   **phone**: The phone number of the assigned location. 
        /// *   **province**: The province of the assigned location. 
        /// *   **zip**: The ZIP code of the assigned location. 
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("assigned_location")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? AssignedLocation { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603