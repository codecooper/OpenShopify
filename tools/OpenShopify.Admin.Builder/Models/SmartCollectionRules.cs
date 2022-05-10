

using System.Text.Json.Serialization;

namespace OpenShopify.Admin.Builder.Models
{
    /// <summary>
    /// An entity representing a Shopify Smart Collection Rule.
    /// </summary>
    public class SmartCollectionRules
    {
        /// <summary>
        /// The relationship between the column choice, and the condition.
        /// </summary>
        [JsonPropertyName("relation")]
        public string? Relation { get; set; }

        /// <summary>
        /// Select products for a collection using a condition. Conditions are either strings or numbers, depending on the relation.
        /// </summary>
        [JsonPropertyName("condition")]
        public string? Condition { get; set; }

        /// <summary>
        /// The properties of a product that can be used to to populate a collection.
        /// </summary>
        [JsonPropertyName("column")]
        public string? Column { get; set; }
    }
}
