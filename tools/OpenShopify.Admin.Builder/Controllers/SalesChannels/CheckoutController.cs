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
    public interface ICheckoutController
    {

        /// <summary>
        /// Creates a checkout
        /// </summary>

        /// <returns>Creates a checkout</returns>

        System.Threading.Tasks.Task CreateCheckoutAsync();

        /// <summary>
        /// Completes a checkout
        /// </summary>


        /// <returns>Completes a checkout</returns>

        System.Threading.Tasks.Task CompleteCheckoutAsync(string token);

        /// <summary>
        /// Retrieves a checkout
        /// </summary>


        /// <returns>Retrieves a checkout</returns>

        System.Threading.Tasks.Task RetrieveCheckoutAsync(string token);

        /// <summary>
        /// Modifies an existing checkout
        /// </summary>


        /// <returns>Modifies an existing checkout</returns>

        System.Threading.Tasks.Task ModifyExistingCheckoutAsync(string token);

        /// <summary>
        /// Retrieves a list of shipping rates
        /// </summary>


        /// <returns>Retrieves a list of shipping rates</returns>

        System.Threading.Tasks.Task RetrieveListOfShippingRatesAsync(string token);

    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]

    public partial class CheckoutController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private ICheckoutController _implementation;

        public CheckoutController(ICheckoutController implementation)
        {
            _implementation = implementation;
        }

        /// <summary>
        /// Creates a checkout
        /// </summary>
        /// <returns>Creates a checkout</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("checkouts.json")]
        public System.Threading.Tasks.Task CreateCheckout()
        {

            return _implementation.CreateCheckoutAsync();
        }

        /// <summary>
        /// Completes a checkout
        /// </summary>
        /// <returns>Completes a checkout</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("checkouts/{token}/complete.json")]
        public System.Threading.Tasks.Task CompleteCheckout(string token)
        {

            return _implementation.CompleteCheckoutAsync(token);
        }

        /// <summary>
        /// Retrieves a checkout
        /// </summary>
        /// <returns>Retrieves a checkout</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("checkouts/{token}.json")]
        public System.Threading.Tasks.Task RetrieveCheckout(string token)
        {

            return _implementation.RetrieveCheckoutAsync(token);
        }

        /// <summary>
        /// Modifies an existing checkout
        /// </summary>
        /// <returns>Modifies an existing checkout</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("checkouts/{token}.json")]
        public System.Threading.Tasks.Task ModifyExistingCheckout(string token)
        {

            return _implementation.ModifyExistingCheckoutAsync(token);
        }

        /// <summary>
        /// Retrieves a list of shipping rates
        /// </summary>
        /// <returns>Retrieves a list of shipping rates</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("checkouts/{token}/shipping_rates.json")]
        public System.Threading.Tasks.Task RetrieveListOfShippingRates(string token)
        {

            return _implementation.RetrieveListOfShippingRatesAsync(token);
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