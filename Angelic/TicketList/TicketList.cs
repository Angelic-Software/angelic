using System.CodeDom.Compiler;
using Angelic.Dtos;
using Newtonsoft.Json;

namespace Angelic.TicketList;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class TicketList
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("dateoccurred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateoccurred { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status_id { get; set; } 

        [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_name { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettype_id { get; set; } 

        [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tickettype_name { get; set; } 

        [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sla_id { get; set; } 

        [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sla_name { get; set; } 

        [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority_id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_1 { get; set; } 

        [JsonProperty("category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_2 { get; set; } 

        [JsonProperty("category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_3 { get; set; } 

        [JsonProperty("category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_4 { get; set; } 

        [JsonProperty("categoryid_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Categoryid_1 { get; set; } 

        [JsonProperty("categoryid_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Categoryid_2 { get; set; } 

        [JsonProperty("categoryid_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Categoryid_3 { get; set; } 

        [JsonProperty("categoryid_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Categoryid_4 { get; set; } 

        [JsonProperty("category_1_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_1_display { get; set; } 

        [JsonProperty("category_2_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_2_display { get; set; } 

        [JsonProperty("category_3_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_3_display { get; set; } 

        [JsonProperty("category_4_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_4_display { get; set; } 

        [JsonProperty("estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Estimate { get; set; } 

        [JsonProperty("estimatedays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Estimatedays { get; set; } 

        [JsonProperty("projecttimepercentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projecttimepercentage { get; set; } 

        [JsonProperty("projectcompletionpercentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projectcompletionpercentage { get; set; } 

        [JsonProperty("projectearlieststart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Projectearlieststart { get; set; } 

        [JsonProperty("projectlatestend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Projectlatestend { get; set; } 

        [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Timetaken { get; set; } 

        [JsonProperty("chargehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Chargehours { get; set; } 

        [JsonProperty("nonchargehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Nonchargehours { get; set; } 

        [JsonProperty("travelhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Travelhours { get; set; } 

        [JsonProperty("totalmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Totalmileage { get; set; } 

        [JsonProperty("itemsprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Itemsprice { get; set; } 

        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Items { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_id { get; set; } 

        [JsonProperty("child_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child_count { get; set; } 

        [JsonProperty("child_count_open", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child_count_open { get; set; } 

        [JsonProperty("attachment_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Attachment_count { get; set; } 

        [JsonProperty("flagged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Flagged { get; set; } 

        [JsonProperty("read", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Read { get; set; } 

        [JsonProperty("enduserstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Enduserstatus { get; set; } 

        [JsonProperty("onhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onhold { get; set; } 

        [JsonProperty("respondbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Respondbydate { get; set; } 

        [JsonProperty("responsedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Responsedate { get; set; } 

        [JsonProperty("first_responsedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? First_responsedate { get; set; } 

        [JsonProperty("responsestartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Responsestartdate { get; set; } 

        [JsonProperty("slaresponsestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slaresponsestate { get; set; } 

        [JsonProperty("fixbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Fixbydate { get; set; } 

        [JsonProperty("dateclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateclosed { get; set; } 

        [JsonProperty("dateassigned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateassigned { get; set; } 

        [JsonProperty("excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Excludefromsla { get; set; } 

        [JsonProperty("slaholdtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Slaholdtime { get; set; } 

        [JsonProperty("site_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_timezone { get; set; } 

        [JsonProperty("parentguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parentguid { get; set; } 

        [JsonProperty("parentassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Parentassign { get; set; } 

        [JsonProperty("slaactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Slaactiondate { get; set; } 

        [JsonProperty("slapercused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Slapercused { get; set; } 

        [JsonProperty("slatimeleft", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Slatimeleft { get; set; } 

        [JsonProperty("currentelapsedhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Currentelapsedhours { get; set; } 

        [JsonProperty("lastactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastactiondate { get; set; } 

        [JsonProperty("last_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_update { get; set; } 

        [JsonProperty("lastchildactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastchildactiondate { get; set; } 

        [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Organisation_id { get; set; } 

        [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Department_id { get; set; } 

        [JsonProperty("reportedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reportedby { get; set; } 

        [JsonProperty("user_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_email { get; set; } 

        [JsonProperty("emailtolist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailtolist { get; set; } 

        [JsonProperty("emailtolistsupplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailtolistsupplier { get; set; } 

        [JsonProperty("emailcclist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailcclist { get; set; } 

        [JsonProperty("emailcclistsupplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailcclistsupplier { get; set; } 

        [JsonProperty("matched_kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Matched_kb_id { get; set; } 

        [JsonProperty("release_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release_note { get; set; } 

        [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Product_id { get; set; } 

        [JsonProperty("product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Product_name { get; set; } 

        [JsonProperty("release_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Release_id { get; set; } 

        [JsonProperty("release_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release_name { get; set; } 

        [JsonProperty("release2_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Release2_id { get; set; } 

        [JsonProperty("release2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release2_name { get; set; } 

        [JsonProperty("release3_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Release3_id { get; set; } 

        [JsonProperty("release3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release3_name { get; set; } 

        [JsonProperty("child_ticket_id_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Child_ticket_id_string { get; set; } 

        [JsonProperty("asset_key_field_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Asset_key_field_string { get; set; } 

        [JsonProperty("asset_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Asset_type_name { get; set; } 

        [JsonProperty("workflow_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workflow_name { get; set; } 

        [JsonProperty("workflow_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workflow_stage { get; set; } 

        [JsonProperty("workflow_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workflow_stage_id { get; set; } 

        [JsonProperty("workflow_stage_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workflow_stage_number { get; set; } 

        [JsonProperty("lastincomingemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastincomingemail { get; set; } 

        [JsonProperty("child_ticket_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Child_ticket_ids { get; set; } 

        [JsonProperty("nextactivitydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextactivitydate { get; set; } 

        [JsonProperty("inventory_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Inventory_number { get; set; } 

        [JsonProperty("workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workflow_id { get; set; } 

        [JsonProperty("workflow_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workflow_step { get; set; } 

        [JsonProperty("workflow_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workflow_seq { get; set; } 

        [JsonProperty("pipeline_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pipeline_stage_id { get; set; } 

        [JsonProperty("pipeline_stage_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pipeline_stage_name { get; set; } 

        [JsonProperty("hasbeenclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hasbeenclosed { get; set; } 

        [JsonProperty("unread_child_action_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unread_child_action_count { get; set; } 

        [JsonProperty("unread_related_action_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unread_related_action_count { get; set; } 

        [JsonProperty("child_action_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child_action_count { get; set; } 

        [JsonProperty("parent_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_subject { get; set; } 

        [JsonProperty("related_action_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Related_action_count { get; set; } 

        [JsonProperty("is_vip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_vip { get; set; } 

        [JsonProperty("isimportantcontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimportantcontact { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Impact { get; set; } 

        [JsonProperty("urgency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Urgency { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("startdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Startdate_timezone { get; set; } 

        [JsonProperty("startdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeZone? Startdate_with_timezone { get; set; } 

        [JsonProperty("starttime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Starttime { get; set; } 

        [JsonProperty("starttimeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Starttimeslot { get; set; } 

        [JsonProperty("targetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Targetdate { get; set; } 

        [JsonProperty("targetdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Targetdate_timezone { get; set; } 

        [JsonProperty("targetdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeZone? Targetdate_with_timezone { get; set; } 

        [JsonProperty("targettime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Targettime { get; set; } 

        [JsonProperty("targettimeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Targettimeslot { get; set; } 

        [JsonProperty("deadlinedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Deadlinedate { get; set; } 

        [JsonProperty("followupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Followupdate { get; set; } 

        [JsonProperty("oppcontactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcontactname { get; set; } 

        [JsonProperty("oppcompanyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcompanyname { get; set; } 

        [JsonProperty("oppemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppemailaddress { get; set; } 

        [JsonProperty("oppcustomertitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcustomertitle { get; set; } 

        [JsonProperty("opptel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opptel { get; set; } 

        [JsonProperty("oppaddr1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppaddr1 { get; set; } 

        [JsonProperty("oppaddr2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppaddr2 { get; set; } 

        [JsonProperty("oppaddr3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppaddr3 { get; set; } 

        [JsonProperty("oppaddr4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppaddr4 { get; set; } 

        [JsonProperty("opppostcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opppostcode { get; set; } 

        [JsonProperty("oppcountry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcountry { get; set; } 

        [JsonProperty("oppregion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppregion { get; set; } 

        [JsonProperty("opptype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opptype { get; set; } 

        [JsonProperty("oppvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Oppvalue { get; set; } 

        [JsonProperty("oppvalue_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Oppvalue_monthly { get; set; } 

        [JsonProperty("oppvalue_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Oppvalue_annual { get; set; } 

        [JsonProperty("oppvalue_oneoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Oppvalue_oneoff { get; set; } 

        [JsonProperty("oppconversionprobability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Oppconversionprobability { get; set; } 

        [JsonProperty("oppvalueadjusted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Oppvalueadjusted { get; set; } 

        [JsonProperty("oppprofit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Oppprofit { get; set; } 

        [JsonProperty("oppcurrentsystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcurrentsystem { get; set; } 

        [JsonProperty("oppcompetitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcompetitors { get; set; } 

        [JsonProperty("opptrialdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Opptrialdate { get; set; } 

        [JsonProperty("oppdemodate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Oppdemodate { get; set; } 

        [JsonProperty("oppdiscountdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Oppdiscountdate { get; set; } 

        [JsonProperty("oppattemptsmade", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Oppattemptsmade { get; set; } 

        [JsonProperty("oppconverteddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Oppconverteddate { get; set; } 

        [JsonProperty("oppproductchosen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppproductchosen { get; set; } 

        [JsonProperty("oppreason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppreason { get; set; } 

        [JsonProperty("opphear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opphear { get; set; } 

        [JsonProperty("opptimezonename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opptimezonename { get; set; } 

        [JsonProperty("oppclosurecategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Oppclosurecategory { get; set; } 

        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; } 

        [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; } 

        [JsonProperty("projecttimebudget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projecttimebudget { get; set; } 

        [JsonProperty("projectmoneybudget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projectmoneybudget { get; set; } 

        [JsonProperty("projecttimeactual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projecttimeactual { get; set; } 

        [JsonProperty("projectmoneyactual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projectmoneyactual { get; set; } 

        [JsonProperty("lastnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastnote { get; set; } 

        [JsonProperty("userdef1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdef1 { get; set; } 

        [JsonProperty("userdef2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdef2 { get; set; } 

        [JsonProperty("userdef3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdef3 { get; set; } 

        [JsonProperty("userdef4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdef4 { get; set; } 

        [JsonProperty("userdef5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdef5 { get; set; } 

        [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Source { get; set; } 

        [JsonProperty("release_important", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Release_important { get; set; } 

        [JsonProperty("releasenotegroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Releasenotegroup_name { get; set; } 

        [JsonProperty("releasenotegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Releasenotegroup_id { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Third_party_id { get; set; } 

        [JsonProperty("third_party_id_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id_string { get; set; } 

        [JsonProperty("supplier_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_status { get; set; } 

        [JsonProperty("contract_refextra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contract_refextra { get; set; } 

        [JsonProperty("appointment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Appointment_type { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("timeentries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultsTimeEntry>? Timeentries { get; set; } 

        [JsonProperty("section_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Section_timezone { get; set; } 

        [JsonProperty("itilname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itilname { get; set; } 

        [JsonProperty("related_service_descriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Related_service_descriptions { get; set; } 

        [JsonProperty("related_service_category_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Related_service_category_names { get; set; } 

        [JsonProperty("projectinternaltask", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Projectinternaltask { get; set; } 

        [JsonProperty("appointment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Appointment_id { get; set; } 

        [JsonProperty("nextappointmentdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextappointmentdate { get; set; } 

        [JsonProperty("firstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Firstname { get; set; } 

        [JsonProperty("lastname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastname { get; set; } 

        [JsonProperty("connectedinstance_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectedinstance_id { get; set; } 

        [JsonProperty("web_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Web_url { get; set; } 

        [JsonProperty("api_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Api_url { get; set; } 

        [JsonProperty("action_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Action_number { get; set; } 

        [JsonProperty("action_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Action_ticket_id { get; set; } 

        [JsonProperty("action_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Action_datetime { get; set; } 

        [JsonProperty("action_outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_outcome { get; set; } 

        [JsonProperty("action_chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_chargerate { get; set; } 

        [JsonProperty("action_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_contract_ref { get; set; } 

        [JsonProperty("action_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_note { get; set; } 

        [JsonProperty("ticket_invoices_for_each_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticket_invoices_for_each_site { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_id { get; set; } 

        [JsonProperty("orderhead_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orderhead_id { get; set; } 

        [JsonProperty("budgettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Budgettype { get; set; } 

        [JsonProperty("requesttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requesttype_name { get; set; } 

        [JsonProperty("recalculate_billing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recalculate_billing { get; set; } 

        [JsonProperty("impactlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Impactlevel { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_id { get; set; } 

        [JsonProperty("pr_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pr_id { get; set; } 

        [JsonProperty("branch_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Branch_id { get; set; } 

        [JsonProperty("branch_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Branch_name { get; set; } 

        [JsonProperty("update_milestone_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Update_milestone_id { get; set; } 

        [JsonProperty("milestone_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Milestone_id { get; set; } 

        [JsonProperty("milestone_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Milestone_name { get; set; } 

        [JsonProperty("milestone_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Milestone_value { get; set; } 

        [JsonProperty("milestone_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Milestone_sequence { get; set; } 

        [JsonProperty("milestone_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Milestone_status { get; set; } 

        [JsonProperty("milestone_startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Milestone_startdate { get; set; } 

        [JsonProperty("milestone_enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Milestone_enddate { get; set; } 

        [JsonProperty("email_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_message_id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("reviewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reviewed { get; set; } 

        [JsonProperty("action_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_agent_name { get; set; } 

        [JsonProperty("merged_into_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Merged_into_id { get; set; } 

        [JsonProperty("reassigncount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reassigncount { get; set; } 

        [JsonProperty("parent_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_status { get; set; } 

        [JsonProperty("parent_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_agent { get; set; } 

        [JsonProperty("child_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child_status { get; set; } 

        [JsonProperty("date_fully_closed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_fully_closed { get; set; } 

        [JsonProperty("lastaction_chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastaction_chargerate { get; set; } 

        [JsonProperty("hover_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hover_summary { get; set; } 

        [JsonProperty("slatimeelapsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Slatimeelapsed { get; set; } 

        [JsonProperty("ai_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ai_summary { get; set; } 

        [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Search_score { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TableEnum? Table { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("canbevotedfor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canbevotedfor { get; set; } 

        [JsonProperty("supplier_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_reference { get; set; } 

        [JsonProperty("top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Top_level_name { get; set; } 

        [JsonProperty("isbeingclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isbeingclosed { get; set; } 

        [JsonProperty("maximumRestrictedPriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumRestrictedPriority { get; set; } 

        [JsonProperty("primary_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Primary_service_name { get; set; } 

        [JsonProperty("idsummary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Idsummary { get; set; } 

        [JsonProperty("scomclearance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scomclearance { get; set; } 

        [JsonProperty("scomalertid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scomalertid { get; set; } 

        [JsonProperty("statusseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Statusseq { get; set; } 

        [JsonProperty("statuscolor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Statuscolor { get; set; } 

        [JsonProperty("next_appointment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Next_appointment_type { get; set; } 

        [JsonProperty("account_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Account_manager { get; set; } 

        [JsonProperty("orionalert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionalert { get; set; } 

        [JsonProperty("orionnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orionnote { get; set; } 

        [JsonProperty("orionwho", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionwho { get; set; } 

        [JsonProperty("product_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Product_key { get; set; } 

        [JsonProperty("ticketage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Ticketage { get; set; } 

        [JsonProperty("ninja_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_id { get; set; } 

        [JsonProperty("teams_ticket_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_ticket_icon { get; set; } 

        [JsonProperty("lastactiondateteams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastactiondateteams { get; set; } 

        [JsonProperty("priority_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Priority_name { get; set; } 

        [JsonProperty("useful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Useful_count { get; set; } 

        [JsonProperty("notuseful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Notuseful_count { get; set; } 

        [JsonProperty("sitepostcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sitepostcode { get; set; } 

        [JsonProperty("mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailbox { get; set; } 

        [JsonProperty("userdepartments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdepartments { get; set; } 

        [JsonProperty("updateservicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Updateservicestatus { get; set; } 

        [JsonProperty("servicestatusnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicestatusnote { get; set; } 

        [JsonProperty("itil_requesttype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itil_requesttype_id { get; set; } 

        [JsonProperty("startdatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdatetime { get; set; } 

        [JsonProperty("enddatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddatetime { get; set; } 

        [JsonProperty("closure_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Closure_agent_id { get; set; } 

        [JsonProperty("closed_in_integration_system", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Closed_in_integration_system { get; set; } 

        [JsonProperty("newrelic_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newrelic_id { get; set; } 

        [JsonProperty("createdfromautomationstdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Createdfromautomationstdid { get; set; } 

        [JsonProperty("ticket_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_tags { get; set; } 

        [JsonProperty("status_change_frozen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Status_change_frozen { get; set; } 

        [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_status { get; set; } 

        [JsonProperty("opp_country_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opp_country_name { get; set; } 

        [JsonProperty("opp_region_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opp_region_name { get; set; } 

        [JsonProperty("invoiceseperatelyoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invoiceseperatelyoverride { get; set; } 

        [JsonProperty("purchaseordernumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchaseordernumber { get; set; } 

        [JsonProperty("overrideticketcost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Overrideticketcost { get; set; } 

        [JsonProperty("budgethours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Budgethours { get; set; } 

        [JsonProperty("created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Created_by { get; set; } 

        [JsonProperty("additional_agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultAdditionalAgents>? Additional_agents { get; set; } 

        [JsonProperty("client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_to_invoice_to_id { get; set; } 

        [JsonProperty("primary_issue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? Primary_issue { get; set; } 

        [JsonProperty("primary_workitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? Primary_workitem { get; set; } 

        [JsonProperty("billing_plan_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Billing_plan_text { get; set; } 

        [JsonProperty("default_appointment_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_appointment_summary { get; set; } 

        [JsonProperty("default_appointment_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_appointment_details { get; set; } 

        [JsonProperty("agent_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_signature { get; set; } 

        [JsonProperty("customer_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customer_signature { get; set; } 

        [JsonProperty("new_agent_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_agent_signature { get; set; } 

        [JsonProperty("new_customer_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_customer_signature { get; set; } 

        [JsonProperty("ticket_client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_client_to_invoice_to_id { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importthirdpartyid { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

    }