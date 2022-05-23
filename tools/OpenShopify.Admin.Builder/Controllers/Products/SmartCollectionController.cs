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

    public abstract class SmartCollectionControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves a list of smart collections
        /// </summary>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        /// <param name="handle">Filter results by smart collection handle.</param>
        /// <param name="ids">Show only the smart collections specified by a comma-separated list of IDs.</param>
        /// <param name="limit">The number of results to show.</param>
        /// <param name="page_info">A unique ID used to access a certain page of results.</param>
        /// <param name="product_id">Show smart collections that includes the specified product.</param>
        /// <param name="published_at_max">Show smart collections published before this date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="published_at_min">Show smart collections published after this date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="published_status">Filter results based on the published status of smart collections.</param>
        /// <param name="since_id">Restrict results to after the specified ID.</param>
        /// <param name="title">Show smart collections with the specified title.</param>
        /// <param name="updated_at_max">Show smart collections last updated before this date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="updated_at_min">Show smart collections last updated after this date. (format: 2014-04-25T16:15:47-04:00)</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("smart_collections.json")]
        public abstract System.Threading.Tasks.Task ListSmartCollections(string? fields = null, string? handle = null, string? ids = null, int? limit = null, string? page_info = null, long? product_id = null, System.DateTimeOffset? published_at_max = null, System.DateTimeOffset? published_at_min = null, string? published_status = null, long? since_id = null, string? title = null, System.DateTimeOffset? updated_at_max = null, System.DateTimeOffset? updated_at_min = null);

        /// <summary>
        /// Creates a smart collection
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("smart_collections.json")]
        public abstract System.Threading.Tasks.Task CreateSmartCollection([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CreateSmartCollectionRequest request);

        /// <summary>
        /// Retrieves a count of smart collections
        /// </summary>
        /// <param name="product_id">Show smart collections that include the specified product.</param>
        /// <param name="published_at_max">Show smart collections published before this date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="published_at_min">Show smart collections published after this date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="published_status">Filter results based on the published status of smart collections.</param>
        /// <param name="title">Show smart collections with the specified title.</param>
        /// <param name="updated_at_max">Show smart collections last updated before this date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="updated_at_min">Show smart collections last updated after this date. (format: 2014-04-25T16:15:47-04:00)</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("smart_collections/count.json")]
        public abstract System.Threading.Tasks.Task CountSmartCollections(long? product_id = null, System.DateTimeOffset? published_at_max = null, System.DateTimeOffset? published_at_min = null, string? published_status = null, string? title = null, System.DateTimeOffset? updated_at_max = null, System.DateTimeOffset? updated_at_min = null);

        /// <summary>
        /// Retrieves a single smart collection
        /// </summary>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("smart_collections/{smart_collection_id}.json")]
        public abstract System.Threading.Tasks.Task GetSmartCollection(long smart_collection_id, string? fields = null);

        /// <summary>
        /// Updates an existing smart collection
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("smart_collections/{smart_collection_id}.json")]
        public abstract System.Threading.Tasks.Task UpdateSmartCollection([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.UpdateSmartCollectionRequest request, long smart_collection_id);

        /// <summary>
        /// Removes a smart collection
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("smart_collections/{smart_collection_id}.json")]
        public abstract System.Threading.Tasks.Task DeleteSmartCollection(long smart_collection_id);

        /// <summary>
        /// Updates the ordering type of products in a smart collection
        /// </summary>
        /// <param name="products">An array of product IDs, in the order that you want them to appear at the top of the collection. When `products` is specified but empty, any previously sorted products are cleared.</param>
        /// <param name="sort_order">The type of sorting to apply. Valid values are listed in the [Properties](#properties) section above.</param>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("smart_collections/{smart_collection_id}/order.json")]
        public abstract System.Threading.Tasks.Task UpdateOrderingTypeOfProductsInSmartCollection([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.UpdateSmartCollectionRequest request, long smart_collection_id, string? products = null, string? sort_order = null);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.0.0 (NJsonSchema v10.7.1.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record SmartCollectionOrig
    {
        /// <summary>
        /// The description of the smart collection. Includes HTML markup. Many shop themes display this on the smart collection page.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("body_html")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? BodyHtml { get; set; } = default!;

        /// <summary>
        /// A human-friendly unique string for the smart collection. Automatically generated from the `title`. Used in shop themes by the Liquid templating language to refer to the smart collection. (maximum: 255 characters)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("handle")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Handle { get; set; } = default!;

        /// <summary>
        /// The image associated with the smart collection. Valid values:
        /// 
        /// *   `attachment`: An image attached to a smart collection returned as Base64-encoded binary data. 
        /// *   `src`: A URL that specifies the location of the image. 
        /// *   `alt`: Alternative text that describes the collection image. 
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("image")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Image { get; set; } = default!;

        /// <summary>
        /// The date and time ([ISO 8601 format](https://en.wikipedia.org/wiki/ISO_8601)) that the smart collection was published. Returns `null` when the collection is hidden.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("published_at")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public System.DateTimeOffset? PublishedAt { get; set; } = default!;

        /// <summary>
        /// Whether the smart collection is published to the Point of Sale channel. Valid values: 
        /// 
        /// *   `web`: The smart collection is published to the Online Store channel but not published to the Point of Sale channel. 
        /// *   `global`: The smart collection is published to both the Online Store channel and the Point of Sale channel. 
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("published_scope")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? PublishedScope { get; set; } = default!;

        /// <summary>
        /// The list of rules that define what products go into the smart collection. Each rule has the following properties:
        /// 
        /// *   
        /// 
        /// **column**: The property of a product being used to populate the smart collection.
        /// 
        /// Valid values for text relations: * `title`: The product title. * `type`: The product type. * `vendor`: The name of the product vendor. * `variant_title`: The title of a product variant. 
        /// 
        /// Valid values for number relations:
        /// 
        ///     *   `variant_compare_at_price`: The compare price. 
        ///     *   `variant_weight`: The weight of the product. 
        ///     *   `variant_inventory`: The inventory stock. Note: `not_equals` does not work with this property. 
        ///     *   `variant_price`: product price.  
        /// 
        /// Valid values for an `equals` relation: * `tag`: A tag associated with the product. * 
        /// 
        /// **relation**: The relationship between the **column** choice, and the **condition**.
        /// 
        /// Valid values for number relations:
        /// 
        ///     *   `greater_than` The column value is greater than the condition. 
        ///     *   `less_than` The column value is less than the condition. 
        ///     *   `equals` The column value is equal to the condition. 
        ///     *   `not_equals` The column value is not equal to the condition.  
        /// 
        /// Valid values for text relations:
        /// 
        ///     *   `equals`: Checks if the **column** value is equal to the **condition** value. 
        ///     *   `not_equals`: Checks if the **column** value is not equal to the **condition** value. 
        ///     *   `starts_with`: Checks if the **column** value starts with the **condition** value. 
        ///     *   `ends_with`: Checks if the **column** value ends with the **condition** value. 
        ///     *   `contains`: Checks if the **column** value contains the **condition** value. 
        ///     *   `not_contains`: Checks if the **column** value does not contain the **condition** value.   
        /// *   
        /// 
        /// **condition**: Select products for a smart collection using a condition. Values are either strings or numbers, depending on the **relation** value.
        ///   
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("rules")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Rules { get; set; } = default!;

        /// <summary>
        /// Whether the product must match all the rules to be included in the smart collection. Valid values: 
        /// 
        /// *   `true`: Products only need to match one or more of the rules to be included in the smart collection. 
        /// *   `false`: Products must match all of the rules to be included in the smart collection. 
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("disjunctive")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public bool? Disjunctive { get; set; } = default!;

        /// <summary>
        /// The order of the products in the smart collection. Valid values:
        /// 
        /// *   `alpha-asc`: The products are sorted alphabetically from A to Z. 
        /// *   `alpha-des`: The products are sorted alphabetically from Z to A. 
        /// *   `best-selling`: The products are sorted by number of sales. 
        /// *   `created`: The products are sorted by the date they were created, from oldest to newest. 
        /// *   `created-desc`: The products are sorted by the date they were created, from newest to oldest. 
        /// *   `manual`: The products are manually sorted by the shop owner. 
        /// *   `price-asc`: The products are sorted by price from lowest to highest. 
        /// *   `price-desc`: The products are sorted by price from highest to lowest. 
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sort_order")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? SortOrder { get; set; } = default!;

        /// <summary>
        /// The suffix of the Liquid template that the shop uses. By default, the original template is called product.liquid, and additional templates are called product.`suffix`.liquid.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("template_suffix")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? TemplateSuffix { get; set; } = default!;

        /// <summary>
        /// The name of the smart collection. Maximum length: 255 characters.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Title { get; set; } = default!;

        /// <summary>
        /// The date and time ([ISO 8601 format](https://en.wikipedia.org/wiki/ISO_8601)) when the smart collection was last modified.
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