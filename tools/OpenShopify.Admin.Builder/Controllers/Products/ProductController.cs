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

    public abstract class ProductControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieve a list of products
        /// </summary>
        /// <param name="collection_id">Return products by product collection ID.</param>
        /// <param name="created_at_max">Return products created before a specified date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="created_at_min">Return products created after a specified date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="fields">Return only certain fields specified by a comma-separated list of field names.</param>
        /// <param name="handle">Return only products specified by a comma-separated list of product handles.</param>
        /// <param name="ids">Return only products specified by a comma-separated list of product IDs.</param>
        /// <param name="limit">Return up to this many results per page.</param>
        /// <param name="page_info">A unique ID used to access a certain page of results.</param>
        /// <param name="presentment_currencies">Return presentment prices in only certain currencies, specified by a comma-separated list of [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency codes.</param>
        /// <param name="product_type">Return products by product type.</param>
        /// <param name="published_at_max">Return products published before a specified date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="published_at_min">Return products published after a specified date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="published_status">Return products by their published status.</param>
        /// <param name="since_id">Return only products after the specified ID.</param>
        /// <param name="status">Return only products specified by a comma-separated list of statuses.</param>
        /// <param name="title">Return products by product title.</param>
        /// <param name="updated_at_max">Return products last updated before a specified date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="updated_at_min">Return products last updated after a specified date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="vendor">Return products by product vendor.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("products.json")]
        public abstract System.Threading.Tasks.Task ListProducts([Microsoft.AspNetCore.Mvc.FromQuery] long collection_id, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? created_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? created_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? handle = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.Collections.Generic.IEnumerable<long>? ids = null, [Microsoft.AspNetCore.Mvc.FromQuery] int? limit = null, string? page_info = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? presentment_currencies = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? product_type = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? published_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? published_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_status = null, [Microsoft.AspNetCore.Mvc.FromQuery] long? since_id = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? status = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? title = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? vendor = null);

        /// <summary>
        /// Create a new product
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("products.json")]
        public abstract System.Threading.Tasks.Task CreateProduct([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CreateProductRequest request);

        /// <summary>
        /// Retrieve a count of products
        /// </summary>
        /// <param name="collection_id">Return products by product collection ID.</param>
        /// <param name="created_at_max">Return products created before a specified date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="created_at_min">Return products created after a specified date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="product_type">Return products by product type.</param>
        /// <param name="published_at_max">Return products published before a specified date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="published_at_min">Return products published after a specified date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="published_status">Return products by their published status.</param>
        /// <param name="updated_at_max">Return products last updated before a specified date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="updated_at_min">Return products last updated after a specified date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="vendor">Return products by product vendor.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("products/count.json")]
        public abstract System.Threading.Tasks.Task CountProducts([Microsoft.AspNetCore.Mvc.FromQuery] long? collection_id = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? created_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? created_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? product_type = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? published_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? published_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_status = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? vendor = null);

        /// <summary>
        /// Retrieve a single product
        /// </summary>
        /// <param name="fields">A comma-separated list of fields to include in the response.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("products/{product_id}.json")]
        public abstract System.Threading.Tasks.Task GetProduct(long product_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null);

        /// <summary>
        /// Updates a product
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("products/{product_id}.json")]
        public abstract System.Threading.Tasks.Task UpdateProduct([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.UpdateProductRequest request, long product_id);

        /// <summary>
        /// Delete a product
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("products/{product_id}.json")]
        public abstract System.Threading.Tasks.Task DeleteProduct(long product_id);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.0.0 (NJsonSchema v10.7.1.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ProductOrig
    {
        /// <summary>
        /// A description of the product. Supports HTML formatting.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("body_html")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? BodyHtml { get; set; } = default!;

        /// <summary>
        /// A unique human-friendly string for the product. Automatically generated from the product's `title`. Used by the Liquid templating language to refer to objects.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("handle")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Handle { get; set; } = default!;

        /// <summary>
        /// A list of [product image](/docs/admin-api/rest/reference/products/product-image) objects, each one representing an image associated with the product.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("images")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Images { get; set; } = default!;

        /// <summary>
        /// The custom product properties. For example, **Size**, **Color**, and **Material**. Each product can have up to 3 options and each option value can be up to 255 characters. Product variants are made of up combinations of option values. Options cannot be created without values. To create new options, a variant with an associated option value also needs to be created.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("options")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Options { get; set; } = default!;

        /// <summary>
        /// A categorization for the product used for filtering and searching products.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("product_type")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? ProductType { get; set; } = default!;

        /// <summary>
        /// The date and time ([ISO 8601 format](https://en.wikipedia.org/wiki/ISO_8601)) when the product was published. Can be set to `null` to unpublish the product from the Online Store channel.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("published_at")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public System.DateTimeOffset? PublishedAt { get; set; } = default!;

        /// <summary>
        /// Whether the product is published to the Point of Sale channel. Valid values: 
        /// 
        /// *   `web`: The product is published to the Online Store channel but not published to the Point of Sale channel. 
        /// *   `global`: The product is published to both the Online Store channel and the Point of Sale channel. 
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("published_scope")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? PublishedScope { get; set; } = default!;

        /// <summary>
        /// The status of the product. Valid values: 
        /// 
        /// *   `active`: The product is ready to sell and is available to customers on the online store, sales channels, and apps. By default, existing products are set to active. 
        /// *   `archived`: The product is no longer being sold and isn't available to customers on sales channels and apps. 
        /// *   `draft`: The product isn't ready to sell and is unavailable to customers on sales channels and apps. By default, duplicated and unarchived products are set to draft. 
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("status")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Status { get; set; } = default!;

        /// <summary>
        /// A string of comma-separated tags that are used for filtering and search. A product can have up to 250 tags. Each tag can have up to 255 characters.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("tags")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Tags { get; set; } = default!;

        /// <summary>
        /// The suffix of the Liquid template used for the product page. If this property is specified, then the product page uses a template called "product.suffix.liquid", where "suffix" is the value of this property. If this property is `""` or `null`, then the product page uses the default template "product.liquid". (default: `null`)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("template_suffix")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? TemplateSuffix { get; set; } = default!;

        /// <summary>
        /// The name of the product.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Title { get; set; } = default!;

        /// <summary>
        /// An array of [product variants](/docs/admin-api/rest/reference/products/product-variant), each representing a different version of the product.
        /// 
        /// The `position` property is read-only. The position of variants is indicated by the order in which they are listed.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("variants")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Variants { get; set; } = default!;

        /// <summary>
        /// The name of the product's vendor.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("vendor")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Vendor { get; set; } = default!;

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