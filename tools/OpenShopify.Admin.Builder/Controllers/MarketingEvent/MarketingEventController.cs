//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
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

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]

    public abstract class MarketingEventControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves a list of all marketing events
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all marketing events. **Note:** As of version 2019-10, this endpoint implements pagination by using links that are provided in the response header. Sending the `page` parameter will return an error. To learn more, refer to [Make paginated requests to the REST Admin API](/api/usage/pagination-rest).
        /// </remarks>
        /// <param name="limit">The amount of results to return.</param>
        /// <param name="page_info">A unique ID used to access a certain page of results.</param>
        /// <param name="offset">The number of marketing events to skip.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("marketing_events.json")]
        public abstract System.Threading.Tasks.Task ListMarketingEvents([Microsoft.AspNetCore.Mvc.FromQuery] int? limit = null, string? page_info = null, [Microsoft.AspNetCore.Mvc.FromQuery] int? offset = null);

        /// <summary>
        /// Creates a marketing event
        /// </summary>
        /// <remarks>
        /// Marketing events can be created to track ad campaigns that target a specific time of year. For example, a marketing event can be created to track a Facebook ad campaign for Christmas 2022. When creating the marketing event, the body of the request includes the UTM parameters that must be included in the links provided in the marketing event. Each marketing event also includes the `event_type` and `marketing_channel` properties that help Shopify to rank your app and surface it within Shopify admin.
        /// 
        /// After a marketing event is created in Shopify, you can start to drive traffic to Shopify. Make sure that the links for the marketing event contain the same UTM parameters that were defined in the marketing event. For example, marketing activities for the Christmas 2022 ad campaign would use the following URL convention:
        /// 
        /// `https://storename.com/product?utm_source=facebook&amp;utm_medium=cpc&amp;utm_campaign=Christmas2022-12142018`
        /// </remarks>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("marketing_events.json")]
        public abstract System.Threading.Tasks.Task CreateMarketingEvent([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CreateMarketingEventRequest request);

        /// <summary>
        /// Retrieves a count of all marketing events
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("marketing_events/count.json")]
        public abstract System.Threading.Tasks.Task CountMarketingEvents();

        /// <summary>
        /// Retrieves a single marketing event
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("marketing_events/{marketing_event_id}.json")]
        public abstract System.Threading.Tasks.Task GetMarketingEvent(long marketing_event_id);

        /// <summary>
        /// Updates a marketing event
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("marketing_events/{marketing_event_id}.json")]
        public abstract System.Threading.Tasks.Task UpdateMarketingEvent([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.UpdateMarketingEventRequest request, long marketing_event_id);

        /// <summary>
        /// Deletes a marketing event
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("marketing_events/{marketing_event_id}.json")]
        public abstract System.Threading.Tasks.Task DeleteMarketingEvent(long marketing_event_id);

        /// <summary>
        /// Creates marketing engagements on a marketing event
        /// </summary>
        /// <remarks>
        /// Engagements on marketing events represent customer activity taken on the marketing event before customers reach the shop’s website. Not all types of marketing events will necessarily have engagement, and most types of marketing events will only use a subset of the possible engagement types.
        /// 
        /// Engagements are aggregated on a daily basis. However, the data can be sent more often than once a day if the information is available. If you create an engagement with the same value for `occurred_on` as an existing engagement, then the new engagement will overwrite the previous one.
        /// </remarks>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("marketing_events/{marketing_event_id}/engagements.json")]
        public abstract System.Threading.Tasks.Task CreateMarketingEngagementsOnMarketingEvent([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CreateMarketingEngagementsOnMarketingEventRequest request, long marketing_event_id);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum MarketingEventEventType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"ad")]
        Ad = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"post")]
        Post = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"message")]
        Message = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"retargeting")]
        Retargeting = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"transactional")]
        Transactional = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"affiliate")]
        Affiliate = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"loyalty")]
        Loyalty = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"newsletter")]
        Newsletter = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"abandoned_cart")]
        AbandonedCart = 8,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum MarketingEventMarketingChannel
    {

        [System.Runtime.Serialization.EnumMember(Value = @"search")]
        Search = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"display")]
        Display = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"social")]
        Social = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"email")]
        Email = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"referral")]
        Referral = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum MarketingEventBudgetType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"budget")]
        Budget = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"daily")]
        Daily = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"lifetime")]
        Lifetime = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum MarketingEventMarketedResources
    {

        [System.Runtime.Serialization.EnumMember(Value = @"type")]
        Type = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"id")]
        Id = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"product")]
        Product = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"collection")]
        Collection = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"price_rule")]
        PriceRule = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"discount")]
        Discount = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"page")]
        Page = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"article")]
        Article = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"homepage")]
        Homepage = 8,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record MarketingEventOrig
    {
        /// <summary>
        /// An optional remote identifier for a marketing event. The remote identifier lets Shopify validate engagement data.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("remote_id")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? RemoteId { get; set; } = default!;

        /// <summary>
        /// The type of marketing event. Valid values: `ad`, `post`, `message`, `retargeting`, `transactional`, `affiliate`, `loyalty`, `newsletter`, `abandoned_cart`. &lt;div class='note'&gt; 
        /// 
        /// #### Note
        /// 
        /// If there are values that you’d like to use for event_type that are not in the list above, then please post your request [here](https://ecommerce.shopify.com/c/partner-feedback/t/marketing-events-apis-feedback-thread-521758). Our approach is to be more structured than using freeform text, but to still allow for categorization of most types of marketing actions.
        ///  &lt;/div&gt;
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("event_type")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? EventType { get; set; } = default!;

        /// <summary>
        /// The channel that your marketing event will use. Valid values: `search`, `display`, `social`, `email`, `referral`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("marketing_channel")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? MarketingChannel { get; set; } = default!;

        /// <summary>
        /// Whether the event is paid or organic.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("paid")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public bool? Paid { get; set; } = default!;

        /// <summary>
        /// The destination domain of the marketing event. Required if the `marketing_channel` is set to `search` or `social`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("referring_domain")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? ReferringDomain { get; set; } = default!;

        /// <summary>
        /// The budget of the ad campaign.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("budget")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Budget { get; set; } = default!;

        /// <summary>
        /// The currency for the budget. Required if `budget` is specified.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("currency")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Currency { get; set; } = default!;

        /// <summary>
        /// The type of the budget. Required if `budget` is specified. Valid values: `daily`, `lifetime`.'
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("budget_type")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? BudgetType { get; set; } = default!;

        /// <summary>
        /// The time when the marketing action was started.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("started_at")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.DateTimeOffset? StartedAt { get; set; } = default!;

        /// <summary>
        /// For events with a duration, the time when the event was scheduled to end.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("scheduled_to_end_at")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.DateTimeOffset? ScheduledToEndAt { get; set; } = default!;

        /// <summary>
        /// For events with a duration, the time when the event actually ended.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ended_at")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.DateTimeOffset? EndedAt { get; set; } = default!;

        /// <summary>
        /// The [UTM parameters](https://en.wikipedia.org/wiki/UTM_parameters) used in the links provided in the marketing event. Values must be unique and should not be url-encoded.
        /// 
        /// To do traffic or order attribution you must at least define `utm_campaign`, `utm_source`, and `utm_medium`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("UTM parameters")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? UTMParameters { get; set; } = default!;

        /// <summary>
        /// A description of the marketing event.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Description { get; set; } = default!;

        /// <summary>
        /// A link to manage the marketing event. In most cases, this links to the app that created the event.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("manage_url")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? ManageUrl { get; set; } = default!;

        /// <summary>
        /// A link to the live version of the event, or to a rendered preview in the app that created it.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("preview_url")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? PreviewUrl { get; set; } = default!;

        /// <summary>
        /// A list of the items that were marketed in the marketing event. Includes the `type` and `id` of each item. Valid values for `type` are: 
        /// 
        /// *   `product` 
        /// *   `collection` 
        /// *   `price_rule` 
        /// *   `discount` (Will be replaced by price_rule after April 20, 2017.) 
        /// *   `page` 
        /// *   `article` 
        /// *   `homepage` (Doesn't have an `id`.)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("marketed_resources")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? MarketedResources { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
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