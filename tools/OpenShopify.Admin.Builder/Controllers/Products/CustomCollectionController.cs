//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
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

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]

    public abstract class CustomCollectionControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves a list of custom collections
        /// </summary>
        /// <remarks>
        /// Retrieves a list of custom collections. **Note:** As of version 2019-10, this endpoint implements pagination by using links that are provided in the response header. Sending the `page` parameter will return an error. To learn more, see [*Make paginated requests to the REST Admin API*](/api/usage/pagination-rest).
        /// </remarks>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        /// <param name="handle">Filter by custom collection handle.</param>
        /// <param name="ids">Show only collections specified by a comma-separated list of IDs.</param>
        /// <param name="limit">The maximum number of results to retrieve.</param>
        /// <param name="page_info">A unique ID used to access a certain page of results.</param>
        /// <param name="product_id">Show custom collections that include a given product.</param>
        /// <param name="published_at_max">Show custom collections published before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_at_min">Show custom collections published after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_status">Show custom collectsion with a given published status.</param>
        /// <param name="since_id">Restrict results to after the specified ID.</param>
        /// <param name="title">Show custom collections with a given title.</param>
        /// <param name="updated_at_max">Show custom collections last updated before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="updated_at_min">Show custom collections last updated after date (format: 2014-04-25T16:15:47-04:00).</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("custom_collections.json")]
        public abstract System.Threading.Tasks.Task ListCustomCollections([Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? handle = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.Collections.Generic.IEnumerable<long>? ids = null, [Microsoft.AspNetCore.Mvc.FromQuery] int? limit = null, string? page_info = null, [Microsoft.AspNetCore.Mvc.FromQuery] long? product_id = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? published_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? published_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_status = null, [Microsoft.AspNetCore.Mvc.FromQuery] long? since_id = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? title = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_min = null);

        /// <summary>
        /// Creates a custom collection
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("custom_collections.json")]
        public abstract System.Threading.Tasks.Task CreateCustomCollection([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CreateCustomCollectionRequest request);

        /// <summary>
        /// Retrieves a count of custom collections
        /// </summary>
        /// <param name="product_id">Count custom collections that include a given product.</param>
        /// <param name="published_at_max">Count custom collections published before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_at_min">Count custom collections published after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_status">Count custom collections with a given published status.</param>
        /// <param name="title">Count custom collections with given title.</param>
        /// <param name="updated_at_max">Count custom collections last updated before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="updated_at_min">Count custom collections last updated after date (format: 2014-04-25T16:15:47-04:00).</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("custom_collections/count.json")]
        public abstract System.Threading.Tasks.Task CountCustomCollections([Microsoft.AspNetCore.Mvc.FromQuery] long? product_id = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? published_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? published_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_status = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? title = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_min = null);

        /// <summary>
        /// Retrieves a single custom collection
        /// </summary>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("custom_collections/{custom_collection_id}.json")]
        public abstract System.Threading.Tasks.Task GetCustomCollection(long custom_collection_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null);

        /// <summary>
        /// Updates an existing custom collection
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("custom_collections/{custom_collection_id}.json")]
        public abstract System.Threading.Tasks.Task UpdateCustomCollection([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.UpdateCustomCollectionRequest request, long custom_collection_id);

        /// <summary>
        /// Deletes a custom collection
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("custom_collections/{custom_collection_id}.json")]
        public abstract System.Threading.Tasks.Task DeleteCustomCollection(long custom_collection_id);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum CustomCollectionPublishedScope
    {

        [System.Runtime.Serialization.EnumMember(Value = @"web")]
        Web = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"global")]
        Global = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum CustomCollectionSortOrder
    {

        [System.Runtime.Serialization.EnumMember(Value = @"alpha-asc")]
        AlphaAsc = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"alpha-desc")]
        AlphaDesc = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"best-selling")]
        BestSelling = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"created")]
        Created = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"created-desc")]
        CreatedDesc = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"manual")]
        Manual = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"price-asc")]
        PriceAsc = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"price-desc")]
        PriceDesc = 7,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record CustomCollectionOrig
    {
        /// <summary>
        /// The description of the custom collection, complete with HTML markup. Many templates display this on their custom collection pages.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("body_html")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? BodyHtml { get; set; } = default!;

        /// <summary>
        /// A human-friendly unique string for the custom collection automatically generated from its title. This is used in shop themes by the Liquid templating language to refer to the custom collection. (limit: 255 characters)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("handle")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Handle { get; set; } = default!;

        /// <summary>
        /// Image associated with the custom collection. Valid values are:
        /// 
        /// *   **attachment**: An image attached to a custom collection returned as Base64-encoded binary data. 
        /// *   **src**: The source URL that specifies the location of the image. 
        /// *   **alt**: Alternative text that describes the collection image. 
        /// *   **created_at**: The time and date ([ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format) when the image was added to the collection. 
        /// *   **width**: The width of the image in pixels. 
        /// *   **height**: The height of the image in pixels.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("image")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Image { get; set; } = default!;

        /// <summary>
        /// Whether the custom collection is published to the Online Store channel.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("published")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public bool? Published { get; set; } = default!;

        /// <summary>
        /// The time and date ([ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format) when the collection was made visible. Returns `null` for a hidden custom collection.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("published_at")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.DateTimeOffset? PublishedAt { get; set; } = default!;

        /// <summary>
        /// Whether the collection is published to the Point of Sale channel. Valid values: 
        /// 
        /// *   `web`: The custom collection is published to the Online Store channel but not published to the Point of Sale channel. 
        /// *   `global`: The custom collection is published to both the Online Store channel and the Point of Sale channel.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("published_scope")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? PublishedScope { get; set; } = default!;

        /// <summary>
        /// The order in which products in the custom collection appear. Valid values:
        /// 
        /// *   **alpha-asc**: Alphabetically, in ascending order (A - Z). 
        /// *   **alpha-desc**: Alphabetically, in descending order (Z - A). 
        /// *   **best-selling**: By best-selling products. 
        /// *   **created**: By date created, in ascending order (oldest - newest). 
        /// *   **created-desc**: By date created, in descending order (newest - oldest). 
        /// *   **manual**: Order created by the shop owner. 
        /// *   &lt;strong&gt;price-asc**: By price, in ascending order (lowest - highest). 
        /// *   **price-desc**: By price, in descending order (highest - lowest). 
        /// 
        /// &lt;/strong&gt;
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sort_order")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? SortOrder { get; set; } = default!;

        /// <summary>
        /// The suffix of the liquid template being used. For example, if the value is `custom`, then the collection is using the `collection.custom.liquid` template. If the value is `null`, then the collection is using the default `collection.liquid`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("template_suffix")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? TemplateSuffix { get; set; } = default!;

        /// <summary>
        /// The name of the custom collection. (limit: 255 characters)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Title { get; set; } = default!;

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