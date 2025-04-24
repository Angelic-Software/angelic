using System.CodeDom.Compiler;
using Angelic.Agent;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class KBEntry
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("view_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? View_count { get; set; } 

        [JsonProperty("useful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Useful_count { get; set; } 

        [JsonProperty("notuseful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Notuseful_count { get; set; } 

        [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_created { get; set; } 

        [JsonProperty("date_edited", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_edited { get; set; } 

        [JsonProperty("tag_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tag_string { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("next_review_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Next_review_date { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("limit_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Limit_start_date { get; set; } 

        [JsonProperty("limit_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Limit_end_date { get; set; } 

        [JsonProperty("editor_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Editor_type { get; set; } 

        [JsonProperty("kb_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kb_tags { get; set; } 

        [JsonProperty("confluence_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Confluence_url { get; set; } 

        [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Search_score { get; set; } 

        [JsonProperty("resolution_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resolution_list { get; set; } 

        [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Link { get; set; } 

        [JsonProperty("geo_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<GeoLocationRestriction>? Geo_restrictions { get; set; } 

        [JsonProperty("resolution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resolution { get; set; } 

        [JsonProperty("creator_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Creator_id { get; set; } 

        [JsonProperty("creator_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Creator_name { get; set; } 

        [JsonProperty("editor_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Editor_id { get; set; } 

        [JsonProperty("editor_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Editor_name { get; set; } 

        [JsonProperty("xrefkbentry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xrefkbentry { get; set; } 

        [JsonProperty("xreftype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xreftype { get; set; } 

        [JsonProperty("xrefdoc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xrefdoc { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("description_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description_html { get; set; } 

        [JsonProperty("description_markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description_markdown { get; set; } 

        [JsonProperty("resolution_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resolution_html { get; set; } 

        [JsonProperty("resolution_markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resolution_markdown { get; set; } 

        [JsonProperty("internalmemoagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Internalmemoagent { get; set; } 

        [JsonProperty("internalmemoagenthtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Internalmemoagenthtml { get; set; } 

        [JsonProperty("internalmemomarkdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Internalmemomarkdown { get; set; } 

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tag>? Tags { get; set; } 

        [JsonProperty("faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FAQListHead>? Faqlists { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestTypeField>? Fields { get; set; } 

        [JsonProperty("teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SectionDetail>? Teams { get; set; } 

        [JsonProperty("your_vote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Your_vote { get; set; } 

        [JsonProperty("showforall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showforall { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AttachmentList>? Attachments { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("importfaqs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importfaqs { get; set; } 

        [JsonProperty("last_review_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_review_date { get; set; } 

        [JsonProperty("reviewed_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reviewed_by { get; set; } 

        [JsonProperty("reviewer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reviewer_name { get; set; } 

        [JsonProperty("_reviewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _reviewed { get; set; } 

        [JsonProperty("new_version_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_version_from_id { get; set; } 

        [JsonProperty("other_versions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KBEntry_List>? Other_versions { get; set; } 

        [JsonProperty("servicenow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_id { get; set; } 

        [JsonProperty("import_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Import_attachments { get; set; } 

        [JsonProperty("related_articles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KBEntry_List>? Related_articles { get; set; } 

        [JsonProperty("your_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Your_comment { get; set; } 

        [JsonProperty("freshdesk_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Freshdesk_id { get; set; } 

        [JsonProperty("freshdesk_folder_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Freshdesk_folder_name { get; set; } 

        [JsonProperty("freshdesk_category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Freshdesk_category_name { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _print_generate { get; set; } 

        [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Printhtml { get; set; } 

        [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdf_attachment_id { get; set; } 

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdftemplate_id { get; set; } 

        [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pdftemplate_name { get; set; } 

        [JsonProperty("kbentryclientaccess", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KbEntryAreaAccess>? Kbentryclientaccess { get; set; } 

        [JsonProperty("kbentrytoplevelaccess", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KbEntryTopLevelAccess>? Kbentrytoplevelaccess { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Devices { get; set; } 

        [JsonProperty("faq_write", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Faq_write { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Import_details_id { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? External_links { get; set; } 

        [JsonProperty("wordpress_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, WordpressComObject>? Wordpress_tags { get; set; } 

        [JsonProperty("wordpress_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, WordpressComObject>? Wordpress_categories { get; set; } 

        [JsonProperty("importtags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtags { get; set; } 

        [JsonProperty("owners", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentList>? Owners { get; set; } 

        [JsonProperty("search_index_sync_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Search_index_sync_timestamp { get; set; } 

        [JsonProperty("search_index_sync_batches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Search_index_sync_batches { get; set; } 

        [JsonProperty("kbpermalinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Permalinks>? Kbpermalinks { get; set; } 

        [JsonProperty("negativeFeedbackTicket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Faults? NegativeFeedbackTicket { get; set; } 

        [JsonProperty("generatetoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Generatetoken { get; set; } 

        [JsonProperty("latestversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Latestversion { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Key { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TableEnum? Table { get; set; } 

        [JsonProperty("ticket_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_template_id { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importthirdpartyid { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

    }