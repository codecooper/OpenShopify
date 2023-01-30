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

    public abstract class BlogControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieve a list of all blogs
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all blogs. **Note:** As of version 2019-10, this endpoint implements pagination by using links that are provided in the response header. Sending the `page` parameter will return an error. To learn more, see [*Make paginated requests to the REST Admin API*](/api/usage/pagination-rest).
        /// </remarks>
        /// <param name="fields">comma-separated list of fields to include in the response</param>
        /// <param name="handle">Filter by blog handle</param>
        /// <param name="limit">The maximum number of results to retrieve.</param>
        /// <param name="page_info">A unique ID used to access a certain page of results.</param>
        /// <param name="since_id">Restrict results to after the specified ID</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("blogs.json")]
        public abstract System.Threading.Tasks.Task ListBlogs([Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? handle = null, [Microsoft.AspNetCore.Mvc.FromQuery] int? limit = null, string? page_info = null, [Microsoft.AspNetCore.Mvc.FromQuery] long? since_id = null);

        /// <summary>
        /// Create a new Blog
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("blogs.json")]
        public abstract System.Threading.Tasks.Task CreateBlog([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CreateBlogRequest request);

        /// <summary>
        /// Receive a count of all Blogs
        /// </summary>
        /// <remarks>
        /// Get a count of all blogs
        /// </remarks>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("blogs/count.json")]
        public abstract System.Threading.Tasks.Task CountBlogs();

        /// <summary>
        /// Receive a single Blog
        /// </summary>
        /// <remarks>
        /// Get a single blog by its ID
        /// </remarks>
        /// <param name="fields">comma-separated list of fields to include in the response</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("blogs/{blog_id}.json")]
        public abstract System.Threading.Tasks.Task GetBlog(long blog_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null);

        /// <summary>
        /// Modify an existing Blog
        /// </summary>
        /// <remarks>
        /// Update a blog
        /// </remarks>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("blogs/{blog_id}.json")]
        public abstract System.Threading.Tasks.Task UpdateBlog([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.UpdateBlogRequest request, long blog_id);

        /// <summary>
        /// Remove an existing Blog
        /// </summary>
        /// <remarks>
        /// Delete a blog
        /// </remarks>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("blogs/{blog_id}.json")]
        public abstract System.Threading.Tasks.Task DeleteBlog(long blog_id);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record BlogOrig
    {
        /// <summary>
        /// Indicates whether readers can post comments to the blog and if comments are moderated or not. Possible values are:
        /// 
        /// *   **no (default)**: Readers cannot post comments to blog articles. 
        /// *   **moderate**: Readers can post comments to blog articles, but comments must be moderated before they appear. 
        /// *   **yes**: Readers can post comments to blog articles without moderation.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("commentable")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Commentable { get; set; } = default!;

        /// <summary>
        /// FeedBurner is a web feed management provider and can be enabled to provide custom RSS feeds for Shopify bloggers. Google has stopped supporting FeedBurner, and new or existing blogs that are not already integrated with FeedBurner can't use the service. This property will default to blank unless FeedBurner is enabled.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("feedburner")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Feedburner { get; set; } = default!;

        /// <summary>
        /// The URL that points to the FeedBurner location for blogs that have FeedBurner enabled. Google has stopped supporting FeedBurner, and new or existing blogs that are not already integrated with FeedBurner can't use the service. This property will default to blank unless FeedBurner is enabled
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("feedburner_location")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? FeedburnerLocation { get; set; } = default!;

        /// <summary>
        /// A human-friendly unique string that is automatically generated from the title if no handle is sent during the creation of a blog. Duplicate handles are appended with an incremental number, for example, `blog-2`. The handle is customizable and is used by the Liquid templating language to refer to the blog. If you change the handle of a blog, then it can negatively affect the SEO of the shop. We recommend that you create a URL redirect to avoid any SEO issues.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("handle")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Handle { get; set; } = default!;

        /// <summary>
        /// Attaches additional metadata to a store's resources:
        /// 
        /// *   **key (required)**: Identifier for the metafield (maximum of 30 characters). 
        /// *   **namespace (required)**: Container for a set of metadata. Namespaces help distinguish between metadata you created and metadata created by another individual with a similar namespace (maximum of 20 characters). 
        /// *   **value (required)**: Information to be stored as metadata. 
        /// *   **type (required)**: The metafield's information type. Refer to the [full list of types](/apps/metafields/types). 
        /// *   **description (optional)**: Additional information about the metafield. 
        /// 
        /// For more information on attaching metadata to Shopify resources, see the [Metafield](/api/admin-rest/latest/resources/metafield) resource.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("metafields")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Metafields { get; set; } = default!;

        /// <summary>
        /// A list of tags associated with the 200 most recent blog articles. Tags are additional short descriptors formatted as a string of comma-separated values. For example, if an article has three tags: tag1, tag2, tag3. Tags are limited to 255 characters.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("tags")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Tags { get; set; } = default!;

        /// <summary>
        /// States the name of the template a blog is using if it is using an alternate template. If a blog is using the default blog.liquid template, the value returned is "null".
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("template_suffix")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? TemplateSuffix { get; set; } = default!;

        /// <summary>
        /// The title of the blog.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Title { get; set; } = default!;

        /// <summary>
        /// The GraphQL GID of the blog.
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