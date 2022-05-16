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
    public interface IPaymentController
    {

        /// <summary>
        /// Creates a new payment
        /// </summary>

        /// <param name="amount">The amount of the payment.</param>

        /// <param name="request_details">The details of the request, including the following attributes:</param>

        /// <param name="session_id">A session ID provided by the card vault when creating a payment session.</param>


        /// <param name="unique_token">A unique idempotency token generated by your app. This can be any value, but must be unique across all payment requests.</param>

        /// <returns>Creates a new payment</returns>

        System.Threading.Tasks.Task CreateNewPaymentAsync(string amount, string request_details, string session_id, string token, string unique_token);

        /// <summary>
        /// Retrieves a list of payments on a particular checkout
        /// </summary>


        /// <returns>Retrieves a list of payments on a particular checkout</returns>

        System.Threading.Tasks.Task RetrieveListOfPaymentsOnParticularCheckoutAsync(string token);

        /// <summary>
        /// Retrieves a single payment
        /// </summary>


        /// <returns>Retrieves a single payment</returns>

        System.Threading.Tasks.Task RetrieveSinglePaymentAsync(string payment_id, string token);

        /// <summary>
        /// Counts the number of payments attempted on a checkout
        /// </summary>


        /// <returns>Counts the number of payments attempted on a checkout</returns>

        System.Threading.Tasks.Task CountTheNumberOfPaymentsAttemptedOnCheckoutAsync(string token);

    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]

    public partial class PaymentController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private IPaymentController _implementation;

        public PaymentController(IPaymentController implementation)
        {
            _implementation = implementation;
        }

        /// <summary>
        /// Creates a new payment
        /// </summary>
        /// <param name="amount">The amount of the payment.</param>
        /// <param name="request_details">The details of the request, including the following attributes:</param>
        /// <param name="session_id">A session ID provided by the card vault when creating a payment session.</param>
        /// <param name="unique_token">A unique idempotency token generated by your app. This can be any value, but must be unique across all payment requests.</param>
        /// <returns>Creates a new payment</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("checkouts/{token}/payments.json")]
        public System.Threading.Tasks.Task CreateNewPayment([Microsoft.AspNetCore.Mvc.FromQuery] string amount, [Microsoft.AspNetCore.Mvc.FromQuery] string request_details, [Microsoft.AspNetCore.Mvc.FromQuery] string session_id, string token, [Microsoft.AspNetCore.Mvc.FromQuery] string unique_token)
        {

            return _implementation.CreateNewPaymentAsync(amount, request_details, session_id, token, unique_token);
        }

        /// <summary>
        /// Retrieves a list of payments on a particular checkout
        /// </summary>
        /// <returns>Retrieves a list of payments on a particular checkout</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("checkouts/{token}/payments.json")]
        public System.Threading.Tasks.Task RetrieveListOfPaymentsOnParticularCheckout(string token)
        {

            return _implementation.RetrieveListOfPaymentsOnParticularCheckoutAsync(token);
        }

        /// <summary>
        /// Retrieves a single payment
        /// </summary>
        /// <returns>Retrieves a single payment</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("checkouts/{token}/payments/{payment_id}.json")]
        public System.Threading.Tasks.Task RetrieveSinglePayment(string payment_id, string token)
        {

            return _implementation.RetrieveSinglePaymentAsync(payment_id, token);
        }

        /// <summary>
        /// Counts the number of payments attempted on a checkout
        /// </summary>
        /// <returns>Counts the number of payments attempted on a checkout</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("checkouts/{token}/payments/count.json")]
        public System.Threading.Tasks.Task CountTheNumberOfPaymentsAttemptedOnCheckout(string token)
        {

            return _implementation.CountTheNumberOfPaymentsAttemptedOnCheckoutAsync(token);
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