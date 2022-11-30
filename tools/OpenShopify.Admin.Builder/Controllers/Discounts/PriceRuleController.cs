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

    public abstract class PriceRuleControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Creates a price rule
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("price_rules.json")]
        public abstract System.Threading.Tasks.Task CreatePriceRule([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.CreatePriceRuleRequest request);

        /// <summary>
        /// Retrieves a list of price rules
        /// </summary>
        /// <remarks>
        /// Retrieves a list of price rules. **Note:** As of version 2019-10, this endpoint implements pagination by using links that are provided in the response header. Sending the `page` parameter will return an error. To learn more, see [*Make paginated requests to the REST Admin API*](/api/usage/pagination-rest).
        /// </remarks>
        /// <param name="created_at_max">Show price rules created before date (format 2017-03-25T16:15:47-04:00).</param>
        /// <param name="created_at_min">Show price rules created after date (format 2017-03-25T16:15:47-04:00).</param>
        /// <param name="ends_at_max">Show price rules ending before date (format 2017-03-25T16:15:47-04:00).</param>
        /// <param name="ends_at_min">Show price rules ending after date (format 2017-03-25T16:15:47-04:00).</param>
        /// <param name="limit">The maximum number of results to retrieve.</param>
        /// <param name="page_info">A unique ID used to access a certain page of results.</param>
        /// <param name="since_id">Restrict results to after the specified ID.</param>
        /// <param name="starts_at_max">Show price rules starting before date (format 2017-03-25T16:15:47-04:00).</param>
        /// <param name="starts_at_min">Show price rules starting after date (format 2017-03-25T16:15:47-04:00).</param>
        /// <param name="times_used">Show price rules with times used.</param>
        /// <param name="updated_at_max">Show price rules last updated before date (format 2017-03-25T16:15:47-04:00).</param>
        /// <param name="updated_at_min">Show price rules last updated after date (format 2017-03-25T16:15:47-04:00).</param>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("price_rules.json")]
        public abstract System.Threading.Tasks.Task ListPriceRules([Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? created_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? created_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? ends_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? ends_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] int? limit = null, string? page_info = null, [Microsoft.AspNetCore.Mvc.FromQuery] long? since_id = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? starts_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? starts_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] int? times_used = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] System.DateTimeOffset? updated_at_min = null);

        /// <summary>
        /// Updates an existing a price rule
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("price_rules/{price_rule_id}.json")]
        public abstract System.Threading.Tasks.Task UpdatePriceRule([System.ComponentModel.DataAnnotations.Required] OpenShopify.Admin.Builder.Models.UpdatePriceRuleRequest request, long price_rule_id);

        /// <summary>
        /// Retrieves a single price rule
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("price_rules/{price_rule_id}.json")]
        public abstract System.Threading.Tasks.Task GetPriceRule(long price_rule_id);

        /// <summary>
        /// Remove an existing PriceRule
        /// </summary>
        /// <remarks>
        /// Deletes a price rule
        /// </remarks>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("price_rules/{price_rule_id}.json")]
        public abstract System.Threading.Tasks.Task DeletePriceRule(long price_rule_id);

        /// <summary>
        /// Retrieves a count of all price rules
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("price_rules/count.json")]
        public abstract System.Threading.Tasks.Task CountPriceRules();

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum PriceRuleAllocationMethod
    {

        [System.Runtime.Serialization.EnumMember(Value = @"each")]
        Each = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"across")]
        Across = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"target_type")]
        TargetType = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"shipping_line")]
        ShippingLine = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum PriceRuleCustomerSelection
    {

        [System.Runtime.Serialization.EnumMember(Value = @"all")]
        All = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"prerequisite")]
        Prerequisite = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum PriceRuleTargetSelection
    {

        [System.Runtime.Serialization.EnumMember(Value = @"all")]
        All = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"entitled")]
        Entitled = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum PriceRuleTargetType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"line_item")]
        LineItem = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"shipping_line")]
        ShippingLine = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum PriceRuleValueType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"fixed_amount")]
        FixedAmount = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"percentage")]
        Percentage = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"target_type")]
        TargetType = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"shipping_line")]
        ShippingLine = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record PriceRuleOrig
    {
        /// <summary>
        /// The allocation method of the price rule. Valid values:
        /// 
        /// *   **each**: The discount is applied to each of the entitled items. For example, for a price rule that takes $15 off, each entitled line item in a checkout will be discounted by $15. 
        /// *   **across**: The calculated discount amount will be applied across the entitled items. For example, for a price rule that takes $15 off, the discount will be applied across all the entitled items. 
        /// 
        /// When the value of `target_type` is `shipping_line`, then this value must be `each`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("allocation_method")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? AllocationMethod { get; set; } = default!;

        /// <summary>
        /// The customer selection for the price rule. Valid values:
        /// 
        /// *   **all**: The price rule is valid for all customers. 
        /// *   **prerequisite**: The customer must either belong to one of the customer segments specified by `customer_segment_prerequisite_ids`, or be one of the customers specified by `prerequisite_customer_ids`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customer_selection")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? CustomerSelection { get; set; } = default!;

        /// <summary>
        /// The date and time ([ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format) when the price rule ends. Must be after `starts_at`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ends_at")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.DateTimeOffset? EndsAt { get; set; } = default!;

        /// <summary>
        /// A list of IDs of collections whose products will be eligible to the discount. It can be used only with `target_type` set to `line_item` and `target_selection` set to `entitled`. It can't be used in combination with `entitled_product_ids` or `entitled_variant_ids`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("entitled_collection_ids")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.List<long>? EntitledCollectionIds { get; set; } = default!;

        /// <summary>
        /// A list of IDs of shipping countries that will be entitled to the discount. It can be used only with `target_type` set to `shipping_line` and `target_selection` set to `entitled`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("entitled_country_ids")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.List<long>? EntitledCountryIds { get; set; } = default!;

        /// <summary>
        /// A list of IDs of products that will be entitled to the discount. It can be used only with `target_type` set to `line_item` and `target_selection` set to `entitled`.
        ///  &lt;div class="note note-caution"&gt; 
        /// 
        /// If a product variant is included in `entitled_variant_ids`, then `entitled_product_ids` can't include the ID of the product associated with that variant.
        ///  &lt;/div&gt;
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("entitled_product_ids")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.List<long>? EntitledProductIds { get; set; } = default!;

        /// <summary>
        /// A list of IDs of product variants that will be entitled to the discount. It can be used only with `target_type` set to `line_item` and `target_selection` set to `entitled`.
        ///  &lt;div class="note note-caution"&gt; 
        /// 
        /// If a product is included in `entitled_product_ids`, then `entitled_variant_ids` can't include the ID of any variants associated with that product.
        ///  &lt;/div&gt;
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("entitled_variant_ids")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.List<long>? EntitledVariantIds { get; set; } = default!;

        /// <summary>
        /// Whether the generated discount code will be valid only for a single use per customer. This is tracked using customer ID.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("once_per_customer")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public bool? OncePerCustomer { get; set; } = default!;

        /// <summary>
        /// A list of customer IDs. For the price rule to be applicable, the customer must match one of the specified [customers](/docs/admin-api/rest/reference/customers/customer).
        /// 
        /// If `prerequisite_customer_ids` is populated, then `customer_segment_prerequisite_ids` must be empty.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("prerequisite_customer_ids")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.List<long>? PrerequisiteCustomerIds { get; set; } = default!;

        /// <summary>
        /// The minimum number of items for the price rule to be applicable. It has the following property:
        /// 
        /// *   **greater_than_or_equal_to**: The quantity of an entitled cart item must be greater than or equal to this value.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("prerequisite_quantity_range")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? PrerequisiteQuantityRange { get; set; } = default!;

        /// <summary>
        /// A list of customer segment IDs. For the price rule to be applicable, the customer must be in the group of customers matching a customer segment.
        /// 
        /// If `customer_segment_prerequisite_ids` is populated, then `prerequisite_customer_ids` must be empty.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("customer_segment_prerequisite_ids")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.List<long>? CustomerSegmentPrerequisiteIds { get; set; } = default!;

        /// <summary>
        /// The maximum shipping price for the price rule to be applicable. It has the following property:
        /// 
        /// *   **less_than_or_equal_to**: The shipping price must be less than or equal to this value.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("prerequisite_shipping_price_range")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? PrerequisiteShippingPriceRange { get; set; } = default!;

        /// <summary>
        /// The minimum subtotal for the price rule to be applicable. It has the following property:
        /// 
        /// *   **greater_than_or_equal_to**: The subtotal of the entitled cart items must be greater than or equal to this value for the discount to apply.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("prerequisite_subtotal_range")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? PrerequisiteSubtotalRange { get; set; } = default!;

        /// <summary>
        /// The prerequisite purchase for a Buy X Get Y discount. It has the following property:
        /// 
        /// *   **prerequisite_amount**: The minimum purchase amount required to be entitled to the discount.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("prerequisite_to_entitlement_purchase")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? PrerequisiteToEntitlementPurchase { get; set; } = default!;

        /// <summary>
        /// The date and time ([ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format) when the price rule starts.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("starts_at")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.DateTimeOffset? StartsAt { get; set; } = default!;

        /// <summary>
        /// The target selection method of the price rule. Valid values:
        /// 
        /// *   **all**: The price rule applies the discount to all line items in the checkout. 
        /// *   **entitled**: The price rule applies the discount to selected entitlements only.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("target_selection")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? TargetSelection { get; set; } = default!;

        /// <summary>
        /// The target type that the price rule applies to. Valid values:
        /// 
        /// *   **line_item**: The price rule applies to the cart's line items. 
        /// *   **shipping_line**: The price rule applies to the cart's shipping lines.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("target_type")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? TargetType { get; set; } = default!;

        /// <summary>
        /// The title of the price rule. This is used by the Shopify admin search to retrieve discounts. It is also displayed on the **Discounts** page of the Shopify admin for bulk discounts.
        /// 
        /// For non-bulk discounts, the discount code is displayed on the admin.
        ///  &lt;div class="note note-caution"&gt; 
        /// 
        /// For a consistent search experience, use the same value for `title` as the `code` property of the associated discount code.
        ///  &lt;/div&gt;
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Title { get; set; } = default!;

        /// <summary>
        /// The maximum number of times the price rule can be used, per discount code.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("usage_limit")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public long? UsageLimit { get; set; } = default!;

        /// <summary>
        /// List of product ids that will be a prerequisites for a Buy X Get Y type discount. The `prerequisite_product_ids` can be used only with:
        /// 
        /// *   `target_type` set to `line_item`, 
        /// *   `target_selection` set to `entitled`, 
        /// *   `allocation_method` set to `each` and 
        /// *   `prerequisite_to_entitlement_quantity_ratio` defined. 
        /// 
        ///  &lt;div class="note note-caution"&gt; 
        /// 
        /// #### Caution
        /// 
        /// If a product variant is included in `prerequisite_variant_ids`, then `prerequisite_product_ids` can't include the ID of the product associated with that variant.
        ///  &lt;/div&gt;
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("prerequisite_product_ids")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.List<long>? PrerequisiteProductIds { get; set; } = default!;

        /// <summary>
        /// List of variant ids that will be a prerequisites for a Buy X Get Y type discount. The `entitled_variant_ids` can be used only with:
        /// 
        /// *   `target_type` set to `line_item`, 
        /// *   `target_selection` set to `entitled`, 
        /// *   `allocation_method` set to `each` and 
        /// *   `prerequisite_to_entitlement_quantity_ratio` defined. 
        /// 
        ///  &lt;div class="note note-caution"&gt; 
        /// 
        /// #### Caution
        /// 
        /// If a product is included in `prerequisite_product_ids`, then `prerequisite_variant_ids` can't include the ID of any variants associated with that product.
        ///  &lt;/div&gt;
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("prerequisite_variant_ids")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.List<long>? PrerequisiteVariantIds { get; set; } = default!;

        /// <summary>
        /// List of collection ids that will be a prerequisites for a Buy X Get Y discount. The `entitled_collection_ids` can be used only with:
        /// 
        /// *   `target_type` set to `line_item`, 
        /// *   `target_selection` set to `entitled`, 
        /// *   `allocation_method` set to `each` and 
        /// *   `prerequisite_to_entitlement_quantity_ratio` defined. 
        /// 
        ///  Cannot be used in combination with `prerequisite_product_ids` or `prerequisite_variant_ids`.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("prerequisite_collection_ids")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.List<long>? PrerequisiteCollectionIds { get; set; } = default!;

        /// <summary>
        /// The value of the price rule. If if the value of `target_type` is `shipping_line`, then only `-100` is accepted. The value must be negative.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Value { get; set; } = default!;

        /// <summary>
        /// The value type of the price rule. Valid values:
        /// 
        /// *   **fixed_amount**: Applies a discount of `value` as a unit of the store's currency. For example, if `value` is -30 and the store's currency is USD, then $30 USD is deducted when the discount is applied. 
        /// *   **percentage**: Applies a percentage discount of `value`. For example, if `value` is -30, then 30% will be deducted when the discount is applied. 
        /// 
        /// If `target_type` is `shipping_line`, then only `percentage` is accepted.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value_type")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? ValueType { get; set; } = default!;

        /// <summary>
        /// Buy/Get ratio for a Buy X Get Y discount. `prerequisite_quantity` defines the necessary 'buy' quantity and `entitled_quantity` the offered 'get' quantity.
        /// 
        /// The `prerequisite_to_entitlement_quantity_ratio` can be used only with:
        /// 
        /// *   `value_type` set to `percentage`, 
        /// *   `target_type` set to `line_item`, 
        /// *   `target_selection` set to `entitled`, 
        /// *   `allocation_method` set to `each`, 
        /// *   `prerequisite_product_ids` or `prerequisite_variant_ids` or `prerequisite_collection_ids` defined and 
        /// *   `entitled_product_ids` or `entitled_variant_ids` or `entitled_collection_ids` defined. 
        /// 
        ///  &lt;div class="note note-caution"&gt; 
        /// 
        /// #### Caution
        /// 
        /// Cannot be used in combination with `prerequisite_subtotal_range`, `prerequisite_quantity_range` or `prerequisite_shipping_price_range`.
        ///  &lt;/div&gt;
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("prerequisite_to_entitlement_quantity_ratio")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? PrerequisiteToEntitlementQuantityRatio { get; set; } = default!;

        /// <summary>
        /// The number of times the discount can be allocated on the cart - if eligible. For example a Buy 1 hat Get 1 hat for free discount can be applied 3 times on a cart having more than 6 hats, where maximum of 3 hats get discounted - if the `allocation_limit` is 3. Empty (`null`) `allocation_limit` means unlimited number of allocations.
        ///  &lt;div class="note note-caution"&gt; 
        /// 
        /// #### Caution
        /// 
        /// `allocation_limit` is only working with Buy X Get Y discount. The default value on creation will be `null` (unlimited).
        ///  &lt;/div&gt;
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("allocation_limit")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? AllocationLimit { get; set; } = default!;

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