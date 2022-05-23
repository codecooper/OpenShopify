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

    public abstract class RedirectControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves a list of URL redirects
        /// </summary>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        /// <param name="limit">The maximum number of results to show.</param>
        /// <param name="page_info">A unique ID used to access a certain page of results.</param>
        /// <param name="path">Show redirects with a given path.</param>
        /// <param name="since_id">Restrict results to after the specified ID.</param>
        /// <param name="target">Show redirects with a given target.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("redirects.json")]
        public abstract System.Threading.Tasks.Task ListUrlRedirects(string? fields = null, int? limit = null, string? page_info = null, string? path = null, long? since_id = null, string? target = null);

        /// <summary>
        /// Creates a redirect
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("redirects.json")]
        public abstract System.Threading.Tasks.Task CreateRedirect([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CreateRedirectRequest request);

        /// <summary>
        /// Retrieves a count of URL redirects
        /// </summary>
        /// <param name="path">Count redirects with given path.</param>
        /// <param name="target">Count redirects with given target.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("redirects/count.json")]
        public abstract System.Threading.Tasks.Task CountUrlRedirects(string? path = null, string? target = null);

        /// <summary>
        /// Retrieves a single redirect
        /// </summary>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("redirects/{redirect_id}.json")]
        public abstract System.Threading.Tasks.Task GetRedirect(long redirect_id, string? fields = null);

        /// <summary>
        /// Updates an existing redirect
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("redirects/{redirect_id}.json")]
        public abstract System.Threading.Tasks.Task UpdateRedirect([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.UpdateRedirectRequest request, long redirect_id);

        /// <summary>
        /// Deletes a redirect
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("redirects/{redirect_id}.json")]
        public abstract System.Threading.Tasks.Task DeleteRedirect(long redirect_id);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.0.0 (NJsonSchema v10.7.1.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record RedirectOrig
    {
        /// <summary>
        /// The old path to be redirected. When the user visits this path, they will be redirected to the target. (maximum: 1024 characters)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("path")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Path { get; set; } = default!;

        /// <summary>
        /// The target location where the user will be redirected. When the user visits the old path specified by the `path` property, they will be redirected to this location. This property can be set to any path on the shop's site, or to an external URL. (maximum: 255 characters)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("target")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]   
        public string? Target { get; set; } = default!;

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