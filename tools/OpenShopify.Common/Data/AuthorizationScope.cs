﻿using System.Text.Json.Serialization;

namespace OpenShopify.Common.Data;
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AuthorizationScope
{
    read_content,
    write_content,
    read_themes,
    write_themes,
    read_products,
    write_products,
    read_customers,
    write_customers,
    read_orders,
    read_all_orders,
    write_orders,
    read_script_tags,
    write_script_tags,
    read_fulfillments,
    write_fulfillments,
    read_shipping,
    write_shipping,
    read_analytics,
    read_users,
    write_users,
    read_checkouts,
    write_checkouts,
    read_reports,
    write_reports,
    read_price_rules,
    write_price_rules,
    read_inventory,
    write_inventory,
    read_product_listings,
    read_collection_listings,
    read_draft_orders,
    write_draft_orders,
    write_merchant_managed_fulfillment_orders,
    read_merchant_managed_fulfillment_orders,
    read_marketing_events,
    write_marketing_events,
    read_resource_feedbacks,
    write_resource_feedbacks,
    unauthenticated_read_checkouts,
    unauthenticated_read_collection_listings,
    unauthenticated_read_customer_tags,
    unauthenticated_read_customers,
    unauthenticated_read_product_listings,
    unauthenticated_read_product_tags,
    unauthenticated_write_checkouts,
    unauthenticated_write_customers,
    unauthenticated_read_content,
    read_locations,
    write_locations,
    read_order_edits,
    write_order_edits,
    read_assigned_fulfillment_orders,
    write_assigned_fulfillment_orders,
    read_third_party_fulfillment_orders,
    write_third_party_fulfillment_orders,
    read_gift_cards,
    write_gift_cards,
    read_discounts,
    write_discounts,
    read_shopify_payments_payouts,
    read_shopify_payments_disputes,
    read_translations,
    write_translations,
    read_locales,
    write_locales,

    #region Subscriptions API

    read_customer_payment_methods,
    read_own_subscription_contracts,
    write_own_subscription_contracts

    #endregion Subscriptions API
}
