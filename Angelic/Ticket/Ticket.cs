using System.CodeDom.Compiler;
using Angelic.Dtos;
using Newtonsoft.Json;

namespace Angelic.TicketList;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Ticket
    {
        [JsonProperty("oppjobtitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppjobtitle { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("dateoccurred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Dateoccurred { get; set; } 

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
        public System.DateTimeOffset? Projectearlieststart { get; set; } 

        [JsonProperty("projectlatestend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Projectlatestend { get; set; } 

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
        public System.DateTimeOffset? Respondbydate { get; set; } 

        [JsonProperty("responsedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Responsedate { get; set; } 

        [JsonProperty("first_responsedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? First_responsedate { get; set; } 

        [JsonProperty("responsestartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Responsestartdate { get; set; } 

        [JsonProperty("slaresponsestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slaresponsestate { get; set; } 

        [JsonProperty("fixbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Fixbydate { get; set; } 

        [JsonProperty("dateclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Dateclosed { get; set; } 

        [JsonProperty("dateassigned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Dateassigned { get; set; } 

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
        public System.DateTimeOffset? Slaactiondate { get; set; } 

        [JsonProperty("slapercused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Slapercused { get; set; } 

        [JsonProperty("slatimeleft", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Slatimeleft { get; set; } 

        [JsonProperty("currentelapsedhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Currentelapsedhours { get; set; } 

        [JsonProperty("lastactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Lastactiondate { get; set; } 

        [JsonProperty("last_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Last_update { get; set; } 

        [JsonProperty("lastchildactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Lastchildactiondate { get; set; } 

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
        public System.DateTimeOffset? Lastincomingemail { get; set; } 

        [JsonProperty("child_ticket_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Child_ticket_ids { get; set; } 

        [JsonProperty("nextactivitydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Nextactivitydate { get; set; } 

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
        public System.DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("startdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Startdate_timezone { get; set; } 

        [JsonProperty("startdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeZone? Startdate_with_timezone { get; set; } 

        [JsonProperty("starttime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Starttime { get; set; } 

        [JsonProperty("starttimeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Starttimeslot { get; set; } 

        [JsonProperty("targetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Targetdate { get; set; } 

        [JsonProperty("targetdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Targetdate_timezone { get; set; } 

        [JsonProperty("targetdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeZone? Targetdate_with_timezone { get; set; } 

        [JsonProperty("targettime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Targettime { get; set; } 

        [JsonProperty("targettimeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Targettimeslot { get; set; } 

        [JsonProperty("deadlinedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Deadlinedate { get; set; } 

        [JsonProperty("followupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Followupdate { get; set; } 

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
        public System.DateTimeOffset? Opptrialdate { get; set; } 

        [JsonProperty("oppdemodate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Oppdemodate { get; set; } 

        [JsonProperty("oppdiscountdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Oppdiscountdate { get; set; } 

        [JsonProperty("oppattemptsmade", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Oppattemptsmade { get; set; } 

        [JsonProperty("oppconverteddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Oppconverteddate { get; set; } 

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
        public System.DateTimeOffset? Nextappointmentdate { get; set; } 

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
        public System.DateTimeOffset? Action_datetime { get; set; } 

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
        public System.DateTimeOffset? Milestone_startdate { get; set; } 

        [JsonProperty("milestone_enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Milestone_enddate { get; set; } 

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
        public System.DateTimeOffset? Date_fully_closed { get; set; } 

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

        [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phonenumber { get; set; } 

        [JsonProperty("details_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details_html { get; set; } 

        [JsonProperty("takenby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Takenby { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Datecreated { get; set; } 

        [JsonProperty("createdfrom_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Createdfrom_id { get; set; } 

        [JsonProperty("createdfrom_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Createdfrom_summary { get; set; } 

        [JsonProperty("clonedfrom_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clonedfrom_id { get; set; } 

        [JsonProperty("clonedfrom_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clonedfrom_summary { get; set; } 

        [JsonProperty("closure_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Closure_note { get; set; } 

        [JsonProperty("closure_note_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Closure_note_html { get; set; } 

        [JsonProperty("closure_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Closure_time { get; set; } 

        [JsonProperty("top_level_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Top_level_id { get; set; } 

        [JsonProperty("customer_relationships", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customer_relationships { get; set; } 

        [JsonProperty("asset_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_number { get; set; } 

        [JsonProperty("asset_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_site { get; set; } 

        [JsonProperty("slastate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slastate { get; set; } 

        [JsonProperty("slaexcuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slaexcuse { get; set; } 

        [JsonProperty("site_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_sla_id { get; set; } 

        [JsonProperty("client_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_reference { get; set; } 

        [JsonProperty("supplier_slaexcuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_slaexcuse { get; set; } 

        [JsonProperty("supplier_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Supplier_date { get; set; } 

        [JsonProperty("supplier_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_contract_id { get; set; } 

        [JsonProperty("supplier_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_contract_ref { get; set; } 

        [JsonProperty("supplier_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_sla_id { get; set; } 

        [JsonProperty("supplier_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_priority_id { get; set; } 

        [JsonProperty("supplier_responsestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_responsestate { get; set; } 

        [JsonProperty("supplier_responsedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Supplier_responsedate { get; set; } 

        [JsonProperty("supplier_responsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Supplier_responsetime { get; set; } 

        [JsonProperty("supplier_respondbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Supplier_respondbydate { get; set; } 

        [JsonProperty("supplier_slastate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_slastate { get; set; } 

        [JsonProperty("supplier_slatimeelapsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Supplier_slatimeelapsed { get; set; } 

        [JsonProperty("supplier_dateclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Supplier_dateclosed { get; set; } 

        [JsonProperty("supplier_fixbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Supplier_fixbydate { get; set; } 

        [JsonProperty("supplier_breachrespsent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Supplier_breachrespsent { get; set; } 

        [JsonProperty("supplier_breachfixbysent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Supplier_breachfixbysent { get; set; } 

        [JsonProperty("changestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Changestate { get; set; } 

        [JsonProperty("approvedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approvedby { get; set; } 

        [JsonProperty("showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showforusers { get; set; } 

        [JsonProperty("messsent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Messsent { get; set; } 

        [JsonProperty("satisfactionlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Satisfactionlevel { get; set; } 

        [JsonProperty("satisfactioncomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Satisfactioncomment { get; set; } 

        [JsonProperty("invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoicenumber { get; set; } 

        [JsonProperty("invoicenote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoicenote { get; set; } 

        [JsonProperty("invoicedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Invoicedate { get; set; } 

        [JsonProperty("invoicepaiddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Invoicepaiddate { get; set; } 

        [JsonProperty("nonbillable_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Nonbillable_time { get; set; } 

        [JsonProperty("mileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Mileage { get; set; } 

        [JsonProperty("planneddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Planneddate { get; set; } 

        [JsonProperty("ccaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ccaddress { get; set; } 

        [JsonProperty("agreedcleared", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Agreedcleared { get; set; } 

        [JsonProperty("responsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Responsetime { get; set; } 

        [JsonProperty("first_responsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? First_responsetime { get; set; } 

        [JsonProperty("alsoinform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alsoinform { get; set; } 

        [JsonProperty("justification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Justification { get; set; } 

        [JsonProperty("backoutplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Backoutplan { get; set; } 

        [JsonProperty("communicationplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Communicationplan { get; set; } 

        [JsonProperty("testplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Testplan { get; set; } 

        [JsonProperty("riskdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Riskdescription { get; set; } 

        [JsonProperty("risklevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Risklevel { get; set; } 

        [JsonProperty("impactdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Impactdescription { get; set; } 

        [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_id { get; set; } 

        [JsonProperty("isparentservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isparentservice { get; set; } 

        [JsonProperty("surveysent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Surveysent { get; set; } 

        [JsonProperty("planneddateend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Planneddateend { get; set; } 

        [JsonProperty("currentfaactionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Currentfaactionnumber { get; set; } 

        [JsonProperty("approval_process_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_process_step { get; set; } 

        [JsonProperty("approval_process_step_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approval_process_step_name { get; set; } 

        [JsonProperty("approval_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approval_cab_name { get; set; } 

        [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_process_id { get; set; } 

        [JsonProperty("faultcodeopen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultcodeopen { get; set; } 

        [JsonProperty("faultcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultcode { get; set; } 

        [JsonProperty("laststatus3rdparty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Laststatus3rdparty { get; set; } 

        [JsonProperty("inform3rdpartysystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inform3rdpartysystem { get; set; } 

        [JsonProperty("deliverycontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deliverycontact { get; set; } 

        [JsonProperty("delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Delivery_address { get; set; } 

        [JsonProperty("surveyneeded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Surveyneeded { get; set; } 

        [JsonProperty("knownerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Knownerror { get; set; } 

        [JsonProperty("development", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Development { get; set; } 

        [JsonProperty("causedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Causedby { get; set; } 

        [JsonProperty("messsentlast", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Messsentlast { get; set; } 

        [JsonProperty("unapprovedchangestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unapprovedchangestatus { get; set; } 

        [JsonProperty("changeseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Changeseq { get; set; } 

        [JsonProperty("lastrecurringemailsentdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Lastrecurringemailsentdate { get; set; } 

        [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Template_id { get; set; } 

        [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Template_name { get; set; } 

        [JsonProperty("child_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child_template_id { get; set; } 

        [JsonProperty("slaholdreminderdatelastemailed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Slaholdreminderdatelastemailed { get; set; } 

        [JsonProperty("closurereminderdatelastemailed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Closurereminderdatelastemailed { get; set; } 

        [JsonProperty("assetstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetstring { get; set; } 

        [JsonProperty("mailboxid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailboxid { get; set; } 

        [JsonProperty("alerttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alerttype { get; set; } 

        [JsonProperty("actisbillabledefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Actisbillabledefault { get; set; } 

        [JsonProperty("emaildisplayname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emaildisplayname { get; set; } 

        [JsonProperty("emailpriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailpriority { get; set; } 

        [JsonProperty("chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chargerate { get; set; } 

        [JsonProperty("timezonename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Timezonename { get; set; } 

        [JsonProperty("forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forwardinboundupdates { get; set; } 

        [JsonProperty("loggedoutofhdworkinghours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Loggedoutofhdworkinghours { get; set; } 

        [JsonProperty("acctmaninformedsurvey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Acctmaninformedsurvey { get; set; } 

        [JsonProperty("laststatuschangeinformed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Laststatuschangeinformed { get; set; } 

        [JsonProperty("gfialerttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gfialerttype { get; set; } 

        [JsonProperty("quotedescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Quotedescription { get; set; } 

        [JsonProperty("quotelabouramount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quotelabouramount { get; set; } 

        [JsonProperty("quotepriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotepriority { get; set; } 

        [JsonProperty("budgetcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Budgetcode { get; set; } 

        [JsonProperty("actualcost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Actualcost { get; set; } 

        [JsonProperty("invoicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoicestatus { get; set; } 

        [JsonProperty("invoicedescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoicedescription { get; set; } 

        [JsonProperty("invoicelabouramount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Invoicelabouramount { get; set; } 

        [JsonProperty("invoicematerialsamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Invoicematerialsamount { get; set; } 

        [JsonProperty("firsttimefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Firsttimefix { get; set; } 

        [JsonProperty("quotematerialsamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quotematerialsamount { get; set; } 

        [JsonProperty("ukasaccredited", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ukasaccredited { get; set; } 

        [JsonProperty("labno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Labno { get; set; } 

        [JsonProperty("twitterscreenname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twitterscreenname { get; set; } 

        [JsonProperty("twitterid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Twitterid { get; set; } 

        [JsonProperty("facebook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Facebook_id { get; set; } 

        [JsonProperty("fixbydateadjusted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fixbydateadjusted { get; set; } 

        [JsonProperty("loggedonbehalfby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Loggedonbehalfby { get; set; } 

        [JsonProperty("alternativecontactno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alternativecontactno { get; set; } 

        [JsonProperty("operationalserviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Operationalserviceid { get; set; } 

        [JsonProperty("requestdetailsprinted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Requestdetailsprinted { get; set; } 

        [JsonProperty("serviceformprinted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Serviceformprinted { get; set; } 

        [JsonProperty("auditstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auditstatus { get; set; } 

        [JsonProperty("auditunum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auditunum { get; set; } 

        [JsonProperty("auditdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Auditdate { get; set; } 

        [JsonProperty("auditnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auditnote { get; set; } 

        [JsonProperty("auditfaileddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Auditfaileddate { get; set; } 

        [JsonProperty("auditfailednote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auditfailednote { get; set; } 

        [JsonProperty("userrequestedapprover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userrequestedapprover { get; set; } 

        [JsonProperty("oppdontaddtomailinglist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Oppdontaddtomailinglist { get; set; } 

        [JsonProperty("sendprintrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sendprintrequest { get; set; } 

        [JsonProperty("pagerdutyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyid { get; set; } 

        [JsonProperty("pagerdutyincidentidstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyincidentidstring { get; set; } 

        [JsonProperty("pagerdutystatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagerdutystatus { get; set; } 

        [JsonProperty("pagerdutyurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyurl { get; set; } 

        [JsonProperty("pagerdutyincidentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyincidentid { get; set; } 

        [JsonProperty("opportunity_third_party_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opportunity_third_party_url { get; set; } 

        [JsonProperty("pr_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pr_link { get; set; } 

        [JsonProperty("github_repository", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Github_repository { get; set; } 

        [JsonProperty("component_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Component_id { get; set; } 

        [JsonProperty("component_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Component_name { get; set; } 

        [JsonProperty("version_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Version_id { get; set; } 

        [JsonProperty("version_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Version_name { get; set; } 

        [JsonProperty("mailentryid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailentryid { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_id { get; set; } 

        [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contract_ref { get; set; } 

        [JsonProperty("billing_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Billing_address { get; set; } 

        [JsonProperty("workflow_stepstarted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Workflow_stepstarted { get; set; } 

        [JsonProperty("lessonslearned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lessonslearned { get; set; } 

        [JsonProperty("laststatuschangeinformedmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Laststatuschangeinformedmanager { get; set; } 

        [JsonProperty("lastbugzillasync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Lastbugzillasync { get; set; } 

        [JsonProperty("sapid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sapid { get; set; } 

        [JsonProperty("sapattachmentsuuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sapattachmentsuuid { get; set; } 

        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Currency { get; set; } 

        [JsonProperty("projectconsignmentheaderid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Projectconsignmentheaderid { get; set; } 

        [JsonProperty("projectconsignmentdetailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Projectconsignmentdetailid { get; set; } 

        [JsonProperty("servicefailurestid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicefailurestid { get; set; } 

        [JsonProperty("hdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hdid { get; set; } 

        [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; } 

        [JsonProperty("matched_rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Matched_rule_id { get; set; } 

        [JsonProperty("matched_rule_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Matched_rule_name { get; set; } 

        [JsonProperty("matched_rule_dont_show_notification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matched_rule_dont_show_notification { get; set; } 

        [JsonProperty("ignore_kb_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignore_kb_match { get; set; } 

        [JsonProperty("deadlinenotificationhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Deadlinenotificationhours { get; set; } 

        [JsonProperty("asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_type { get; set; } 

        [JsonProperty("showonroadmap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showonroadmap { get; set; } 

        [JsonProperty("roadmapnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Roadmapnote { get; set; } 

        [JsonProperty("phonenumberfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phonenumberfrom { get; set; } 

        [JsonProperty("addressfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addressfrom { get; set; } 

        [JsonProperty("changeinformation_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Changeinformation_html { get; set; } 

        [JsonProperty("team_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Team_department_id { get; set; } 

        [JsonProperty("sendack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendack { get; set; } 

        [JsonProperty("newaction_emailfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newaction_emailfrom { get; set; } 

        [JsonProperty("newaction_emailfrom_address_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newaction_emailfrom_address_override { get; set; } 

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _canupdate { get; set; } 

        [JsonProperty("_mustupdateticketuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _mustupdateticketuser { get; set; } 

        [JsonProperty("_spam", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _spam { get; set; } 

        [JsonProperty("_spamblock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _spamblock { get; set; } 

        [JsonProperty("users_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Users_name { get; set; } 

        [JsonProperty("sibling_count_open", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sibling_count_open { get; set; } 

        [JsonProperty("parent_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_summary { get; set; } 

        [JsonProperty("parent_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_status_name { get; set; } 

        [JsonProperty("new_approvalprocess", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess { get; set; } 

        [JsonProperty("new_approvalprocess_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_agent_id { get; set; } 

        [JsonProperty("new_approvalprocess_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_user_id { get; set; } 

        [JsonProperty("new_approvalprocess_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_approvalprocess_email { get; set; } 

        [JsonProperty("new_approvalprocess_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_cab_id { get; set; } 

        [JsonProperty("approvers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultApproval>? Approvers { get; set; } 

        [JsonProperty("approvers_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultApproval>? Approvers_history { get; set; } 

        [JsonProperty("appointment_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Appointment_count { get; set; } 

        [JsonProperty("open_chat_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Open_chat_count { get; set; } 

        [JsonProperty("task_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Task_count { get; set; } 

        [JsonProperty("create_article", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_article { get; set; } 

        [JsonProperty("qualifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Qualification>? Qualifications { get; set; } 

        [JsonProperty("target_adjust", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Target_adjust { get; set; } 

        [JsonProperty("start_adjust", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Start_adjust { get; set; } 

        [JsonProperty("dont_do_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_do_rules { get; set; } 

        [JsonProperty("dont_do_databaselookups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_do_databaselookups { get; set; } 

        [JsonProperty("apply_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Apply_rules { get; set; } 

        [JsonProperty("apply_this_rule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Apply_this_rule { get; set; } 

        [JsonProperty("_forcereassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _forcereassign { get; set; } 

        [JsonProperty("_appointment01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _appointment01_ok { get; set; } 

        [JsonProperty("_agent01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _agent01_ok { get; set; } 

        [JsonProperty("_agent02_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _agent02_ok { get; set; } 

        [JsonProperty("_asset01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _asset01_ok { get; set; } 

        [JsonProperty("return_this", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Return_this { get; set; } 

        [JsonProperty("_validate_form", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _validate_form { get; set; } 

        [JsonProperty("_validate_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _validate_updates { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Attachments { get; set; } 

        [JsonProperty("documents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Documents { get; set; } 

        [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaPopup>? Popup_notes { get; set; } 

        [JsonProperty("current_action_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Current_action_type { get; set; } 

        [JsonProperty("current_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Current_action_name { get; set; } 

        [JsonProperty("_ispreview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _ispreview { get; set; } 

        [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Assets { get; set; } 

        [JsonProperty("nochangesequpdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nochangesequpdate { get; set; } 

        [JsonProperty("_reclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _reclose { get; set; } 

        [JsonProperty("_reclose_oid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _reclose_oid { get; set; } 

        [JsonProperty("_recover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _recover { get; set; } 

        [JsonProperty("reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reference { get; set; } 

        [JsonProperty("email_start_tag_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_start_tag_override { get; set; } 

        [JsonProperty("email_end_tag_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_end_tag_override { get; set; } 

        [JsonProperty("follower_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Follower_count { get; set; } 

        [JsonProperty("contact_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Contact_address { get; set; } 

        [JsonProperty("chat_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chat_id { get; set; } 

        [JsonProperty("actioncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actioncode { get; set; } 

        [JsonProperty("clone_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clone_count { get; set; } 

        [JsonProperty("todo_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Todo_count { get; set; } 

        [JsonProperty("todo_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultToDo>? Todo_list { get; set; } 

        [JsonProperty("service_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_count { get; set; } 

        [JsonProperty("unsubscribedfromserviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unsubscribedfromserviceid { get; set; } 

        [JsonProperty("is_opportunity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_opportunity { get; set; } 

        [JsonProperty("is_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_project { get; set; } 

        [JsonProperty("items_issued_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Items_issued_count { get; set; } 

        [JsonProperty("items_issued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultItem>? Items_issued { get; set; } 

        [JsonProperty("project_items_issued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultItem>? Project_items_issued { get; set; } 

        [JsonProperty("quotation_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotation_count { get; set; } 

        [JsonProperty("salesorder_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_count { get; set; } 

        [JsonProperty("purchaseorder_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchaseorder_count { get; set; } 

        [JsonProperty("invoice_line_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_line_count { get; set; } 

        [JsonProperty("third_party_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_client_id { get; set; } 

        [JsonProperty("_refreshresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _refreshresponse { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_isalert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isalert { get; set; } 

        [JsonProperty("_novalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _novalidate { get; set; } 

        [JsonProperty("is_closure_reminder_closure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_closure_reminder_closure { get; set; } 

        [JsonProperty("is_slahold_reminder_closure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_slahold_reminder_closure { get; set; } 

        [JsonProperty("_importid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _importid { get; set; } 

        [JsonProperty("sendtopagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendtopagerduty { get; set; } 

        [JsonProperty("splunkurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Splunkurl { get; set; } 

        [JsonProperty("splunksearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Splunksearch { get; set; } 

        [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Budgettype_id { get; set; } 

        [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Budgettype_name { get; set; } 

        [JsonProperty("budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultBudget>? Budgets { get; set; } 

        [JsonProperty("process_ai", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Process_ai { get; set; } 

        [JsonProperty("send_remoteinvite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Send_remoteinvite { get; set; } 

        [JsonProperty("invite_emaillist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invite_emaillist { get; set; } 

        [JsonProperty("third_party_call_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_call_id { get; set; } 

        [JsonProperty("remotetechid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Remotetechid { get; set; } 

        [JsonProperty("linkremotesession", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Linkremotesession { get; set; } 

        [JsonProperty("remotesessionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Remotesessionid { get; set; } 

        [JsonProperty("utcoffset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Utcoffset { get; set; } 

        [JsonProperty("form_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Form_id { get; set; } 

        [JsonProperty("database_lookup_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PartsLookupResult? Database_lookup_result { get; set; } 

        [JsonProperty("azure_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_tenants { get; set; } 

        [JsonProperty("azure_tenants_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_tenants_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("_warning_is_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning_is_error { get; set; } 

        [JsonProperty("close_unassigned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Close_unassigned { get; set; } 

        [JsonProperty("canbechild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canbechild { get; set; } 

        [JsonProperty("_changefreeze01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _changefreeze01_ok { get; set; } 

        [JsonProperty("_force", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _force { get; set; } 

        [JsonProperty("_ticketclash01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _ticketclash01_ok { get; set; } 

        [JsonProperty("_milestonedate01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _milestonedate01_ok { get; set; } 

        [JsonProperty("_ignoremilestonedates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _ignoremilestonedates { get; set; } 

        [JsonProperty("locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked { get; set; } 

        [JsonProperty("has_related", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Has_related { get; set; } 

        [JsonProperty("pagerdutyeragent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagerdutyeragent { get; set; } 

        [JsonProperty("elapsed_response_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Elapsed_response_hours { get; set; } 

        [JsonProperty("elapsed_resolution_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Elapsed_resolution_hours { get; set; } 

        [JsonProperty("sla_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Sla_start_date { get; set; } 

        [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _print_generate { get; set; } 

        [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Printhtml { get; set; } 

        [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdf_attachment_id { get; set; } 

        [JsonProperty("journeys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Journey>? Journeys { get; set; } 

        [JsonProperty("devops_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Devops_agent { get; set; } 

        [JsonProperty("_dontupdate_devops", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dontupdate_devops { get; set; } 

        [JsonProperty("category_note_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_note_1 { get; set; } 

        [JsonProperty("category_user_note_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_user_note_1 { get; set; } 

        [JsonProperty("category_include_note_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Category_include_note_1 { get; set; } 

        [JsonProperty("category_itil_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Category_itil_1 { get; set; } 

        [JsonProperty("category_note_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_note_2 { get; set; } 

        [JsonProperty("category_user_note_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_user_note_2 { get; set; } 

        [JsonProperty("category_include_note_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Category_include_note_2 { get; set; } 

        [JsonProperty("category_itil_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Category_itil_2 { get; set; } 

        [JsonProperty("category_note_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_note_3 { get; set; } 

        [JsonProperty("category_user_note_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_user_note_3 { get; set; } 

        [JsonProperty("category_include_note_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Category_include_note_3 { get; set; } 

        [JsonProperty("category_itil_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Category_itil_3 { get; set; } 

        [JsonProperty("category_note_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_note_4 { get; set; } 

        [JsonProperty("category_user_note_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_user_note_4 { get; set; } 

        [JsonProperty("category_include_note_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Category_include_note_4 { get; set; } 

        [JsonProperty("category_itil_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Category_itil_4 { get; set; } 

        [JsonProperty("devops_comment_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Devops_comment_count { get; set; } 

        [JsonProperty("_iszapier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _iszapier { get; set; } 

        [JsonProperty("ncentral_ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ncentral_ticketid { get; set; } 

        [JsonProperty("_isnotify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isnotify { get; set; } 

        [JsonProperty("created_from_action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Created_from_action_id { get; set; } 

        [JsonProperty("created_from_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Created_from_action_name { get; set; } 

        [JsonProperty("createacknowledgement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createacknowledgement { get; set; } 

        [JsonProperty("your_vote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Your_vote { get; set; } 

        [JsonProperty("your_vote_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Your_vote_comment { get; set; } 

        [JsonProperty("donotapplytemplateintheapi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Donotapplytemplateintheapi { get; set; } 

        [JsonProperty("_create_outstanding_appointments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _create_outstanding_appointments { get; set; } 

        [JsonProperty("_create_outstanding_appointment_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _create_outstanding_appointment_email { get; set; } 

        [JsonProperty("scomalertstate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Scomalertstate { get; set; } 

        [JsonProperty("orionalertid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionalertid { get; set; } 

        [JsonProperty("orionalertactiveid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionalertactiveid { get; set; } 

        [JsonProperty("orionacknowledgestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionacknowledgestate { get; set; } 

        [JsonProperty("orionclosestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionclosestate { get; set; } 

        [JsonProperty("orionacknowledgedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionacknowledgedby { get; set; } 

        [JsonProperty("orionacknowledgedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Orionacknowledgedate { get; set; } 

        [JsonProperty("_acknowledgealert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _acknowledgealert { get; set; } 

        [JsonProperty("orionacknowledgenote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orionacknowledgenote { get; set; } 

        [JsonProperty("orionacknowledgedbyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orionacknowledgedbyname { get; set; } 

        [JsonProperty("orionalertname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orionalertname { get; set; } 

        [JsonProperty("servicenow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_id { get; set; } 

        [JsonProperty("third_party_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_parent_id { get; set; } 

        [JsonProperty("third_party_problem_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_problem_id { get; set; } 

        [JsonProperty("opened_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opened_by { get; set; } 

        [JsonProperty("resolved_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resolved_by { get; set; } 

        [JsonProperty("sendtosplunkoncall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendtosplunkoncall { get; set; } 

        [JsonProperty("splunkoncalltarget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Splunkoncalltarget { get; set; } 

        [JsonProperty("splunkoncalltarget_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Splunkoncalltarget_id { get; set; } 

        [JsonProperty("splunkoncall_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Splunkoncall_id { get; set; } 

        [JsonProperty("splunkoncallurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Splunkoncallurl { get; set; } 

        [JsonProperty("splunkoncallstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Splunkoncallstatus { get; set; } 

        [JsonProperty("connectwise_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwise_id { get; set; } 

        [JsonProperty("connectwise_project_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwise_project_id { get; set; } 

        [JsonProperty("prepay_balance_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepay_balance_hours { get; set; } 

        [JsonProperty("prepay_balance_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepay_balance_amount { get; set; } 

        [JsonProperty("servicenow_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_number { get; set; } 

        [JsonProperty("parent_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_ticket_type_name { get; set; } 

        [JsonProperty("createdfrom_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Createdfrom_ticket_type_name { get; set; } 

        [JsonProperty("clonedfrom_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clonedfrom_ticket_type_name { get; set; } 

        [JsonProperty("autotask_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autotask_id { get; set; } 

        [JsonProperty("autotask_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Autotask_number { get; set; } 

        [JsonProperty("atera_alert_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Atera_alert_id { get; set; } 

        [JsonProperty("syncro_alert_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncro_alert_id { get; set; } 

        [JsonProperty("laststatuschangestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Laststatuschangestatus { get; set; } 

        [JsonProperty("laststatuschangestatusdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Laststatuschangestatusdate { get; set; } 

        [JsonProperty("mark_as_read_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mark_as_read_only { get; set; } 

        [JsonProperty("audit_log", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Audit>? Audit_log { get; set; } 

        [JsonProperty("meraki_device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Meraki_device { get; set; } 

        [JsonProperty("meraki_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Meraki_alert_type { get; set; } 

        [JsonProperty("matched_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultRuleMatch>? Matched_rules { get; set; } 

        [JsonProperty("powershell_script_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Powershell_script_count { get; set; } 

        [JsonProperty("devops_workitem_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Devops_workitem_count { get; set; } 

        [JsonProperty("ninja_alert_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_alert_id { get; set; } 

        [JsonProperty("ninja_device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninja_device_id { get; set; } 

        [JsonProperty("usertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Usertype { get; set; } 

        [JsonProperty("actionworkflowset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Actionworkflowset { get; set; } 

        [JsonProperty("isbillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isbillable { get; set; } 

        [JsonProperty("itemsarebillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Itemsarebillable { get; set; } 

        [JsonProperty("childrenlefttocreate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Childrenlefttocreate { get; set; } 

        [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Who { get; set; } 

        [JsonProperty("resourcetype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resourcetype_id { get; set; } 

        [JsonProperty("resourcetype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resourcetype_name { get; set; } 

        [JsonProperty("resource_booking_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resource_booking_type { get; set; } 

        [JsonProperty("resource_booking_timeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Resource_booking_timeslot { get; set; } 

        [JsonProperty("resource_booking_asset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resource_booking_asset { get; set; } 

        [JsonProperty("matched_rule_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Matched_rule_ids { get; set; } 

        [JsonProperty("forceruleupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forceruleupdate { get; set; } 

        [JsonProperty("teams_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_user_id { get; set; } 

        [JsonProperty("_isteams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isteams { get; set; } 

        [JsonProperty("faultapprovalfailed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Faultapprovalfailed { get; set; } 

        [JsonProperty("article_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Article_description { get; set; } 

        [JsonProperty("article_resolution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Article_resolution { get; set; } 

        [JsonProperty("article_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Article_notes { get; set; } 

        [JsonProperty("article_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Article_type { get; set; } 

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tag>? Tags { get; set; } 

        [JsonProperty("dontcreatechild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontcreatechild { get; set; } 

        [JsonProperty("needcreatechild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Needcreatechild { get; set; } 

        [JsonProperty("sentinel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_id { get; set; } 

        [JsonProperty("sentinel_resourcegroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_resourcegroup { get; set; } 

        [JsonProperty("sentinel_subscriptionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_subscriptionid { get; set; } 

        [JsonProperty("sentinel_workspace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_workspace { get; set; } 

        [JsonProperty("faultapprovalexists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Faultapprovalexists { get; set; } 

        [JsonProperty("_validate_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _validate_only { get; set; } 

        [JsonProperty("_validation_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _validation_key { get; set; } 

        [JsonProperty("azuremonitor_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azuremonitor_id { get; set; } 

        [JsonProperty("domotz_alertid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Domotz_alertid { get; set; } 

        [JsonProperty("domotz_deviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Domotz_deviceid { get; set; } 

        [JsonProperty("domerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Domerge { get; set; } 

        [JsonProperty("isnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isnew { get; set; } 

        [JsonProperty("automate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automate_id { get; set; } 

        [JsonProperty("device_automate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_automate_id { get; set; } 

        [JsonProperty("auvik_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_id { get; set; } 

        [JsonProperty("auvik_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_url { get; set; } 

        [JsonProperty("contract_balance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contract_balance { get; set; } 

        [JsonProperty("bookingurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bookingurl { get; set; } 

        [JsonProperty("billable_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Billable_time { get; set; } 

        [JsonProperty("isclone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isclone { get; set; } 

        [JsonProperty("clonedfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clonedfrom { get; set; } 

        [JsonProperty("slatimeremaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Slatimeremaining { get; set; } 

        [JsonProperty("customfieldvalidationreason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customfieldvalidationreason { get; set; } 

        [JsonProperty("_has_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _has_automations { get; set; } 

        [JsonProperty("chat_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chat_count { get; set; } 

        [JsonProperty("_dontupdate_jira", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dontupdate_jira { get; set; } 

        [JsonProperty("jira_issue_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Jira_issue_count { get; set; } 

        [JsonProperty("call_log_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Call_log_count { get; set; } 

        [JsonProperty("sentinel_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_url { get; set; } 

        [JsonProperty("sentinel_display_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sentinel_display_id { get; set; } 

        [JsonProperty("postloggedview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Postloggedview { get; set; } 

        [JsonProperty("addigy_alert_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addigy_alert_id { get; set; } 

        [JsonProperty("ninja_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_alert_type { get; set; } 

        [JsonProperty("freshdesk_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Freshdesk_id { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? External_links { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("kaseya_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseya_agent_id { get; set; } 

        [JsonProperty("salesforce_contactid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_contactid { get; set; } 

        [JsonProperty("salesforce_accountid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_accountid { get; set; } 

        [JsonProperty("salesforce_parentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_parentid { get; set; } 

        [JsonProperty("salesforce_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_status { get; set; } 

        [JsonProperty("newrelic_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newrelic_id { get; set; } 

        [JsonProperty("newrelicincident_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newrelicincident_id { get; set; } 

        [JsonProperty("backup_radar_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Backup_radar_id { get; set; } 

        [JsonProperty("backup_radar_state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Backup_radar_state { get; set; } 

        [JsonProperty("linktypesarray", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair>? Linktypesarray { get; set; } 

        [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseyaid { get; set; } 

        [JsonProperty("alluserscanview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Alluserscanview { get; set; } 

        [JsonProperty("_dontupdate_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dontupdate_salesforce { get; set; } 

        [JsonProperty("sync_to_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_to_salesforce { get; set; } 

        [JsonProperty("salesforce_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesforce_stage { get; set; } 

        [JsonProperty("_newticket_quickclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _newticket_quickclose { get; set; } 

        [JsonProperty("service_request_detail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_request_detail_id { get; set; } 

        [JsonProperty("visible_child_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Visible_child_tickets { get; set; } 

        [JsonProperty("check_status_freeze", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Check_status_freeze { get; set; } 

        [JsonProperty("expenses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Expense>? Expenses { get; set; } 

        [JsonProperty("clear_feedback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clear_feedback { get; set; } 

        [JsonProperty("facebook_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Facebook_message_id { get; set; } 

        [JsonProperty("twitter_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Twitter_message_id { get; set; } 

        [JsonProperty("ncentral_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ncentral_details_id { get; set; } 

        [JsonProperty("requesttype_published_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requesttype_published_id { get; set; } 

        [JsonProperty("chat_key_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Chat_key_id { get; set; } 

        [JsonProperty("supplier_contact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_contact_id { get; set; } 

        [JsonProperty("parent_itil_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_itil_ticket_type { get; set; } 

        [JsonProperty("parent_release_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_release_note { get; set; } 

        [JsonProperty("parent_release_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_release_name { get; set; } 

        [JsonProperty("parent_release2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_release2_name { get; set; } 

        [JsonProperty("parent_release3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_release3_name { get; set; } 

        [JsonProperty("pagerdutyservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyservice { get; set; } 

        [JsonProperty("pagerdutyservice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyservice_name { get; set; } 

        [JsonProperty("_dontupdate_pagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dontupdate_pagerduty { get; set; } 

        [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dont_fire_automations { get; set; } 

        [JsonProperty("teamsmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamsmessage { get; set; } 

        [JsonProperty("default_teams_chat_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_teams_chat_name { get; set; } 

        [JsonProperty("show_chat_create", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_chat_create { get; set; } 

        [JsonProperty("htmlmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Htmlmessage { get; set; } 

        [JsonProperty("linked_halo_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_halo_ticket_count { get; set; } 

        [JsonProperty("halolink_ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halolink_ticketid { get; set; } 

        [JsonProperty("override_opening_action_who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override_opening_action_who { get; set; } 

        [JsonProperty("whatsappcreatedfromid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Whatsappcreatedfromid { get; set; } 

        [JsonProperty("unotes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Unotes { get; set; } 

        [JsonProperty("smemo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Smemo { get; set; } 

        [JsonProperty("amemo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Amemo { get; set; } 

        [JsonProperty("_matchintacctclass", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _matchintacctclass { get; set; } 

        [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_class { get; set; } 

        [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_class_name { get; set; } 

        [JsonProperty("sms_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sms_override { get; set; } 

        [JsonProperty("device_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device_name { get; set; } 

        [JsonProperty("milestones", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MileStone>? Milestones { get; set; } 

        [JsonProperty("email_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_message_id { get; set; } 

        [JsonProperty("seenby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Seenby { get; set; } 

        [JsonProperty("recaptcha_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Recaptcha_token { get; set; } 

        [JsonProperty("resource_booking_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resource_booking_site { get; set; } 

        [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tabname>? Extratabs { get; set; } 

        [JsonProperty("new_approvalprocess_role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_role_id { get; set; } 

        [JsonProperty("new_approvalprocess_customfieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_customfieldid { get; set; } 

        [JsonProperty("linked_ecommerce_order_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Linked_ecommerce_order_number { get; set; } 

        [JsonProperty("linked_ecommerce_order_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Linked_ecommerce_order_url { get; set; } 

        [JsonProperty("parent_milestones", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MileStone>? Parent_milestones { get; set; } 

        [JsonProperty("vectors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultVector>? Vectors { get; set; } 

        [JsonProperty("ai_matched_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultVectorScore>? Ai_matched_tickets { get; set; } 

        [JsonProperty("ai_matched_articles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultVectorScore>? Ai_matched_articles { get; set; } 

        [JsonProperty("ai_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AiSuggestionFault>? Ai_suggestions { get; set; } 

        [JsonProperty("_apply_ai_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? _apply_ai_suggestions { get; set; } 

        [JsonProperty("_dismiss_ai_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? _dismiss_ai_suggestions { get; set; } 

        [JsonProperty("suggested_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Suggested_category1 { get; set; } 

        [JsonProperty("thirdpartyreviewscore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Thirdpartyreviewscore { get; set; } 

        [JsonProperty("datto_alert_state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datto_alert_state { get; set; } 

        [JsonProperty("forwarded_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Forwarded_by { get; set; } 

        [JsonProperty("reviewed_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Reviewed_date { get; set; } 

        [JsonProperty("is_sensitive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_sensitive { get; set; } 

        [JsonProperty("contract_schedule_plan_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_schedule_plan_id { get; set; } 

        [JsonProperty("instagram_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Instagram_message_id { get; set; } 

        [JsonProperty("default_reporter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_reporter { get; set; } 

        [JsonProperty("defaultsendattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Defaultsendattachments { get; set; } 

        [JsonProperty("devops_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Devops_key { get; set; } 

        [JsonProperty("related_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultsList>? Related_tickets { get; set; } 

        [JsonProperty("new_related_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultsList>? New_related_tickets { get; set; } 

        [JsonProperty("unrelate_from_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unrelate_from_ticket_id { get; set; } 

        [JsonProperty("ecommerce_orders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<EcommerceOrderFault>? Ecommerce_orders { get; set; } 

        [JsonProperty("hide_feedback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_feedback { get; set; } 

        [JsonProperty("workflow_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WorkflowHistory>? Workflow_history { get; set; } 

        [JsonProperty("connectwisermm_ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwisermm_ticketid { get; set; } 

        [JsonProperty("colour_rule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Colour_rule { get; set; } 

        [JsonProperty("google_reviewdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GoogleBusinessReview? Google_reviewdata { get; set; } 

        [JsonProperty("google_questiondata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GoogleBusinessQuestion? Google_questiondata { get; set; } 

        [JsonProperty("original_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Original_agent { get; set; } 

        [JsonProperty("do_lookups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Do_lookups { get; set; } 

        [JsonProperty("liongard_system_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongard_system_id { get; set; } 

        [JsonProperty("bigpanda_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bigpanda_id { get; set; } 

        [JsonProperty("contributors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Contributors>? Contributors { get; set; } 

        [JsonProperty("internet_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Internet_message_id { get; set; } 

        [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Matching_value { get; set; } 

        [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sqlimport_id { get; set; } 

        [JsonProperty("respondbydateadjusted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Respondbydateadjusted { get; set; } 

        [JsonProperty("date_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultsDateDependencies>? Date_dependencies { get; set; } 

        [JsonProperty("new_milestone_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_milestone_ticket { get; set; } 

        [JsonProperty("assets_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ViewColumnsDetails>? Assets_columns { get; set; } 

        [JsonProperty("slaresponseexcuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slaresponseexcuse { get; set; } 

        [JsonProperty("can_add_cc_followers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Can_add_cc_followers { get; set; } 

        [JsonProperty("_fromchatprofileid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _fromchatprofileid { get; set; } 

        [JsonProperty("lapsafe_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lapsafe_count { get; set; } 

        [JsonProperty("olas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultOLA>? Olas { get; set; } 

        [JsonProperty("ola_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ola_count { get; set; } 

        [JsonProperty("new_workflow_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WorkflowHistory>? New_workflow_history { get; set; } 

        [JsonProperty("default_slack_channel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_slack_channel_name { get; set; } 

        [JsonProperty("show_channel_create", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_channel_create { get; set; } 

        [JsonProperty("slack_channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slack_channel_id { get; set; } 

        [JsonProperty("slack_callback_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slack_callback_id { get; set; } 

        [JsonProperty("ai_suggested_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ai_suggested_priority { get; set; } 

        [JsonProperty("ai_suggested_resolution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ai_suggested_resolution { get; set; } 

        [JsonProperty("ai_generated_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ai_generated_summary { get; set; } 

        [JsonProperty("ai_search_query", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ai_search_query { get; set; } 

        [JsonProperty("ai_suggested_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ai_suggested_type { get; set; } 

        [JsonProperty("ai_sentiment_analysis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ai_sentiment_analysis { get; set; } 

        [JsonProperty("ai_satisfaction_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ai_satisfaction_level { get; set; } 

        [JsonProperty("ai_tonality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ai_tonality { get; set; } 

        [JsonProperty("_isagentuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isagentuser { get; set; } 

        [JsonProperty("ai_survey_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ai_survey_score { get; set; } 

        [JsonProperty("ai_survey_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ai_survey_comment { get; set; } 

        [JsonProperty("freshdesk_ticket_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FreshdeskTicket? Freshdesk_ticket_data { get; set; } 

        [JsonProperty("freshdesk_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Freshdesk_group_name { get; set; } 

        [JsonProperty("freshdesk_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Freshdesk_agent_name { get; set; } 

        [JsonProperty("freshdesk_agent_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Freshdesk_agent_email { get; set; } 

        [JsonProperty("freshdesk_product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Freshdesk_product_name { get; set; } 

        [JsonProperty("matched_kb_id_acessible_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matched_kb_id_acessible_to_user { get; set; } 

        [JsonProperty("remotesession_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Remotesession_count { get; set; } 

        [JsonProperty("search_index_sync_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Search_index_sync_timestamp { get; set; } 

        [JsonProperty("search_index_sync_batches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Search_index_sync_batches { get; set; } 

        [JsonProperty("new_whe_", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? New_whe_ { get; set; } 

        [JsonProperty("new_actioncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_actioncode { get; set; } 

        [JsonProperty("notepad", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notepad { get; set; } 

        [JsonProperty("embedding_match_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Embedding_match_timestamp { get; set; } 

        [JsonProperty("_re_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _re_index { get; set; } 

        [JsonProperty("_fetch_matches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _fetch_matches { get; set; } 

        [JsonProperty("workflow_move_date_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Workflow_move_date_override { get; set; } 

        [JsonProperty("lookup_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lookup_search { get; set; } 

        [JsonProperty("agent_booking_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_booking_type { get; set; } 

        [JsonProperty("agent_booking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Appointment? Agent_booking { get; set; } 

        [JsonProperty("pandadoc_attachment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pandadoc_attachment { get; set; } 

        [JsonProperty("pandadoc_attachment_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pandadoc_attachment_name { get; set; } 

        [JsonProperty("pandadoc_attachment_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pandadoc_attachment_url { get; set; } 

        [JsonProperty("thirdparty_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdparty_url { get; set; } 

        [JsonProperty("security_signal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Security_signal_id { get; set; } 

        [JsonProperty("datadog_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datadog_id { get; set; } 

        [JsonProperty("ai_conversation_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ai_conversation_summary { get; set; } 

        [JsonProperty("incomingevent_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Incomingevent_count { get; set; } 

        [JsonProperty("azure_connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azure_connection_id { get; set; } 

        [JsonProperty("kblinkid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kblinkid { get; set; } 

        [JsonProperty("ticket_client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_client_to_invoice_to_id { get; set; } 

        [JsonProperty("ticket_client_to_invoice_to_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_client_to_invoice_to_name { get; set; } 

        [JsonProperty("_prevent_outgoing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _prevent_outgoing { get; set; } 

        [JsonProperty("dont_copy_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_copy_history { get; set; } 

        [JsonProperty("user_linked_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? User_linked_sites { get; set; } 

        [JsonProperty("prepay_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PrePayThreshold? Prepay_threshold { get; set; } 

        [JsonProperty("automation_entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automation_entity_type { get; set; } 

        [JsonProperty("make_automation_entity_inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Make_automation_entity_inactive { get; set; } 

        [JsonProperty("is_downtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_downtime { get; set; } 

        [JsonProperty("add_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tag>? Add_tags { get; set; } 

        [JsonProperty("locked_by_agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Locked_by_agentid { get; set; } 

        [JsonProperty("_forceunlock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _forceunlock { get; set; } 

        [JsonProperty("_is_aisuggestion_merge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_aisuggestion_merge { get; set; } 

        [JsonProperty("service_linked_device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_linked_device { get; set; } 

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
        public System.DateTimeOffset? Startdatetime { get; set; } 

        [JsonProperty("enddatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? Enddatetime { get; set; } 

        [JsonProperty("closure_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Closure_agent_id { get; set; } 

        [JsonProperty("closed_in_integration_system", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Closed_in_integration_system { get; set; } 

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

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importthirdpartyid { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

    }