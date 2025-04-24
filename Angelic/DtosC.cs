using System.CodeDom.Compiler;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;


    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CspCustomer
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("companyProfile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CspCustomerProfile? CompanyProfile { get; set; } 

        [JsonProperty("relationshipToPartner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RelationshipToPartner { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CspCustomerProfile
    {
        [JsonProperty("tenantId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TenantId { get; set; } 

        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domain { get; set; } 

        [JsonProperty("companyName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CompanyName { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CsvTemplate
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("groupingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Groupingtype { get; set; } 

        [JsonProperty("detailcolumns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CsvTemplateDetail>? Detailcolumns { get; set; } 

        [JsonProperty("is_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPreview { get; set; } 

        [JsonProperty("is_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsGenerate { get; set; } 

        [JsonProperty("printcsv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Printcsv { get; set; } 

        [JsonProperty("invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceHeader>? Invoices { get; set; } 

        [JsonProperty("csv_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CsvAttachmentId { get; set; } 

        [JsonProperty("csv_attachment_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CsvAttachmentName { get; set; } 

        [JsonProperty("update_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdatePosted { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("background_task", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? BackgroundTask { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CsvTemplateDetail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("csvtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Csvtid { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("systemuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Systemuse { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Content { get; set; } 

        [JsonProperty("default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CabHeader
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("all_must_approve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllMustApprove { get; set; } 

        [JsonProperty("approvals_needed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ApprovalsNeeded { get; set; } 

        [JsonProperty("rejection_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RejectionThreshold { get; set; } 

        [JsonProperty("members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CabMember>? Members { get; set; } 

        [JsonProperty("ldapstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ldapstring { get; set; } 

        [JsonProperty("roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CabRole>? Roles { get; set; } 

        [JsonProperty("teams_webhook_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsWebhookUrl { get; set; } 

        [JsonProperty("slack_channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlackChannel { get; set; } 

        [JsonProperty("slack_channel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlackChannelName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CabMember
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CabId { get; set; } 

        [JsonProperty("cab_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? CabGuid { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentId { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; } 

        [JsonProperty("member_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MemberName { get; set; } 

        [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailaddress { get; set; } 

        [JsonProperty("is_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMandatory { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RoleId { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RoleName { get; set; } 

        [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ModuleId { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CabRole
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CabId { get; set; } 

        [JsonProperty("cab_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? CabGuid { get; set; } 

        [JsonProperty("mandatory_approvers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MandatoryApprovers { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("mandatory_rejecters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MandatoryRejecters { get; set; } 

        [JsonProperty("mandatory_voters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MandatoryVoters { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CallLog
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; } 

        [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Timetaken { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentId { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientName { get; set; } 

        [JsonProperty("client_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Area? ClientDetails { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SiteName { get; set; } 

        [JsonProperty("site_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Site? SiteDetails { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserName { get; set; } 

        [JsonProperty("user_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Users? UserDetails { get; set; } 

        [JsonProperty("callerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Callerid { get; set; } 

        [JsonProperty("diallednumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Diallednumber { get; set; } 

        [JsonProperty("caller_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CallerName { get; set; } 

        [JsonProperty("caller_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CallerEmail { get; set; } 

        [JsonProperty("user_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserNumber { get; set; } 

        [JsonProperty("caller_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? CallerAddress { get; set; } 

        [JsonProperty("outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OutcomeId { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketId { get; set; } 

        [JsonProperty("action_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionNumber { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("call_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CallStatus { get; set; } 

        [JsonProperty("_complete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Complete { get; set; } 

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canupdate { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyId { get; set; } 

        [JsonProperty("start_date_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StartDateNote { get; set; } 

        [JsonProperty("form_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FormId { get; set; } 

        [JsonProperty("update_user_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateUserNumber { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("displayname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Displayname { get; set; } 

        [JsonProperty("existingticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Existingticketid { get; set; } 

        [JsonProperty("call_direction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CallDirection { get; set; } 

        [JsonProperty("call_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CallType { get; set; } 

        [JsonProperty("call_transcript", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CallTranscript { get; set; } 

        [JsonProperty("calllog_attachment_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CalllogAttachmentCount { get; set; } 

        [JsonProperty("transferred_agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TransferredAgentid { get; set; } 

        [JsonProperty("transferred_teamid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TransferredTeamid { get; set; } 

        [JsonProperty("call_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CallCategory { get; set; } 

        [JsonProperty("transferred_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TransferredTeamName { get; set; } 

        [JsonProperty("category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category1 { get; set; } 

        [JsonProperty("category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category2 { get; set; } 

        [JsonProperty("category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category3 { get; set; } 

        [JsonProperty("category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category4 { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CannedText
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupId { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Html { get; set; } 

        [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RestrictionType { get; set; } 

        [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DepartmentId { get; set; } 

        [JsonProperty("department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DepartmentGuid { get; set; } 

        [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DepartmentName { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamId { get; set; } 

        [JsonProperty("team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TeamGuid { get; set; } 

        [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamName { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentId { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AgentName { get; set; } 

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canupdate { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AccessControl { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessControlLevel { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimport { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GroupName { get; set; } 

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tag>? Tags { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CategoryDetail
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CategoryName { get; set; } 

        [JsonProperty("type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TypeId { get; set; } 

        [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlaId { get; set; } 

        [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PriorityId { get; set; } 

        [JsonProperty("chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chargerate { get; set; } 

        [JsonProperty("category_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryGroupId { get; set; } 

        [JsonProperty("_isnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isnew { get; set; } 

        [JsonProperty("include_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeNote { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("user_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserNote { get; set; } 

        [JsonProperty("itilrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itilrequesttype { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("is_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIntegration { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CategoryRestriction
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TickettypeId { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamId { get; set; } 

        [JsonProperty("team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TeamGuid { get; set; } 

        [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceId { get; set; } 

        [JsonProperty("category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId { get; set; } 

        [JsonProperty("category_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? CategoryGuid { get; set; } 

        [JsonProperty("category_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CategoryValue { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("partial_match_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PartialMatchCategory { get; set; } 

        [JsonProperty("category_name_partial", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CategoryNamePartial { get; set; } 

        [JsonProperty("is_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIntegration { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Certificate
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("issuer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Issuer { get; set; } 

        [JsonProperty("thumbprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thumbprint { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewPassword { get; set; } 

        [JsonProperty("attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachmentId { get; set; } 

        [JsonProperty("attachment_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AttachmentName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ChangeType
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

        _3 = 3,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ChargeRate
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Area { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractId { get; set; } 

        [JsonProperty("charge_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargeId { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("expirydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Expirydate { get; set; } 

        [JsonProperty("rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Rate { get; set; } 

        [JsonProperty("org", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Org { get; set; } 

        [JsonProperty("minimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Minimum { get; set; } 

        [JsonProperty("increment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Increment { get; set; } 

        [JsonProperty("oohmultiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Oohmultiplier { get; set; } 

        [JsonProperty("holidaymultiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Holidaymultiplier { get; set; } 

        [JsonProperty("weekendmultiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Weekendmultiplier { get; set; } 

        [JsonProperty("surcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Surcharge { get; set; } 

        [JsonProperty("round", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Round { get; set; } 

        [JsonProperty("useagentworkinghours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useagentworkinghours { get; set; } 

        [JsonProperty("use_budget_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseBudgetRate { get; set; } 

        [JsonProperty("current", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Current { get; set; } 

        [JsonProperty("current_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CurrentRate { get; set; } 

        [JsonProperty("use_for_travel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseForTravel { get; set; } 

        [JsonProperty("use_for_mileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseForMileage { get; set; } 

        [JsonProperty("travel_surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TravelSurchargeid { get; set; } 

        [JsonProperty("contractmultiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Contractmultiplier { get; set; } 

        [JsonProperty("rateoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Rateoverride { get; set; } 

        [JsonProperty("override_surcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OverrideSurcharge { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ChargeRateArea
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Area { get; set; } 

        [JsonProperty("chargerate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargerateId { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ChatFlowProcess
    {
        [JsonProperty("chat_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChatId { get; set; } 

        [JsonProperty("chat_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChatProfileId { get; set; } 

        [JsonProperty("flow_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FlowStep { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ChatInputField
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("lookup_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? LookupValues { get; set; } 

        [JsonProperty("input_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ChatInputSuggestionUi>? InputSuggestions { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ChatInputSuggestion
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("flowdetail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FlowdetailId { get; set; } 

        [JsonProperty("suggestion_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SuggestionText { get; set; } 

        [JsonProperty("message_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MessageText { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ChatInputSuggestionUi
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("suggestion_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SuggestionText { get; set; } 

        [JsonProperty("message_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MessageText { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ChatPopupMessage
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("chat_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChatProfileId { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ChatProfile
    {
        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key { get; set; } 

        [JsonProperty("access_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessType { get; set; } 

        [JsonProperty("chatnameoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Chatnameoverride { get; set; } 

        [JsonProperty("greeting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Greeting { get; set; } 

        [JsonProperty("bot_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BotName { get; set; } 

        [JsonProperty("technamevisibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technamevisibility { get; set; } 

        [JsonProperty("technamevisibilitytext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Technamevisibilitytext { get; set; } 

        [JsonProperty("techmustonline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Techmustonline { get; set; } 

        [JsonProperty("workdays_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkdaysId { get; set; } 

        [JsonProperty("workdays_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkdaysName { get; set; } 

        [JsonProperty("logticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logticket { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TickettypeId { get; set; } 

        [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TickettypeName { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("icon_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IconSize { get; set; } 

        [JsonProperty("colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ColourType { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Theme { get; set; } 

        [JsonProperty("enable_feedback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableFeedback { get; set; } 

        [JsonProperty("feedback_message_before", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FeedbackMessageBefore { get; set; } 

        [JsonProperty("feedback_message_after", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FeedbackMessageAfter { get; set; } 

        [JsonProperty("cors_whitelist_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? CorsWhitelistList { get; set; } 

        [JsonProperty("steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FlowDetail>? Steps { get; set; } 

        [JsonProperty("flow_chart_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FlowChartJson { get; set; } 

        [JsonProperty("in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? InUse { get; set; } 

        [JsonProperty("_chat_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChatAvailable { get; set; } 

        [JsonProperty("_chat_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChatMode { get; set; } 

        [JsonProperty("_chatserviceurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Chatserviceurl { get; set; } 

        [JsonProperty("_tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenantid { get; set; } 

        [JsonProperty("bubble_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BubbleType { get; set; } 

        [JsonProperty("message_box_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MessageBoxSize { get; set; } 

        [JsonProperty("use_bubble_popup_message_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseBubblePopupMessageMappings { get; set; } 

        [JsonProperty("popup_message_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ChatPopupMessage>? PopupMessageMappings { get; set; } 

        [JsonProperty("default_ticket_clientsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultTicketClientsite { get; set; } 

        [JsonProperty("default_ticket_clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultTicketClientsiteName { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AccessControl { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessControlLevel { get; set; } 

        [JsonProperty("email_storage_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailStorageKey { get; set; } 

        [JsonProperty("name_storage_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NameStorageKey { get; set; } 

        [JsonProperty("fullscreen_threshold_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FullscreenThresholdOverride { get; set; } 

        [JsonProperty("bot_width_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BotWidthOverride { get; set; } 

        [JsonProperty("bot_height_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BotHeightOverride { get; set; } 

        [JsonProperty("bot_height_units", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BotHeightUnits { get; set; } 

        [JsonProperty("textcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Textcolour { get; set; } 

        [JsonProperty("textcolour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TextcolourType { get; set; } 

        [JsonProperty("agent_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<NHD_Roles>? AgentRoles { get; set; } 

        [JsonProperty("enable_start_message_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableStartMessageMapping { get; set; } 

        [JsonProperty("new_chat_window_controls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewChatWindowControls { get; set; } 

        [JsonProperty("abandoned_live_chat_check_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AbandonedLiveChatCheckPeriod { get; set; } 

        [JsonProperty("start_message_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ChatStartMessage>? StartMessageMappings { get; set; } 

        [JsonProperty("default_wait_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DefaultWaitTime { get; set; } 

        [JsonProperty("wait_time_calc_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WaitTimeCalcMins { get; set; } 

        [JsonProperty("anon_token_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AnonTokenMethod { get; set; } 

        [JsonProperty("enable_user_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableUserMatching { get; set; } 

        [JsonProperty("new_hmac_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewHmacSecret { get; set; } 

        [JsonProperty("validate_lifetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateLifetime { get; set; } 

        [JsonProperty("use_subject_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSubjectMatching { get; set; } 

        [JsonProperty("new_user_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewUserSiteId { get; set; } 

        [JsonProperty("new_user_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewUserSiteName { get; set; } 

        [JsonProperty("usermappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Usermappings { get; set; } 

        [JsonProperty("enable_feedback_comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableFeedbackComments { get; set; } 

        [JsonProperty("feedback_message_before_comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FeedbackMessageBeforeComments { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ChatStartMessage
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("chat_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChatProfileId { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("flowstep_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FlowstepId { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ChatStepQuestion
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("flowdetail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FlowdetailId { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("question", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Question { get; set; } 

        [JsonProperty("answer_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AnswerFieldId { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ChildRequestType
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TickettypeId { get; set; } 

        [JsonProperty("child_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildTickettypeId { get; set; } 

        [JsonProperty("child_tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChildTickettypeName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Company
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("toplevel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ToplevelId { get; set; } 

        [JsonProperty("toplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ToplevelName { get; set; } 

        [JsonProperty("contact_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContactName { get; set; } 

        [JsonProperty("email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailAddress { get; set; } 

        [JsonProperty("support_email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SupportEmailAddress { get; set; } 

        [JsonProperty("phone_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("emailtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EmailtemplateId { get; set; } 

        [JsonProperty("default_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultContractId { get; set; } 

        [JsonProperty("default_contract_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultContractSlaId { get; set; } 

        [JsonProperty("thirdpartynhdapiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartynhdapiurl { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("contract_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractCount { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datecreated { get; set; } 

        [JsonProperty("phone_number_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PhoneNumber2 { get; set; } 

        [JsonProperty("phone_number_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PhoneNumber3 { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address { get; set; } 

        [JsonProperty("switchslatosupplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Switchslatosupplier { get; set; } 

        [JsonProperty("emailoverduefixby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emailoverduefixby { get; set; } 

        [JsonProperty("emailoverdueresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emailoverdueresponse { get; set; } 

        [JsonProperty("webserviceurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webserviceurl { get; set; } 

        [JsonProperty("emailtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailtemplateName { get; set; } 

        [JsonProperty("accounts_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AccountsId { get; set; } 

        [JsonProperty("portal_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PortalUrl { get; set; } 

        [JsonProperty("portal_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PortalRef { get; set; } 

        [JsonProperty("portal_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PortalUsername { get; set; } 

        [JsonProperty("portal_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PortalPassword { get; set; } 

        [JsonProperty("contact_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContactTitle { get; set; } 

        [JsonProperty("fax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fax { get; set; } 

        [JsonProperty("email_start_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailStartTag { get; set; } 

        [JsonProperty("email_end_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailEndTag { get; set; } 

        [JsonProperty("usesnhd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usesnhd { get; set; } 

        [JsonProperty("nhdurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nhdurl { get; set; } 

        [JsonProperty("nhdemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nhdemailaddress { get; set; } 

        [JsonProperty("nhdpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nhdpassword { get; set; } 

        [JsonProperty("parentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parentid { get; set; } 

        [JsonProperty("emaildomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emaildomain { get; set; } 

        [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UsersList>? Users { get; set; } 

        [JsonProperty("allow_api_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowApiAccess { get; set; } 

        [JsonProperty("api_access_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApiAccessClientid { get; set; } 

        [JsonProperty("api_access_clientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApiAccessClientsecret { get; set; } 

        [JsonProperty("thirdpartynhdauthurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartynhdauthurl { get; set; } 

        [JsonProperty("thirdpartynhdtenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartynhdtenant { get; set; } 

        [JsonProperty("thirdpartynhdapiclientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartynhdapiclientid { get; set; } 

        [JsonProperty("new_thirdpartynhdapiclientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewThirdpartynhdapiclientsecret { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtype { get; set; } 

        [JsonProperty("kashflowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kashflowid { get; set; } 

        [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DetailsId { get; set; } 

        [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KashflowTenantId { get; set; } 

        [JsonProperty("kashflow_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KashflowTenantName { get; set; } 

        [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroTenantId { get; set; } 

        [JsonProperty("xero_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroTenantName { get; set; } 

        [JsonProperty("xero_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroId { get; set; } 

        [JsonProperty("is_xero_archived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsXeroArchived { get; set; } 

        [JsonProperty("qbo_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboCompanyName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("issupplierdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Issupplierdetails { get; set; } 

        [JsonProperty("jira_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JiraUrl { get; set; } 

        [JsonProperty("jira_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JiraUsername { get; set; } 

        [JsonProperty("new_jirakey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewJirakey { get; set; } 

        [JsonProperty("test_jira", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TestJira { get; set; } 

        [JsonProperty("jira_servicedesk_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JiraServicedeskId { get; set; } 

        [JsonProperty("jira_servicedesk_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JiraServicedeskName { get; set; } 

        [JsonProperty("jira_servicedesk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? JiraServicedesk { get; set; } 

        [JsonProperty("jira_requesttype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? JiraRequesttypeMappings { get; set; } 

        [JsonProperty("jira_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JiraUserId { get; set; } 

        [JsonProperty("jira_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JiraUserName { get; set; } 

        [JsonProperty("jira_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? JiraUser { get; set; } 

        [JsonProperty("jira_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? JiraPriorityMappings { get; set; } 

        [JsonProperty("jira_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? JiraStatusMappings { get; set; } 

        [JsonProperty("create_jira_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateJiraWebhook { get; set; } 

        [JsonProperty("jira_webhook_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? JiraWebhookCreated { get; set; } 

        [JsonProperty("synced_to_intacct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncedToIntacct { get; set; } 

        [JsonProperty("intacct_location_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctLocationId { get; set; } 

        [JsonProperty("intacct_location_id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? IntacctLocationIdList { get; set; } 

        [JsonProperty("intacct_location_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctLocationType { get; set; } 

        [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctSaveLocation { get; set; } 

        [JsonProperty("default_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultCurrencyCodeName { get; set; } 

        [JsonProperty("ignore_from_accounting_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreFromAccountingSync { get; set; } 

        [JsonProperty("intacct_default_save_loc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctDefaultSaveLoc { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AccessControl { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessControlLevel { get; set; } 

        [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewIcon { get; set; } 

        [JsonProperty("servicenow_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowUrl { get; set; } 

        [JsonProperty("servicenow_locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowLocale { get; set; } 

        [JsonProperty("servicenow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowUsername { get; set; } 

        [JsonProperty("new_servicenowkey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewServicenowkey { get; set; } 

        [JsonProperty("servicenow_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowPriorityMappings { get; set; } 

        [JsonProperty("servicenow_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowStatusMappings { get; set; } 

        [JsonProperty("servicenow_impact_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowImpactMappings { get; set; } 

        [JsonProperty("servicenow_urgency_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowUrgencyMappings { get; set; } 

        [JsonProperty("servicenow_category_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowCategoryMappings { get; set; } 

        [JsonProperty("servicenow_assignment_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowAssignmentGroup { get; set; } 

        [JsonProperty("servicenow_assignment_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowAssignmentGroupName { get; set; } 

        [JsonProperty("servicenow_assignmentgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? ServicenowAssignmentgroup { get; set; } 

        [JsonProperty("servicenow_defaultuser_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowDefaultuserId { get; set; } 

        [JsonProperty("servicenow_defaultuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowDefaultuserName { get; set; } 

        [JsonProperty("servicenow_defaultuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? ServicenowDefaultuser { get; set; } 

        [JsonProperty("test_servicenow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TestServicenow { get; set; } 

        [JsonProperty("myob_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MyobTenant { get; set; } 

        [JsonProperty("myob_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MyobTenantName { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? ExternalLinks { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? NewExternalLink { get; set; } 

        [JsonProperty("purchase_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PurchaseTaxCode { get; set; } 

        [JsonProperty("purchase_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PurchaseTaxCodeName { get; set; } 

        [JsonProperty("sync_servicenow_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SyncServicenowAttachments { get; set; } 

        [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModified { get; set; } 

        [JsonProperty("servicenow_team_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowTeamMappings { get; set; } 

        [JsonProperty("servicenow_ticket_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowTicketSync { get; set; } 

        [JsonProperty("servicenow_ticket_sync_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? ServicenowTicketSyncList { get; set; } 

        [JsonProperty("servicenow_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowFieldmappings { get; set; } 

        [JsonProperty("jira_webhook_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? JiraWebhookUser { get; set; } 

        [JsonProperty("jira_webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JiraWebhookUsername { get; set; } 

        [JsonProperty("supplier_invoice_due_date_extra_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierInvoiceDueDateExtraDays { get; set; } 

        [JsonProperty("is_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupplier { get; set; } 

        [JsonProperty("is_manufacturer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsManufacturer { get; set; } 

        [JsonProperty("servicenow_authtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServicenowAuthtype { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logo { get; set; } 

        [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboCompanyId { get; set; } 

        [JsonProperty("jira_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? JiraValidated { get; set; } 

        [JsonProperty("default_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultCurrencyCode { get; set; } 

        [JsonProperty("supplier_mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierMailboxOverride { get; set; } 

        [JsonProperty("supplier_mailbox_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SupplierMailboxAddress { get; set; } 

        [JsonProperty("servicenow_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ServicenowValidated { get; set; } 

        [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MessagegroupId { get; set; } 

        [JsonProperty("website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Website { get; set; } 

        [JsonProperty("mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mobile { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ConfigCommit
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; } 

        [JsonProperty("source_instance_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceInstanceId { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentId { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("object_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ObjectGuid { get; set; } 

        [JsonProperty("operation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Operation { get; set; } 

        [JsonProperty("payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Payload { get; set; } 

        [JsonProperty("rollback_operation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RollbackOperation { get; set; } 

        [JsonProperty("rollback_payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RollbackPayload { get; set; } 

        [JsonProperty("rolled_back", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RolledBack { get; set; } 

        [JsonProperty("rolled_back_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RolledBackTimestamp { get; set; } 

        [JsonProperty("rolled_back_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RolledBackAgentId { get; set; } 

        [JsonProperty("is_merge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMerge { get; set; } 

        [JsonProperty("original_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OriginalJson { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("_rollback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rollback { get; set; } 

        [JsonProperty("_push_to_instance_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PushToInstanceId { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ConfirmClosure
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketId { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key { get; set; } 

        [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Result { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment { get; set; } 

        [JsonProperty("user_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserMessage { get; set; } 

        [JsonProperty("withfeedback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Withfeedback { get; set; } 

        [JsonProperty("feedbackhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Feedbackhtml { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ConfluenceDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("newmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newmethod { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewPassword { get; set; } 

        [JsonProperty("faq_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? FaqLinks { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ConfluenceWebhookEndpoint
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Events { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Filters { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("self", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Self { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ConnectedInstance
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("apiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Apiurl { get; set; } 

        [JsonProperty("authurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Authurl { get; set; } 

        [JsonProperty("tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenant { get; set; } 

        [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clientid { get; set; } 

        [JsonProperty("new_clientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewClientsecret { get; set; } 

        [JsonProperty("_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Test { get; set; } 

        [JsonProperty("_test_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TestOk { get; set; } 

        [JsonProperty("_test_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? TestResult { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ConsignmentDetail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("consignment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConsignmentId { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemId { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity { get; set; } 

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InvoiceId { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesorderId { get; set; } 

        [JsonProperty("salesorder_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesorderLine { get; set; } 

        [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StocklocationId { get; set; } 

        [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Costprice { get; set; } 

        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; } 

        [JsonProperty("itemstock_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemstockId { get; set; } 

        [JsonProperty("item_assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemAssettypeId { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierId { get; set; } 

        [JsonProperty("stockadjustedamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Stockadjustedamount { get; set; } 

        [JsonProperty("serialised_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? SerialisedAssets { get; set; } 

        [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StockbinId { get; set; } 

        [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SerialiseOnlyOne { get; set; } 

        [JsonProperty("is_return", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReturn { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("item_internalreference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemInternalreference { get; set; } 

        [JsonProperty("item_externalreference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemExternalreference { get; set; } 

        [JsonProperty("item_supplier_part_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemSupplierPartCode { get; set; } 

        [JsonProperty("item_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemDescription { get; set; } 

        [JsonProperty("item_purchase_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemPurchaseDescription { get; set; } 

        [JsonProperty("item_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemLocation { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ConsignmentHeader
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketId { get; set; } 

        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserName { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesorderId { get; set; } 

        [JsonProperty("lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ConsignmentDetail>? Lines { get; set; } 

        [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Assets { get; set; } 

        [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrintGenerate { get; set; } 

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PdftemplateId { get; set; } 

        [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Printhtml { get; set; } 

        [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PdfAttachmentId { get; set; } 

        [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StockbinId { get; set; } 

        [JsonProperty("assettomoveback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettomoveback { get; set; } 

        [JsonProperty("ignoreserialisation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignoreserialisation { get; set; } 

        [JsonProperty("is_return", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReturn { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Contactgroup
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("ownerunum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ownerunum { get; set; } 

        [JsonProperty("allowall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall { get; set; } 

        [JsonProperty("allowalledit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowalledit { get; set; } 

        [JsonProperty("contactgroupcontacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Contactgroupcontacts>? Contactgroupcontacts { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Contactgroupcontacts
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ccgid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ccgid { get; set; } 

        [JsonProperty("cuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cuid { get; set; } 

        [JsonProperty("cunum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cunum { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailaddress { get; set; } 

        [JsonProperty("contacttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contacttype { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContentDisposition
    {
        [JsonProperty("disposition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Disposition { get; set; } 

        [JsonProperty("isAttachment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAttachment { get; set; } 

        [JsonProperty("parameters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Parameter>? Parameters { get; set; } 

        [JsonProperty("fileName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FileName { get; set; } 

        [JsonProperty("creationDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreationDate { get; set; } 

        [JsonProperty("modificationDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ModificationDate { get; set; } 

        [JsonProperty("readDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ReadDate { get; set; } 

        [JsonProperty("size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContentType
    {
        [JsonProperty("mediaType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MediaType { get; set; } 

        [JsonProperty("mediaSubtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MediaSubtype { get; set; } 

        [JsonProperty("parameters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Parameter>? Parameters { get; set; } 

        [JsonProperty("boundary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Boundary { get; set; } 

        [JsonProperty("charset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Charset { get; set; } 

        [JsonProperty("charsetEncoding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Encoding? CharsetEncoding { get; set; } 

        [JsonProperty("format", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Format { get; set; } 

        [JsonProperty("mimeType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MimeType { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Contract
    {
        [JsonProperty("started", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Started { get; set; } 

        [JsonProperty("expired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expired { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ref { get; set; } 

        [JsonProperty("contract_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContractDescription { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierId { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SupplierName { get; set; } 

        [JsonProperty("contact_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contact1 { get; set; } 

        [JsonProperty("contact_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contact2 { get; set; } 

        [JsonProperty("contact_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contact3 { get; set; } 

        [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlaId { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; } 

        [JsonProperty("dontsendalarm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontsendalarm { get; set; } 

        [JsonProperty("costing_information", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CostingInformation { get; set; } 

        [JsonProperty("is_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; } 

        [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Assets { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimport { get; set; } 

        [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlaName { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("iscontractdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iscontractdetails { get; set; } 

        [JsonProperty("contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractHeaderContract>? Contracts { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AccessControl { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessControlLevel { get; set; } 

        [JsonProperty("configuration_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? ConfigurationItems { get; set; } 

        [JsonProperty("add_configuration_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? AddConfigurationItems { get; set; } 

        [JsonProperty("renewedfrom_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RenewedfromId { get; set; } 

        [JsonProperty("renewedfrom_id_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RenewedfromIdRef { get; set; } 

        [JsonProperty("renewedby_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RenewedbyId { get; set; } 

        [JsonProperty("renewedby_id_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RenewedbyIdRef { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContractApproval
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Token { get; set; } 

        [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Result { get; set; } 

        [JsonProperty("approvername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvername { get; set; } 

        [JsonProperty("approveremailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approveremailaddress { get; set; } 

        [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Signature { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContractDetail
    {
        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("itil_requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItilRequesttype { get; set; } 

        [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requesttype { get; set; } 

        [JsonProperty("requesttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RequesttypeName { get; set; } 

        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; } 

        [JsonProperty("chargerate_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargerateType { get; set; } 

        [JsonProperty("chargerate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargerateId { get; set; } 

        [JsonProperty("chargerate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChargerateName { get; set; } 

        [JsonProperty("multiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Multiplier { get; set; } 

        [JsonProperty("plan_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PlanId { get; set; } 

        [JsonProperty("plan_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PlanContractId { get; set; } 

        [JsonProperty("plan_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PlanName { get; set; } 

        [JsonProperty("category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category1 { get; set; } 

        [JsonProperty("partialmatchcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partialmatchcategory { get; set; } 

        [JsonProperty("category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category2 { get; set; } 

        [JsonProperty("partialmatchcategory2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partialmatchcategory2 { get; set; } 

        [JsonProperty("category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category3 { get; set; } 

        [JsonProperty("partialmatchcategory3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partialmatchcategory3 { get; set; } 

        [JsonProperty("category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category4 { get; set; } 

        [JsonProperty("partialmatchcategory4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partialmatchcategory4 { get; set; } 

        [JsonProperty("user_covered_billingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserCoveredBillingdescription { get; set; } 

        [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SiteName { get; set; } 

        [JsonProperty("allowallcontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowallcontracts { get; set; } 

        [JsonProperty("asset_covered_by_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssetCoveredByContract { get; set; } 

        [JsonProperty("user_covered_by_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserCoveredByContract { get; set; } 

        [JsonProperty("work_hours_covered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkHoursCovered { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Order { get; set; } 

        [JsonProperty("billing_plan_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BillingPlanDesc { get; set; } 

        [JsonProperty("contract_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractType { get; set; } 

        [JsonProperty("contract_sub_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractSubType { get; set; } 

        [JsonProperty("not_included_in_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotIncludedInContract { get; set; } 

        [JsonProperty("contract_header_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ContractHeaderEndDate { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContractHeader
    {
        [JsonProperty("contract_contact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractContactId { get; set; } 

        [JsonProperty("item_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemDesc { get; set; } 

        [JsonProperty("main_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MainSite { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientName { get; set; } 

        [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ref { get; set; } 

        [JsonProperty("refextra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Refextra { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; } 

        [JsonProperty("started", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Started { get; set; } 

        [JsonProperty("expired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expired { get; set; } 

        [JsonProperty("numberofunitsfree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Numberofunitsfree { get; set; } 

        [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingperiod { get; set; } 

        [JsonProperty("billingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingdescription { get; set; } 

        [JsonProperty("subtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Subtype { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SiteName { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserName { get; set; } 

        [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlaId { get; set; } 

        [JsonProperty("periodicinvoicenextdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Periodicinvoicenextdate { get; set; } 

        [JsonProperty("next_invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NextInvoiceDate { get; set; } 

        [JsonProperty("periodchargeamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Periodchargeamount { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("asset_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AssetValue { get; set; } 

        [JsonProperty("refextra2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Refextra2 { get; set; } 

        [JsonProperty("contract_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContractStatus { get; set; } 

        [JsonProperty("asset_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetSequence { get; set; } 

        [JsonProperty("next_call_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NextCallDate { get; set; } 

        [JsonProperty("accounts_override_mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountsOverrideMailbox { get; set; } 

        [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlaName { get; set; } 

        [JsonProperty("startbalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Startbalance { get; set; } 

        [JsonProperty("paymentscheme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Paymentscheme { get; set; } 

        [JsonProperty("chargehoursperperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Chargehoursperperiod { get; set; } 

        [JsonProperty("chargerollover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Chargerollover { get; set; } 

        [JsonProperty("outofhoursmultiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Outofhoursmultiplier { get; set; } 

        [JsonProperty("requestminimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Requestminimum { get; set; } 

        [JsonProperty("invoiceminimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Invoiceminimum { get; set; } 

        [JsonProperty("allowfixedprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowfixedprice { get; set; } 

        [JsonProperty("allowpyg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowpyg { get; set; } 

        [JsonProperty("allowprepay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowprepay { get; set; } 

        [JsonProperty("chargeperdevice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Chargeperdevice { get; set; } 

        [JsonProperty("prepayrecurringcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayrecurringcharge { get; set; } 

        [JsonProperty("chargeprepaytravel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Chargeprepaytravel { get; set; } 

        [JsonProperty("chargeprepaymileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Chargeprepaymileage { get; set; } 

        [JsonProperty("chargepygtravel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Chargepygtravel { get; set; } 

        [JsonProperty("chargepygmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Chargepygmileage { get; set; } 

        [JsonProperty("onlybillatendofperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onlybillatendofperiod { get; set; } 

        [JsonProperty("unmatchedcombinations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unmatchedcombinations { get; set; } 

        [JsonProperty("termmonths", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Termmonths { get; set; } 

        [JsonProperty("percentageincrease", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percentageincrease { get; set; } 

        [JsonProperty("nextincrementdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextincrementdate { get; set; } 

        [JsonProperty("datereceived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datereceived { get; set; } 

        [JsonProperty("invoicedescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoicedescription { get; set; } 

        [JsonProperty("datesent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datesent { get; set; } 

        [JsonProperty("paymentmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Paymentmethod { get; set; } 

        [JsonProperty("dontsendalarm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontsendalarm { get; set; } 

        [JsonProperty("createdfrom_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedfromId { get; set; } 

        [JsonProperty("costperperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Costperperiod { get; set; } 

        [JsonProperty("rollingcontract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rollingcontract { get; set; } 

        [JsonProperty("previouscontract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Previouscontract { get; set; } 

        [JsonProperty("dontinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontinvoice { get; set; } 

        [JsonProperty("ohid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ohid { get; set; } 

        [JsonProperty("emailaddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailaddresses { get; set; } 

        [JsonProperty("scheduleemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scheduleemails { get; set; } 

        [JsonProperty("schedulesendaccountmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Schedulesendaccountmanager { get; set; } 

        [JsonProperty("accountsdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsdesc { get; set; } 

        [JsonProperty("hasactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hasactions { get; set; } 

        [JsonProperty("billingperiods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingperiods { get; set; } 

        [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Assets { get; set; } 

        [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UsersList>? Users { get; set; } 

        [JsonProperty("periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractPeriod>? Periods { get; set; } 

        [JsonProperty("surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Surchargeid { get; set; } 

        [JsonProperty("chargerate_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargerateMethod { get; set; } 

        [JsonProperty("overriding_rates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ChargeRate>? OverridingRates { get; set; } 

        [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Lookup>? Chargerates { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimport { get; set; } 

        [JsonProperty("_ignore_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreMandatory { get; set; } 

        [JsonProperty("billing_description_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BillingDescriptionString { get; set; } 

        [JsonProperty("billing_period_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BillingPeriodString { get; set; } 

        [JsonProperty("dontchargeforitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontchargeforitems { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("_print_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrintPreview { get; set; } 

        [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrintGenerate { get; set; } 

        [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Printhtml { get; set; } 

        [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PdfAttachmentId { get; set; } 

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PdftemplateId { get; set; } 

        [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PdftemplateName { get; set; } 

        [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractSchedule>? Schedule { get; set; } 

        [JsonProperty("scheduleplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractSchedulePlan>? Scheduleplan { get; set; } 

        [JsonProperty("_send_outstanding_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendOutstandingEmails { get; set; } 

        [JsonProperty("_send_appointment_invites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendAppointmentInvites { get; set; } 

        [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autotaskid { get; set; } 

        [JsonProperty("import_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportUser { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesorderId { get; set; } 

        [JsonProperty("salesorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesorderLineId { get; set; } 

        [JsonProperty("endtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Endtype { get; set; } 

        [JsonProperty("new_invoice_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewInvoiceStartDate { get; set; } 

        [JsonProperty("new_invoice_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewInvoiceEndDate { get; set; } 

        [JsonProperty("chargeratemultiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Chargeratemultiplier { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("contract_prepaytotal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ContractPrepaytotal { get; set; } 

        [JsonProperty("contract_prepayused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ContractPrepayused { get; set; } 

        [JsonProperty("contract_prepaybalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ContractPrepaybalance { get; set; } 

        [JsonProperty("contract_prepayhistory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PrepayHistory>? ContractPrepayhistory { get; set; } 

        [JsonProperty("contract_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PrepayPeriod>? ContractPeriods { get; set; } 

        [JsonProperty("contract_prepayasamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContractPrepayasamount { get; set; } 

        [JsonProperty("prepay_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PrepayPeriod>? PrepayPeriods { get; set; } 

        [JsonProperty("prepayrecurringchargenextdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Prepayrecurringchargenextdate { get; set; } 

        [JsonProperty("prepayrecurringhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayrecurringhours { get; set; } 

        [JsonProperty("billforrecurringprepayamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Billforrecurringprepayamount { get; set; } 

        [JsonProperty("prepayrecurringminimumdeduction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayrecurringminimumdeduction { get; set; } 

        [JsonProperty("prepayrecurringminimumdeductiononlyactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prepayrecurringminimumdeductiononlyactive { get; set; } 

        [JsonProperty("prepayrecurringautomaticdeduction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayrecurringautomaticdeduction { get; set; } 

        [JsonProperty("iscontractdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iscontractdetails { get; set; } 

        [JsonProperty("labournominalcodeoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Labournominalcodeoverride { get; set; } 

        [JsonProperty("labournominalcodeoverride_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LabournominalcodeoverrideName { get; set; } 

        [JsonProperty("prepayrecurringexpirymonths", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prepayrecurringexpirymonths { get; set; } 

        [JsonProperty("contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractHeaderContract>? Contracts { get; set; } 

        [JsonProperty("sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Site_List>? Sites { get; set; } 

        [JsonProperty("emailaddress_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailaddressTo { get; set; } 

        [JsonProperty("emailaddress_cc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailaddressCc { get; set; } 

        [JsonProperty("use_cost_calculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseCostCalculation { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AttachmentList>? Attachments { get; set; } 

        [JsonProperty("billingplans", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractDetail>? Billingplans { get; set; } 

        [JsonProperty("send_to_oracle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendToOracle { get; set; } 

        [JsonProperty("oracle_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OracleInvoiceId { get; set; } 

        [JsonProperty("datesent_to_oracle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DatesentToOracle { get; set; } 

        [JsonProperty("prepay_itemid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrepayItemid { get; set; } 

        [JsonProperty("prepay_itemname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrepayItemname { get; set; } 

        [JsonProperty("created_from_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedFromOrder { get; set; } 

        [JsonProperty("autotopupthreshhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Autotopupthreshhold { get; set; } 

        [JsonProperty("autotopuptoamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Autotopuptoamount { get; set; } 

        [JsonProperty("autotopupcostperhour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Autotopupcostperhour { get; set; } 

        [JsonProperty("autotopupbyamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Autotopupbyamount { get; set; } 

        [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tabname>? Extratabs { get; set; } 

        [JsonProperty("approvername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvername { get; set; } 

        [JsonProperty("approveremailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approveremailaddress { get; set; } 

        [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Signature { get; set; } 

        [JsonProperty("can_approve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanApprove { get; set; } 

        [JsonProperty("portal_display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PortalDisplayType { get; set; } 

        [JsonProperty("contractapprovalfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestTypeField>? Contractapprovalfields { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Key { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TableEnum? Table { get; set; } 

        [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModified { get; set; } 

        [JsonProperty("asset_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? AssetEndDate { get; set; } 

        [JsonProperty("contracttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contracttype { get; set; } 

        [JsonProperty("contracttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContracttypeName { get; set; } 

        [JsonProperty("prepayrecurringchargebp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prepayrecurringchargebp { get; set; } 

        [JsonProperty("force_recalculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceRecalculation { get; set; } 

        [JsonProperty("cost_calculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CostCalculation { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("sent_to_oracle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SentToOracle { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("createdby_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedbyId { get; set; } 

        [JsonProperty("createdby_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CreatedbyName { get; set; } 

        [JsonProperty("billingcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingcategory { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importthirdpartyid { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtype { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? NewExternalLink { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContractHeaderContract
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractId { get; set; } 

        [JsonProperty("supplier_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierContractId { get; set; } 

        [JsonProperty("contractref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contractref { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContractHeaderList
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientName { get; set; } 

        [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ref { get; set; } 

        [JsonProperty("refextra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Refextra { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; } 

        [JsonProperty("started", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Started { get; set; } 

        [JsonProperty("expired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expired { get; set; } 

        [JsonProperty("numberofunitsfree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Numberofunitsfree { get; set; } 

        [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingperiod { get; set; } 

        [JsonProperty("billingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingdescription { get; set; } 

        [JsonProperty("subtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Subtype { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SiteName { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserName { get; set; } 

        [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlaId { get; set; } 

        [JsonProperty("periodicinvoicenextdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Periodicinvoicenextdate { get; set; } 

        [JsonProperty("next_invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NextInvoiceDate { get; set; } 

        [JsonProperty("periodchargeamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Periodchargeamount { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("asset_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AssetValue { get; set; } 

        [JsonProperty("refextra2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Refextra2 { get; set; } 

        [JsonProperty("contract_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContractStatus { get; set; } 

        [JsonProperty("asset_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetSequence { get; set; } 

        [JsonProperty("next_call_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NextCallDate { get; set; } 

        [JsonProperty("accounts_override_mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountsOverrideMailbox { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Key { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TableEnum? Table { get; set; } 

        [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModified { get; set; } 

        [JsonProperty("asset_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? AssetEndDate { get; set; } 

        [JsonProperty("contracttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contracttype { get; set; } 

        [JsonProperty("contracttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContracttypeName { get; set; } 

        [JsonProperty("prepayrecurringchargebp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prepayrecurringchargebp { get; set; } 

        [JsonProperty("force_recalculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceRecalculation { get; set; } 

        [JsonProperty("cost_calculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CostCalculation { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("sent_to_oracle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SentToOracle { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("createdby_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedbyId { get; set; } 

        [JsonProperty("createdby_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CreatedbyName { get; set; } 

        [JsonProperty("billingcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingcategory { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importthirdpartyid { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtype { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? NewExternalLink { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContractPeriod
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractId { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; } 

        [JsonProperty("start_date_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDateDisplay { get; set; } 

        [JsonProperty("end_date_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDateDisplay { get; set; } 

        [JsonProperty("current", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Current { get; set; } 

        [JsonProperty("hours_in_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? HoursInPeriod { get; set; } 

        [JsonProperty("hours_used", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? HoursUsed { get; set; } 

        [JsonProperty("hours_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? HoursRemaining { get; set; } 

        [JsonProperty("hours_charged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? HoursCharged { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContractRule
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("user_under_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserUnderClient { get; set; } 

        [JsonProperty("outcome_contract_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OutcomeContractType { get; set; } 

        [JsonProperty("outcome_contract_subtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OutcomeContractSubtype { get; set; } 

        [JsonProperty("outcome_covered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OutcomeCovered { get; set; } 

        [JsonProperty("outcome_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OutcomeValue { get; set; } 

        [JsonProperty("outcome_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? OutcomeEndDate { get; set; } 

        [JsonProperty("rule_criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AutoassignCriteria>? RuleCriteria { get; set; } 

        [JsonProperty("is_matched", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMatched { get; set; } 

        [JsonProperty("outcome_contract_type_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OutcomeContractTypeDisplay { get; set; } 

        [JsonProperty("outcome_contract_subtype_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OutcomeContractSubtypeDisplay { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContractSchedule
    {
        [JsonProperty("chid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chid { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentId { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContractSchedulePlan
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractId { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requesttype { get; set; } 

        [JsonProperty("requesttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RequesttypeName { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentId { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AgentName { get; set; } 

        [JsonProperty("hours_allocated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? HoursAllocated { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketId { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours { get; set; } 

        [JsonProperty("apid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Apid { get; set; } 

        [JsonProperty("event", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Appointment? Event { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContractTemplateDetail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("billingtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingtemplateId { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("itil_requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItilRequesttype { get; set; } 

        [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requesttype { get; set; } 

        [JsonProperty("requesttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RequesttypeName { get; set; } 

        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; } 

        [JsonProperty("chargerate_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargerateType { get; set; } 

        [JsonProperty("chargerate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargerateId { get; set; } 

        [JsonProperty("chargerate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChargerateName { get; set; } 

        [JsonProperty("multiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Multiplier { get; set; } 

        [JsonProperty("plan_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PlanId { get; set; } 

        [JsonProperty("plan_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PlanName { get; set; } 

        [JsonProperty("category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category1 { get; set; } 

        [JsonProperty("partialmatchcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partialmatchcategory { get; set; } 

        [JsonProperty("category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category2 { get; set; } 

        [JsonProperty("partialmatchcategory2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partialmatchcategory2 { get; set; } 

        [JsonProperty("category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category3 { get; set; } 

        [JsonProperty("partialmatchcategory3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partialmatchcategory3 { get; set; } 

        [JsonProperty("category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category4 { get; set; } 

        [JsonProperty("partialmatchcategory4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partialmatchcategory4 { get; set; } 

        [JsonProperty("user_covered_billingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserCoveredBillingdescription { get; set; } 

        [JsonProperty("asset_covered_by_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssetCoveredByContract { get; set; } 

        [JsonProperty("user_covered_by_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserCoveredByContract { get; set; } 

        [JsonProperty("work_hours_covered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkHoursCovered { get; set; } 

        [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Order { get; set; } 

        [JsonProperty("contract_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractType { get; set; } 

        [JsonProperty("contract_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContractTypeName { get; set; } 

        [JsonProperty("contract_sub_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractSubType { get; set; } 

        [JsonProperty("contract_sub_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContractSubTypeName { get; set; } 

        [JsonProperty("remove_from_plan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoveFromPlan { get; set; } 

        [JsonProperty("billing_plan_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BillingPlanDesc { get; set; } 

        [JsonProperty("not_included_in_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotIncludedInContract { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ContractTemplateHeader
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("unmatchedcombinations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unmatchedcombinations { get; set; } 

        [JsonProperty("prepayrecurringchargenextdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Prepayrecurringchargenextdate { get; set; } 

        [JsonProperty("billforrecurringprepayamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Billforrecurringprepayamount { get; set; } 

        [JsonProperty("prepayrecurringcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayrecurringcharge { get; set; } 

        [JsonProperty("prepayrecurringhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayrecurringhours { get; set; } 

        [JsonProperty("prepayrecurringchargebp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prepayrecurringchargebp { get; set; } 

        [JsonProperty("autotopupthreshhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Autotopupthreshhold { get; set; } 

        [JsonProperty("autotopuptoamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Autotopuptoamount { get; set; } 

        [JsonProperty("autotopupcostperhour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Autotopupcostperhour { get; set; } 

        [JsonProperty("autotopupbyamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Autotopupbyamount { get; set; } 

        [JsonProperty("surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Surchargeid { get; set; } 

        [JsonProperty("numberofunitsfree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Numberofunitsfree { get; set; } 

        [JsonProperty("prepayrecurringminimumdeduction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayrecurringminimumdeduction { get; set; } 

        [JsonProperty("prepayrecurringminimumdeductiononlyactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prepayrecurringminimumdeductiononlyactive { get; set; } 

        [JsonProperty("prepayrecurringautomaticdeduction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayrecurringautomaticdeduction { get; set; } 

        [JsonProperty("billingplans", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractTemplateDetail>? Billingplans { get; set; } 

        [JsonProperty("billingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingdescription { get; set; } 

        [JsonProperty("subtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Subtype { get; set; } 

        [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingperiod { get; set; } 

        [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Clients { get; set; } 

        [JsonProperty("create_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateContract { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Contributors
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentId { get; set; } 

        [JsonProperty("agentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agentname { get; set; } 

        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; } 

        [JsonProperty("rolename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rolename { get; set; } 

        [JsonProperty("ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketid { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("contributor_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContributorType { get; set; } 

        [JsonProperty("quality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quality { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Costcentres
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("chargeable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Chargeable { get; set; } 

        [JsonProperty("addr1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addr1 { get; set; } 

        [JsonProperty("addr2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addr2 { get; set; } 

        [JsonProperty("addr3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addr3 { get; set; } 

        [JsonProperty("addr4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addr4 { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CreateSlackChannel
    {
        [JsonProperty("workspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkspaceId { get; set; } 

        [JsonProperty("access_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessType { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SlackUser>? Members { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CreateTeamsChat
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Users>? Members { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Currency
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Symbol { get; set; } 

        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; } 

        [JsonProperty("conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ConversionRate { get; set; } 

        [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdated { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CustomButton
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("usage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Usage { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Label { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("newtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newtab { get; set; } 

        [JsonProperty("msid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Msid { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("runbook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RunbookId { get; set; } 

        [JsonProperty("runbook_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RunbookName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CustomField
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Label { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Value { get; set; } 

        [JsonProperty("value_is_password_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValueIsPasswordId { get; set; } 

        [JsonProperty("display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Display { get; set; } 

        [JsonProperty("characterlimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Characterlimit { get; set; } 

        [JsonProperty("characterlimittype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Characterlimittype { get; set; } 

        [JsonProperty("inputtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inputtype { get; set; } 

        [JsonProperty("copytochild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copytochild { get; set; } 

        [JsonProperty("copytoparent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copytoparent { get; set; } 

        [JsonProperty("searchable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Searchable { get; set; } 

        [JsonProperty("ordervalues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ordervalues { get; set; } 

        [JsonProperty("ordervaluesby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ordervaluesby { get; set; } 

        [JsonProperty("database_lookup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DatabaseLookupId { get; set; } 

        [JsonProperty("database_lookup_auto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DatabaseLookupAuto { get; set; } 

        [JsonProperty("database_lookup_triggers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PartsLookupField>? DatabaseLookupTriggers { get; set; } 

        [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyName { get; set; } 

        [JsonProperty("extratype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Extratype { get; set; } 

        [JsonProperty("copytochildonupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copytochildonupdate { get; set; } 

        [JsonProperty("copytoparentonupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copytoparentonupdate { get; set; } 

        [JsonProperty("hyperlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hyperlink { get; set; } 

        [JsonProperty("usage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Usage { get; set; } 

        [JsonProperty("linked_table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LinkedTableId { get; set; } 

        [JsonProperty("showondetailsscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showondetailsscreen { get; set; } 

        [JsonProperty("third_party_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyValue { get; set; } 

        [JsonProperty("custom_extra_table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomExtraTableId { get; set; } 

        [JsonProperty("copytorelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copytorelated { get; set; } 

        [JsonProperty("calculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Calculation { get; set; } 

        [JsonProperty("rounding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rounding { get; set; } 

        [JsonProperty("validation_reasons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? ValidationReasons { get; set; } 

        [JsonProperty("int_value_is_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntValueIsDisplay { get; set; } 

        [JsonProperty("regex", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Regex { get; set; } 

        [JsonProperty("onlyshowforagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onlyshowforagents { get; set; } 

        [JsonProperty("is_horizontal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHorizontal { get; set; } 

        [JsonProperty("copied", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copied { get; set; } 

        [JsonProperty("isencrypted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isencrypted { get; set; } 

        [JsonProperty("max_selection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxSelection { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("selection_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SelectionFieldId { get; set; } 

        [JsonProperty("variable_format_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? VariableFormat1 { get; set; } 

        [JsonProperty("variable_format_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? VariableFormat2 { get; set; } 

        [JsonProperty("validation_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomFieldValidation>? ValidationData { get; set; } 

        [JsonProperty("database_lookup_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DatabaseLookupInput { get; set; } 

        [JsonProperty("table_data_entry_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TableDataEntryType { get; set; } 

        [JsonProperty("showintable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showintable { get; set; } 

        [JsonProperty("table_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TableHeight { get; set; } 

        [JsonProperty("dont_delete_rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontDeleteRows { get; set; } 

        [JsonProperty("table_matching_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TableMatchingField { get; set; } 

        [JsonProperty("new_storage_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewStorageMethod { get; set; } 

        [JsonProperty("where_sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WhereSql { get; set; } 

        [JsonProperty("load_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LoadType { get; set; } 

        [JsonProperty("add_rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddRows { get; set; } 

        [JsonProperty("delete_these_rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? DeleteTheseRows { get; set; } 

        [JsonProperty("showinpool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showinpool { get; set; } 

        [JsonProperty("allow_pool_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowPoolOverride { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CustomFieldValidation
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("fiid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fiid { get; set; } 

        [JsonProperty("filinktoid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filinktoid { get; set; } 

        [JsonProperty("validationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Validationtype { get; set; } 

        [JsonProperty("askforreason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Askforreason { get; set; } 

        [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hours { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CustomFieldValueRestrictions
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TickettypeId { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FieldId { get; set; } 

        [JsonProperty("value_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ValueId { get; set; } 

        [JsonProperty("value_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ValueGuid { get; set; } 

        [JsonProperty("value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CustomFieldVisibility
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TickettypeId { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FieldId { get; set; } 

        [JsonProperty("field_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? FieldGuid { get; set; } 

        [JsonProperty("lookup_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LookupFieldId { get; set; } 

        [JsonProperty("lookup_field_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? LookupFieldGuid { get; set; } 

        [JsonProperty("lookup_value_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LookupValueId { get; set; } 

        [JsonProperty("lookup_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LookupValue { get; set; } 

        [JsonProperty("field_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FieldValue { get; set; } 

        [JsonProperty("dynamic_SQL_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DynamicSqlField { get; set; } 

        [JsonProperty("value_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValueModified { get; set; } 

        [JsonProperty("conditiontype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Conditiontype { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CustomQuery
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("sql_script", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SqlScript { get; set; } 

        [JsonProperty("run", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Run { get; set; } 

        [JsonProperty("run_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CustomSqlResult? RunResult { get; set; } 

        [JsonProperty("lookup_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? LookupValues { get; set; } 

        [JsonProperty("column_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ColumnName { get; set; } 

        [JsonProperty("top_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TopMax { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CustomSqlResult
    {
        [JsonProperty("sql_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? SqlResult { get; set; } 

        [JsonProperty("success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; } 

        [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Error { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CustomTable
    {
        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("ctfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CustomField? Ctfield { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("add_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? AddCustomfields { get; set; } 

        [JsonProperty("edit_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? EditCustomfields { get; set; } 

        [JsonProperty("delete_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? DeleteCustomfields { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("db_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DbName { get; set; } 

        [JsonProperty("linkto_table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LinktoTableId { get; set; } 

        [JsonProperty("linkto_table_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? LinktoTableGuid { get; set; } 

        [JsonProperty("linkto_table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LinktoTableName { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("import_folder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportFolder { get; set; } 

        [JsonProperty("data_entry_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DataEntryType { get; set; } 

        [JsonProperty("clear_on_close", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClearOnClose { get; set; } 

        [JsonProperty("primary_field_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrimaryField1 { get; set; } 

        [JsonProperty("primary_field_1_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? PrimaryField1Guid { get; set; } 

        [JsonProperty("primary_field_1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrimaryField1Name { get; set; } 

        [JsonProperty("primary_field_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrimaryField2 { get; set; } 

        [JsonProperty("primary_field_2_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? PrimaryField2Guid { get; set; } 

        [JsonProperty("primary_field_2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrimaryField2Name { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FieldInfo>? Fields { get; set; } 

        [JsonProperty("customextratableid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customextratableid { get; set; } 

        [JsonProperty("can_load_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanLoadData { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("customtable_orderby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomtableOrderby { get; set; } 

        [JsonProperty("customtable_orderby_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? CustomtableOrderbyGuid { get; set; } 

        [JsonProperty("customtable_orderby_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CustomtableOrderbyName { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtype { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Key { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AccessControl { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessControlLevel { get; set; } 

        [JsonProperty("import_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportName { get; set; } 

        [JsonProperty("columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Columns { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class CustomTableRow
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("fkid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fkid { get; set; } 

        [JsonProperty("display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Display { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

    }

