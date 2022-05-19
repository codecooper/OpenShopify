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

    public abstract class ReportControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves a list of reports
        /// </summary>
        /// <param name="fields">A comma-separated list of fields to include in the response.</param>
        /// <param name="ids">A comma-separated list of report IDs.</param>
        /// <param name="limit">The amount of results to return.</param>
        /// <param name="since_id">Restrict results to after the specified ID.</param>
        /// <param name="updated_at_max">Show reports last updated before date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <param name="updated_at_min">Show reports last updated after date. (format: 2014-04-25T16:15:47-04:00)</param>
        /// <returns>Retrieves a list of reports</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("reports.json")]
        public abstract System.Threading.Tasks.Task RetrieveListOfReports([Microsoft.AspNetCore.Mvc.FromQuery] string? fields, [Microsoft.AspNetCore.Mvc.FromQuery] string? ids, [Microsoft.AspNetCore.Mvc.FromQuery] int? limit, string? page_info, [Microsoft.AspNetCore.Mvc.FromQuery] int? since_id, [Microsoft.AspNetCore.Mvc.FromQuery] DateTime? updated_at_max, [Microsoft.AspNetCore.Mvc.FromQuery] DateTime? updated_at_min);

        /// <summary>
        /// Creates a new report
        /// </summary>
        /// <param name="name">The name of the report. Maximum length: 255 characters.</param>
        /// <param name="shopify_ql">The ShopifyQL the report will query.</param>
        /// <returns>Creates a new report</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("reports.json")]
        public abstract System.Threading.Tasks.Task CreateNewReport([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.ReportItem request, [Microsoft.AspNetCore.Mvc.FromQuery] string? name, [Microsoft.AspNetCore.Mvc.FromQuery] string? shopify_ql);

        /// <summary>
        /// Retrieves a single report
        /// </summary>
        /// <param name="fields">A comma-separated list of fields to include in the response.</param>
        /// <returns>Retrieves a single report</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("reports/{report_id}.json")]
        public abstract System.Threading.Tasks.Task RetrieveSingleReport(long report_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields);

        /// <summary>
        /// Updates a report
        /// </summary>
        /// <returns>Updates a report</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("reports/{report_id}.json")]
        public abstract System.Threading.Tasks.Task UpdateReport([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.ReportItem request, long report_id);

        /// <summary>
        /// Deletes a report
        /// </summary>
        /// <returns>Deletes a report</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("reports/{report_id}.json")]
        public abstract System.Threading.Tasks.Task DeleteReport(long report_id);

    }

    


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603