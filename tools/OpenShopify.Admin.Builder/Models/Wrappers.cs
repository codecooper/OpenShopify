﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenShopify.Common.Models;

namespace OpenShopify.Admin.Builder.Models;
// ReSharper disable All

public partial record StorefrontAccessTokenItem
{
    [JsonPropertyName("storefront_access_token"), Required]
    public StorefrontAccessToken StorefrontAccessToken { get; set; } = null!;
}

public partial record StorefrontAccessTokenList
{
    [JsonPropertyName("storefront_access_tokens"), Required]
    public IEnumerable<StorefrontAccessToken> StorefrontAccessTokens { get; set; } = null!;
}
public partial record CreateStorefrontAccessTokenRequest
{
    [JsonPropertyName("storefront_access_token"), Required]
    public CreateStorefrontAccessToken StorefrontAccessToken { get; set; } = null!;
}

public partial record CreateStorefrontAccessToken : StorefrontAccessTokenBase {}
public partial record UpdateStorefrontAccessTokenRequest
{
    [JsonPropertyName("storefront_access_token"), Required]
    public UpdateStorefrontAccessToken StorefrontAccessToken { get; set; } = null!;
}

public partial record UpdateStorefrontAccessToken : StorefrontAccessToken{}

		
public partial record StorefrontAccessToken : StorefrontAccessTokenBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record StorefrontAccessTokenBase : StorefrontAccessTokenOrig{}

	
public partial record ReportItem
{
    [JsonPropertyName("report"), Required]
    public Report Report { get; set; } = null!;
}

public partial record ReportList
{
    [JsonPropertyName("reports"), Required]
    public IEnumerable<Report> Reports { get; set; } = null!;
}
public partial record CreateReportRequest
{
    [JsonPropertyName("report"), Required]
    public CreateReport Report { get; set; } = null!;
}

public partial record CreateReport : ReportBase {}
public partial record UpdateReportRequest
{
    [JsonPropertyName("report"), Required]
    public UpdateReport Report { get; set; } = null!;
}

public partial record UpdateReport : Report{}

		
public partial record Report : ReportBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record ReportBase : ReportOrig{}

	
public partial record ApplicationChargeItem
{
    [JsonPropertyName("application_charge"), Required]
    public ApplicationCharge ApplicationCharge { get; set; } = null!;
}

public partial record ApplicationChargeList
{
    [JsonPropertyName("application_charges"), Required]
    public IEnumerable<ApplicationCharge> ApplicationCharges { get; set; } = null!;
}
public partial record CreateApplicationChargeRequest
{
    [JsonPropertyName("application_charge"), Required]
    public CreateApplicationCharge ApplicationCharge { get; set; } = null!;
}

public partial record CreateApplicationCharge : ApplicationChargeBase {}
public partial record UpdateApplicationChargeRequest
{
    [JsonPropertyName("application_charge"), Required]
    public UpdateApplicationCharge ApplicationCharge { get; set; } = null!;
}

public partial record UpdateApplicationCharge : ApplicationCharge{}

		
public partial record ApplicationCharge : ApplicationChargeBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record ApplicationChargeBase : ApplicationChargeOrig{}

	
public partial record ApplicationCreditItem
{
    [JsonPropertyName("application_credit"), Required]
    public ApplicationCredit ApplicationCredit { get; set; } = null!;
}

public partial record ApplicationCreditList
{
    [JsonPropertyName("application_credits"), Required]
    public IEnumerable<ApplicationCredit> ApplicationCredits { get; set; } = null!;
}
public partial record CreateApplicationCreditRequest
{
    [JsonPropertyName("application_credit"), Required]
    public CreateApplicationCredit ApplicationCredit { get; set; } = null!;
}

public partial record CreateApplicationCredit : ApplicationCreditBase {}
public partial record UpdateApplicationCreditRequest
{
    [JsonPropertyName("application_credit"), Required]
    public UpdateApplicationCredit ApplicationCredit { get; set; } = null!;
}

public partial record UpdateApplicationCredit : ApplicationCredit{}

		
public partial record ApplicationCredit : ApplicationCreditBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record ApplicationCreditBase : ApplicationCreditOrig{}

	
public partial record RecurringApplicationChargeItem
{
    [JsonPropertyName("recurring_application_charge"), Required]
    public RecurringApplicationCharge RecurringApplicationCharge { get; set; } = null!;
}

public partial record RecurringApplicationChargeList
{
    [JsonPropertyName("recurring_application_charges"), Required]
    public IEnumerable<RecurringApplicationCharge> RecurringApplicationCharges { get; set; } = null!;
}
public partial record CreateRecurringApplicationChargeRequest
{
    [JsonPropertyName("recurring_application_charge"), Required]
    public CreateRecurringApplicationCharge RecurringApplicationCharge { get; set; } = null!;
}

public partial record CreateRecurringApplicationCharge : RecurringApplicationChargeBase {}
public partial record UpdateRecurringApplicationChargeRequest
{
    [JsonPropertyName("recurring_application_charge"), Required]
    public UpdateRecurringApplicationCharge RecurringApplicationCharge { get; set; } = null!;
}

public partial record UpdateRecurringApplicationCharge : RecurringApplicationCharge{}

		
public partial record RecurringApplicationCharge : RecurringApplicationChargeBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record RecurringApplicationChargeBase : RecurringApplicationChargeOrig{}

	
public partial record UsageChargeItem
{
    [JsonPropertyName("usage_charge"), Required]
    public UsageCharge UsageCharge { get; set; } = null!;
}

public partial record UsageChargeList
{
    [JsonPropertyName("usage_charges"), Required]
    public IEnumerable<UsageCharge> UsageCharges { get; set; } = null!;
}
public partial record CreateUsageChargeRequest
{
    [JsonPropertyName("usage_charge"), Required]
    public CreateUsageCharge UsageCharge { get; set; } = null!;
}

public partial record CreateUsageCharge : UsageChargeBase {}
public partial record UpdateUsageChargeRequest
{
    [JsonPropertyName("usage_charge"), Required]
    public UpdateUsageCharge UsageCharge { get; set; } = null!;
}

public partial record UpdateUsageCharge : UsageCharge{}

		
public partial record UsageCharge : UsageChargeBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record UsageChargeBase : UsageChargeOrig{}

	
public partial record CustomerItem
{
    [JsonPropertyName("customer"), Required]
    public Customer Customer { get; set; } = null!;
}

public partial record CustomerList
{
    [JsonPropertyName("customers"), Required]
    public IEnumerable<Customer> Customers { get; set; } = null!;
}
public partial record CreateCustomerRequest
{
    [JsonPropertyName("customer"), Required]
    public CreateCustomer Customer { get; set; } = null!;
}

public partial record CreateCustomer : CustomerBase {}
public partial record UpdateCustomerRequest
{
    [JsonPropertyName("customer"), Required]
    public UpdateCustomer Customer { get; set; } = null!;
}

public partial record UpdateCustomer : Customer{}

		
public partial record Customer : CustomerBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record CustomerBase : CustomerOrig{}

	
public partial record CustomerSavedSearchItem
{
    [JsonPropertyName("customer_saved_search"), Required]
    public CustomerSavedSearch CustomerSavedSearch { get; set; } = null!;
}

public partial record CustomerSavedSearchList
{
    [JsonPropertyName("customer_saved_searches"), Required]
    public IEnumerable<CustomerSavedSearch> CustomerSavedSearches { get; set; } = null!;
}
public partial record CreateCustomerSavedSearchRequest
{
    [JsonPropertyName("customer_saved_search"), Required]
    public CreateCustomerSavedSearch CustomerSavedSearch { get; set; } = null!;
}

public partial record CreateCustomerSavedSearch : CustomerSavedSearchBase {}
public partial record UpdateCustomerSavedSearchRequest
{
    [JsonPropertyName("customer_saved_search"), Required]
    public UpdateCustomerSavedSearch CustomerSavedSearch { get; set; } = null!;
}

public partial record UpdateCustomerSavedSearch : CustomerSavedSearch{}

		
public partial record CustomerSavedSearch : CustomerSavedSearchBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record CustomerSavedSearchBase : CustomerSavedSearchOrig{}

	
public partial record DeprecatedApiCallItem
{
    [JsonPropertyName("deprecated_api_call"), Required]
    public DeprecatedApiCall DeprecatedApiCall { get; set; } = null!;
}

public partial record DeprecatedApiCallList
{
    [JsonPropertyName("deprecated_api_calls"), Required]
    public IEnumerable<DeprecatedApiCall> DeprecatedApiCalls { get; set; } = null!;
}
		
public partial record DeprecatedApiCall : DeprecatedAPIcallsBase
{
}

public partial record DeprecatedAPIcallsBase : DeprecatedAPIcallsOrig{}

	
public partial record DiscountCodeItem
{
    [JsonPropertyName("discount_code"), Required]
    public DiscountCode DiscountCode { get; set; } = null!;
}

public partial record DiscountCodeList
{
    [JsonPropertyName("discount_codes"), Required]
    public IEnumerable<DiscountCode> DiscountCodes { get; set; } = null!;
}
public partial record CreateDiscountCodeRequest
{
    [JsonPropertyName("discount_code"), Required]
    public CreateDiscountCode DiscountCode { get; set; } = null!;
}

public partial record CreateDiscountCode : DiscountCodeBase {}
public partial record UpdateDiscountCodeRequest
{
    [JsonPropertyName("discount_code"), Required]
    public UpdateDiscountCode DiscountCode { get; set; } = null!;
}

public partial record UpdateDiscountCode : DiscountCode{}

		
public partial record DiscountCode : DiscountCodeBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record DiscountCodeBase : DiscountCodeOrig{}

	
public partial record PriceRuleItem
{
    [JsonPropertyName("price_rule"), Required]
    public PriceRule PriceRule { get; set; } = null!;
}

public partial record PriceRuleList
{
    [JsonPropertyName("price_rules"), Required]
    public IEnumerable<PriceRule> PriceRules { get; set; } = null!;
}
public partial record CreatePriceRuleRequest
{
    [JsonPropertyName("price_rule"), Required]
    public CreatePriceRule PriceRule { get; set; } = null!;
}

public partial record CreatePriceRule : PriceRuleBase {}
public partial record UpdatePriceRuleRequest
{
    [JsonPropertyName("price_rule"), Required]
    public UpdatePriceRule PriceRule { get; set; } = null!;
}

public partial record UpdatePriceRule : PriceRule{}

		
public partial record PriceRule : PriceRuleBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record PriceRuleBase : PriceRuleOrig{}

	
public partial record EventItem
{
    [JsonPropertyName("event"), Required]
    public Event Event { get; set; } = null!;
}

public partial record EventList
{
    [JsonPropertyName("events"), Required]
    public IEnumerable<Event> Events { get; set; } = null!;
}
public partial record CreateEventRequest
{
    [JsonPropertyName("event"), Required]
    public CreateEvent Event { get; set; } = null!;
}

public partial record CreateEvent : EventBase {}
public partial record UpdateEventRequest
{
    [JsonPropertyName("event"), Required]
    public UpdateEvent Event { get; set; } = null!;
}

public partial record UpdateEvent : Event{}

		
public partial record Event : EventBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record EventBase : EventOrig{}

	
public partial record WebhookItem
{
    [JsonPropertyName("webhook"), Required]
    public Webhook Webhook { get; set; } = null!;
}

public partial record WebhookList
{
    [JsonPropertyName("webhooks"), Required]
    public IEnumerable<Webhook> Webhooks { get; set; } = null!;
}
public partial record CreateWebhookRequest
{
    [JsonPropertyName("webhook"), Required]
    public CreateWebhook Webhook { get; set; } = null!;
}

public partial record CreateWebhook : WebhookBase {}
public partial record UpdateWebhookRequest
{
    [JsonPropertyName("webhook"), Required]
    public UpdateWebhook Webhook { get; set; } = null!;
}

public partial record UpdateWebhook : Webhook{}

		
public partial record Webhook : WebhookBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record WebhookBase : WebhookOrig{}

	
public partial record InventoryItemItem
{
    [JsonPropertyName("inventory_item"), Required]
    public InventoryItem InventoryItem { get; set; } = null!;
}

public partial record InventoryItemList
{
    [JsonPropertyName("inventory_items"), Required]
    public IEnumerable<InventoryItem> InventoryItems { get; set; } = null!;
}
public partial record CreateInventoryItemRequest
{
    [JsonPropertyName("inventory_item"), Required]
    public CreateInventoryItem InventoryItem { get; set; } = null!;
}

public partial record CreateInventoryItem : InventoryItemBase {}
public partial record UpdateInventoryItemRequest
{
    [JsonPropertyName("inventory_item"), Required]
    public UpdateInventoryItem InventoryItem { get; set; } = null!;
}

public partial record UpdateInventoryItem : InventoryItem{}

		
public partial record InventoryItem : InventoryItemBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record InventoryItemBase : InventoryItemOrig{}

	
public partial record InventoryLevelItem
{
    [JsonPropertyName("inventory_level"), Required]
    public InventoryLevel InventoryLevel { get; set; } = null!;
}

public partial record InventoryLevelList
{
    [JsonPropertyName("inventory_levels"), Required]
    public IEnumerable<InventoryLevel> InventoryLevels { get; set; } = null!;
}
public partial record CreateInventoryLevelRequest
{
    [JsonPropertyName("inventory_level"), Required]
    public CreateInventoryLevel InventoryLevel { get; set; } = null!;
}

public partial record CreateInventoryLevel : InventoryLevelBase {}
public partial record UpdateInventoryLevelRequest
{
    [JsonPropertyName("inventory_level"), Required]
    public UpdateInventoryLevel InventoryLevel { get; set; } = null!;
}

public partial record UpdateInventoryLevel : InventoryLevel{}

		
public partial record InventoryLevel : InventoryLevelBase
{
}

public partial record InventoryLevelBase : InventoryLevelOrig{}

	
public partial record LocationItem
{
    [JsonPropertyName("location"), Required]
    public Location Location { get; set; } = null!;
}

public partial record LocationList
{
    [JsonPropertyName("locations"), Required]
    public IEnumerable<Location> Locations { get; set; } = null!;
}
public partial record CreateLocationRequest
{
    [JsonPropertyName("location"), Required]
    public CreateLocation Location { get; set; } = null!;
}

public partial record CreateLocation : LocationBase {}
public partial record UpdateLocationRequest
{
    [JsonPropertyName("location"), Required]
    public UpdateLocation Location { get; set; } = null!;
}

public partial record UpdateLocation : Location{}

		
public partial record Location : LocationBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record LocationBase : LocationOrig{}

	
public partial record MarketingEventItem
{
    [JsonPropertyName("marketing_event"), Required]
    public MarketingEvent MarketingEvent { get; set; } = null!;
}

public partial record MarketingEventList
{
    [JsonPropertyName("marketing_events"), Required]
    public IEnumerable<MarketingEvent> MarketingEvents { get; set; } = null!;
}
public partial record CreateMarketingEventRequest
{
    [JsonPropertyName("marketing_event"), Required]
    public CreateMarketingEvent MarketingEvent { get; set; } = null!;
}

public partial record CreateMarketingEvent : MarketingEventBase {}
public partial record UpdateMarketingEventRequest
{
    [JsonPropertyName("marketing_event"), Required]
    public UpdateMarketingEvent MarketingEvent { get; set; } = null!;
}

public partial record UpdateMarketingEvent : MarketingEvent{}

		
public partial record MarketingEvent : MarketingEventBase
{
}

public partial record MarketingEventBase : MarketingEventOrig{}

	
public partial record MetafieldItem
{
    [JsonPropertyName("metafield"), Required]
    public Metafield Metafield { get; set; } = null!;
}

public partial record MetafieldList
{
    [JsonPropertyName("metafields"), Required]
    public IEnumerable<Metafield> Metafields { get; set; } = null!;
}
public partial record CreateMetafieldRequest
{
    [JsonPropertyName("metafield"), Required]
    public CreateMetafield Metafield { get; set; } = null!;
}

public partial record CreateMetafield : MetafieldBase {}
public partial record UpdateMetafieldRequest
{
    [JsonPropertyName("metafield"), Required]
    public UpdateMetafield Metafield { get; set; } = null!;
}

public partial record UpdateMetafield : Metafield{}

		
public partial record Metafield : MetafieldBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record MetafieldBase : MetafieldOrig{}

	
public partial record ArticleItem
{
    [JsonPropertyName("article"), Required]
    public Article Article { get; set; } = null!;
}

public partial record ArticleList
{
    [JsonPropertyName("articles"), Required]
    public IEnumerable<Article> Articles { get; set; } = null!;
}
public partial record CreateArticleRequest
{
    [JsonPropertyName("article"), Required]
    public CreateArticle Article { get; set; } = null!;
}

public partial record CreateArticle : ArticleBase {}
public partial record UpdateArticleRequest
{
    [JsonPropertyName("article"), Required]
    public UpdateArticle Article { get; set; } = null!;
}

public partial record UpdateArticle : Article{}

		
public partial record Article : ArticleBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record ArticleBase : ArticleOrig{}

	
public partial record AssetItem
{
    [JsonPropertyName("asset"), Required]
    public Asset Asset { get; set; } = null!;
}

public partial record AssetList
{
    [JsonPropertyName("assets"), Required]
    public IEnumerable<Asset> Assets { get; set; } = null!;
}
public partial record CreateAssetRequest
{
    [JsonPropertyName("asset"), Required]
    public CreateAsset Asset { get; set; } = null!;
}

public partial record CreateAsset : AssetBase {}
public partial record UpdateAssetRequest
{
    [JsonPropertyName("asset"), Required]
    public UpdateAsset Asset { get; set; } = null!;
}

public partial record UpdateAsset : Asset{}

		
public partial record Asset : AssetBase
{
}

public partial record AssetBase : AssetOrig{}

	
public partial record BlogItem
{
    [JsonPropertyName("blog"), Required]
    public Blog Blog { get; set; } = null!;
}

public partial record BlogList
{
    [JsonPropertyName("blogs"), Required]
    public IEnumerable<Blog> Blogs { get; set; } = null!;
}
public partial record CreateBlogRequest
{
    [JsonPropertyName("blog"), Required]
    public CreateBlog Blog { get; set; } = null!;
}

public partial record CreateBlog : BlogBase {}
public partial record UpdateBlogRequest
{
    [JsonPropertyName("blog"), Required]
    public UpdateBlog Blog { get; set; } = null!;
}

public partial record UpdateBlog : Blog{}

		
public partial record Blog : BlogBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record BlogBase : BlogOrig{}

	
public partial record CommentItem
{
    [JsonPropertyName("comment"), Required]
    public Comment Comment { get; set; } = null!;
}

public partial record CommentList
{
    [JsonPropertyName("comments"), Required]
    public IEnumerable<Comment> Comments { get; set; } = null!;
}
public partial record CreateCommentRequest
{
    [JsonPropertyName("comment"), Required]
    public CreateComment Comment { get; set; } = null!;
}

public partial record CreateComment : CommentBase {}
public partial record UpdateCommentRequest
{
    [JsonPropertyName("comment"), Required]
    public UpdateComment Comment { get; set; } = null!;
}

public partial record UpdateComment : Comment{}

		
public partial record Comment : CommentBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record CommentBase : CommentOrig{}

	
public partial record PageItem
{
    [JsonPropertyName("page"), Required]
    public Page Page { get; set; } = null!;
}

public partial record PageList
{
    [JsonPropertyName("pages"), Required]
    public IEnumerable<Page> Pages { get; set; } = null!;
}
public partial record CreatePageRequest
{
    [JsonPropertyName("page"), Required]
    public CreatePage Page { get; set; } = null!;
}

public partial record CreatePage : PageBase {}
public partial record UpdatePageRequest
{
    [JsonPropertyName("page"), Required]
    public UpdatePage Page { get; set; } = null!;
}

public partial record UpdatePage : Page{}

		
public partial record Page : PageBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record PageBase : PageOrig{}

	
public partial record RedirectItem
{
    [JsonPropertyName("redirect"), Required]
    public Redirect Redirect { get; set; } = null!;
}

public partial record RedirectList
{
    [JsonPropertyName("redirects"), Required]
    public IEnumerable<Redirect> Redirects { get; set; } = null!;
}
public partial record CreateRedirectRequest
{
    [JsonPropertyName("redirect"), Required]
    public CreateRedirect Redirect { get; set; } = null!;
}

public partial record CreateRedirect : RedirectBase {}
public partial record UpdateRedirectRequest
{
    [JsonPropertyName("redirect"), Required]
    public UpdateRedirect Redirect { get; set; } = null!;
}

public partial record UpdateRedirect : Redirect{}

		
public partial record Redirect : RedirectBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record RedirectBase : RedirectOrig{}

	
public partial record ScriptTagItem
{
    [JsonPropertyName("script_tag"), Required]
    public ScriptTag ScriptTag { get; set; } = null!;
}

public partial record ScriptTagList
{
    [JsonPropertyName("script_tags"), Required]
    public IEnumerable<ScriptTag> ScriptTags { get; set; } = null!;
}
public partial record CreateScriptTagRequest
{
    [JsonPropertyName("script_tag"), Required]
    public CreateScriptTag ScriptTag { get; set; } = null!;
}

public partial record CreateScriptTag : ScriptTagBase {}
public partial record UpdateScriptTagRequest
{
    [JsonPropertyName("script_tag"), Required]
    public UpdateScriptTag ScriptTag { get; set; } = null!;
}

public partial record UpdateScriptTag : ScriptTag{}

		
public partial record ScriptTag : ScriptTagBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record ScriptTagBase : ScriptTagOrig{}

	
public partial record ThemeItem
{
    [JsonPropertyName("theme"), Required]
    public Theme Theme { get; set; } = null!;
}

public partial record ThemeList
{
    [JsonPropertyName("themes"), Required]
    public IEnumerable<Theme> Themes { get; set; } = null!;
}
public partial record CreateThemeRequest
{
    [JsonPropertyName("theme"), Required]
    public CreateTheme Theme { get; set; } = null!;
}

public partial record CreateTheme : ThemeBase {}
public partial record UpdateThemeRequest
{
    [JsonPropertyName("theme"), Required]
    public UpdateTheme Theme { get; set; } = null!;
}

public partial record UpdateTheme : Theme{}

		
public partial record Theme : ThemeBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record ThemeBase : ThemeOrig{}

	
public partial record AbandonedCheckoutItem
{
    [JsonPropertyName("checkout"), Required]
    public Checkout AbandonedCheckout { get; set; } = null!;
}

public partial record AbandonedCheckoutList
{
    [JsonPropertyName("checkouts"), Required]
    public IEnumerable<Checkout> AbandonedCheckouts { get; set; } = null!;
}
public partial record CreateAbandonedCheckoutRequest
{
    [JsonPropertyName("checkout"), Required]
    public CreateAbandonedCheckout AbandonedCheckout { get; set; } = null!;
}

public partial record CreateAbandonedCheckout : CheckoutBase {}
public partial record UpdateAbandonedCheckoutRequest
{
    [JsonPropertyName("checkout"), Required]
    public UpdateAbandonedCheckout AbandonedCheckout { get; set; } = null!;
}

public partial record UpdateAbandonedCheckout : Checkout{}

		
public partial record AbandonedCheckout : CheckoutBase
{
}

public partial record CheckoutBase : CheckoutOrig{}

	
public partial record DraftOrderItem
{
    [JsonPropertyName("draft_order"), Required]
    public DraftOrder DraftOrder { get; set; } = null!;
}

public partial record DraftOrderList
{
    [JsonPropertyName("draft_orders"), Required]
    public IEnumerable<DraftOrder> DraftOrders { get; set; } = null!;
}
public partial record CreateDraftOrderRequest
{
    [JsonPropertyName("draft_order"), Required]
    public CreateDraftOrder DraftOrder { get; set; } = null!;
}

public partial record CreateDraftOrder : DraftOrderBase {}
public partial record UpdateDraftOrderRequest
{
    [JsonPropertyName("draft_order"), Required]
    public UpdateDraftOrder DraftOrder { get; set; } = null!;
}

public partial record UpdateDraftOrder : DraftOrder{}

		
public partial record DraftOrder : DraftOrderBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record DraftOrderBase : DraftOrderOrig{}

	
public partial record DraftOrderInvoiceItem
{
    [JsonPropertyName("draft_order_invoice"), Required]
    public DraftOrderInvoice DraftOrderInvoice { get; set; } = null!;
}

public partial record DraftOrderInvoiceList
{
    [JsonPropertyName("draft_order_invoices"), Required]
    public IEnumerable<DraftOrderInvoice> DraftOrderInvoices { get; set; } = null!;
}
		
public partial record DraftOrderInvoice : DraftOrderInvoiceBase
{
}

public partial record DraftOrderInvoiceBase : DraftOrderInvoiceOrig{}

	
public partial record OrderItem
{
    [JsonPropertyName("order"), Required]
    public Order Order { get; set; } = null!;
}

public partial record OrderList
{
    [JsonPropertyName("orders"), Required]
    public IEnumerable<Order> Orders { get; set; } = null!;
}
public partial record CreateOrderRequest
{
    [JsonPropertyName("order"), Required]
    public CreateOrder Order { get; set; } = null!;
}

public partial record CreateOrder : OrderBase {}
public partial record UpdateOrderRequest
{
    [JsonPropertyName("order"), Required]
    public UpdateOrder Order { get; set; } = null!;
}

public partial record UpdateOrder : Order{}

		
public partial record Order : OrderBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record OrderBase : OrderOrig{}

	
public partial record OrderRiskItem
{
    [JsonPropertyName("order_risk"), Required]
    public OrderRisk OrderRisk { get; set; } = null!;
}

public partial record OrderRiskList
{
    [JsonPropertyName("order_risks"), Required]
    public IEnumerable<OrderRisk> OrderRisks { get; set; } = null!;
}
public partial record CreateOrderRiskRequest
{
    [JsonPropertyName("order_risk"), Required]
    public CreateOrderRisk OrderRisk { get; set; } = null!;
}

public partial record CreateOrderRisk : OrderRiskBase {}
public partial record UpdateOrderRiskRequest
{
    [JsonPropertyName("order_risk"), Required]
    public UpdateOrderRisk OrderRisk { get; set; } = null!;
}

public partial record UpdateOrderRisk : OrderRisk{}

		
public partial record OrderRisk : OrderRiskBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record OrderRiskBase : OrderRiskOrig{}

	
public partial record RefundItem
{
    [JsonPropertyName("refund"), Required]
    public Refund Refund { get; set; } = null!;
}

public partial record RefundList
{
    [JsonPropertyName("refunds"), Required]
    public IEnumerable<Refund> Refunds { get; set; } = null!;
}
public partial record CreateRefundRequest
{
    [JsonPropertyName("refund"), Required]
    public CreateRefund Refund { get; set; } = null!;
}

public partial record CreateRefund : RefundBase {}
public partial record UpdateRefundRequest
{
    [JsonPropertyName("refund"), Required]
    public UpdateRefund Refund { get; set; } = null!;
}

public partial record UpdateRefund : Refund{}

		
public partial record Refund : RefundBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record RefundBase : RefundOrig{}

	
public partial record TransactionItem
{
    [JsonPropertyName("transaction"), Required]
    public Transaction Transaction { get; set; } = null!;
}

public partial record TransactionList
{
    [JsonPropertyName("transactions"), Required]
    public IEnumerable<Transaction> Transactions { get; set; } = null!;
}
public partial record CreateTransactionRequest
{
    [JsonPropertyName("transaction"), Required]
    public CreateTransaction Transaction { get; set; } = null!;
}

public partial record CreateTransaction : TransactionBase {}
public partial record UpdateTransactionRequest
{
    [JsonPropertyName("transaction"), Required]
    public UpdateTransaction Transaction { get; set; } = null!;
}

public partial record UpdateTransaction : Transaction{}

		
public partial record Transaction : TransactionBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record TransactionBase : TransactionOrig{}

	
public partial record GiftCardItem
{
    [JsonPropertyName("gift_card"), Required]
    public GiftCard GiftCard { get; set; } = null!;
}

public partial record GiftCardList
{
    [JsonPropertyName("gift_cards"), Required]
    public IEnumerable<GiftCard> GiftCards { get; set; } = null!;
}
public partial record CreateGiftCardRequest
{
    [JsonPropertyName("gift_card"), Required]
    public CreateGiftCard GiftCard { get; set; } = null!;
}

public partial record CreateGiftCard : GiftCardBase {}
public partial record UpdateGiftCardRequest
{
    [JsonPropertyName("gift_card"), Required]
    public UpdateGiftCard GiftCard { get; set; } = null!;
}

public partial record UpdateGiftCard : GiftCard{}

		
public partial record GiftCard : GiftCardBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record GiftCardBase : GiftCardOrig{}

	
public partial record UserItem
{
    [JsonPropertyName("user"), Required]
    public User User { get; set; } = null!;
}

public partial record UserList
{
    [JsonPropertyName("users"), Required]
    public IEnumerable<User> Users { get; set; } = null!;
}
public partial record CreateUserRequest
{
    [JsonPropertyName("user"), Required]
    public CreateUser User { get; set; } = null!;
}

public partial record CreateUser : UserBase {}
public partial record UpdateUserRequest
{
    [JsonPropertyName("user"), Required]
    public UpdateUser User { get; set; } = null!;
}

public partial record UpdateUser : User{}

		
public partial record User : UserBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record UserBase : UserOrig{}

	
public partial record CollectItem
{
    [JsonPropertyName("collect"), Required]
    public Collect Collect { get; set; } = null!;
}

public partial record CollectList
{
    [JsonPropertyName("collects"), Required]
    public IEnumerable<Collect> Collects { get; set; } = null!;
}
public partial record CreateCollectRequest
{
    [JsonPropertyName("collect"), Required]
    public CreateCollect Collect { get; set; } = null!;
}

public partial record CreateCollect : CollectBase {}
public partial record UpdateCollectRequest
{
    [JsonPropertyName("collect"), Required]
    public UpdateCollect Collect { get; set; } = null!;
}

public partial record UpdateCollect : Collect{}

		
public partial record Collect : CollectBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record CollectBase : CollectOrig{}

	
public partial record CollectionItem
{
    [JsonPropertyName("collection"), Required]
    public Collection Collection { get; set; } = null!;
}

public partial record CollectionList
{
    [JsonPropertyName("collections"), Required]
    public IEnumerable<Collection> Collections { get; set; } = null!;
}
public partial record CreateCollectionRequest
{
    [JsonPropertyName("collection"), Required]
    public CreateCollection Collection { get; set; } = null!;
}

public partial record CreateCollection : CollectionBase {}
public partial record UpdateCollectionRequest
{
    [JsonPropertyName("collection"), Required]
    public UpdateCollection Collection { get; set; } = null!;
}

public partial record UpdateCollection : Collection{}

		
public partial record Collection : CollectionBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record CollectionBase : CollectionOrig{}

	
public partial record CustomCollectionItem
{
    [JsonPropertyName("custom_collection"), Required]
    public CustomCollection CustomCollection { get; set; } = null!;
}

public partial record CustomCollectionList
{
    [JsonPropertyName("custom_collections"), Required]
    public IEnumerable<CustomCollection> CustomCollections { get; set; } = null!;
}
public partial record CreateCustomCollectionRequest
{
    [JsonPropertyName("custom_collection"), Required]
    public CreateCustomCollection CustomCollection { get; set; } = null!;
}

public partial record CreateCustomCollection : CustomCollectionBase {}
public partial record UpdateCustomCollectionRequest
{
    [JsonPropertyName("custom_collection"), Required]
    public UpdateCustomCollection CustomCollection { get; set; } = null!;
}

public partial record UpdateCustomCollection : CustomCollection{}

		
public partial record CustomCollection : CustomCollectionBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record CustomCollectionBase : CustomCollectionOrig{}

	
public partial record ProductItem
{
    [JsonPropertyName("product"), Required]
    public Product Product { get; set; } = null!;
}

public partial record ProductList
{
    [JsonPropertyName("products"), Required]
    public IEnumerable<Product> Products { get; set; } = null!;
}
public partial record CreateProductRequest
{
    [JsonPropertyName("product"), Required]
    public CreateProduct Product { get; set; } = null!;
}

public partial record CreateProduct : ProductBase {}
public partial record UpdateProductRequest
{
    [JsonPropertyName("product"), Required]
    public UpdateProduct Product { get; set; } = null!;
}

public partial record UpdateProduct : Product{}

		
public partial record Product : ProductBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record ProductBase : ProductOrig{}

	
public partial record ProductImageItem
{
    [JsonPropertyName("image"), Required]
    public ProductImage ProductImage { get; set; } = null!;
}

public partial record ProductImageList
{
    [JsonPropertyName("images"), Required]
    public IEnumerable<ProductImage> ProductImages { get; set; } = null!;
}
public partial record CreateProductImageRequest
{
    [JsonPropertyName("image"), Required]
    public CreateProductImage ProductImage { get; set; } = null!;
}

public partial record CreateProductImage : ProductImageBase {}
public partial record UpdateProductImageRequest
{
    [JsonPropertyName("image"), Required]
    public UpdateProductImage ProductImage { get; set; } = null!;
}

public partial record UpdateProductImage : ProductImage{}

		
public partial record ProductImage : ProductImageBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record ProductImageBase : ProductImageOrig{}

	
public partial record ProductVariantItem
{
    [JsonPropertyName("variant"), Required]
    public ProductVariant ProductVariant { get; set; } = null!;
}

public partial record ProductVariantList
{
    [JsonPropertyName("variants"), Required]
    public IEnumerable<ProductVariant> ProductVariants { get; set; } = null!;
}
public partial record CreateProductVariantRequest
{
    [JsonPropertyName("variant"), Required]
    public CreateProductVariant ProductVariant { get; set; } = null!;
}

public partial record CreateProductVariant : ProductVariantBase {}
public partial record UpdateProductVariantRequest
{
    [JsonPropertyName("variant"), Required]
    public UpdateProductVariant ProductVariant { get; set; } = null!;
}

public partial record UpdateProductVariant : ProductVariant{}

		
public partial record ProductVariant : ProductVariantBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record ProductVariantBase : ProductVariantOrig{}

	
public partial record SmartCollectionItem
{
    [JsonPropertyName("smart_collection"), Required]
    public SmartCollection SmartCollection { get; set; } = null!;
}

public partial record SmartCollectionList
{
    [JsonPropertyName("smart_collections"), Required]
    public IEnumerable<SmartCollection> SmartCollections { get; set; } = null!;
}
public partial record CreateSmartCollectionRequest
{
    [JsonPropertyName("smart_collection"), Required]
    public CreateSmartCollection SmartCollection { get; set; } = null!;
}

public partial record CreateSmartCollection : SmartCollectionBase {}
public partial record UpdateSmartCollectionRequest
{
    [JsonPropertyName("smart_collection"), Required]
    public UpdateSmartCollection SmartCollection { get; set; } = null!;
}

public partial record UpdateSmartCollection : SmartCollection{}

		
public partial record SmartCollection : SmartCollectionBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record SmartCollectionBase : SmartCollectionOrig{}

	
public partial record CheckoutItem
{
    [JsonPropertyName("checkout"), Required]
    public Checkout Checkout { get; set; } = null!;
}

public partial record CheckoutList
{
    [JsonPropertyName("checkouts"), Required]
    public IEnumerable<Checkout> Checkouts { get; set; } = null!;
}
public partial record CreateCheckoutRequest
{
    [JsonPropertyName("checkout"), Required]
    public CreateCheckout Checkout { get; set; } = null!;
}

public partial record CreateCheckout : CheckoutBase {}
public partial record UpdateCheckoutRequest
{
    [JsonPropertyName("checkout"), Required]
    public UpdateCheckout Checkout { get; set; } = null!;
}

public partial record UpdateCheckout : Checkout{}

		
public partial record Checkout : CheckoutBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record CheckoutBase : CheckoutOrig{}

	
public partial record CollectionListingItem
{
    [JsonPropertyName("collection_listing"), Required]
    public CollectionListing CollectionListing { get; set; } = null!;
}

public partial record CollectionListingList
{
    [JsonPropertyName("collection_listings"), Required]
    public IEnumerable<CollectionListing> CollectionListings { get; set; } = null!;
}
public partial record CreateCollectionListingRequest
{
    [JsonPropertyName("collection_listing"), Required]
    public CreateCollectionListing CollectionListing { get; set; } = null!;
}

public partial record CreateCollectionListing : CollectionListingBase {}
public partial record UpdateCollectionListingRequest
{
    [JsonPropertyName("collection_listing"), Required]
    public UpdateCollectionListing CollectionListing { get; set; } = null!;
}

public partial record UpdateCollectionListing : CollectionListing{}

		
public partial record CollectionListing : CollectionListingBase
{
}

public partial record CollectionListingBase : CollectionListingOrig{}

	
public partial record MobilePlatformApplicationItem
{
    [JsonPropertyName("mobile_platform_application"), Required]
    public MobilePlatformApplication MobilePlatformApplication { get; set; } = null!;
}

public partial record MobilePlatformApplicationList
{
    [JsonPropertyName("mobile_platform_applications"), Required]
    public IEnumerable<MobilePlatformApplication> MobilePlatformApplications { get; set; } = null!;
}
public partial record CreateMobilePlatformApplicationRequest
{
    [JsonPropertyName("mobile_platform_application"), Required]
    public CreateMobilePlatformApplication MobilePlatformApplication { get; set; } = null!;
}

public partial record CreateMobilePlatformApplication : MobilePlatformApplicationBase {}
public partial record UpdateMobilePlatformApplicationRequest
{
    [JsonPropertyName("mobile_platform_application"), Required]
    public UpdateMobilePlatformApplication MobilePlatformApplication { get; set; } = null!;
}

public partial record UpdateMobilePlatformApplication : MobilePlatformApplication{}

		
public partial record MobilePlatformApplication : MobilePlatformApplicationBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record MobilePlatformApplicationBase : MobilePlatformApplicationOrig{}

	
public partial record PaymentItem
{
    [JsonPropertyName("payment"), Required]
    public Payment Payment { get; set; } = null!;
}

public partial record PaymentList
{
    [JsonPropertyName("payments"), Required]
    public IEnumerable<Payment> Payments { get; set; } = null!;
}
public partial record CreatePaymentRequest
{
    [JsonPropertyName("payment"), Required]
    public CreatePayment Payment { get; set; } = null!;
}

public partial record CreatePayment : PaymentBase {}
public partial record UpdatePaymentRequest
{
    [JsonPropertyName("payment"), Required]
    public UpdatePayment Payment { get; set; } = null!;
}

public partial record UpdatePayment : Payment{}

		
public partial record Payment : PaymentBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record PaymentBase : PaymentOrig{}

	
public partial record ProductResourceFeedbackItem
{
    [JsonPropertyName("product_resource_feedback"), Required]
    public ProductResourceFeedback ProductResourceFeedback { get; set; } = null!;
}

public partial record ProductResourceFeedbackList
{
    [JsonPropertyName("product_resource_feedbacks"), Required]
    public IEnumerable<ProductResourceFeedback> ProductResourceFeedbacks { get; set; } = null!;
}
public partial record CreateProductResourceFeedbackRequest
{
    [JsonPropertyName("product_resource_feedback"), Required]
    public CreateProductResourceFeedback ProductResourceFeedback { get; set; } = null!;
}

public partial record CreateProductResourceFeedback : ProductResourceFeedbackBase {}
public partial record UpdateProductResourceFeedbackRequest
{
    [JsonPropertyName("product_resource_feedback"), Required]
    public UpdateProductResourceFeedback ProductResourceFeedback { get; set; } = null!;
}

public partial record UpdateProductResourceFeedback : ProductResourceFeedback{}

		
public partial record ProductResourceFeedback : ProductResourceFeedbackBase
{
}

public partial record ProductResourceFeedbackBase : ProductResourceFeedbackOrig{}

	
public partial record ProductListingItem
{
    [JsonPropertyName("product_listing"), Required]
    public ProductListing ProductListing { get; set; } = null!;
}

public partial record ProductListingList
{
    [JsonPropertyName("product_listings"), Required]
    public IEnumerable<ProductListing> ProductListings { get; set; } = null!;
}
public partial record CreateProductListingRequest
{
    [JsonPropertyName("product_listing"), Required]
    public CreateProductListing ProductListing { get; set; } = null!;
}

public partial record CreateProductListing : ProductListingBase {}
public partial record UpdateProductListingRequest
{
    [JsonPropertyName("product_listing"), Required]
    public UpdateProductListing ProductListing { get; set; } = null!;
}

public partial record UpdateProductListing : ProductListing{}

		
public partial record ProductListing : ProductListingBase
{
}

public partial record ProductListingBase : ProductListingOrig{}

	
public partial record ResourceFeedbackItem
{
    [JsonPropertyName("resource_feedback"), Required]
    public ResourceFeedback ResourceFeedback { get; set; } = null!;
}

public partial record ResourceFeedbackList
{
    [JsonPropertyName("resource_feedbacks"), Required]
    public IEnumerable<ResourceFeedback> ResourceFeedbacks { get; set; } = null!;
}
public partial record CreateResourceFeedbackRequest
{
    [JsonPropertyName("resource_feedback"), Required]
    public CreateResourceFeedback ResourceFeedback { get; set; } = null!;
}

public partial record CreateResourceFeedback : ResourceFeedbackBase {}
public partial record UpdateResourceFeedbackRequest
{
    [JsonPropertyName("resource_feedback"), Required]
    public UpdateResourceFeedback ResourceFeedback { get; set; } = null!;
}

public partial record UpdateResourceFeedback : ResourceFeedback{}

		
public partial record ResourceFeedback : ResourceFeedbackBase
{
}

public partial record ResourceFeedbackBase : ResourceFeedbackOrig{}

	
public partial record AssignedFulfillmentOrderItem
{
    [JsonPropertyName("assigned_fulfillment_order"), Required]
    public FulfillmentOrder AssignedFulfillmentOrder { get; set; } = null!;
}

public partial record AssignedFulfillmentOrderList
{
    [JsonPropertyName("assigned_fulfillment_orders"), Required]
    public IEnumerable<FulfillmentOrder> AssignedFulfillmentOrders { get; set; } = null!;
}
public partial record CreateAssignedFulfillmentOrderRequest
{
    [JsonPropertyName("assigned_fulfillment_order"), Required]
    public CreateAssignedFulfillmentOrder AssignedFulfillmentOrder { get; set; } = null!;
}

public partial record CreateAssignedFulfillmentOrder : FulfillmentOrderBase {}
public partial record UpdateAssignedFulfillmentOrderRequest
{
    [JsonPropertyName("assigned_fulfillment_order"), Required]
    public UpdateAssignedFulfillmentOrder AssignedFulfillmentOrder { get; set; } = null!;
}

public partial record UpdateAssignedFulfillmentOrder : FulfillmentOrder{}

		
public partial record AssignedFulfillmentOrder : FulfillmentOrderBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record FulfillmentOrderBase : FulfillmentOrderOrig{}

	
public partial record CancellationRequestItem
{
    [JsonPropertyName("cancellation_request"), Required]
    public FulfillmentOrder CancellationRequest { get; set; } = null!;
}

public partial record CancellationRequestList
{
    [JsonPropertyName("cancellation_request"), Required]
    public IEnumerable<FulfillmentOrder> CancellationRequest { get; set; } = null!;
}
public partial record CreateCancellationRequestRequest
{
    [JsonPropertyName("cancellation_request"), Required]
    public CreateCancellationRequest CancellationRequest { get; set; } = null!;
}

public partial record CreateCancellationRequest : FulfillmentOrderBase {}
public partial record UpdateCancellationRequestRequest
{
    [JsonPropertyName("cancellation_request"), Required]
    public UpdateCancellationRequest CancellationRequest { get; set; } = null!;
}

public partial record UpdateCancellationRequest : FulfillmentOrder{}

		
public partial record CancellationRequest : FulfillmentOrderBase
{
}

public partial record FulfillmentOrderBase : FulfillmentOrderOrig{}

	
public partial record CarrierServiceItem
{
    [JsonPropertyName("carrier_service"), Required]
    public CarrierService CarrierService { get; set; } = null!;
}

public partial record CarrierServiceList
{
    [JsonPropertyName("carrier_services"), Required]
    public IEnumerable<CarrierService> CarrierServices { get; set; } = null!;
}
public partial record CreateCarrierServiceRequest
{
    [JsonPropertyName("carrier_service"), Required]
    public CreateCarrierService CarrierService { get; set; } = null!;
}

public partial record CreateCarrierService : CarrierServiceBase {}
public partial record UpdateCarrierServiceRequest
{
    [JsonPropertyName("carrier_service"), Required]
    public UpdateCarrierService CarrierService { get; set; } = null!;
}

public partial record UpdateCarrierService : CarrierService{}

		
public partial record CarrierService : CarrierServiceBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record CarrierServiceBase : CarrierServiceOrig{}

	
public partial record FulfillmentItem
{
    [JsonPropertyName("fulfillment"), Required]
    public Fulfillment Fulfillment { get; set; } = null!;
}

public partial record FulfillmentList
{
    [JsonPropertyName("fulfillments"), Required]
    public IEnumerable<Fulfillment> Fulfillments { get; set; } = null!;
}
public partial record CreateFulfillmentRequest
{
    [JsonPropertyName("fulfillment"), Required]
    public CreateFulfillment Fulfillment { get; set; } = null!;
}

public partial record CreateFulfillment : FulfillmentBase {}
public partial record UpdateFulfillmentRequest
{
    [JsonPropertyName("fulfillment"), Required]
    public UpdateFulfillment Fulfillment { get; set; } = null!;
}

public partial record UpdateFulfillment : Fulfillment{}

		
public partial record Fulfillment : FulfillmentBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record FulfillmentBase : FulfillmentOrig{}

	
public partial record FulfillmentEventItem
{
    [JsonPropertyName("fulfillment_event"), Required]
    public FulfillmentEvent FulfillmentEvent { get; set; } = null!;
}

public partial record FulfillmentEventList
{
    [JsonPropertyName("fulfillment_events"), Required]
    public IEnumerable<FulfillmentEvent> FulfillmentEvents { get; set; } = null!;
}
public partial record CreateFulfillmentEventRequest
{
    [JsonPropertyName("fulfillment_event"), Required]
    public CreateFulfillmentEvent FulfillmentEvent { get; set; } = null!;
}

public partial record CreateFulfillmentEvent : FulfillmentEventBase {}
public partial record UpdateFulfillmentEventRequest
{
    [JsonPropertyName("fulfillment_event"), Required]
    public UpdateFulfillmentEvent FulfillmentEvent { get; set; } = null!;
}

public partial record UpdateFulfillmentEvent : FulfillmentEvent{}

		
public partial record FulfillmentEvent : FulfillmentEventBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record FulfillmentEventBase : FulfillmentEventOrig{}

	
public partial record FulfillmentOrderItem
{
    [JsonPropertyName("fulfillment_order"), Required]
    public FulfillmentOrder FulfillmentOrder { get; set; } = null!;
}

public partial record FulfillmentOrderList
{
    [JsonPropertyName("fulfillment_orders"), Required]
    public IEnumerable<FulfillmentOrder> FulfillmentOrders { get; set; } = null!;
}
public partial record CreateFulfillmentOrderRequest
{
    [JsonPropertyName("fulfillment_order"), Required]
    public CreateFulfillmentOrder FulfillmentOrder { get; set; } = null!;
}

public partial record CreateFulfillmentOrder : FulfillmentOrderBase {}
public partial record UpdateFulfillmentOrderRequest
{
    [JsonPropertyName("fulfillment_order"), Required]
    public UpdateFulfillmentOrder FulfillmentOrder { get; set; } = null!;
}

public partial record UpdateFulfillmentOrder : FulfillmentOrder{}

		
public partial record FulfillmentOrder : FulfillmentOrderBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record FulfillmentOrderBase : FulfillmentOrderOrig{}

	
public partial record FulfillmentRequestItem
{
    [JsonPropertyName("fulfillment_request"), Required]
    public FulfillmentRequest FulfillmentRequest { get; set; } = null!;
}

public partial record FulfillmentRequestList
{
    [JsonPropertyName("fulfillment_requests"), Required]
    public IEnumerable<FulfillmentRequest> FulfillmentRequests { get; set; } = null!;
}
public partial record CreateFulfillmentRequestRequest
{
    [JsonPropertyName("fulfillment_request"), Required]
    public CreateFulfillmentRequest FulfillmentRequest { get; set; } = null!;
}

public partial record CreateFulfillmentRequest : FulfillmentRequestBase {}
public partial record UpdateFulfillmentRequestRequest
{
    [JsonPropertyName("fulfillment_request"), Required]
    public UpdateFulfillmentRequest FulfillmentRequest { get; set; } = null!;
}

public partial record UpdateFulfillmentRequest : FulfillmentRequest{}

		
public partial record FulfillmentRequest : FulfillmentRequestBase
{
}

public partial record FulfillmentRequestBase : FulfillmentRequestOrig{}

	
public partial record FulfillmentServiceItem
{
    [JsonPropertyName("fulfillment_service"), Required]
    public FulfillmentService FulfillmentService { get; set; } = null!;
}

public partial record FulfillmentServiceList
{
    [JsonPropertyName("fulfillment_services"), Required]
    public IEnumerable<FulfillmentService> FulfillmentServices { get; set; } = null!;
}
public partial record CreateFulfillmentServiceRequest
{
    [JsonPropertyName("fulfillment_service"), Required]
    public CreateFulfillmentService FulfillmentService { get; set; } = null!;
}

public partial record CreateFulfillmentService : FulfillmentServiceBase {}
public partial record UpdateFulfillmentServiceRequest
{
    [JsonPropertyName("fulfillment_service"), Required]
    public UpdateFulfillmentService FulfillmentService { get; set; } = null!;
}

public partial record UpdateFulfillmentService : FulfillmentService{}

		
public partial record FulfillmentService : FulfillmentServiceBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record FulfillmentServiceBase : FulfillmentServiceOrig{}

	
public partial record LocationsForMoveItem
{
    [JsonPropertyName("locations_for_move"), Required]
    public LocationsForMove LocationsForMove { get; set; } = null!;
}

public partial record LocationsForMoveList
{
    [JsonPropertyName("locations_for_moves"), Required]
    public IEnumerable<LocationsForMove> LocationsForMoves { get; set; } = null!;
}
public partial record CreateLocationsForMoveRequest
{
    [JsonPropertyName("locations_for_move"), Required]
    public CreateLocationsForMove LocationsForMove { get; set; } = null!;
}

public partial record CreateLocationsForMove : LocationsForMoveBase {}
public partial record UpdateLocationsForMoveRequest
{
    [JsonPropertyName("locations_for_move"), Required]
    public UpdateLocationsForMove LocationsForMove { get; set; } = null!;
}

public partial record UpdateLocationsForMove : LocationsForMove{}

		
public partial record LocationsForMove : LocationsForMoveBase
{
}

public partial record LocationsForMoveBase : LocationsForMoveOrig{}

	
public partial record BalanceItem
{
    [JsonPropertyName("balance"), Required]
    public Balance Balance { get; set; } = null!;
}

public partial record BalanceList
{
    [JsonPropertyName("balances"), Required]
    public IEnumerable<Balance> Balances { get; set; } = null!;
}
public partial record CreateBalanceRequest
{
    [JsonPropertyName("balance"), Required]
    public CreateBalance Balance { get; set; } = null!;
}

public partial record CreateBalance : BalanceBase {}
public partial record UpdateBalanceRequest
{
    [JsonPropertyName("balance"), Required]
    public UpdateBalance Balance { get; set; } = null!;
}

public partial record UpdateBalance : Balance{}

		
public partial record Balance : BalanceBase
{
}

public partial record BalanceBase : BalanceOrig{}

	
public partial record DisputeItem
{
    [JsonPropertyName("dispute"), Required]
    public Dispute Dispute { get; set; } = null!;
}

public partial record DisputeList
{
    [JsonPropertyName("disputes"), Required]
    public IEnumerable<Dispute> Disputes { get; set; } = null!;
}
public partial record CreateDisputeRequest
{
    [JsonPropertyName("dispute"), Required]
    public CreateDispute Dispute { get; set; } = null!;
}

public partial record CreateDispute : DisputeBase {}
public partial record UpdateDisputeRequest
{
    [JsonPropertyName("dispute"), Required]
    public UpdateDispute Dispute { get; set; } = null!;
}

public partial record UpdateDispute : Dispute{}

		
public partial record Dispute : DisputeBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record DisputeBase : DisputeOrig{}

	
public partial record PayoutItem
{
    [JsonPropertyName("payout"), Required]
    public Payout Payout { get; set; } = null!;
}

public partial record PayoutList
{
    [JsonPropertyName("payouts"), Required]
    public IEnumerable<Payout> Payouts { get; set; } = null!;
}
public partial record CreatePayoutRequest
{
    [JsonPropertyName("payout"), Required]
    public CreatePayout Payout { get; set; } = null!;
}

public partial record CreatePayout : PayoutsBase {}
public partial record UpdatePayoutRequest
{
    [JsonPropertyName("payout"), Required]
    public UpdatePayout Payout { get; set; } = null!;
}

public partial record UpdatePayout : Payout{}

		
public partial record Payout : PayoutsBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record PayoutsBase : PayoutsOrig{}

	
public partial record CountryItem
{
    [JsonPropertyName("country"), Required]
    public Country Country { get; set; } = null!;
}

public partial record CountryList
{
    [JsonPropertyName("countries"), Required]
    public IEnumerable<Country> Countries { get; set; } = null!;
}
public partial record CreateCountryRequest
{
    [JsonPropertyName("country"), Required]
    public CreateCountry Country { get; set; } = null!;
}

public partial record CreateCountry : CountryBase {}
public partial record UpdateCountryRequest
{
    [JsonPropertyName("country"), Required]
    public UpdateCountry Country { get; set; } = null!;
}

public partial record UpdateCountry : Country{}

		
public partial record Country : CountryBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record CountryBase : CountryOrig{}

	
public partial record CurrencyItem
{
    [JsonPropertyName("currency"), Required]
    public Currency Currency { get; set; } = null!;
}

public partial record CurrencyList
{
    [JsonPropertyName("currencies"), Required]
    public IEnumerable<Currency> Currencies { get; set; } = null!;
}
public partial record CreateCurrencyRequest
{
    [JsonPropertyName("currency"), Required]
    public CreateCurrency Currency { get; set; } = null!;
}

public partial record CreateCurrency : CurrencyBase {}
public partial record UpdateCurrencyRequest
{
    [JsonPropertyName("currency"), Required]
    public UpdateCurrency Currency { get; set; } = null!;
}

public partial record UpdateCurrency : Currency{}

		
public partial record Currency : CurrencyBase
{
}

public partial record CurrencyBase : CurrencyOrig{}

	
public partial record PolicyItem
{
    [JsonPropertyName("policy"), Required]
    public Policy Policy { get; set; } = null!;
}

public partial record PolicyList
{
    [JsonPropertyName("policies"), Required]
    public IEnumerable<Policy> Policies { get; set; } = null!;
}
public partial record CreatePolicyRequest
{
    [JsonPropertyName("policy"), Required]
    public CreatePolicy Policy { get; set; } = null!;
}

public partial record CreatePolicy : PolicyBase {}
public partial record UpdatePolicyRequest
{
    [JsonPropertyName("policy"), Required]
    public UpdatePolicy Policy { get; set; } = null!;
}

public partial record UpdatePolicy : Policy{}

		
public partial record Policy : PolicyBase
{
}

public partial record PolicyBase : PolicyOrig{}

	
public partial record ProvinceItem
{
    [JsonPropertyName("province"), Required]
    public Province Province { get; set; } = null!;
}

public partial record ProvinceList
{
    [JsonPropertyName("provinces"), Required]
    public IEnumerable<Province> Provinces { get; set; } = null!;
}
public partial record CreateProvinceRequest
{
    [JsonPropertyName("province"), Required]
    public CreateProvince Province { get; set; } = null!;
}

public partial record CreateProvince : ProvinceBase {}
public partial record UpdateProvinceRequest
{
    [JsonPropertyName("province"), Required]
    public UpdateProvince Province { get; set; } = null!;
}

public partial record UpdateProvince : Province{}

		
public partial record Province : ProvinceBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record ProvinceBase : ProvinceOrig{}

	
public partial record ShippingZoneItem
{
    [JsonPropertyName("shipping_zone"), Required]
    public ShippingZone ShippingZone { get; set; } = null!;
}

public partial record ShippingZoneList
{
    [JsonPropertyName("shipping_zones"), Required]
    public IEnumerable<ShippingZone> ShippingZones { get; set; } = null!;
}
public partial record CreateShippingZoneRequest
{
    [JsonPropertyName("shipping_zone"), Required]
    public CreateShippingZone ShippingZone { get; set; } = null!;
}

public partial record CreateShippingZone : ShippingZoneBase {}
public partial record UpdateShippingZoneRequest
{
    [JsonPropertyName("shipping_zone"), Required]
    public UpdateShippingZone ShippingZone { get; set; } = null!;
}

public partial record UpdateShippingZone : ShippingZone{}

		
public partial record ShippingZone : ShippingZoneBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record ShippingZoneBase : ShippingZoneOrig{}

	
public partial record ShopItem
{
    [JsonPropertyName("shop"), Required]
    public Shop Shop { get; set; } = null!;
}

public partial record ShopList
{
    [JsonPropertyName("shops"), Required]
    public IEnumerable<Shop> Shops { get; set; } = null!;
}
public partial record CreateShopRequest
{
    [JsonPropertyName("shop"), Required]
    public CreateShop Shop { get; set; } = null!;
}

public partial record CreateShop : ShopBase {}
public partial record UpdateShopRequest
{
    [JsonPropertyName("shop"), Required]
    public UpdateShop Shop { get; set; } = null!;
}

public partial record UpdateShop : Shop{}

		
public partial record Shop : ShopBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record ShopBase : ShopOrig{}

	
public partial record TenderTransactionItem
{
    [JsonPropertyName("tender_transaction"), Required]
    public TenderTransaction TenderTransaction { get; set; } = null!;
}

public partial record TenderTransactionList
{
    [JsonPropertyName("tender_transactions"), Required]
    public IEnumerable<TenderTransaction> TenderTransactions { get; set; } = null!;
}
public partial record CreateTenderTransactionRequest
{
    [JsonPropertyName("tender_transaction"), Required]
    public CreateTenderTransaction TenderTransaction { get; set; } = null!;
}

public partial record CreateTenderTransaction : TenderTransactionBase {}
public partial record UpdateTenderTransactionRequest
{
    [JsonPropertyName("tender_transaction"), Required]
    public UpdateTenderTransaction TenderTransaction { get; set; } = null!;
}

public partial record UpdateTenderTransaction : TenderTransaction{}

		
public partial record TenderTransaction : TenderTransactionBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record TenderTransactionBase : TenderTransactionOrig{}

	
public partial record DiscountCodeCreationItem
{
    [JsonPropertyName("discount_code_creation"), Required]
    public DiscountCodeCreation DiscountCodeCreation { get; set; } = null!;
}

public partial record DiscountCodeCreationList
{
    [JsonPropertyName("discount_code_creations"), Required]
    public IEnumerable<DiscountCodeCreation> DiscountCodeCreations { get; set; } = null!;
}
public partial record CreateDiscountCodeCreationRequest
{
    [JsonPropertyName("discount_code_creation"), Required]
    public CreateDiscountCodeCreation DiscountCodeCreation { get; set; } = null!;
}

public partial record CreateDiscountCodeCreation : DiscountCodeCreationBase {}
public partial record UpdateDiscountCodeCreationRequest
{
    [JsonPropertyName("discount_code_creation"), Required]
    public UpdateDiscountCodeCreation DiscountCodeCreation { get; set; } = null!;
}

public partial record UpdateDiscountCodeCreation : DiscountCodeCreation{}

		
public partial record DiscountCodeCreation : DiscountCodeCreationBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record DiscountCodeCreationBase : DiscountCodeCreationOrig{}

	
public partial record EngagementItem
{
    [JsonPropertyName("engagement"), Required]
    public Engagement Engagement { get; set; } = null!;
}

public partial record EngagementList
{
    [JsonPropertyName("engagements"), Required]
    public IEnumerable<Engagement> Engagements { get; set; } = null!;
}
public partial record CreateEngagementRequest
{
    [JsonPropertyName("engagement"), Required]
    public CreateEngagement Engagement { get; set; } = null!;
}

public partial record CreateEngagement : EngagementBase {}
public partial record UpdateEngagementRequest
{
    [JsonPropertyName("engagement"), Required]
    public UpdateEngagement Engagement { get; set; } = null!;
}

public partial record UpdateEngagement : Engagement{}

		
public partial record Engagement : EngagementBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record EngagementBase : EngagementOrig{}

	
public partial record CustomerInviteItem
{
    [JsonPropertyName("customer_invite"), Required]
    public CustomerInvite CustomerInvite { get; set; } = null!;
}

public partial record CustomerInviteList
{
    [JsonPropertyName("customer_invites"), Required]
    public IEnumerable<CustomerInvite> CustomerInvites { get; set; } = null!;
}
public partial record CreateCustomerInviteRequest
{
    [JsonPropertyName("customer_invite"), Required]
    public CreateCustomerInvite CustomerInvite { get; set; } = null!;
}

public partial record CreateCustomerInvite : CustomerInviteBase {}
public partial record UpdateCustomerInviteRequest
{
    [JsonPropertyName("customer_invite"), Required]
    public UpdateCustomerInvite CustomerInvite { get; set; } = null!;
}

public partial record UpdateCustomerInvite : CustomerInvite{}

		
public partial record CustomerInvite : CustomerInviteBase
{
    [JsonPropertyName("id"), Required]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

public partial record CustomerInviteBase : CustomerInviteOrig{}

	