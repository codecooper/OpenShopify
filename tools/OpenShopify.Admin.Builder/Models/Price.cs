

using System.Text.Json.Serialization;

namespace OpenShopify.Admin.Builder.Models
{
    public partial record Price
    {
        /// <summary>
        /// The three-letter code (ISO 4217 format) for currency.
        /// </summary>
        [JsonPropertyName("currency_code")]
        public string? CurrencyCode { get; set; }

        /// <summary>
        /// The amount in the currency.
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }
    }
}