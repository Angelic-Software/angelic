using Newtonsoft.Json;
using System.CodeDom.Compiler;

namespace Angelic;


    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SOCCreateIncident
    {
        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("userName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserName { get; set; } 

        [JsonProperty("isMultiResponder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMultiResponder { get; set; } 

        [JsonProperty("targets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SOCCreateIncidentTarget>? Targets { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SOCCreateIncidentTarget
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("slug", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slug { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SOCWebhook
    {
        [JsonProperty("phase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phase { get; set; } 

        [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Entity_id { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("incident", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Incident { get; set; } 

        [JsonProperty("last_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Last_timestamp { get; set; } 

        [JsonProperty("ack_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Ack_at { get; set; } 

        [JsonProperty("ack_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ack_by { get; set; } 

        [JsonProperty("ack_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ack_message { get; set; } 

        [JsonProperty("resolved_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Resolved_at { get; set; } 

        [JsonProperty("resolved_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resolved_by { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("resourceObject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? ResourceObject { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SQLImport
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Table { get; set; } 

        [JsonProperty("udlpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Udlpath { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql { get; set; } 

        [JsonProperty("keyfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Keyfield { get; set; } 

        [JsonProperty("datafield1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datafield1 { get; set; } 

        [JsonProperty("datafield2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datafield2 { get; set; } 

        [JsonProperty("datafield3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datafield3 { get; set; } 

        [JsonProperty("datafield4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datafield4 { get; set; } 

        [JsonProperty("defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultsite { get; set; } 

        [JsonProperty("defaultsitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultsitename { get; set; } 

        [JsonProperty("lastrundate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastrundate { get; set; } 

        [JsonProperty("nhdfield3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nhdfield3 { get; set; } 

        [JsonProperty("updateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Updateonly { get; set; } 

        [JsonProperty("integrator_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Integrator_enabled { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SQLImportField>? Fields { get; set; } 

        [JsonProperty("sqlserver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sqlserver { get; set; } 

        [JsonProperty("sqldatabase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sqldatabase { get; set; } 

        [JsonProperty("sqlusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sqlusername { get; set; } 

        [JsonProperty("sisqlpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sisqlpassword { get; set; } 

        [JsonProperty("new_sql_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_sql_password { get; set; } 

        [JsonProperty("useusers_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useusers_site { get; set; } 

        [JsonProperty("dontupdatesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontupdatesite { get; set; } 

        [JsonProperty("dontremoveusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontremoveusers { get; set; } 

        [JsonProperty("canupdaterecords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canupdaterecords { get; set; } 

        [JsonProperty("syncto3party", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Syncto3party { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_lastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_lasterror { get; set; } 

        [JsonProperty("halointegrator_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Halointegrator_allowed_clientids_list { get; set; } 

        [JsonProperty("halointegrator_allowed_clientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_allowed_clientids { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("allow_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_access { get; set; } 

        [JsonProperty("include_linux_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_linux_software { get; set; } 

        [JsonProperty("dontupdatetoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontupdatetoplevel { get; set; } 

        [JsonProperty("donotvalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Donotvalidate { get; set; } 

        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetimportidentifier { get; set; } 

        [JsonProperty("assetimportidentifier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Assetimportidentifier_guid { get; set; } 

        [JsonProperty("assetimportidentifier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetimportidentifier_name { get; set; } 

        [JsonProperty("sql_provider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sql_provider { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("sql_driver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_driver { get; set; } 

        [JsonProperty("dontupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontupdatetype { get; set; } 

        [JsonProperty("sql_timeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sql_timeout { get; set; } 

        [JsonProperty("sql_port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_port { get; set; } 

        [JsonProperty("import_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Import_table { get; set; } 

        [JsonProperty("import_table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Import_table_name { get; set; } 

        [JsonProperty("entity_match_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Entity_match_field { get; set; } 

        [JsonProperty("table_matching_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Table_matching_field { get; set; } 

        [JsonProperty("table_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Table_matching_field_name { get; set; } 

        [JsonProperty("linkto_table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linkto_table_id { get; set; } 

        [JsonProperty("table_update_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Table_update_type { get; set; } 

        [JsonProperty("match_accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Match_accountsid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SQLImportField
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("siid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Siid { get; set; } 

        [JsonProperty("thirdpartyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartyname { get; set; } 

        [JsonProperty("nhdname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nhdname { get; set; } 

        [JsonProperty("is_site_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_site_field { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class STDToDo
    {
        [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Template_id { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("allowed_clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaToDo>? Allowed_clients { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ToDoGroup? Group { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Group_name { get; set; } 

        [JsonProperty("group_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_seq { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class STDrequestbudget
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Template_id { get; set; } 

        [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours { get; set; } 

        [JsonProperty("days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Days { get; set; } 

        [JsonProperty("rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Rate { get; set; } 

        [JsonProperty("rate_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Rate_days { get; set; } 

        [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Budgettype_id { get; set; } 

        [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Budgettype_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SageBusinessCloudDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Tokenexpiry { get; set; } 

        [JsonProperty("isauthorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isauthorized { get; set; } 

        [JsonProperty("redirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Redirecturi { get; set; } 

        [JsonProperty("clienttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clienttoplevel { get; set; } 

        [JsonProperty("itemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itemgroup { get; set; } 

        [JsonProperty("enablesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablesync { get; set; } 

        [JsonProperty("defaultitemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultitemcode { get; set; } 

        [JsonProperty("showmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showmessage { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_id { get; set; } 

        [JsonProperty("syncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncentities { get; set; } 

        [JsonProperty("sbcdnewmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sbcdnewmethod { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_group_name { get; set; } 

        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; } 

        [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _exchangecode { get; set; } 

        [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _disconnect { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_top_level_name { get; set; } 

        [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Client_mappings { get; set; } 

        [JsonProperty("item_group_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Item_group_mappings { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SalesMailbox
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenantid { get; set; } 

        [JsonProperty("applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Applicationid { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Token_expiry { get; set; } 

        [JsonProperty("halointegrator_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_enabled { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_lastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_lasterror { get; set; } 

        [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Redirect_uri { get; set; } 

        [JsonProperty("_authcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _authcode { get; set; } 

        [JsonProperty("_exchangecodefortoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _exchangecodefortoken { get; set; } 

        [JsonProperty("mailboxes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SalesMailboxDetail>? Mailboxes { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("google_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Google_authorized { get; set; } 

        [JsonProperty("new_google_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_google_access_token { get; set; } 

        [JsonProperty("new_google_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_google_refresh_token { get; set; } 

        [JsonProperty("google_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Google_token_expiry { get; set; } 

        [JsonProperty("google_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Google_redirect { get; set; } 

        [JsonProperty("google_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Google_email { get; set; } 

        [JsonProperty("_getgoogletoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getgoogletoken { get; set; } 

        [JsonProperty("google_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Google_code { get; set; } 

        [JsonProperty("google_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Google_type { get; set; } 

        [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Graph_host { get; set; } 

        [JsonProperty("import_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Import_sent { get; set; } 

        [JsonProperty("match_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Match_method { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SalesMailboxDetail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("smid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Smid { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("enableautomatching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableautomatching { get; set; } 

        [JsonProperty("lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastsync { get; set; } 

        [JsonProperty("sentlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Sentlastsync { get; set; } 

        [JsonProperty("lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lasterror { get; set; } 

        [JsonProperty("_hasAccess", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _hasAccess { get; set; } 

        [JsonProperty("google_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Google_authorized { get; set; } 

        [JsonProperty("new_google_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_google_access_token { get; set; } 

        [JsonProperty("new_google_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_google_refresh_token { get; set; } 

        [JsonProperty("google_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Google_token_expiry { get; set; } 

        [JsonProperty("google_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Google_redirect { get; set; } 

        [JsonProperty("_getgoogletoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getgoogletoken { get; set; } 

        [JsonProperty("agent_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_email { get; set; } 

        [JsonProperty("_authcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _authcode { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Applicationid { get; set; } 

        [JsonProperty("linked_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_agent { get; set; } 

        [JsonProperty("linked_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Linked_agent_name { get; set; } 

        [JsonProperty("linked_agent_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Linked_agent_email { get; set; } 

        [JsonProperty("match_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Match_type { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Schedule
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddate { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours { get; set; } 

        [JsonProperty("dailyrecurrencepattern", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dailyrecurrencepattern { get; set; } 

        [JsonProperty("dailyrecurrencedays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dailyrecurrencedays { get; set; } 

        [JsonProperty("weeklyrecurrenceweeks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Weeklyrecurrenceweeks { get; set; } 

        [JsonProperty("endafteramount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Endafteramount { get; set; } 

        [JsonProperty("rangeofrecurrence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rangeofrecurrence { get; set; } 

        [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requesttype { get; set; } 

        [JsonProperty("recurrencepattern", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recurrencepattern { get; set; } 

        [JsonProperty("agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agentid { get; set; } 

        [JsonProperty("monthlyrecurrencepattern", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Monthlyrecurrencepattern { get; set; } 

        [JsonProperty("yearlyrecurrencepattern", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Yearlyrecurrencepattern { get; set; } 

        [JsonProperty("monthlyrecurrencespecificdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Monthlyrecurrencespecificdate { get; set; } 

        [JsonProperty("monthlyrecurrencespecificdateinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Monthlyrecurrencespecificdateinterval { get; set; } 

        [JsonProperty("monthlyrecurrencespecificday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Monthlyrecurrencespecificday { get; set; } 

        [JsonProperty("monthlyrecurrencespecificdayofweek", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Monthlyrecurrencespecificdayofweek { get; set; } 

        [JsonProperty("monthlyrecurrencespecificdayinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Monthlyrecurrencespecificdayinterval { get; set; } 

        [JsonProperty("yearlyrecurrencespecificdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Yearlyrecurrencespecificdate { get; set; } 

        [JsonProperty("yearlyrecurrencespecificdatemonth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Yearlyrecurrencespecificdatemonth { get; set; } 

        [JsonProperty("yearlyrecurrencespecificdateinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Yearlyrecurrencespecificdateinterval { get; set; } 

        [JsonProperty("yearlyrecurrencespecificday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Yearlyrecurrencespecificday { get; set; } 

        [JsonProperty("yearlyrecurrencespecificdayofweek", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Yearlyrecurrencespecificdayofweek { get; set; } 

        [JsonProperty("yearlyrecurrencespecificdaymonth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Yearlyrecurrencespecificdaymonth { get; set; } 

        [JsonProperty("yearlyrecurrencespecificdayinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Yearlyrecurrencespecificdayinterval { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Uniqueid { get; set; } 

        [JsonProperty("weeklyrecurrencestring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Weeklyrecurrencestring { get; set; } 

        [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextcreationdate { get; set; } 

        [JsonProperty("nextrundate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextrundate { get; set; } 

        [JsonProperty("contract_schedule_plan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractSchedulePlan>? Contract_schedule_plan { get; set; } 

        [JsonProperty("weeklyrecurrenceamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? Weeklyrecurrenceamount { get; set; } 

        [JsonProperty("_validateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _validateonly { get; set; } 

        [JsonProperty("events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Appointment>? Events { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ScreenLayout
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("usage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Usage { get; set; } 

        [JsonProperty("tab_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tab_display { get; set; } 

        [JsonProperty("tab_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TabConfig>? Tab_config { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("field1_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field1_visibility { get; set; } 

        [JsonProperty("field2_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field2_visibility { get; set; } 

        [JsonProperty("field3_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field3_visibility { get; set; } 

        [JsonProperty("field4_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field4_visibility { get; set; } 

        [JsonProperty("field5_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field5_visibility { get; set; } 

        [JsonProperty("field6_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field6_visibility { get; set; } 

        [JsonProperty("field7_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field7_visibility { get; set; } 

        [JsonProperty("field8_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field8_visibility { get; set; } 

        [JsonProperty("field1_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field1_tab { get; set; } 

        [JsonProperty("field2_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field2_tab { get; set; } 

        [JsonProperty("field3_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field3_tab { get; set; } 

        [JsonProperty("field4_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field4_tab { get; set; } 

        [JsonProperty("field5_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field5_tab { get; set; } 

        [JsonProperty("field6_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field6_tab { get; set; } 

        [JsonProperty("field7_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field7_tab { get; set; } 

        [JsonProperty("field8_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field8_tab { get; set; } 

        [JsonProperty("field9_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field9_tab { get; set; } 

        [JsonProperty("field10_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field10_tab { get; set; } 

        [JsonProperty("field1_tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field1_tab_name { get; set; } 

        [JsonProperty("field2_tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field2_tab_name { get; set; } 

        [JsonProperty("field3_tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field3_tab_name { get; set; } 

        [JsonProperty("field4_tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field4_tab_name { get; set; } 

        [JsonProperty("field5_tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field5_tab_name { get; set; } 

        [JsonProperty("field6_tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field6_tab_name { get; set; } 

        [JsonProperty("field7_tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field7_tab_name { get; set; } 

        [JsonProperty("field8_tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field8_tab_name { get; set; } 

        [JsonProperty("field9_tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field9_tab_name { get; set; } 

        [JsonProperty("field10_tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field10_tab_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ScriptChoice
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("script_question_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Script_question_id { get; set; } 

        [JsonProperty("choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Choice { get; set; } 

        [JsonProperty("next_question_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Next_question_id { get; set; } 

        [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sort_seq { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ScriptHeader
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_1 { get; set; } 

        [JsonProperty("questions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ScriptLine>? Questions { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ScriptLine
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("script_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Script_id { get; set; } 

        [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sort_seq { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("question", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Question { get; set; } 

        [JsonProperty("next_question_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Next_question_id { get; set; } 

        [JsonProperty("update_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Update_field_id { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("input_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Input_type { get; set; } 

        [JsonProperty("temp_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Temp_id { get; set; } 

        [JsonProperty("choices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ScriptChoice>? Choices { get; set; } 

        [JsonProperty("verification_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FieldInfo>? Verification_fields { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SectionDetail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("forrequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forrequests { get; set; } 

        [JsonProperty("foropps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Foropps { get; set; } 

        [JsonProperty("forprojects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forprojects { get; set; } 

        [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_count { get; set; } 

        [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Department_id { get; set; } 

        [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Department_name { get; set; } 

        [JsonProperty("org_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Org_team_name { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("override_column_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Override_column_id { get; set; } 

        [JsonProperty("managers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Manager>? Managers { get; set; } 

        [JsonProperty("teamphotopath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamphotopath { get; set; } 

        [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified { get; set; } 

        [JsonProperty("hide_agents_in_tree_if_no_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_agents_in_tree_if_no_tickets { get; set; } 

        [JsonProperty("timesheet_approver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timesheet_approver { get; set; } 

        [JsonProperty("timesheet_approver_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Timesheet_approver_name { get; set; } 

        [JsonProperty("concurrent_lic_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Concurrent_lic_limit { get; set; } 

        [JsonProperty("workinghoursbeforealert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Workinghoursbeforealert { get; set; } 

        [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailaddress { get; set; } 

        [JsonProperty("addtoallagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addtoallagents { get; set; } 

        [JsonProperty("allowlivechat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowlivechat { get; set; } 

        [JsonProperty("rtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rtid { get; set; } 

        [JsonProperty("mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailbox_override { get; set; } 

        [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameSection>? Agents { get; set; } 

        [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Organisation_id { get; set; } 

        [JsonProperty("cannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CannedText>? Cannedtext { get; set; } 

        [JsonProperty("templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StdRequest_List>? Templates { get; set; } 

        [JsonProperty("allowall_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_category1 { get; set; } 

        [JsonProperty("allowed_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? Allowed_category1 { get; set; } 

        [JsonProperty("allowall_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_category2 { get; set; } 

        [JsonProperty("allowed_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? Allowed_category2 { get; set; } 

        [JsonProperty("allowall_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_category3 { get; set; } 

        [JsonProperty("allowed_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? Allowed_category3 { get; set; } 

        [JsonProperty("allowall_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_category4 { get; set; } 

        [JsonProperty("includeinloadbalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includeinloadbalance { get; set; } 

        [JsonProperty("allowed_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? Allowed_category4 { get; set; } 

        [JsonProperty("override_column_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_column_name { get; set; } 

        [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Messagegroup_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _canupdate { get; set; } 

        [JsonProperty("_canupdate2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _canupdate2 { get; set; } 

        [JsonProperty("main_email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Main_email_address { get; set; } 

        [JsonProperty("phone_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phone_number { get; set; } 

        [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Timezone { get; set; } 

        [JsonProperty("alternative_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alternative_name { get; set; } 

        [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logo { get; set; } 

        [JsonProperty("dontsendsurvey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontsendsurvey { get; set; } 

        [JsonProperty("team_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_note { get; set; } 

        [JsonProperty("booking_workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Booking_workday_id { get; set; } 

        [JsonProperty("booking_workday_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Booking_workday_name { get; set; } 

        [JsonProperty("recurring_shifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Appointment_List>? Recurring_shifts { get; set; } 

        [JsonProperty("third_party_migration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_migration_id { get; set; } 

        [JsonProperty("enable_teams_shifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_teams_shifts { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Department_guid { get; set; } 

        [JsonProperty("homescreendashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Homescreendashboardid { get; set; } 

        [JsonProperty("homescreendashboardname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Homescreendashboardname { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SectionDetail_List
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("forrequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forrequests { get; set; } 

        [JsonProperty("foropps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Foropps { get; set; } 

        [JsonProperty("forprojects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forprojects { get; set; } 

        [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_count { get; set; } 

        [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Department_id { get; set; } 

        [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Department_name { get; set; } 

        [JsonProperty("org_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Org_team_name { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("override_column_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Override_column_id { get; set; } 

        [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Uname_List>? Agents { get; set; } 

        [JsonProperty("managers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Manager>? Managers { get; set; } 

        [JsonProperty("teamphotopath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamphotopath { get; set; } 

        [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified { get; set; } 

        [JsonProperty("hide_agents_in_tree_if_no_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_agents_in_tree_if_no_tickets { get; set; } 

        [JsonProperty("timesheet_approver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timesheet_approver { get; set; } 

        [JsonProperty("timesheet_approver_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Timesheet_approver_name { get; set; } 

        [JsonProperty("concurrent_lic_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Concurrent_lic_limit { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Department_guid { get; set; } 

        [JsonProperty("homescreendashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Homescreendashboardid { get; set; } 

        [JsonProperty("homescreendashboardname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Homescreendashboardname { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SectionRequestType
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettype_id { get; set; } 

        [JsonProperty("section_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Section_id { get; set; } 

        [JsonProperty("section_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Section_name { get; set; } 

        [JsonProperty("allowedteamsrestriction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowedteamsrestriction { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SecurityQuestion
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("answer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Answer { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ServSite
    {
        [JsonProperty("sendemailtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sendemailtype { get; set; } 

        [JsonProperty("email_subscriber_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Email_subscriber_count { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("showinusercatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showinusercatalog { get; set; } 

        [JsonProperty("showintechcatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showintechcatalog { get; set; } 

        [JsonProperty("trackstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trackstatus { get; set; } 

        [JsonProperty("service_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_category_id { get; set; } 

        [JsonProperty("service_category_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Service_category_guid { get; set; } 

        [JsonProperty("service_category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_category_name { get; set; } 

        [JsonProperty("business_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Business_owner_id { get; set; } 

        [JsonProperty("business_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner_name { get; set; } 

        [JsonProperty("business_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Business_owner_cab_id { get; set; } 

        [JsonProperty("business_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner_cab_name { get; set; } 

        [JsonProperty("technical_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technical_owner_id { get; set; } 

        [JsonProperty("technical_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Technical_owner_name { get; set; } 

        [JsonProperty("technical_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technical_owner_cab_id { get; set; } 

        [JsonProperty("technical_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Technical_owner_cab_name { get; set; } 

        [JsonProperty("compliance_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Compliance_owner_id { get; set; } 

        [JsonProperty("compliance_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Compliance_owner_name { get; set; } 

        [JsonProperty("compliance_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Compliance_owner_cab_id { get; set; } 

        [JsonProperty("compliance_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Compliance_owner_cab_name { get; set; } 

        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; } 

        [JsonProperty("estimated_delivery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Estimated_delivery { get; set; } 

        [JsonProperty("estimated_delivery_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Estimated_delivery_days { get; set; } 

        [JsonProperty("subscribable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Subscribable { get; set; } 

        [JsonProperty("subscriber_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Subscriber_count { get; set; } 

        [JsonProperty("asset_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_count { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_id { get; set; } 

        [JsonProperty("assettype_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_ids { get; set; } 

        [JsonProperty("current_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Current_status { get; set; } 

        [JsonProperty("status_message_update_internal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_message_update_internal { get; set; } 

        [JsonProperty("status_message_update_public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_message_update_public { get; set; } 

        [JsonProperty("using_default_public_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Using_default_public_message { get; set; } 

        [JsonProperty("status_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status_ticket_id { get; set; } 

        [JsonProperty("status_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Status_date { get; set; } 

        [JsonProperty("service_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_tickettype_id { get; set; } 

        [JsonProperty("serviceshownewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Serviceshownewreqscreen { get; set; } 

        [JsonProperty("service_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_template_id { get; set; } 

        [JsonProperty("newservicereqtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newservicereqtype { get; set; } 

        [JsonProperty("incident_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Incident_tickettype_id { get; set; } 

        [JsonProperty("incident_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Incident_template_id { get; set; } 

        [JsonProperty("newincidenttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newincidenttype { get; set; } 

        [JsonProperty("relatedworkdayid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Relatedworkdayid { get; set; } 

        [JsonProperty("status_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Status_end_date { get; set; } 

        [JsonProperty("status_ticket_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Status_ticket_start_date { get; set; } 

        [JsonProperty("status_ticket_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Status_ticket_end_date { get; set; } 

        [JsonProperty("requestdetails_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requestdetails_count { get; set; } 

        [JsonProperty("requestdetails_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requestdetails_id { get; set; } 

        [JsonProperty("requestdetail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requestdetail_url { get; set; } 

        [JsonProperty("requestdetail_shownewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Requestdetail_shownewreqscreen { get; set; } 

        [JsonProperty("requestdetail_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requestdetail_type { get; set; } 

        [JsonProperty("screenafterlogging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Screenafterlogging { get; set; } 

        [JsonProperty("pricingrange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pricingrange { get; set; } 

        [JsonProperty("override_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Override_site_id { get; set; } 

        [JsonProperty("failcreaterequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Failcreaterequest { get; set; } 

        [JsonProperty("workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workdays { get; set; } 

        [JsonProperty("checkminutes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Checkminutes { get; set; } 

        [JsonProperty("failalwaysnewrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Failalwaysnewrequest { get; set; } 

        [JsonProperty("criticality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Criticality { get; set; } 

        [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Search_score { get; set; } 

        [JsonProperty("device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_id { get; set; } 

        [JsonProperty("override_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_site_name { get; set; } 

        [JsonProperty("override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Override { get; set; } 

        [JsonProperty("checkmon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checkmon { get; set; } 

        [JsonProperty("checktue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checktue { get; set; } 

        [JsonProperty("checkwed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checkwed { get; set; } 

        [JsonProperty("checkthu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checkthu { get; set; } 

        [JsonProperty("checkfri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checkfri { get; set; } 

        [JsonProperty("checksat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checksat { get; set; } 

        [JsonProperty("checksun", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checksun { get; set; } 

        [JsonProperty("servicekind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicekind { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("param1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Param1 { get; set; } 

        [JsonProperty("param2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Param2 { get; set; } 

        [JsonProperty("param3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Param3 { get; set; } 

        [JsonProperty("min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Min { get; set; } 

        [JsonProperty("max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Max { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("pop3serverid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pop3serverid { get; set; } 

        [JsonProperty("pop3serverid_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pop3serverid_name { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Body { get; set; } 

        [JsonProperty("fromaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fromaddr { get; set; } 

        [JsonProperty("toaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Toaddr { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("oksubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oksubject { get; set; } 

        [JsonProperty("okbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Okbody { get; set; } 

        [JsonProperty("okfromaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Okfromaddr { get; set; } 

        [JsonProperty("oktoaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oktoaddr { get; set; } 

        [JsonProperty("okany", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Okany { get; set; } 

        [JsonProperty("failsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Failsubject { get; set; } 

        [JsonProperty("failbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Failbody { get; set; } 

        [JsonProperty("failfromaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Failfromaddr { get; set; } 

        [JsonProperty("failtoaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Failtoaddr { get; set; } 

        [JsonProperty("failany", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Failany { get; set; } 

        [JsonProperty("wdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Wdid { get; set; } 

        [JsonProperty("cat2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cat2 { get; set; } 

        [JsonProperty("workdays_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workdays_name { get; set; } 

        [JsonProperty("photopath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Photopath { get; set; } 

        [JsonProperty("allowincidients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowincidients { get; set; } 

        [JsonProperty("allowoptin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowoptin { get; set; } 

        [JsonProperty("service_tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_tickettype_name { get; set; } 

        [JsonProperty("service_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_template_name { get; set; } 

        [JsonProperty("incident_tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Incident_tickettype_name { get; set; } 

        [JsonProperty("incident_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Incident_template_name { get; set; } 

        [JsonProperty("autoemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autoemail { get; set; } 

        [JsonProperty("servicedetailshtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicedetailshtml { get; set; } 

        [JsonProperty("alsosubscribe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Alsosubscribe { get; set; } 

        [JsonProperty("allowunsubscribe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowunsubscribe { get; set; } 

        [JsonProperty("allowservicerequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowservicerequests { get; set; } 

        [JsonProperty("userlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userlevel { get; set; } 

        [JsonProperty("showonmyservicespage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showonmyservicespage { get; set; } 

        [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_name { get; set; } 

        [JsonProperty("smsmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Smsmessage { get; set; } 

        [JsonProperty("servicerequestlbl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicerequestlbl { get; set; } 

        [JsonProperty("servicerequesthint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Servicerequesthint { get; set; } 

        [JsonProperty("incidentlbl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Incidentlbl { get; set; } 

        [JsonProperty("incidenthint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Incidenthint { get; set; } 

        [JsonProperty("allowall_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_category1 { get; set; } 

        [JsonProperty("allowed_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? Allowed_category1 { get; set; } 

        [JsonProperty("allowall_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_category2 { get; set; } 

        [JsonProperty("allowed_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? Allowed_category2 { get; set; } 

        [JsonProperty("allowall_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_category3 { get; set; } 

        [JsonProperty("allowed_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? Allowed_category3 { get; set; } 

        [JsonProperty("allowall_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_category4 { get; set; } 

        [JsonProperty("allowed_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? Allowed_category4 { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("unsubscribe_ticketortemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unsubscribe_ticketortemplate { get; set; } 

        [JsonProperty("unsubscribe_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unsubscribe_tickettype_id { get; set; } 

        [JsonProperty("unsubscribe_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unsubscribe_template_id { get; set; } 

        [JsonProperty("create_on_unsubscribe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_on_unsubscribe { get; set; } 

        [JsonProperty("unsubscribe_all", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unsubscribe_all { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_name { get; set; } 

        [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tickettype_name { get; set; } 

        [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Template_name { get; set; } 

        [JsonProperty("recent_servicerequest_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recent_servicerequest_count { get; set; } 

        [JsonProperty("recent_incident_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recent_incident_count { get; set; } 

        [JsonProperty("open_incident_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Open_incident_count { get; set; } 

        [JsonProperty("open_servicerequest_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Open_servicerequest_count { get; set; } 

        [JsonProperty("user_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServiceRestriction>? User_access { get; set; } 

        [JsonProperty("subscribers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServiceUser>? Subscribers { get; set; } 

        [JsonProperty("linked_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServiceLinks>? Linked_services { get; set; } 

        [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Assets { get; set; } 

        [JsonProperty("update_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_status { get; set; } 

        [JsonProperty("user_subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? User_subscribed { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Users? User { get; set; } 

        [JsonProperty("emailtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailtemplate { get; set; } 

        [JsonProperty("send_service_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Send_service_email { get; set; } 

        [JsonProperty("preview_service_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Preview_service_email { get; set; } 

        [JsonProperty("service_email_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_email_from { get; set; } 

        [JsonProperty("service_email_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_email_subject { get; set; } 

        [JsonProperty("service_email_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_email_html { get; set; } 

        [JsonProperty("allowfollowfault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowfollowfault { get; set; } 

        [JsonProperty("status_subscribedtoupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Status_subscribedtoupdates { get; set; } 

        [JsonProperty("unsubcount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unsubcount { get; set; } 

        [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_icon { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("showinrelatedservices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showinrelatedservices { get; set; } 

        [JsonProperty("user_canunsubscribe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? User_canunsubscribe { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("optional_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServiceOption>? Optional_services { get; set; } 

        [JsonProperty("isservicedetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isservicedetails { get; set; } 

        [JsonProperty("statushistoryportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Statushistoryportal { get; set; } 

        [JsonProperty("status_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServStatus>? Status_history { get; set; } 

        [JsonProperty("service_request_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServiceRequestDetails>? Service_request_details { get; set; } 

        [JsonProperty("device_child_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_child_id { get; set; } 

        [JsonProperty("device_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_count { get; set; } 

        [JsonProperty("incidentonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incidentonly { get; set; } 

        [JsonProperty("cat_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cat_phonenumber { get; set; } 

        [JsonProperty("kbs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KBEntry_List>? Kbs { get; set; } 

        [JsonProperty("search_index_sync_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Search_index_sync_timestamp { get; set; } 

        [JsonProperty("search_index_sync_batches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Search_index_sync_batches { get; set; } 

        [JsonProperty("preview_when_logging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Preview_when_logging { get; set; } 

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tag>? Tags { get; set; } 

        [JsonProperty("track_availability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Track_availability { get; set; } 

        [JsonProperty("tracking_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tracking_period { get; set; } 

        [JsonProperty("tracking_target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tracking_target { get; set; } 

        [JsonProperty("delay_avilability_calc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Delay_avilability_calc { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("relatedworkdayid_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Relatedworkdayid_name { get; set; } 

        [JsonProperty("relatedworkdayid_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Relatedworkdayid_content { get; set; } 

        [JsonProperty("status_message_update_internal_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_message_update_internal_html { get; set; } 

        [JsonProperty("status_message_update_public_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_message_update_public_html { get; set; } 

        [JsonProperty("future_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Int32NullableStringDateTimeNullableInt32NullableTuple>? Future_statuses { get; set; } 

        [JsonProperty("current_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Int32NullableStringDateTimeNullableInt32NullableDateTimeNullableTuple>? Current_statuses { get; set; } 

        [JsonProperty("service_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_url { get; set; } 

        [JsonProperty("incident_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Incident_url { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Link { get; set; } 

        [JsonProperty("tag_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tag_string { get; set; } 

        [JsonProperty("device_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Device_guid { get; set; } 

        [JsonProperty("device_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ServSite_List
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("showinusercatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showinusercatalog { get; set; } 

        [JsonProperty("showintechcatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showintechcatalog { get; set; } 

        [JsonProperty("trackstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trackstatus { get; set; } 

        [JsonProperty("service_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_category_id { get; set; } 

        [JsonProperty("service_category_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Service_category_guid { get; set; } 

        [JsonProperty("service_category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_category_name { get; set; } 

        [JsonProperty("business_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Business_owner_id { get; set; } 

        [JsonProperty("business_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner_name { get; set; } 

        [JsonProperty("business_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Business_owner_cab_id { get; set; } 

        [JsonProperty("business_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner_cab_name { get; set; } 

        [JsonProperty("technical_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technical_owner_id { get; set; } 

        [JsonProperty("technical_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Technical_owner_name { get; set; } 

        [JsonProperty("technical_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technical_owner_cab_id { get; set; } 

        [JsonProperty("technical_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Technical_owner_cab_name { get; set; } 

        [JsonProperty("compliance_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Compliance_owner_id { get; set; } 

        [JsonProperty("compliance_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Compliance_owner_name { get; set; } 

        [JsonProperty("compliance_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Compliance_owner_cab_id { get; set; } 

        [JsonProperty("compliance_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Compliance_owner_cab_name { get; set; } 

        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; } 

        [JsonProperty("estimated_delivery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Estimated_delivery { get; set; } 

        [JsonProperty("estimated_delivery_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Estimated_delivery_days { get; set; } 

        [JsonProperty("subscribable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Subscribable { get; set; } 

        [JsonProperty("subscriber_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Subscriber_count { get; set; } 

        [JsonProperty("asset_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_count { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_id { get; set; } 

        [JsonProperty("assettype_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_ids { get; set; } 

        [JsonProperty("current_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Current_status { get; set; } 

        [JsonProperty("status_message_update_internal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_message_update_internal { get; set; } 

        [JsonProperty("status_message_update_public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_message_update_public { get; set; } 

        [JsonProperty("using_default_public_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Using_default_public_message { get; set; } 

        [JsonProperty("status_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status_ticket_id { get; set; } 

        [JsonProperty("status_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Status_date { get; set; } 

        [JsonProperty("service_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_tickettype_id { get; set; } 

        [JsonProperty("serviceshownewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Serviceshownewreqscreen { get; set; } 

        [JsonProperty("service_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_template_id { get; set; } 

        [JsonProperty("newservicereqtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newservicereqtype { get; set; } 

        [JsonProperty("incident_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Incident_tickettype_id { get; set; } 

        [JsonProperty("incident_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Incident_template_id { get; set; } 

        [JsonProperty("newincidenttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newincidenttype { get; set; } 

        [JsonProperty("relatedworkdayid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Relatedworkdayid { get; set; } 

        [JsonProperty("status_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Status_end_date { get; set; } 

        [JsonProperty("status_ticket_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Status_ticket_start_date { get; set; } 

        [JsonProperty("status_ticket_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Status_ticket_end_date { get; set; } 

        [JsonProperty("requestdetails_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requestdetails_count { get; set; } 

        [JsonProperty("requestdetails_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requestdetails_id { get; set; } 

        [JsonProperty("requestdetail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requestdetail_url { get; set; } 

        [JsonProperty("requestdetail_shownewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Requestdetail_shownewreqscreen { get; set; } 

        [JsonProperty("requestdetail_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requestdetail_type { get; set; } 

        [JsonProperty("screenafterlogging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Screenafterlogging { get; set; } 

        [JsonProperty("pricingrange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pricingrange { get; set; } 

        [JsonProperty("override_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Override_site_id { get; set; } 

        [JsonProperty("failcreaterequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Failcreaterequest { get; set; } 

        [JsonProperty("workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workdays { get; set; } 

        [JsonProperty("checkminutes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Checkminutes { get; set; } 

        [JsonProperty("failalwaysnewrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Failalwaysnewrequest { get; set; } 

        [JsonProperty("criticality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Criticality { get; set; } 

        [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Search_score { get; set; } 

        [JsonProperty("device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("relatedworkdayid_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Relatedworkdayid_name { get; set; } 

        [JsonProperty("relatedworkdayid_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Relatedworkdayid_content { get; set; } 

        [JsonProperty("status_message_update_internal_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_message_update_internal_html { get; set; } 

        [JsonProperty("status_message_update_public_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_message_update_public_html { get; set; } 

        [JsonProperty("future_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Int32NullableStringDateTimeNullableInt32NullableTuple>? Future_statuses { get; set; } 

        [JsonProperty("current_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Int32NullableStringDateTimeNullableInt32NullableDateTimeNullableTuple>? Current_statuses { get; set; } 

        [JsonProperty("service_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_url { get; set; } 

        [JsonProperty("incident_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Incident_url { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Link { get; set; } 

        [JsonProperty("tag_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tag_string { get; set; } 

        [JsonProperty("device_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Device_guid { get; set; } 

        [JsonProperty("device_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ServStatus
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("message_internal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message_internal { get; set; } 

        [JsonProperty("message_public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message_public { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Who { get; set; } 

        [JsonProperty("lastcheck", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastcheck { get; set; } 

        [JsonProperty("lastok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastok { get; set; } 

        [JsonProperty("lastfailed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastfailed { get; set; } 

        [JsonProperty("okcount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Okcount { get; set; } 

        [JsonProperty("failedcount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Failedcount { get; set; } 

        [JsonProperty("lastemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastemail { get; set; } 

        [JsonProperty("totaldownmins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Totaldownmins { get; set; } 

        [JsonProperty("totaldowninstances", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Totaldowninstances { get; set; } 

        [JsonProperty("message_internal_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message_internal_html { get; set; } 

        [JsonProperty("message_public_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message_public_html { get; set; } 

        [JsonProperty("status_ticket_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Status_ticket_start_date { get; set; } 

        [JsonProperty("status_ticket_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Status_ticket_end_date { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Uniqueid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ServStatusSubscribe
    {
        [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_id { get; set; } 

        [JsonProperty("subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Subscribed { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ServiceAvailability
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service { get; set; } 

        [JsonProperty("service_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_desc { get; set; } 

        [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; } 

        [JsonProperty("percent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percent { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddate { get; set; } 

        [JsonProperty("totalhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Totalhours { get; set; } 

        [JsonProperty("downhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Downhours { get; set; } 

        [JsonProperty("targetmet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Targetmet { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ServiceCategory
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("userlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userlevel { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("important", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Important { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_icon { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_id { get; set; } 

        [JsonProperty("parent_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Parent_guid { get; set; } 

        [JsonProperty("parent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_name { get; set; } 

        [JsonProperty("grandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Grandparent_name { get; set; } 

        [JsonProperty("long_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Long_name { get; set; } 

        [JsonProperty("service_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_count { get; set; } 

        [JsonProperty("user_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServiceRestriction>? User_access { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phonenumber { get; set; } 

        [JsonProperty("portalbackgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? Portalbackgroundimageurl { get; set; } 

        [JsonProperty("portaldesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portaldesc { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ServiceLinks
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_id { get; set; } 

        [JsonProperty("linked_service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_service_id { get; set; } 

        [JsonProperty("linked_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Linked_service_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ServiceNowAction
    {
        [JsonProperty("sys_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sys_id { get; set; } 

        [JsonProperty("sys_created_on", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sys_created_on { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("element_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Element_id { get; set; } 

        [JsonProperty("sys_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sys_tags { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("sys_created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sys_created_by { get; set; } 

        [JsonProperty("element", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Element { get; set; } 

        [JsonProperty("halo_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_key { get; set; } 

        [JsonProperty("halo_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halo_client_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ServiceOption
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_id { get; set; } 

        [JsonProperty("optional_service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_service_id { get; set; } 

        [JsonProperty("optional_service_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Optional_service_guid { get; set; } 

        [JsonProperty("optional_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Optional_service_name { get; set; } 

        [JsonProperty("sequenceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequenceid { get; set; } 

        [JsonProperty("show_new_req_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_new_req_screen { get; set; } 

        [JsonProperty("mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatory { get; set; } 

        [JsonProperty("default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; } 

        [JsonProperty("expandeddefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expandeddefault { get; set; } 

        [JsonProperty("include", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include { get; set; } 

        [JsonProperty("servicerequestdetails_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicerequestdetails_id { get; set; } 

        [JsonProperty("optional_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_parent_id { get; set; } 

        [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_count { get; set; } 

        [JsonProperty("creation_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StdRequestRule>? Creation_rules { get; set; } 

        [JsonProperty("optional_service_name_short", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Optional_service_name_short { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ServiceRequestDetails
    {
        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("servicedetail_servsiteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicedetail_servsiteid { get; set; } 

        [JsonProperty("servicedetail_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicedetail_type { get; set; } 

        [JsonProperty("servicedetail_requesttypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicedetail_requesttypeid { get; set; } 

        [JsonProperty("servicedetail_requesttypeguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Servicedetail_requesttypeguid { get; set; } 

        [JsonProperty("servicedetail_requesttypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicedetail_requesttypename { get; set; } 

        [JsonProperty("servicedetail_templateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicedetail_templateid { get; set; } 

        [JsonProperty("servicedetail_templateguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Servicedetail_templateguid { get; set; } 

        [JsonProperty("servicedetail_templatename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicedetail_templatename { get; set; } 

        [JsonProperty("servicedetail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicedetail_url { get; set; } 

        [JsonProperty("servicedetail_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicedetail_label { get; set; } 

        [JsonProperty("servicedetail_hint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicedetail_hint { get; set; } 

        [JsonProperty("servicedetail_shownewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Servicedetail_shownewreqscreen { get; set; } 

        [JsonProperty("optional_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServiceOption>? Optional_services { get; set; } 

        [JsonProperty("sequenceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequenceid { get; set; } 

        [JsonProperty("servicedetail_longname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicedetail_longname { get; set; } 

        [JsonProperty("allow_all_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_all_items { get; set; } 

        [JsonProperty("allowed_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ItemRestriction>? Allowed_items { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("show_submission_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_submission_summary { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ServiceRestriction
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("service_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_category_id { get; set; } 

        [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("data_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Data_id { get; set; } 

        [JsonProperty("svrdata_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Svrdata_guid { get; set; } 

        [JsonProperty("data_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Data_name { get; set; } 

        [JsonProperty("service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_name { get; set; } 

        [JsonProperty("allow_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_access { get; set; } 

        [JsonProperty("data_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Data_string { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ServiceUser
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_id { get; set; } 

        [JsonProperty("service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("data_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Data_id { get; set; } 

        [JsonProperty("data_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Data_name { get; set; } 

        [JsonProperty("emailupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emailupdates { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SetupTab
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("subtitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subtitle { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; } 

        [JsonProperty("system_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? System_use { get; set; } 

        [JsonProperty("completed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Completed { get; set; } 

        [JsonProperty("article1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Article1 { get; set; } 

        [JsonProperty("article2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Article2 { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Group_name { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SharePointError
    {
        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; } 

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SharePointErrorMessage? Message { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SharePointErrorMessage
    {
        [JsonProperty("lang", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lang { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SharePointList
    {
        [JsonProperty("odata.error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SharePointError? OdataError { get; set; } 

        [JsonProperty("error_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Error_description { get; set; } 

        [JsonProperty("odata.metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OdataMetadata { get; set; } 

        [JsonProperty("odata.type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OdataType { get; set; } 

        [JsonProperty("odata.id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OdataId { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SharePointSite
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("siteId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SiteId { get; set; } 

        [JsonProperty("sitePath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SitePath { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ShopifyDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("shopname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Shopname { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_integration_method { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; } 

        [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _exchangecode { get; set; } 

        [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _disconnect { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Site
    {
        [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsid { get; set; } 

        [JsonProperty("accountsfirstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsfirstname { get; set; } 

        [JsonProperty("accountslastname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountslastname { get; set; } 

        [JsonProperty("accountsemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsemailaddress { get; set; } 

        [JsonProperty("accountsccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsccemailaddress { get; set; } 

        [JsonProperty("accountsbccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsbccemailaddress { get; set; } 

        [JsonProperty("sitephonenumberint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Sitephonenumberint { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clientsite_name { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sla_id { get; set; } 

        [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phonenumber { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Timezone { get; set; } 

        [JsonProperty("invoice_address_isdelivery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invoice_address_isdelivery { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("isstocklocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isstocklocation { get; set; } 

        [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Messagegroup_id { get; set; } 

        [JsonProperty("item_quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_quantity_in_stock { get; set; } 

        [JsonProperty("item_serialised_assets_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_serialised_assets_in_stock { get; set; } 

        [JsonProperty("item_quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_quantity_reserved { get; set; } 

        [JsonProperty("item_quantity_reserved_on_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_quantity_reserved_on_order { get; set; } 

        [JsonProperty("item_quantity_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_quantity_available { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datecreated { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Text { get; set; } 

        [JsonProperty("globx", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Globx { get; set; } 

        [JsonProperty("globy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Globy { get; set; } 

        [JsonProperty("style", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Style { get; set; } 

        [JsonProperty("inuseby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inuseby { get; set; } 

        [JsonProperty("upwho", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Upwho { get; set; } 

        [JsonProperty("uptimestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Uptimestamp { get; set; } 

        [JsonProperty("xrefsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Xrefsite { get; set; } 

        [JsonProperty("zoffsetx", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zoffsetx { get; set; } 

        [JsonProperty("zoffsety", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zoffsety { get; set; } 

        [JsonProperty("zoomx", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Zoomx { get; set; } 

        [JsonProperty("zoomy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Zoomy { get; set; } 

        [JsonProperty("smallx", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Smallx { get; set; } 

        [JsonProperty("smally", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Smally { get; set; } 

        [JsonProperty("bigx", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bigx { get; set; } 

        [JsonProperty("bigy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bigy { get; set; } 

        [JsonProperty("ldapstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ldapstring { get; set; } 

        [JsonProperty("emaildomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emaildomain { get; set; } 

        [JsonProperty("deliverby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Deliverby { get; set; } 

        [JsonProperty("isinvoicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isinvoicesite { get; set; } 

        [JsonProperty("refnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Refnumber { get; set; } 

        [JsonProperty("defaultdelivery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Defaultdelivery { get; set; } 

        [JsonProperty("seriousnesslevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seriousnesslevel { get; set; } 

        [JsonProperty("geocoord1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Geocoord1 { get; set; } 

        [JsonProperty("geocoord2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Geocoord2 { get; set; } 

        [JsonProperty("todomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Todomain { get; set; } 

        [JsonProperty("defaultstocklocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultstocklocation { get; set; } 

        [JsonProperty("stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stopped { get; set; } 

        [JsonProperty("sitetimeoffset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sitetimeoffset { get; set; } 

        [JsonProperty("sitedateformat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sitedateformat { get; set; } 

        [JsonProperty("disclaimermatchstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Disclaimermatchstring { get; set; } 

        [JsonProperty("emailsubjectprefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailsubjectprefix { get; set; } 

        [JsonProperty("regionaldirector", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Regionaldirector { get; set; } 

        [JsonProperty("facilitiesmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Facilitiesmanager { get; set; } 

        [JsonProperty("actguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Actguid { get; set; } 

        [JsonProperty("teamviewerpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamviewerpassword { get; set; } 

        [JsonProperty("contractlastchecked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Contractlastchecked { get; set; } 

        [JsonProperty("maincontact_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Maincontact_name { get; set; } 

        [JsonProperty("wildcardref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Wildcardref { get; set; } 

        [JsonProperty("monthlyreportlastrun", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Monthlyreportlastrun { get; set; } 

        [JsonProperty("monthlyreportinclude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Monthlyreportinclude { get; set; } 

        [JsonProperty("monthlyreportemailmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Monthlyreportemailmanager { get; set; } 

        [JsonProperty("accountmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accountmanagertech { get; set; } 

        [JsonProperty("monthlyreportemaildirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Monthlyreportemaildirect { get; set; } 

        [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Language_id { get; set; } 

        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Language_name { get; set; } 

        [JsonProperty("snowname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snowname { get; set; } 

        [JsonProperty("linked_organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_organisation_id { get; set; } 

        [JsonProperty("slocked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Slocked { get; set; } 

        [JsonProperty("newsite_contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newsite_contactname { get; set; } 

        [JsonProperty("newsite_contactemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newsite_contactemail { get; set; } 

        [JsonProperty("newsite_contacttitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newsite_contacttitle { get; set; } 

        [JsonProperty("newsite_web_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newsite_web_access_level { get; set; } 

        [JsonProperty("newsite_sendwelcomeemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newsite_sendwelcomeemail { get; set; } 

        [JsonProperty("delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Delivery_address { get; set; } 

        [JsonProperty("invoice_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Invoice_address { get; set; } 

        [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaPopup>? Popup_notes { get; set; } 

        [JsonProperty("_reassign_all_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _reassign_all_to_user { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FieldHelper>? Fields { get; set; } 

        [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Open_ticket_count { get; set; } 

        [JsonProperty("onhold_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Onhold_ticket_count { get; set; } 

        [JsonProperty("total_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_ticket_count { get; set; } 

        [JsonProperty("opened_thismonth_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Opened_thismonth_count { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Guid { get; set; } 

        [JsonProperty("sitecontacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SiteContact>? Sitecontacts { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("cautomateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cautomateid { get; set; } 

        [JsonProperty("ninjarmmid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninjarmmid { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("_isxero", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isxero { get; set; } 

        [JsonProperty("_match_first_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _match_first_site { get; set; } 

        [JsonProperty("servicenowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenowid { get; set; } 

        [JsonProperty("isnhserveremaildefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isnhserveremaildefault { get; set; } 

        [JsonProperty("device42id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device42id { get; set; } 

        [JsonProperty("datto_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_id { get; set; } 

        [JsonProperty("datto_alternate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datto_alternate_id { get; set; } 

        [JsonProperty("datto_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_url { get; set; } 

        [JsonProperty("connectwiseid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwiseid { get; set; } 

        [JsonProperty("azuretenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azuretenantid { get; set; } 

        [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autotaskid { get; set; } 

        [JsonProperty("pagerdutywildcard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutywildcard { get; set; } 

        [JsonProperty("ateraid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ateraid { get; set; } 

        [JsonProperty("slastupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Slastupdate { get; set; } 

        [JsonProperty("site_service_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_service_tax_code { get; set; } 

        [JsonProperty("site_prepay_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_prepay_tax_code { get; set; } 

        [JsonProperty("site_contract_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_contract_tax_code { get; set; } 

        [JsonProperty("site_item_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_item_tax_code_name { get; set; } 

        [JsonProperty("site_service_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_service_tax_code_name { get; set; } 

        [JsonProperty("site_contract_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_contract_tax_code_name { get; set; } 

        [JsonProperty("site_prepay_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_prepay_tax_code_name { get; set; } 

        [JsonProperty("site_sales_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_sales_tax_code { get; set; } 

        [JsonProperty("site_purchase_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_purchase_tax_code { get; set; } 

        [JsonProperty("site_purchase_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_purchase_tax_code_name { get; set; } 

        [JsonProperty("syncroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncroid { get; set; } 

        [JsonProperty("third_party_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_client_name { get; set; } 

        [JsonProperty("auvik_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_id { get; set; } 

        [JsonProperty("faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FAQListHead>? Faqlists { get; set; } 

        [JsonProperty("all_faqlists_allowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? All_faqlists_allowed { get; set; } 

        [JsonProperty("hubspot_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_id { get; set; } 

        [JsonProperty("passportal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Passportal_id { get; set; } 

        [JsonProperty("import_site_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Import_site_mapping { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("issitedetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Issitedetails { get; set; } 

        [JsonProperty("hudu_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hudu_url { get; set; } 

        [JsonProperty("liongardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongardid { get; set; } 

        [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseyaid { get; set; } 

        [JsonProperty("surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Surchargeid { get; set; } 

        [JsonProperty("country_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Country_code { get; set; } 

        [JsonProperty("region_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Region_code { get; set; } 

        [JsonProperty("stockbins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StockBin>? Stockbins { get; set; } 

        [JsonProperty("ncentral_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ncentral_details_id { get; set; } 

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

        [JsonProperty("hasitemsinstock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hasitemsinstock { get; set; } 

        [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dont_fire_automations { get; set; } 

        [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sqlimport_id { get; set; } 

        [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Matching_value { get; set; } 

        [JsonProperty("lapsafe_default_installation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lapsafe_default_installation_name { get; set; } 

        [JsonProperty("lapsafe_default_installation_obj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Lapsafe_default_installation_obj { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? External_links { get; set; } 

        [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tabname>? Extratabs { get; set; } 

        [JsonProperty("businesscentral_area_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Businesscentral_area_company_id { get; set; } 

        [JsonProperty("businesscentral_billing_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BusinessCentralCustomer? Businesscentral_billing_client { get; set; } 

        [JsonProperty("_convert_phonenumbers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _convert_phonenumbers { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("authrocket_locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Authrocket_locale { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("site_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FieldHelper>? Site_fields { get; set; } 

        [JsonProperty("gfisiteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Gfisiteid { get; set; } 

        [JsonProperty("delivery_address_line1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delivery_address_line1 { get; set; } 

        [JsonProperty("delivery_address_line2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delivery_address_line2 { get; set; } 

        [JsonProperty("delivery_address_line3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delivery_address_line3 { get; set; } 

        [JsonProperty("delivery_address_line4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delivery_address_line4 { get; set; } 

        [JsonProperty("delivery_address_line5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delivery_address_line5 { get; set; } 

        [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_id { get; set; } 

        [JsonProperty("client_itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_itglue_id { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stockbin_id { get; set; } 

        [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stockbin_name { get; set; } 

        [JsonProperty("country_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Country_code_name { get; set; } 

        [JsonProperty("region_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Region_code_name { get; set; } 

        [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ref { get; set; } 

        [JsonProperty("lapsafe_default_installation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lapsafe_default_installation { get; set; } 

        [JsonProperty("maincontact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Maincontact_id { get; set; } 

        [JsonProperty("site_item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_item_tax_code { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SiteContact
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site { get; set; } 

        [JsonProperty("uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Uid { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("user_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_email { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Site_List
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clientsite_name { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sla_id { get; set; } 

        [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phonenumber { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Timezone { get; set; } 

        [JsonProperty("invoice_address_isdelivery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invoice_address_isdelivery { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("isstocklocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isstocklocation { get; set; } 

        [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Messagegroup_id { get; set; } 

        [JsonProperty("item_quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_quantity_in_stock { get; set; } 

        [JsonProperty("item_serialised_assets_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_serialised_assets_in_stock { get; set; } 

        [JsonProperty("item_quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_quantity_reserved { get; set; } 

        [JsonProperty("item_quantity_reserved_on_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_quantity_reserved_on_order { get; set; } 

        [JsonProperty("item_quantity_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_quantity_available { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("site_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FieldHelper>? Site_fields { get; set; } 

        [JsonProperty("gfisiteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Gfisiteid { get; set; } 

        [JsonProperty("delivery_address_line1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delivery_address_line1 { get; set; } 

        [JsonProperty("delivery_address_line2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delivery_address_line2 { get; set; } 

        [JsonProperty("delivery_address_line3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delivery_address_line3 { get; set; } 

        [JsonProperty("delivery_address_line4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delivery_address_line4 { get; set; } 

        [JsonProperty("delivery_address_line5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delivery_address_line5 { get; set; } 

        [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_id { get; set; } 

        [JsonProperty("client_itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_itglue_id { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stockbin_id { get; set; } 

        [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stockbin_name { get; set; } 

        [JsonProperty("country_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Country_code_name { get; set; } 

        [JsonProperty("region_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Region_code_name { get; set; } 

        [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ref { get; set; } 

        [JsonProperty("lapsafe_default_installation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lapsafe_default_installation { get; set; } 

        [JsonProperty("maincontact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Maincontact_id { get; set; } 

        [JsonProperty("site_item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_item_tax_code { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlaHead
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("hoursaretechslocaltime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hoursaretechslocaltime { get; set; } 

        [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workday_id { get; set; } 

        [JsonProperty("workday_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Workday_guid { get; set; } 

        [JsonProperty("responsereset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Responsereset { get; set; } 

        [JsonProperty("autoreleaseoption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autoreleaseoption { get; set; } 

        [JsonProperty("workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Workdays? Workdays { get; set; } 

        [JsonProperty("priorities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Policy>? Priorities { get; set; } 

        [JsonProperty("response_reset_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Response_reset_approval { get; set; } 

        [JsonProperty("autoreleaselimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autoreleaselimit { get; set; } 

        [JsonProperty("trackslaresponsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trackslaresponsetime { get; set; } 

        [JsonProperty("trackslafixbytime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trackslafixbytime { get; set; } 

        [JsonProperty("statusafterautorelease", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Statusafterautorelease { get; set; } 

        [JsonProperty("slstatusafterfirstwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slstatusafterfirstwarning { get; set; } 

        [JsonProperty("slstatusaftersecondwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slstatusaftersecondwarning { get; set; } 

        [JsonProperty("workday_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workday_name { get; set; } 

        [JsonProperty("dontsendholdreminders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontsendholdreminders { get; set; } 

        [JsonProperty("statusafterautorelease_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Statusafterautorelease_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackActionResult
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("block_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Block_id { get; set; } 

        [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_id { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("action_ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_ts { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackBlock
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("block_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Block_id { get; set; } 

        [JsonProperty("optional", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Optional { get; set; } 

        [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackBlockText? Label { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackBlockText? Text { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SlackBlockText>? Fields { get; set; } 

        [JsonProperty("elements", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SlackBlockElement>? Elements { get; set; } 

        [JsonProperty("element", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackBlockElement? Element { get; set; } 

        [JsonProperty("accessory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackBlockAccessory? Accessory { get; set; } 

        [JsonProperty("dispatch_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dispatch_action { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackBlockAccessory
    {
        [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("min_query_length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Min_query_length { get; set; } 

        [JsonProperty("placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackBlockText? Placeholder { get; set; } 

        [JsonProperty("initial_option", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackOption? Initial_option { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackBlockElement
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackBlockText? Text { get; set; } 

        [JsonProperty("style", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Style { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_id { get; set; } 

        [JsonProperty("multiline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multiline { get; set; } 

        [JsonProperty("initial_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Initial_value { get; set; } 

        [JsonProperty("is_decimal_allowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_decimal_allowed { get; set; } 

        [JsonProperty("dispatch_action_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackBlockElementDispatchActionConfig? Dispatch_action_config { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackBlockElementDispatchActionConfig
    {
        [JsonProperty("trigger_actions_on", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Trigger_actions_on { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackBlockText
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("emoji", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emoji { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackChannel
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("is_private", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_private { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackCommandDetail
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackCommandType? Type { get; set; } 

        [JsonProperty("application", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WorkspaceApplication? Application { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackServiceUser? User { get; set; } 

        [JsonProperty("attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object?>? Attributes { get; set; } 

        [JsonProperty("webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackWebhook? Webhook { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum SlackCommandType
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

        _3 = 3,

        _4 = 4,

        _5 = 5,

        _6 = 6,

        _7 = 7,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("teamname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamname { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("webhookurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhookurl { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Channel_id { get; set; } 

        [JsonProperty("allow_ticket_create", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_ticket_create { get; set; } 

        [JsonProperty("ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_type { get; set; } 

        [JsonProperty("ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_type_name { get; set; } 

        [JsonProperty("_getoauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getoauthtoken { get; set; } 

        [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oauth_code { get; set; } 

        [JsonProperty("oauth_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oauth_redirect { get; set; } 

        [JsonProperty("scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Scopes { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_id { get; set; } 

        [JsonProperty("ticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_user { get; set; } 

        [JsonProperty("ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_user_name { get; set; } 

        [JsonProperty("command_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Command_ticket_type { get; set; } 

        [JsonProperty("command_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Command_ticket_type_name { get; set; } 

        [JsonProperty("command_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Command_user { get; set; } 

        [JsonProperty("command_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Command_user_name { get; set; } 

        [JsonProperty("uninstalled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Uninstalled { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackEvent
    {
        [JsonProperty("client_msg_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_msg_id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User { get; set; } 

        [JsonProperty("ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ts { get; set; } 

        [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team { get; set; } 

        [JsonProperty("channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Channel { get; set; } 

        [JsonProperty("event_ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Event_ts { get; set; } 

        [JsonProperty("channel_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Channel_type { get; set; } 

        [JsonProperty("blocks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SlackBlock>? Blocks { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum SlackEventType
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

        _3 = 3,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackEventWebhook
    {
        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Token { get; set; } 

        [JsonProperty("challenge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Challenge { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("event_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Event_id { get; set; } 

        [JsonProperty("event_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Event_time { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_id { get; set; } 

        [JsonProperty("context_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Context_team_id { get; set; } 

        [JsonProperty("context_enterprise_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Context_enterprise_id { get; set; } 

        [JsonProperty("api_app_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Api_app_id { get; set; } 

        [JsonProperty("is_ext_shared_channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_ext_shared_channel { get; set; } 

        [JsonProperty("event", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackEvent? Event { get; set; } 

        [JsonProperty("eventtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackEventType? Eventtype { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackFile
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("url_private", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url_private { get; set; } 

        [JsonProperty("url_private_download", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url_private_download { get; set; } 

        [JsonProperty("permalink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Permalink { get; set; } 

        [JsonProperty("permalink_public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Permalink_public { get; set; } 

        [JsonProperty("is_public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_public { get; set; } 

        [JsonProperty("is_external", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_external { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackInteractivity
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Token { get; set; } 

        [JsonProperty("action_ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_ts { get; set; } 

        [JsonProperty("api_app_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Api_app_id { get; set; } 

        [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackTeam? Team { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackUser? User { get; set; } 

        [JsonProperty("channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackChannel? Channel { get; set; } 

        [JsonProperty("is_enterprise_install", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_enterprise_install { get; set; } 

        [JsonProperty("callback_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Callback_id { get; set; } 

        [JsonProperty("trigger_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Trigger_id { get; set; } 

        [JsonProperty("response_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Response_url { get; set; } 

        [JsonProperty("message_ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message_ts { get; set; } 

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackMessage? Message { get; set; } 

        [JsonProperty("view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackView? View { get; set; } 

        [JsonProperty("actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SlackActionResult>? Actions { get; set; } 

        [JsonProperty("detail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackCommandDetail? Detail { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackMessage
    {
        [JsonProperty("client_msg_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_msg_id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User { get; set; } 

        [JsonProperty("ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ts { get; set; } 

        [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team { get; set; } 

        [JsonProperty("channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Channel { get; set; } 

        [JsonProperty("bot_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bot_id { get; set; } 

        [JsonProperty("app_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? App_id { get; set; } 

        [JsonProperty("bot_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackUser? Bot_profile { get; set; } 

        [JsonProperty("files", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SlackFile>? Files { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackOption
    {
        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackBlockText? Text { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackServiceUser
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; } 

        [JsonProperty("database_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Database_id { get; set; } 

        [JsonProperty("workspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workspace_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_id { get; set; } 

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email { get; set; } 

        [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Token_expiry { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackTeam
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domain { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackUser
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("real_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Real_name { get; set; } 

        [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackView
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("callback_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Callback_id { get; set; } 

        [JsonProperty("private_metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Private_metadata { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewText? Title { get; set; } 

        [JsonProperty("submit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewText? Submit { get; set; } 

        [JsonProperty("blocks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SlackViewBlock>? Blocks { get; set; } 

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewState? State { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackViewBlock
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("block_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Block_id { get; set; } 

        [JsonProperty("optional", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Optional { get; set; } 

        [JsonProperty("element", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewBlockElement? Element { get; set; } 

        [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewText? Label { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewText? Text { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackViewBlockElement
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_id { get; set; } 

        [JsonProperty("multiline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multiline { get; set; } 

        [JsonProperty("initial_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Initial_value { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackViewState
    {
        [JsonProperty("values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewStateValues? Values { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackViewStateStatusField
    {
        [JsonProperty("search_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewStateValuesDropdownInput? Search_status { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackViewStateValues
    {
        [JsonProperty("summary_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewStateValuesInput? Summary_input { get; set; } 

        [JsonProperty("details_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewStateValuesInput? Details_input { get; set; } 

        [JsonProperty("note_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewStateValuesInput? Note_input { get; set; } 

        [JsonProperty("ticket_id_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewStateValuesInput? Ticket_id_input { get; set; } 

        [JsonProperty("status_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewStateStatusField? Status_input { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackViewStateValuesDropdownInput
    {
        [JsonProperty("external_select", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? External_select { get; set; } 

        [JsonProperty("selected_option", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackOption? Selected_option { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackViewStateValuesInput
    {
        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SlackViewValue? Value { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackViewText
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackViewValue
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SlackWebhook
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Channel_id { get; set; } 

        [JsonProperty("view_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? View_id { get; set; } 

        [JsonProperty("response_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Response_url { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SnelStartWebhook
    {
        [JsonProperty("koppelSleutel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KoppelSleutel { get; set; } 

        [JsonProperty("actionType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionType { get; set; } 

        [JsonProperty("referenceKey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReferenceKey { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SnipeITDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_integration_key { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_integration_method { get; set; } 

        [JsonProperty("toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Toplevel { get; set; } 

        [JsonProperty("toplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Toplevel_name { get; set; } 

        [JsonProperty("default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_devicesite { get; set; } 

        [JsonProperty("default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_devicesite_name { get; set; } 

        [JsonProperty("default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_devicetype { get; set; } 

        [JsonProperty("default_devicetypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_devicetypename { get; set; } 

        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetimportidentifier { get; set; } 

        [JsonProperty("assetimportidentifier_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetimportidentifier_fieldname { get; set; } 

        [JsonProperty("snipeit_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Snipeit_fieldmappings { get; set; } 

        [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableintegrator { get; set; } 

        [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastsyncdate { get; set; } 

        [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastsyncerror { get; set; } 

        [JsonProperty("halo_integrator_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_integrator_import_list { get; set; } 

        [JsonProperty("halo_integrator_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Halo_integrator_import_types { get; set; } 

        [JsonProperty("delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delete_devices { get; set; } 

        [JsonProperty("dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_create_new_devices { get; set; } 

        [JsonProperty("dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_update_device_type { get; set; } 

        [JsonProperty("dont_move_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_move_site { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("client_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Client_links { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Mappings_xtype { get; set; } 

        [JsonProperty("default_assetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_assetgroup { get; set; } 

        [JsonProperty("default_assetgroupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_assetgroupname { get; set; } 

        [JsonProperty("assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_choice { get; set; } 

        [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_field { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SnowComputerUserAbstract
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("customerId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("lastLogon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastLogon { get; set; } 

        [JsonProperty("fullName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FullName { get; set; } 

        [JsonProperty("updatedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedDate { get; set; } 

        [JsonProperty("updatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UpdatedBy { get; set; } 

        [JsonProperty("logonCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogonCount { get; set; } 

        [JsonProperty("userIsAccessible", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserIsAccessible { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SnowDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("sdpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sdpassword { get; set; } 

        [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_integration_key { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_integration_method { get; set; } 

        [JsonProperty("toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Toplevel { get; set; } 

        [JsonProperty("toplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Toplevel_name { get; set; } 

        [JsonProperty("default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_devicesite { get; set; } 

        [JsonProperty("default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_devicesite_name { get; set; } 

        [JsonProperty("default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_devicetype { get; set; } 

        [JsonProperty("default_devicetypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_devicetypename { get; set; } 

        [JsonProperty("user_matching_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_matching_type { get; set; } 

        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetimportidentifier { get; set; } 

        [JsonProperty("assetimportidentifier_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetimportidentifier_fieldname { get; set; } 

        [JsonProperty("snow_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Snow_fieldmappings { get; set; } 

        [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableintegrator { get; set; } 

        [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastsyncdate { get; set; } 

        [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastsyncerror { get; set; } 

        [JsonProperty("halo_integrator_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_integrator_import_list { get; set; } 

        [JsonProperty("halo_integrator_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Halo_integrator_import_types { get; set; } 

        [JsonProperty("delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delete_devices { get; set; } 

        [JsonProperty("dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_create_new_devices { get; set; } 

        [JsonProperty("dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_update_device_type { get; set; } 

        [JsonProperty("dont_move_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_move_site { get; set; } 

        [JsonProperty("dont_update_site_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_update_site_addresses { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("client_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Client_links { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SnowDevice
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("organization", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Organization { get; set; } 

        [JsonProperty("orgChecksum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OrgChecksum { get; set; } 

        [JsonProperty("manufacturer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Manufacturer { get; set; } 

        [JsonProperty("model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Model { get; set; } 

        [JsonProperty("operatingSystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OperatingSystem { get; set; } 

        [JsonProperty("operatingSystemServicePack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OperatingSystemServicePack { get; set; } 

        [JsonProperty("isVirtual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVirtual { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("ipAddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IpAddresses { get; set; } 

        [JsonProperty("lastScanDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastScanDate { get; set; } 

        [JsonProperty("updatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UpdatedBy { get; set; } 

        [JsonProperty("updatedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedDate { get; set; } 

        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domain { get; set; } 

        [JsonProperty("totalDiskSpace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDiskSpace { get; set; } 

        [JsonProperty("physicalMemory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PhysicalMemory { get; set; } 

        [JsonProperty("processorType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProcessorType { get; set; } 

        [JsonProperty("processorCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ProcessorCount { get; set; } 

        [JsonProperty("coreCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CoreCount { get; set; } 

        [JsonProperty("biosSerialNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BiosSerialNumber { get; set; } 

        [JsonProperty("hypervisorName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HypervisorName { get; set; } 

        [JsonProperty("mostFrequentUserId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MostFrequentUserId { get; set; } 

        [JsonProperty("mostRecentUserId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MostRecentUserId { get; set; } 

        [JsonProperty("hardware", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SnowHardware? Hardware { get; set; } 

        [JsonProperty("biosVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BiosVersion { get; set; } 

        [JsonProperty("biosDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BiosDate { get; set; } 

        [JsonProperty("numberOfProcessors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfProcessors { get; set; } 

        [JsonProperty("coresPerProcessor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CoresPerProcessor { get; set; } 

        [JsonProperty("physicalMemoryMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PhysicalMemoryMb { get; set; } 

        [JsonProperty("memorySlots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MemorySlots { get; set; } 

        [JsonProperty("memorySlotsAvailable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MemorySlotsAvailable { get; set; } 

        [JsonProperty("systemDiskSpaceMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SystemDiskSpaceMb { get; set; } 

        [JsonProperty("systemDiskSpaceAvailableMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SystemDiskSpaceAvailableMb { get; set; } 

        [JsonProperty("totalDiskSpaceMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDiskSpaceMb { get; set; } 

        [JsonProperty("totalDiskSpaceAvailableMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDiskSpaceAvailableMb { get; set; } 

        [JsonProperty("phoneNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } 

        [JsonProperty("mobileDeviceType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MobileDeviceType { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SnowHardware
    {
        [JsonProperty("biosSerialNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BiosSerialNumber { get; set; } 

        [JsonProperty("biosVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BiosVersion { get; set; } 

        [JsonProperty("biosDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BiosDate { get; set; } 

        [JsonProperty("processorType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProcessorType { get; set; } 

        [JsonProperty("numberOfProcessors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfProcessors { get; set; } 

        [JsonProperty("coresPerProcessor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CoresPerProcessor { get; set; } 

        [JsonProperty("physicalMemoryMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PhysicalMemoryMb { get; set; } 

        [JsonProperty("memorySlots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MemorySlots { get; set; } 

        [JsonProperty("memorySlotsAvailable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MemorySlotsAvailable { get; set; } 

        [JsonProperty("systemDiskSpaceMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SystemDiskSpaceMb { get; set; } 

        [JsonProperty("systemDiskSpaceAvailableMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SystemDiskSpaceAvailableMb { get; set; } 

        [JsonProperty("totalDiskSpaceMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDiskSpaceMb { get; set; } 

        [JsonProperty("totalDiskSpaceAvailableMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDiskSpaceAvailableMb { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SnowLicenseAbstract
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("applicationName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApplicationName { get; set; } 

        [JsonProperty("manufacturerName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ManufacturerName { get; set; } 

        [JsonProperty("metric", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Metric { get; set; } 

        [JsonProperty("assignmentType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AssignmentType { get; set; } 

        [JsonProperty("purchaseDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PurchaseDate { get; set; } 

        [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; } 

        [JsonProperty("isIncomplete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIncomplete { get; set; } 

        [JsonProperty("updatedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedDate { get; set; } 

        [JsonProperty("updatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UpdatedBy { get; set; } 

        [JsonProperty("snowDevices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SnowDevice>? SnowDevices { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SqlLookupRequest
    {
        [JsonProperty("connection_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connection_name { get; set; } 

        [JsonProperty("sql_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_string { get; set; } 

        [JsonProperty("db_params", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringObjectDbTypeTuple>? Db_params { get; set; } 

        [JsonProperty("filookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filookup { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StdRequest
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domain { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Restriction_type { get; set; } 

        [JsonProperty("restrictto_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restrictto_department_id { get; set; } 

        [JsonProperty("restrictto_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Restrictto_department_name { get; set; } 

        [JsonProperty("restrictto_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restrictto_team_id { get; set; } 

        [JsonProperty("restrictto_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Restrictto_team_name { get; set; } 

        [JsonProperty("restrictto_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restrictto_agent_id { get; set; } 

        [JsonProperty("restrictto_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Restrictto_agent_name { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettype_id { get; set; } 

        [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_count { get; set; } 

        [JsonProperty("creation_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StdRequestRule>? Creation_rules { get; set; } 

        [JsonProperty("todo_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<STDToDo>? Todo_list { get; set; } 

        [JsonProperty("emailto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailto { get; set; } 

        [JsonProperty("emailcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailcc { get; set; } 

        [JsonProperty("emailbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailbcc { get; set; } 

        [JsonProperty("emailsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailsubject { get; set; } 

        [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Time { get; set; } 

        [JsonProperty("disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; } 

        [JsonProperty("lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastcreated { get; set; } 

        [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextcreationdate { get; set; } 

        [JsonProperty("nextcreationdate_after_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextcreationdate_after_end { get; set; } 

        [JsonProperty("execution_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Execution_type { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; } 

        [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; } 

        [JsonProperty("create_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_locked { get; set; } 

        [JsonProperty("one_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? One_ticket_id { get; set; } 

        [JsonProperty("created_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Created_ticket_id { get; set; } 

        [JsonProperty("approval_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_id { get; set; } 

        [JsonProperty("reportarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reportarea { get; set; } 

        [JsonProperty("reportarea_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reportarea_name { get; set; } 

        [JsonProperty("users_can_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Users_can_use { get; set; } 

        [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority_id { get; set; } 

        [JsonProperty("estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Estimate { get; set; } 

        [JsonProperty("category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_1 { get; set; } 

        [JsonProperty("category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_2 { get; set; } 

        [JsonProperty("category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_3 { get; set; } 

        [JsonProperty("category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_4 { get; set; } 

        [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status_id { get; set; } 

        [JsonProperty("status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Status_guid { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("details_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details_html { get; set; } 

        [JsonProperty("clearance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clearance { get; set; } 

        [JsonProperty("workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workflow_id { get; set; } 

        [JsonProperty("workflow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Workflow_guid { get; set; } 

        [JsonProperty("workflow_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workflow_name { get; set; } 

        [JsonProperty("approval_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approval_name { get; set; } 

        [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showforusers { get; set; } 

        [JsonProperty("excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Excludefromsla { get; set; } 

        [JsonProperty("defaultresourcetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultresourcetype { get; set; } 

        [JsonProperty("defaultresourcetype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultresourcetype_name { get; set; } 

        [JsonProperty("informlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Informlevel { get; set; } 

        [JsonProperty("scheduletype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Scheduletype { get; set; } 

        [JsonProperty("dom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dom { get; set; } 

        [JsonProperty("mon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mon { get; set; } 

        [JsonProperty("tue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tue { get; set; } 

        [JsonProperty("wed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Wed { get; set; } 

        [JsonProperty("thu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Thu { get; set; } 

        [JsonProperty("fri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fri { get; set; } 

        [JsonProperty("sat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sat { get; set; } 

        [JsonProperty("sun", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sun { get; set; } 

        [JsonProperty("year", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Year { get; set; } 

        [JsonProperty("_clearlastrun", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _clearlastrun { get; set; } 

        [JsonProperty("daysplus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Daysplus { get; set; } 

        [JsonProperty("every", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Every { get; set; } 

        [JsonProperty("reportid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reportid { get; set; } 

        [JsonProperty("impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Impact { get; set; } 

        [JsonProperty("urgency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Urgency { get; set; } 

        [JsonProperty("reportperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reportperiod { get; set; } 

        [JsonProperty("reportsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reportsite { get; set; } 

        [JsonProperty("repeat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Repeat { get; set; } 

        [JsonProperty("toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Toplevel { get; set; } 

        [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Report_id { get; set; } 

        [JsonProperty("emailbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailbody { get; set; } 

        [JsonProperty("kbid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kbid { get; set; } 

        [JsonProperty("did", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Did { get; set; } 

        [JsonProperty("yeargapvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Yeargapvalue { get; set; } 

        [JsonProperty("graph", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Graph { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Table { get; set; } 

        [JsonProperty("csv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Csv { get; set; } 

        [JsonProperty("json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Json { get; set; } 

        [JsonProperty("prompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prompt { get; set; } 

        [JsonProperty("promptproceed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Promptproceed { get; set; } 

        [JsonProperty("pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pdf { get; set; } 

        [JsonProperty("sendifempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendifempty { get; set; } 

        [JsonProperty("copied_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Copied_from_id { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Assets { get; set; } 

        [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Users_List>? Users { get; set; } 

        [JsonProperty("itil_request_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itil_request_type { get; set; } 

        [JsonProperty("create_on_nonworkdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_on_nonworkdays { get; set; } 

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_id { get; set; } 

        [JsonProperty("webhook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhook_id { get; set; } 

        [JsonProperty("creationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Creationtype { get; set; } 

        [JsonProperty("parentticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parentticketid { get; set; } 

        [JsonProperty("kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kb_id { get; set; } 

        [JsonProperty("kb_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kb_name { get; set; } 

        [JsonProperty("kb_accessible_for_enduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kb_accessible_for_enduser { get; set; } 

        [JsonProperty("forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forwardinboundupdates { get; set; } 

        [JsonProperty("enable_budget_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_budget_table { get; set; } 

        [JsonProperty("budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<STDrequestbudget>? Budgets { get; set; } 

        [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Budgettype_id { get; set; } 

        [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Budgettype_name { get; set; } 

        [JsonProperty("emailcclist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailcclist { get; set; } 

        [JsonProperty("services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServSite_List>? Services { get; set; } 

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _canupdate { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("updateparent_status_close", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Updateparent_status_close { get; set; } 

        [JsonProperty("updateparent_target_create", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Updateparent_target_create { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("clone_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clone_parent_id { get; set; } 

        [JsonProperty("increasecontractnextcalldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Increasecontractnextcalldate { get; set; } 

        [JsonProperty("makeinactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Makeinactive { get; set; } 

        [JsonProperty("_queue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _queue { get; set; } 

        [JsonProperty("_sendnow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _sendnow { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("automationcriteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AutoassignCriteria>? Automationcriteria { get; set; } 

        [JsonProperty("isclone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isclone { get; set; } 

        [JsonProperty("showforusers_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Showforusers_int { get; set; } 

        [JsonProperty("forwardinboundupdates_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Forwardinboundupdates_int { get; set; } 

        [JsonProperty("excludefromsla_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Excludefromsla_int { get; set; } 

        [JsonProperty("start_num_days_added", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Start_num_days_added { get; set; } 

        [JsonProperty("target_num_days_added", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Target_num_days_added { get; set; } 

        [JsonProperty("milestones", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MileStone>? Milestones { get; set; } 

        [JsonProperty("sqltoselectusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sqltoselectusers { get; set; } 

        [JsonProperty("usersqllookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Usersqllookup { get; set; } 

        [JsonProperty("notification_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Notification_id { get; set; } 

        [JsonProperty("additional_agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultAdditionalAgents>? Additional_agents { get; set; } 

        [JsonProperty("new_audits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Audit>? New_audits { get; set; } 

        [JsonProperty("new_changes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceChange>? New_changes { get; set; } 

        [JsonProperty("child_count_of_ticket_to_save", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child_count_of_ticket_to_save { get; set; } 

        [JsonProperty("ticket_id_to_save", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id_to_save { get; set; } 

        [JsonProperty("create_child_templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_child_templates { get; set; } 

        [JsonProperty("ticket_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_template { get; set; } 

        [JsonProperty("ticket_template_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Ticket_template_guid { get; set; } 

        [JsonProperty("ticket_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_template_name { get; set; } 

        [JsonProperty("enable_task_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_task_dependencies { get; set; } 

        [JsonProperty("date_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StdrequestDateDependencies>? Date_dependencies { get; set; } 

        [JsonProperty("upload_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Upload_type { get; set; } 

        [JsonProperty("integration_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integration_details_id { get; set; } 

        [JsonProperty("integration_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_details_name { get; set; } 

        [JsonProperty("integration_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integration_mapping { get; set; } 

        [JsonProperty("integration_mapping_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_mapping_name { get; set; } 

        [JsonProperty("integration_folder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_folder { get; set; } 

        [JsonProperty("overwrite_files", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Overwrite_files { get; set; } 

        [JsonProperty("create_for_user_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Create_for_user_type { get; set; } 

        [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sla_id { get; set; } 

        [JsonProperty("restrictto_department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Restrictto_department_guid { get; set; } 

        [JsonProperty("restrictto_team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Restrictto_team_guid { get; set; } 

        [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clients { get; set; } 

        [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Tickettype_guid { get; set; } 

        [JsonProperty("automationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automationtype { get; set; } 

        [JsonProperty("optionalservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optionalservice { get; set; } 

        [JsonProperty("optional_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_agent_id { get; set; } 

        [JsonProperty("optional_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Optional_team { get; set; } 

        [JsonProperty("optional_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_status_id { get; set; } 

        [JsonProperty("optional_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_tickettype_id { get; set; } 

        [JsonProperty("optional_create_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Optional_create_locked { get; set; } 

        [JsonProperty("optional_defaultresourcetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_defaultresourcetype { get; set; } 

        [JsonProperty("optional_excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_excludefromsla { get; set; } 

        [JsonProperty("optional_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Optional_customfields { get; set; } 

        [JsonProperty("optional_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Optional_assets { get; set; } 

        [JsonProperty("optional_forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_forwardinboundupdates { get; set; } 

        [JsonProperty("optional_showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_showforusers { get; set; } 

        [JsonProperty("optional_urgency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_urgency { get; set; } 

        [JsonProperty("optional_impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_impact { get; set; } 

        [JsonProperty("optional_workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_workflow_id { get; set; } 

        [JsonProperty("optional_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Optional_estimate { get; set; } 

        [JsonProperty("optional_category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Optional_category_1 { get; set; } 

        [JsonProperty("optional_category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Optional_category_2 { get; set; } 

        [JsonProperty("optional_category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Optional_category_3 { get; set; } 

        [JsonProperty("optional_category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Optional_category_4 { get; set; } 

        [JsonProperty("optional_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_priority_id { get; set; } 

        [JsonProperty("optional_budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_budgettype_id { get; set; } 

        [JsonProperty("optional_kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_kb_id { get; set; } 

        [JsonProperty("optional_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_service { get; set; } 

        [JsonProperty("optional_service_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_service_details_id { get; set; } 

        [JsonProperty("service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service { get; set; } 

        [JsonProperty("optional_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_sla_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StdRequestRule
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("parent_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_template_id { get; set; } 

        [JsonProperty("child_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child_template_id { get; set; } 

        [JsonProperty("usage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Usage { get; set; } 

        [JsonProperty("rule_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_type { get; set; } 

        [JsonProperty("createonchildclose_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Createonchildclose_id { get; set; } 

        [JsonProperty("createonchildclose_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Createonchildclose_name { get; set; } 

        [JsonProperty("working_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Working_days { get; set; } 

        [JsonProperty("outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Outcome_id { get; set; } 

        [JsonProperty("outcome_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Outcome_name { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("field_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_value { get; set; } 

        [JsonProperty("field_value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_value_string { get; set; } 

        [JsonProperty("field_contains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_contains { get; set; } 

        [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_name { get; set; } 

        [JsonProperty("approvalstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approvalstatus { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("optionalservice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optionalservice_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StdRequest_List
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domain { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Restriction_type { get; set; } 

        [JsonProperty("restrictto_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restrictto_department_id { get; set; } 

        [JsonProperty("restrictto_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Restrictto_department_name { get; set; } 

        [JsonProperty("restrictto_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restrictto_team_id { get; set; } 

        [JsonProperty("restrictto_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Restrictto_team_name { get; set; } 

        [JsonProperty("restrictto_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restrictto_agent_id { get; set; } 

        [JsonProperty("restrictto_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Restrictto_agent_name { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettype_id { get; set; } 

        [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_count { get; set; } 

        [JsonProperty("creation_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StdRequestRule>? Creation_rules { get; set; } 

        [JsonProperty("todo_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<STDToDo>? Todo_list { get; set; } 

        [JsonProperty("emailto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailto { get; set; } 

        [JsonProperty("emailcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailcc { get; set; } 

        [JsonProperty("emailbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailbcc { get; set; } 

        [JsonProperty("emailsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailsubject { get; set; } 

        [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Time { get; set; } 

        [JsonProperty("disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; } 

        [JsonProperty("lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastcreated { get; set; } 

        [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextcreationdate { get; set; } 

        [JsonProperty("nextcreationdate_after_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextcreationdate_after_end { get; set; } 

        [JsonProperty("execution_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Execution_type { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; } 

        [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; } 

        [JsonProperty("create_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_locked { get; set; } 

        [JsonProperty("one_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? One_ticket_id { get; set; } 

        [JsonProperty("created_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Created_ticket_id { get; set; } 

        [JsonProperty("approval_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_id { get; set; } 

        [JsonProperty("reportarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reportarea { get; set; } 

        [JsonProperty("reportarea_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reportarea_name { get; set; } 

        [JsonProperty("restrictto_department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Restrictto_department_guid { get; set; } 

        [JsonProperty("restrictto_team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Restrictto_team_guid { get; set; } 

        [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clients { get; set; } 

        [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Tickettype_guid { get; set; } 

        [JsonProperty("automationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automationtype { get; set; } 

        [JsonProperty("optionalservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optionalservice { get; set; } 

        [JsonProperty("optional_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_agent_id { get; set; } 

        [JsonProperty("optional_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Optional_team { get; set; } 

        [JsonProperty("optional_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_status_id { get; set; } 

        [JsonProperty("optional_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_tickettype_id { get; set; } 

        [JsonProperty("optional_create_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Optional_create_locked { get; set; } 

        [JsonProperty("optional_defaultresourcetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_defaultresourcetype { get; set; } 

        [JsonProperty("optional_excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_excludefromsla { get; set; } 

        [JsonProperty("optional_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Optional_customfields { get; set; } 

        [JsonProperty("optional_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Optional_assets { get; set; } 

        [JsonProperty("optional_forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_forwardinboundupdates { get; set; } 

        [JsonProperty("optional_showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_showforusers { get; set; } 

        [JsonProperty("optional_urgency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_urgency { get; set; } 

        [JsonProperty("optional_impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_impact { get; set; } 

        [JsonProperty("optional_workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_workflow_id { get; set; } 

        [JsonProperty("optional_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Optional_estimate { get; set; } 

        [JsonProperty("optional_category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Optional_category_1 { get; set; } 

        [JsonProperty("optional_category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Optional_category_2 { get; set; } 

        [JsonProperty("optional_category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Optional_category_3 { get; set; } 

        [JsonProperty("optional_category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Optional_category_4 { get; set; } 

        [JsonProperty("optional_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_priority_id { get; set; } 

        [JsonProperty("optional_budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_budgettype_id { get; set; } 

        [JsonProperty("optional_kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_kb_id { get; set; } 

        [JsonProperty("optional_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_service { get; set; } 

        [JsonProperty("optional_service_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_service_details_id { get; set; } 

        [JsonProperty("service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service { get; set; } 

        [JsonProperty("optional_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Optional_sla_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StdrequestDateDependencies
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("parenttemplateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parenttemplateid { get; set; } 

        [JsonProperty("childtemplateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Childtemplateid { get; set; } 

        [JsonProperty("child_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Child_template_name { get; set; } 

        [JsonProperty("dependentchildtemplateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dependentchildtemplateid { get; set; } 

        [JsonProperty("dependent_child_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dependent_child_template_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StockBin
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("dont_add_to_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_add_to_order { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StreamOneIonDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Account_id { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Import_entities { get; set; } 

        [JsonProperty("top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Top_level { get; set; } 

        [JsonProperty("update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_addresses { get; set; } 

        [JsonProperty("halointegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_lastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_lasterror { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Client_mappings { get; set; } 

        [JsonProperty("top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Top_level_name { get; set; } 

        [JsonProperty("import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Import_entities_list { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StringObjectDbTypeTuple
    {
        [JsonProperty("item1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item1 { get; set; } 

        [JsonProperty("item2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Item2 { get; set; } 

        [JsonProperty("item3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DbType? Item3 { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StringStringValuesKeyValuePair
    {
        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Value { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StripeCreatePortalSession
    {
        [JsonProperty("customerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customerid { get; set; } 

        [JsonProperty("returnurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Returnurl { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StripeItem
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StripePaymentIntentCreateRequest
    {
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StripeItem>? Items { get; set; } 

        [JsonProperty("cardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cardid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StripePaymentMethod
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("hint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hint { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StripeUpdateInvoicePaymentRequest
    {
        [JsonProperty("payment_intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Payment_intent { get; set; } 

        [JsonProperty("payment_intent_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Payment_intent_client_secret { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class StripeWebhookEndpoint
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("_object", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _object { get; set; } 

        [JsonProperty("created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Created { get; set; } 

        [JsonProperty("enabled_events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Enabled_events { get; set; } 

        [JsonProperty("livemode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Livemode { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SubscriptionQuantityChange
    {
        [JsonProperty("licence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licence_id { get; set; } 

        [JsonProperty("current_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Current_quantity { get; set; } 

        [JsonProperty("new_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_quantity { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Supplier
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SupplierOrderDetail
    {
        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sort_seq { get; set; } 

        [JsonProperty("productcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Productcode { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("quantity_received", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_received { get; set; } 

        [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchaseorder_id { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_id { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_id { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("isgroupdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isgroupdesc { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_id { get; set; } 

        [JsonProperty("salesorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_line_id { get; set; } 

        [JsonProperty("sales_order_stock_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sales_order_stock_location { get; set; } 

        [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_internal_reference { get; set; } 

        [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_external_reference { get; set; } 

        [JsonProperty("item_min_purchase_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_min_purchase_qty { get; set; } 

        [JsonProperty("xero_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_line_id { get; set; } 

        [JsonProperty("item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_code { get; set; } 

        [JsonProperty("accounts_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accounts_code { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("line_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Line_site_id { get; set; } 

        [JsonProperty("qbo_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_line_id { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hideitems { get; set; } 

        [JsonProperty("invoiceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoiceid { get; set; } 

        [JsonProperty("asset_type_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Asset_type_matching_field_name { get; set; } 

        [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Serialise_only_one { get; set; } 

        [JsonProperty("synced_to_intacct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Synced_to_intacct { get; set; } 

        [JsonProperty("intacct_warehouse_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_warehouse_id { get; set; } 

        [JsonProperty("intacct_location_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_location_id { get; set; } 

        [JsonProperty("intacct_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_department_id { get; set; } 

        [JsonProperty("_create_invoice_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? _create_invoice_percentage { get; set; } 

        [JsonProperty("percentage_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percentage_invoiced { get; set; } 

        [JsonProperty("invoiced_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Invoiced_quantity { get; set; } 

        [JsonProperty("myob_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Myob_location { get; set; } 

        [JsonProperty("myob_row_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Myob_row_id { get; set; } 

        [JsonProperty("entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Entity_type { get; set; } 

        [JsonProperty("item_dont_receive_on_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_dont_receive_on_po { get; set; } 

        [JsonProperty("net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Net_total { get; set; } 

        [JsonProperty("total_tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax_converted { get; set; } 

        [JsonProperty("tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax_converted { get; set; } 

        [JsonProperty("quote_line_distributor_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? Quote_line_distributor_external_link { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

        [JsonProperty("date_received", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_received { get; set; } 

        [JsonProperty("override_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Override_tax_code { get; set; } 

        [JsonProperty("baseprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Baseprice_converted { get; set; } 

        [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Baseprice { get; set; } 

        [JsonProperty("total_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax { get; set; } 

        [JsonProperty("total_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price { get; set; } 

        [JsonProperty("total_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_discount { get; set; } 

        [JsonProperty("conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Conversion_rate { get; set; } 

        [JsonProperty("discount_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Discount_converted { get; set; } 

        [JsonProperty("net_amount_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Net_amount_converted { get; set; } 

        [JsonProperty("total_price_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_converted { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tax_name { get; set; } 

        [JsonProperty("taxRuleResult", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TaxRuleResult>? TaxRuleResult { get; set; } 

        [JsonProperty("decimalplacesforinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Decimalplacesforinvoices { get; set; } 

        [JsonProperty("total_net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_net_total { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SupplierOrderHeader
    {
        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("po_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Po_ref { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("datesent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datesent { get; set; } 

        [JsonProperty("carriage_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Carriage_desc { get; set; } 

        [JsonProperty("carriage_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Carriage_price { get; set; } 

        [JsonProperty("auth_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auth_by { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; } 

        [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_id { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("goodsin_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Goodsin_status { get; set; } 

        [JsonProperty("3rd_party_ponumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _3rd_party_ponumber { get; set; } 

        [JsonProperty("date_published", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_published { get; set; } 

        [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_status { get; set; } 

        [JsonProperty("approval_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approval_start { get; set; } 

        [JsonProperty("assigned_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assigned_agent { get; set; } 

        [JsonProperty("assigned_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assigned_agent_name { get; set; } 

        [JsonProperty("approvalagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approvalagent { get; set; } 

        [JsonProperty("approvalemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvalemailaddress { get; set; } 

        [JsonProperty("approvalnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvalnote { get; set; } 

        [JsonProperty("approvalagentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approvalagentid { get; set; } 

        [JsonProperty("approvaldatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Approvaldatetime { get; set; } 

        [JsonProperty("thirdparty_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Thirdparty_status { get; set; } 

        [JsonProperty("accounts_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accounts_ref { get; set; } 

        [JsonProperty("deliver_to_us", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deliver_to_us { get; set; } 

        [JsonProperty("deliver_to_so_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deliver_to_so_address { get; set; } 

        [JsonProperty("deliver_to_ticket_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deliver_to_ticket_address { get; set; } 

        [JsonProperty("delivery_backup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Delivery_backup { get; set; } 

        [JsonProperty("est_delivery_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Est_delivery_date { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_id { get; set; } 

        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Currency { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? User { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("cost_centre_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cost_centre_id { get; set; } 

        [JsonProperty("cost_centre_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cost_centre_name { get; set; } 

        [JsonProperty("ticket_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_summary { get; set; } 

        [JsonProperty("ticket_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_note { get; set; } 

        [JsonProperty("attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Attachment_id { get; set; } 

        [JsonProperty("lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SupplierOrderDetail>? Lines { get; set; } 

        [JsonProperty("add_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SupplierOrderDetail>? Add_lines { get; set; } 

        [JsonProperty("_validateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _validateonly { get; set; } 

        [JsonProperty("_print_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _print_preview { get; set; } 

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

        [JsonProperty("createdbyagentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Createdbyagentname { get; set; } 

        [JsonProperty("xero_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_id { get; set; } 

        [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_tenant_id { get; set; } 

        [JsonProperty("xero_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_status { get; set; } 

        [JsonProperty("last_synced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_synced { get; set; } 

        [JsonProperty("last_update_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_update_time { get; set; } 

        [JsonProperty("requires_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Requires_approval { get; set; } 

        [JsonProperty("below_approval_minimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Below_approval_minimum { get; set; } 

        [JsonProperty("approval_for_below_minimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approval_for_below_minimum { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("so_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? So_assets { get; set; } 

        [JsonProperty("warrantyurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warrantyurl { get; set; } 

        [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_company_id { get; set; } 

        [JsonProperty("qbo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbo_id { get; set; } 

        [JsonProperty("_iscopy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _iscopy { get; set; } 

        [JsonProperty("_create_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _create_invoice { get; set; } 

        [JsonProperty("_create_invoice_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _create_invoice_method { get; set; } 

        [JsonProperty("_create_invoice_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? _create_invoice_percentage { get; set; } 

        [JsonProperty("_create_invoice_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SupplierOrderDetail>? _create_invoice_lines { get; set; } 

        [JsonProperty("_return_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _return_invoice { get; set; } 

        [JsonProperty("percentage_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percentage_invoiced { get; set; } 

        [JsonProperty("invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceHeader>? Invoices { get; set; } 

        [JsonProperty("invoice_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_count { get; set; } 

        [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_save_location { get; set; } 

        [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Currency_code { get; set; } 

        [JsonProperty("currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Currency_code_name { get; set; } 

        [JsonProperty("currency_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Currency_conversion_rate { get; set; } 

        [JsonProperty("duedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Duedate { get; set; } 

        [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_class { get; set; } 

        [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_class_name { get; set; } 

        [JsonProperty("suppliers_order_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Suppliers_order_reference { get; set; } 

        [JsonProperty("_create_invoice_invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? _create_invoice_invoice_date { get; set; } 

        [JsonProperty("deladdress1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress1 { get; set; } 

        [JsonProperty("deladdress2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress2 { get; set; } 

        [JsonProperty("deladdress3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress3 { get; set; } 

        [JsonProperty("deladdress4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress4 { get; set; } 

        [JsonProperty("deladdress5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress5 { get; set; } 

        [JsonProperty("delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Delivery_address { get; set; } 

        [JsonProperty("_forcethirdpartysync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _forcethirdpartysync { get; set; } 

        [JsonProperty("_create_invoice_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? _create_invoice_amount { get; set; } 

        [JsonProperty("_create_invoice_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? _create_invoice_qty { get; set; } 

        [JsonProperty("_create_invoice_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _create_invoice_line_description { get; set; } 

        [JsonProperty("_ticket_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _ticket_access { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("is_po_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_po_screen { get; set; } 

        [JsonProperty("avalara_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Avalara_details_id { get; set; } 

        [JsonProperty("avalara_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Avalara_details_name { get; set; } 

        [JsonProperty("_purchasing_run", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _purchasing_run { get; set; } 

        [JsonProperty("_novalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _novalidate { get; set; } 

        [JsonProperty("_dodistributorsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dodistributorsync { get; set; } 

        [JsonProperty("originaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Originaddress { get; set; } 

        [JsonProperty("originaddress1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress1 { get; set; } 

        [JsonProperty("originaddress2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress2 { get; set; } 

        [JsonProperty("originaddress3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress3 { get; set; } 

        [JsonProperty("originaddress4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress4 { get; set; } 

        [JsonProperty("originaddress5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress5 { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tabname>? Extratabs { get; set; } 

        [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dont_fire_automations { get; set; } 

        [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_process_id { get; set; } 

        [JsonProperty("use_ticket_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_ticket_approval { get; set; } 

        [JsonProperty("new_approvalprocess_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_agent_id { get; set; } 

        [JsonProperty("new_approvalprocess_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_user_id { get; set; } 

        [JsonProperty("new_approvalprocess_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Users_List>? New_approvalprocess_users { get; set; } 

        [JsonProperty("new_approvalprocess_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_approvalprocess_email { get; set; } 

        [JsonProperty("new_approvalprocess_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_cab_id { get; set; } 

        [JsonProperty("new_approvalprocess_cab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CabMember>? New_approvalprocess_cab { get; set; } 

        [JsonProperty("new_approvalprocess_role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_role_id { get; set; } 

        [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isbatch { get; set; } 

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Token { get; set; } 

        [JsonProperty("receipt_confirmed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Receipt_confirmed { get; set; } 

        [JsonProperty("receipt_confirmation_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Receipt_confirmation_date { get; set; } 

        [JsonProperty("_dotaxsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dotaxsync { get; set; } 

        [JsonProperty("tax_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax_total { get; set; } 

        [JsonProperty("revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Revenue { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? External_links { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importthirdpartyid { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SyncroAlert
    {
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Html { get; set; } 

        [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Link { get; set; } 

        [JsonProperty("attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SyncroAlertAttributes? Attributes { get; set; } 

        [JsonProperty("device_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device_name { get; set; } 

        [JsonProperty("customer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customer_name { get; set; } 

        [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_at { get; set; } 

        [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Updated_at { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customer_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SyncroAlertAsset
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SyncroAlertAttributes
    {
        [JsonProperty("properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SyncroAlertProperties? Properties { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customer_id { get; set; } 

        [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_at { get; set; } 

        [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Updated_at { get; set; } 

        [JsonProperty("customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SyncroCustomer? Customer { get; set; } 

        [JsonProperty("asset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SyncroAlertAsset? Asset { get; set; } 

        [JsonProperty("resolved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resolved { get; set; } 

        [JsonProperty("computer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Computer_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SyncroAlertProperties
    {
        [JsonProperty("device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_id { get; set; } 

        [JsonProperty("trigger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Trigger { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SyncroCustomer
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("firstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Firstname { get; set; } 

        [JsonProperty("lastname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastname { get; set; } 

        [JsonProperty("business_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_name { get; set; } 

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email { get; set; } 

        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phone { get; set; } 

        [JsonProperty("mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mobile { get; set; } 

        [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created_at { get; set; } 

        [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Updated_at { get; set; } 

        [JsonProperty("pdf_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pdf_url { get; set; } 

        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address { get; set; } 

        [JsonProperty("address_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address_2 { get; set; } 

        [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? City { get; set; } 

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? State { get; set; } 

        [JsonProperty("zip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zip { get; set; } 

        [JsonProperty("longitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Longitude { get; set; } 

        [JsonProperty("latitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Latitude { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("get_sms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Get_sms { get; set; } 

        [JsonProperty("opt_out", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Opt_out { get; set; } 

        [JsonProperty("disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; } 

        [JsonProperty("no_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? No_email { get; set; } 

        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Location_name { get; set; } 

        [JsonProperty("location_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Location_id { get; set; } 

        [JsonProperty("online_profile_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Online_profile_url { get; set; } 

        [JsonProperty("tax_rate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tax_rate_id { get; set; } 

        [JsonProperty("notification_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notification_email { get; set; } 

        [JsonProperty("invoice_cc_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_cc_emails { get; set; } 

        [JsonProperty("invoice_term_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_term_id { get; set; } 

        [JsonProperty("referred_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Referred_by { get; set; } 

        [JsonProperty("ref_customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ref_customer_id { get; set; } 

        [JsonProperty("business_and_full_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_and_full_name { get; set; } 

        [JsonProperty("business_then_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_then_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SynnexDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_id { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Client_mappings { get; set; } 

        [JsonProperty("import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Import_entities { get; set; } 

        [JsonProperty("toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Toplevel { get; set; } 

        [JsonProperty("top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Top_level_name { get; set; } 

        [JsonProperty("update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_addresses { get; set; } 

        [JsonProperty("application_region", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Application_region { get; set; } 

        [JsonProperty("application_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Application_type { get; set; } 

        [JsonProperty("halointegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_lastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_lasterror { get; set; } 

        [JsonProperty("import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Import_entities_list { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }