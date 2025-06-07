using System.CodeDom.Compiler;
using Angelic.Models.Assets;
using Angelic.Models.Attachments;
using Angelic.Models.Configuration;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.Integrations.Wordpress;
using Angelic.Models.Configuration.Language;
using Angelic.Models.Configuration.TeamsAndAgents;
using Angelic.Models.Configuration.TeamsAndAgents.Agents;
using Angelic.Models.Configuration.TeamsAndAgents.Teams;
using Angelic.Models.Configuration.Tickets.TicketTypes;
using Angelic.Models.ExternalLinks;
using Angelic.Models.Tickets;
using Newtonsoft.Json;

namespace Angelic.Models.KnowledgeBase;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class KbArticle
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("view_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ViewCount { get; set; } 

        [JsonProperty("useful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UsefulCount { get; set; } 

        [JsonProperty("notuseful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NotusefulCount { get; set; } 

        [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateCreated { get; set; } 

        [JsonProperty("date_edited", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateEdited { get; set; } 

        [JsonProperty("tag_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TagString { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("next_review_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NextReviewDate { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? CustomFields { get; set; } 

        [JsonProperty("limit_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LimitStartDate { get; set; } 

        [JsonProperty("limit_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LimitEndDate { get; set; } 

        [JsonProperty("editor_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EditorType { get; set; } 

        [JsonProperty("kb_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KbTags { get; set; } 

        [JsonProperty("confluence_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConfluenceUrl { get; set; } 

        [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SearchScore { get; set; } 

        [JsonProperty("resolution_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ResolutionList { get; set; } 

        [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Link { get; set; } 

        [JsonProperty("geo_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<GeoLocationRestriction>? GeoRestrictions { get; set; } 

        [JsonProperty("resolution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resolution { get; set; } 

        [JsonProperty("creator_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatorId { get; set; } 

        [JsonProperty("creator_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CreatorName { get; set; } 

        [JsonProperty("editor_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EditorId { get; set; } 

        [JsonProperty("editor_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EditorName { get; set; } 

        [JsonProperty("xrefkbentry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xrefkbentry { get; set; } 

        [JsonProperty("xreftype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xreftype { get; set; } 

        [JsonProperty("xrefdoc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xrefdoc { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketId { get; set; } 

        [JsonProperty("description_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DescriptionHtml { get; set; } 

        [JsonProperty("description_markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DescriptionMarkdown { get; set; } 

        [JsonProperty("resolution_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ResolutionHtml { get; set; } 

        [JsonProperty("resolution_markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ResolutionMarkdown { get; set; } 

        [JsonProperty("internalmemoagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Internalmemoagent { get; set; } 

        [JsonProperty("internalmemoagenthtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Internalmemoagenthtml { get; set; } 

        [JsonProperty("internalmemomarkdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Internalmemomarkdown { get; set; } 

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tag>? Tags { get; set; } 

        [JsonProperty("faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaqListHead>? FaqLists { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeField>? Fields { get; set; } 

        [JsonProperty("teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Team>? Teams { get; set; } 

        [JsonProperty("your_vote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? YourVote { get; set; } 

        [JsonProperty("showforall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowForAll { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AttachmentList>? Attachments { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsImport { get; set; } 

        [JsonProperty("importfaqs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importfaqs { get; set; } 

        [JsonProperty("last_review_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastReviewDate { get; set; } 

        [JsonProperty("reviewed_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReviewedBy { get; set; } 

        [JsonProperty("reviewer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReviewerName { get; set; } 

        [JsonProperty("_reviewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reviewed { get; set; } 

        [JsonProperty("new_version_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewVersionFromId { get; set; } 

        [JsonProperty("other_versions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KbArticleList>? OtherVersions { get; set; } 

        [JsonProperty("servicenow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceNowId { get; set; } 

        [JsonProperty("import_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? ImportAttachments { get; set; } 

        [JsonProperty("related_articles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KbArticleList>? RelatedArticles { get; set; } 

        [JsonProperty("your_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? YourComment { get; set; } 

        [JsonProperty("freshdesk_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FreshdeskId { get; set; } 

        [JsonProperty("freshdesk_folder_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FreshdeskFolderName { get; set; } 

        [JsonProperty("freshdesk_category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FreshdeskCategoryName { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrintGenerate { get; set; } 

        [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrintHtml { get; set; } 

        [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PdfAttachmentId { get; set; } 

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PdfTemplateId { get; set; } 

        [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PdfTemplateName { get; set; } 

        [JsonProperty("kbentryclientaccess", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KbArticleAreaAccess>? KbEntryclientaccess { get; set; } 

        [JsonProperty("kbentrytoplevelaccess", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KbArticleTopLevelAccess>? KbEntrytoplevelaccess { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetList>? Devices { get; set; } 

        [JsonProperty("faq_write", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FaqWrite { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink? NewExternalLink { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchThirdPartyId { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MatchIntegrationId { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchIntegrationName { get; set; } 

        [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ImportDetailsId { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? ExternalLinks { get; set; } 

        [JsonProperty("wordpress_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, WordpressComObject>? WordpressTags { get; set; } 

        [JsonProperty("wordpress_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, WordpressComObject>? WordpressCategories { get; set; } 

        [JsonProperty("importtags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportTags { get; set; } 

        [JsonProperty("owners", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentList>? Owners { get; set; } 

        [JsonProperty("search_index_sync_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SearchIndexSyncTimestamp { get; set; } 

        [JsonProperty("search_index_sync_batches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SearchIndexSyncBatches { get; set; } 

        [JsonProperty("kbpermalinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Permalinks>? Kbpermalinks { get; set; } 

        [JsonProperty("negativeFeedbackTicket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Ticket? NegativeFeedbackTicket { get; set; } 

        [JsonProperty("generatetoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Generatetoken { get; set; } 

        [JsonProperty("latestversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Latestversion { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Key { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Table { get; set; } 

        [JsonProperty("ticket_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketTemplateId { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ImportTypeId { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportThirdPartyId { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportType { get; set; } 

    }