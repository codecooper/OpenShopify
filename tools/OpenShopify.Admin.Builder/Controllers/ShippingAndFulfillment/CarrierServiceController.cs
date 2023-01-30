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

    public abstract class CarrierServiceControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Create a new CarrierService
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("carrier_services.json")]
        public abstract System.Threading.Tasks.Task CreateCarrierService([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CreateCarrierServiceRequest request);

        /// <summary>
        /// Receive a list of all CarrierServices
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("carrier_services.json")]
        public abstract System.Threading.Tasks.Task ListCarrierServices();

        /// <summary>
        /// Modify an existing CarrierService
        /// </summary>
        /// <remarks>
        /// Updates a carrier service. Only the app that creates a carrier service can update it.
        /// </remarks>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("carrier_services/{carrier_service_id}.json")]
        public abstract System.Threading.Tasks.Task UpdateCarrierService([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.UpdateCarrierServiceRequest request, long carrier_service_id);

        /// <summary>
        /// Receive a single CarrierService
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("carrier_services/{carrier_service_id}.json")]
        public abstract System.Threading.Tasks.Task GetCarrierService(long carrier_service_id);

        /// <summary>
        /// Remove an existing CarrierService
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("carrier_services/{carrier_service_id}.json")]
        public abstract System.Threading.Tasks.Task DeleteCarrierService(long carrier_service_id);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record CarrierServiceOrig
    {
        /// <summary>
        /// Whether this carrier service is active.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("active")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public bool? Active { get; set; } = default!;

        /// <summary>
        /// The URL endpoint that Shopify needs to retrieve shipping rates. This must be a public URL.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("callback_url")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? CallbackUrl { get; set; } = default!;

        /// <summary>
        /// Distinguishes between API or legacy carrier services.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("carrier_service_type")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? CarrierServiceType { get; set; } = default!;

        /// <summary>
        /// The name of the shipping service as seen by merchants and their customers.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Name { get; set; } = default!;

        /// <summary>
        /// Whether merchants are able to send dummy data to your service through the Shopify admin to see shipping rate examples.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("service_discovery")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public bool? ServiceDiscovery { get; set; } = default!;

        /// <summary>
        /// The GraphQL GID for this carrier service.
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