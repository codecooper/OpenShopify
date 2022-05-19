//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
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

namespace OpenShopify.Admin.Builder.Controllers
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]

    public abstract class PageControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves a list of pages
        /// </summary>
        /// <param name="created_at_max">Show pages created before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="created_at_min">Show pages created after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        /// <param name="handle">Retrieve a page with a given handle.</param>
        /// <param name="limit">The maximum number of results to show.</param>
        /// <param name="published_at_max">Show pages published before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_at_min">Show pages published after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_status">Restrict results to pages with a given published status:</param>
        /// <param name="since_id">Restrict results to after the specified ID.</param>
        /// <param name="title">Retrieve pages with a given title.</param>
        /// <param name="updated_at_max">Show pages last updated before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="updated_at_min">Show pages last updated after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <returns>Retrieves a list of pages</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("pages.json")]
        public abstract System.Threading.Tasks.Task RetrieveListOfPages([Microsoft.AspNetCore.Mvc.FromQuery] DateTime? created_at_max, [Microsoft.AspNetCore.Mvc.FromQuery] DateTime? created_at_min, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields, [Microsoft.AspNetCore.Mvc.FromQuery] string? handle, [Microsoft.AspNetCore.Mvc.FromQuery] int? limit, string? page_info, [Microsoft.AspNetCore.Mvc.FromQuery] DateTime? published_at_max, [Microsoft.AspNetCore.Mvc.FromQuery] DateTime? published_at_min, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_status, [Microsoft.AspNetCore.Mvc.FromQuery] int? since_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? title, [Microsoft.AspNetCore.Mvc.FromQuery] DateTime? updated_at_max, [Microsoft.AspNetCore.Mvc.FromQuery] DateTime? updated_at_min);

        /// <summary>
        /// Creates a page
        /// </summary>
        /// <returns>Creates a page</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("pages.json")]
        public abstract System.Threading.Tasks.Task CreatePage([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.PageItem request);

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
        /// <returns>Retrieves a page count</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("pages/count.json")]
        public abstract System.Threading.Tasks.Task RetrievePageCount([Microsoft.AspNetCore.Mvc.FromQuery] DateTime? created_at_max, [Microsoft.AspNetCore.Mvc.FromQuery] DateTime? created_at_min, [Microsoft.AspNetCore.Mvc.FromQuery] DateTime? published_at_max, [Microsoft.AspNetCore.Mvc.FromQuery] DateTime? published_at_min, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_status, [Microsoft.AspNetCore.Mvc.FromQuery] string? title, [Microsoft.AspNetCore.Mvc.FromQuery] DateTime? updated_at_max, [Microsoft.AspNetCore.Mvc.FromQuery] DateTime? updated_at_min);

        /// <summary>
        /// Retrieves a single page by its ID
        /// </summary>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        /// <returns>Retrieves a single page by its ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("pages/{page_id}.json")]
        public abstract System.Threading.Tasks.Task RetrieveSinglePageByItsID(long page_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields);

        /// <summary>
        /// Updates a page
        /// </summary>
        /// <returns>Updates a page</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("pages/{page_id}.json")]
        public abstract System.Threading.Tasks.Task UpdatePage([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.PageItem request, long page_id);

        /// <summary>
        /// Deletes a page
        /// </summary>
        /// <returns>Deletes a page</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("pages/{page_id}.json")]
        public abstract System.Threading.Tasks.Task DeletePage(long page_id);

    }

    


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603