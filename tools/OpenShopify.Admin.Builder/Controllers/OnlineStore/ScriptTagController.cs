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

    public abstract class ScriptTagControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves a list of all script tags
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all script tags. **Note:** As of version 2019-10, this endpoint implements pagination by using links that are provided in the response header. Sending the `page` parameter will return an error. To learn more, see [*Make paginated requests to the REST Admin API*](/api/usage/pagination-rest).
        /// </remarks>
        /// <param name="created_at_max">Show script tags created before this date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="created_at_min">Show script tags created after this date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="fields">A comma-separated list of fields to include in the response.</param>
        /// <param name="limit">The number of results to return.</param>
        /// <param name="page_info">A unique ID used to access a certain page of results.</param>
        /// <param name="since_id">Restrict results to after the specified ID.</param>
        /// <param name="src">Show script tags with this URL.</param>
        /// <param name="updated_at_max">Show script tags last updated before this date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="updated_at_min">Show script tags last updated after this date. (format: 2014-04-25T16:15:47-04:00)</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("script_tags.json")]
        public abstract System.Threading.Tasks.Task ListScriptTags([Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? created_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? created_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null, [Microsoft.AspNetCore.Mvc.FromQuery] int? limit = null, string? page_info = null, [Microsoft.AspNetCore.Mvc.FromQuery] long? since_id = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? src = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_min = null);

        /// <summary>
        /// Creates a new script tag
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("script_tags.json")]
        public abstract System.Threading.Tasks.Task CreateScriptTag([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CreateScriptTagRequest request);

        /// <summary>
        /// Retrieves a count of all script tags
        /// </summary>
        /// <param name="src">Count only script tags with a given URL.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("script_tags/count.json")]
        public abstract System.Threading.Tasks.Task CountScriptTags([Microsoft.AspNetCore.Mvc.FromQuery] string? src = null);

        /// <summary>
        /// Retrieves a single script tag
        /// </summary>
        /// <param name="fields">A comma-separated list of fields to include in the response.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("script_tags/{script_tag_id}.json")]
        public abstract System.Threading.Tasks.Task GetScriptTag(long script_tag_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null);

        /// <summary>
        /// Updates a script tag
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("script_tags/{script_tag_id}.json")]
        public abstract System.Threading.Tasks.Task UpdateScriptTag([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.UpdateScriptTagRequest request, long script_tag_id);

        /// <summary>
        /// Deletes a script tag
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("script_tags/{script_tag_id}.json")]
        public abstract System.Threading.Tasks.Task DeleteScriptTag(long script_tag_id);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ScriptTagEvent
    {

        [System.Runtime.Serialization.EnumMember(Value = @"onload")]
        Onload = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ScriptTagDisplayScope
    {

        [System.Runtime.Serialization.EnumMember(Value = @"online_store")]
        OnlineStore = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"order_status")]
        OrderStatus = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"all")]
        All = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ScriptTagOrig
    {
        /// <summary>
        /// The DOM event that triggers the loading of the script. Valid values: `onload`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("event")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Event { get; set; } = default!;

        /// <summary>
        /// The URL of the remote script.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("src")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Src { get; set; } = default!;

        /// <summary>
        /// The page or pages on the online store where the script should be included. Valid values: 
        /// 
        /// *   `online_store`: Include the script only on the web storefront. 
        /// *   `order_status`: Include the script only on the order status page. 
        /// *   `all`: Include the script on both the web storefront and the order status page.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("display_scope")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? DisplayScope { get; set; } = default!;

        /// <summary>
        /// Whether the Shopify CDN can cache and serve the script tag. Valid values: 
        /// 
        /// *   `true`: The script will be cached and served by the CDN. The cache expires 15 minutes after the script tag is successfully returned. 
        /// *   `false`: The script will be served as is. 
        /// 
        ///  Default value: `false`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("cache")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public bool? Cache { get; set; } = default!;

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