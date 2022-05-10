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

namespace OpenShopify.Admin.Builder
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]

    public abstract class CollectControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Adds a product to a custom collection
        /// </summary>
        /// <returns>Adds a product to a custom collection</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("collects.json")]
        public abstract System.Threading.Tasks.Task AddProductToCustomCollection();

        /// <summary>
        /// Retrieves a list of collects
        /// </summary>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        /// <param name="limit">The maximum number of results to show.</param>
        /// <param name="since_id">Restrict results to after the specified ID.</param>
        /// <returns>Retrieves a list of collects</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("collects.json")]
        public abstract System.Threading.Tasks.Task RetrieveListOfCollects([Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? limit = "50", [Microsoft.AspNetCore.Mvc.FromQuery] string? since_id = null);

        /// <summary>
        /// Removes a product from a collection
        /// </summary>
        /// <returns>Removes a product from a collection</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("collects/{collect_id}.json")]
        public abstract System.Threading.Tasks.Task RemoveProductFromCollection(string collect_id);

        /// <summary>
        /// Retrieves a specific collect by its ID
        /// </summary>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        /// <returns>Retrieves a specific collect by its ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("collects/{collect_id}.json")]
        public abstract System.Threading.Tasks.Task RetrieveSpecificCollectByItsID(string collect_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null);

        /// <summary>
        /// Retrieves a count of collects
        /// </summary>
        /// <returns>Retrieves a count of collects</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("collects/count.json")]
        public abstract System.Threading.Tasks.Task RetrieveCountOfCollects();

    }

    


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603