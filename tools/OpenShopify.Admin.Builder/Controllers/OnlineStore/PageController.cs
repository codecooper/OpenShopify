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

    public abstract class PageControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves a list of pages
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all pages. **Note:** As of version 2019-10, this endpoint implements pagination by using links that are provided in the response header. Sending the `page` parameter will return an error. To learn more, refer to [Make paginated requests to the REST Admin API](/api/usage/pagination-rest).
        /// </remarks>
        /// <param name="created_at_max">Show pages created before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="created_at_min">Show pages created after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        /// <param name="handle">Retrieve a page with a given handle.</param>
        /// <param name="limit">The maximum number of results to show.</param>
        /// <param name="page_info">A unique ID used to access a certain page of results.</param>
        /// <param name="published_at_max">Show pages published before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_at_min">Show pages published after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_status">Restrict results to pages with a given published status:</param>
        /// <param name="since_id">Restrict results to after the specified ID.</param>
        /// <param name="title">Retrieve pages with a given title.</param>
        /// <param name="updated_at_max">Show pages last updated before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="updated_at_min">Show pages last updated after date (format: 2014-04-25T16:15:47-04:00).</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("pages.json")]
        public abstract System.Threading.Tasks.Task ListPages([Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? created_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? created_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? handle = null, [Microsoft.AspNetCore.Mvc.FromQuery] int? limit = null, string? page_info = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? published_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? published_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_status = null, [Microsoft.AspNetCore.Mvc.FromQuery] long? since_id = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? title = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_min = null);

        /// <summary>
        /// Creates a page
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("pages.json")]
        public abstract System.Threading.Tasks.Task CreatePage([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CreatePageRequest request);

        /// <summary>
        /// Retrieves a page count
        /// </summary>
        /// <param name="created_at_max">Count pages created before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="created_at_min">Count pages created after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_at_max">Show pages published before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_at_min">Show pages published after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_status">Count pages with a given published status:</param>
        /// <param name="title">Count pages with a given title.</param>
        /// <param name="updated_at_max">Count pages last updated before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="updated_at_min">Count pages last updated after date (format: 2014-04-25T16:15:47-04:00).</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("pages/count.json")]
        public abstract System.Threading.Tasks.Task GetPageCount([Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? created_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? created_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? published_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? published_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_status = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? title = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_min = null);

        /// <summary>
        /// Retrieves a single page by its ID
        /// </summary>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("pages/{page_id}.json")]
        public abstract System.Threading.Tasks.Task GetPage(long page_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null);

        /// <summary>
        /// Updates a page
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("pages/{page_id}.json")]
        public abstract System.Threading.Tasks.Task UpdatePage([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.UpdatePageRequest request, long page_id);

        /// <summary>
        /// Deletes a page
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("pages/{page_id}.json")]
        public abstract System.Threading.Tasks.Task DeletePage(long page_id);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record PageOrig
    {
        /// <summary>
        /// The name of the person who created the page.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("author")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Author { get; set; } = default!;

        /// <summary>
        /// The text content of the page, complete with HTML markup.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("body_html")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? BodyHtml { get; set; } = default!;

        /// <summary>
        /// A unique, human-friendly string for the page, generated automatically from its title. In themes, the Liquid templating language refers to a page by its handle.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("handle")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Handle { get; set; } = default!;

        /// <summary>
        /// Additional information attached to the Page object. It has the following properties: 
        /// 
        /// *   **key**: An identifier for the metafield. (maximum: 30 characters) 
        /// *   **namespace**: A container for a set of metadata. Namespaces help distinguish between metadata created by different apps. (maximum: 20 characters) 
        /// *   **value**: The information to be stored as metadata. 
        /// *   **type**: The metafield's information type. Refer to the [full list of types](/apps/metafields/types). 
        /// *   **description (optional)**: Additional information about the metafield. 
        /// 
        /// For more information on attaching metadata to Shopify resources, see the [Metafield](/docs/admin-api/rest/reference/metafield) resource.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("metafield")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Metafield { get; set; } = default!;

        /// <summary>
        /// The date and time ([ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format) when the page was published. Returns `null` when the page is hidden.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("published_at")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.DateTimeOffset? PublishedAt { get; set; } = default!;

        /// <summary>
        /// The ID of the shop to which the page belongs.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public long? ShopId { get; set; } = default!;

        /// <summary>
        /// The suffix of the [template](/api/liquid/objects/template) that is used to render the page. If the value is an empty string or `null`, then the default page template is used.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("template_suffix")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? TemplateSuffix { get; set; } = default!;

        /// <summary>
        /// The title of the page.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Title { get; set; } = default!;

        /// <summary>
        /// The GraphQL GID of the page.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("admin_graphql_api_id")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? AdminGraphqlApiId { get; set; } = default!;

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