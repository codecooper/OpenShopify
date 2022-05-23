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

    public abstract class WebhookControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves a list of webhooks
        /// </summary>
        /// <param name="address">Retrieve webhook subscriptions that send the POST request to this URI.</param>
        /// <param name="created_at_max">Retrieve webhook subscriptions that were created before a given date and time (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="created_at_min">Retrieve webhook subscriptions that were created after a given date and time (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="fields">Comma-separated list of the properties you want returned for each item in the result list. Use this parameter to restrict the returned list of items to only those properties you specify.</param>
        /// <param name="limit">Maximum number of webhook subscriptions that should be returned. Setting this parameter outside the maximum range will return an error.</param>
        /// <param name="page_info">A unique ID used to access a certain page of results.</param>
        /// <param name="since_id">Restrict the returned list to webhook subscriptions whose id is greater than the specified since_id.</param>
        /// <param name="topic">Show webhook subscriptions with a given topic.For a list of valid values, refer to the [`topic` property](#topic-property-{{ current_version }}).&gt;</param>
        /// <param name="updated_at_max">Retrieve webhooks that were updated after a given date and time (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="updated_at_min">Retrieve webhooks that were updated before a given date and time (format: 2014-04-25T16:15:47-04:00).</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("webhooks.json")]
        public abstract System.Threading.Tasks.Task ListWebhooks(string? address = null, System.DateTimeOffset? created_at_max = null, System.DateTimeOffset? created_at_min = null, string? fields = null, int? limit = null, string? page_info = null, long? since_id = null, string? topic = null, System.DateTimeOffset? updated_at_max = null, System.DateTimeOffset? updated_at_min = null);

        /// <summary>
        /// Create a new Webhook
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("webhooks.json")]
        public abstract System.Threading.Tasks.Task CreateWebhook([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CreateWebhookRequest request);

        /// <summary>
        /// Receive a count of all Webhooks
        /// </summary>
        /// <param name="address">Webhook subscriptions that send the POST request to this URI.</param>
        /// <param name="topic">The topic of the webhook subscriptions.For a list of valid values, refer to the [`topic` property](#topic-property-{{ current_version }}).</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("webhooks/count.json")]
        public abstract System.Threading.Tasks.Task CountWebhooks(string? address = null, string? topic = null);

        /// <summary>
        /// Receive a single Webhook
        /// </summary>
        /// <param name="fields">Comma-separated list of the properties you want returned for each item in the result list. Use this parameter to restrict the returned list of items to only those properties you specify.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("webhooks/{webhook_id}.json")]
        public abstract System.Threading.Tasks.Task GetWebhook(long webhook_id, string? fields = null);

        /// <summary>
        /// Modify an existing Webhook
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("webhooks/{webhook_id}.json")]
        public abstract System.Threading.Tasks.Task UpdateWebhook([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.UpdateWebhookRequest request, long webhook_id);

        /// <summary>
        /// Remove an existing Webhook
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("webhooks/{webhook_id}.json")]
        public abstract System.Threading.Tasks.Task DeleteWebhook(long webhook_id);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.0.0 (NJsonSchema v10.7.1.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record WebhookOrig
    {
        /// <summary>
        /// Destination URI to which the webhook subscription should send the POST request when an event occurs.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("address")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Address { get; set; } = default!;

        /// <summary>
        /// The Admin API version that Shopify uses to serialize webhook events. This value is inherited from the app that created the webhook subscription.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("api_version")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? ApiVersion { get; set; } = default!;

        /// <summary>
        /// Date and time when the webhook subscription was created. The API returns this value in [ISO 8601 format](https://en.wikipedia.org/wiki/ISO_8601).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("created_at")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public System.DateTimeOffset? CreatedAt { get; set; } = default!;

        /// <summary>
        /// An optional array of top-level resource fields that should be serialized and sent in the POST request. If absent, all fields will be sent.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fields")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public System.Collections.Generic.List<string>? Fields { get; set; } = default!;

        /// <summary>
        /// Format in which the webhook subscription should send the data. Valid values are `JSON` and `XML`. Defaults to `JSON`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("format")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Format { get; set; } = default!;

        /// <summary>
        /// Optional array of namespaces for any metafields that should be included with each webhook.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("metafield_namespaces")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public System.Collections.Generic.List<string>? MetafieldNamespaces { get; set; } = default!;

        /// <summary>
        /// Optional array of namespaces for any private metafields that should be included with each webhook.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("private_metafield_namespaces")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? PrivateMetafieldNamespaces { get; set; } = default!;

        /// <summary>
        /// Event that triggers the webhook. Valid values are: app/uninstalled, bulk_operations/finish, carts/create, carts/update, checkouts/create, checkouts/delete, checkouts/update, collection_listings/add, collection_listings/remove, collection_listings/update, collections/create, collections/delete, collections/update, customer_groups/create, customer_groups/delete, customer_groups/update, customer_payment_methods/create, customer_payment_methods/revoke, customer_payment_methods/update, customers/create, customers/delete, customers/disable, customers/enable, customers/update, customers_marketing_consent/update, disputes/create, disputes/update, domains/create, domains/destroy, domains/update, draft_orders/create, draft_orders/delete, draft_orders/update, fulfillment_events/create, fulfillment_events/delete, fulfillments/create, fulfillments/update, inventory_items/create, inventory_items/delete, inventory_items/update, inventory_levels/connect, inventory_levels/disconnect, inventory_levels/update, locales/create, locales/update, locations/create, locations/delete, locations/update, markets/create, markets/delete, markets/update, order_transactions/create, orders/cancelled, orders/create, orders/delete, orders/edited, orders/fulfilled, orders/paid, orders/partially_fulfilled, orders/updated, product_listings/add, product_listings/remove, product_listings/update, products/create, products/delete, products/update, profiles/create, profiles/delete, profiles/update, refunds/create, scheduled_product_listings/add, scheduled_product_listings/remove, scheduled_product_listings/update, selling_plan_groups/create, selling_plan_groups/delete, selling_plan_groups/update, shop/update, subscription_billing_attempts/challenged, subscription_billing_attempts/failure, subscription_billing_attempts/success, subscription_contracts/create, subscription_contracts/update, tender_transactions/create, themes/create, themes/delete, themes/publish, themes/update
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("topic")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Topic { get; set; } = default!;

        /// <summary>
        /// Date and time when the webhook subscription was updated. The API returns this value in [ISO 8601 format](https://en.wikipedia.org/wiki/ISO_8601).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("updated_at")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public System.DateTimeOffset? UpdatedAt { get; set; } = default!;

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