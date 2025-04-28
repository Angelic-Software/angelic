using System.CodeDom.Compiler;
using Angelic.Models.Areas;
using Angelic.Models.Assets;
using Angelic.Models.Attachments;
using Angelic.Models.Configuration;
using Angelic.Models.Configuration.Billing.Prepay;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.Integrations.Lookups;
using Angelic.Models.Configuration.Language;
using Angelic.Models.Configuration.Tickets.Templates;
using Angelic.Models.Tickets;
using Angelic.Models.Users;
using Newtonsoft.Json;

namespace Angelic.Models.Action;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Actions
    {
        /// <summary>
        /// The ID of the ticket in which this Action applies to.
        /// </summary>
        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketId { get; set; }

        /// <summary>
        /// The ID of this action.
        /// </summary>
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the outcome that this action has performed.
        /// If no outcome ID has been supplied, but an outcome name has been supplied,
        /// then the action will POST successfully with an outcome ID of zero
        /// and generate a blank action on the ticket with the title of the blank action being the outcome name supplied here.
        /// </summary>
        [JsonProperty("outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Outcome { get; set; }

        [JsonProperty("who_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WhoType { get; set; }

        /// <summary>
        /// The URI of the image file that shows the image of the agent that performed this action.
        /// </summary>
        [JsonProperty("who_imgpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WhoImgPath { get; set; }

        [JsonProperty("who_agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WhoAgentId { get; set; }

        [JsonProperty("who_initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WhoInitials { get; set; }

        [JsonProperty("who_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WhoColour { get; set; }

        [JsonProperty("who_onlinestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WhoOnlineStatus { get; set; }

        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateTime { get; set; }

        [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdated { get; set; }

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; }

        [JsonProperty("replied_to_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RepliedToTicketId { get; set; }

        [JsonProperty("replied_to_action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RepliedToActionId { get; set; }

        [JsonProperty("created_from_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedFromTicketId { get; set; }

        [JsonProperty("created_from_action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedFromActionId { get; set; }

        [JsonProperty("action_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionContractId { get; set; }

        [JsonProperty("action_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionContractRef { get; set; }

        [JsonProperty("action_travel_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionTravelContractId { get; set; }

        [JsonProperty("project_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectId { get; set; }

        [JsonProperty("twitter_id_str", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwitterIdStr { get; set; }

        [JsonProperty("twitter_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwitterUserName { get; set; }

        [JsonProperty("tweet_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TweetSent { get; set; }

        [JsonProperty("attachment_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AttachmentView? AttachmentList { get; set; }

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? CustomFields { get; set; }

        [JsonProperty("personal_unread", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PersonalUnread { get; set; }

        [JsonProperty("actionarrivaldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ActionArrivalDate { get; set; }

        [JsonProperty("actioncompletiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ActionCompletionDate { get; set; }

        [JsonProperty("isjson", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsJson { get; set; }

        [JsonProperty("facebook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FacebookId { get; set; }

        [JsonProperty("facebook_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FacebookSent { get; set; }

        [JsonProperty("merged_from_ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MergedFromTicketId { get; set; }

        [JsonProperty("reactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ActionReaction>? Reactions { get; set; }

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; }

        [JsonProperty("email_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailMessageId { get; set; }

        [JsonProperty("post_translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? PostTranslations { get; set; }

        [JsonProperty("ticket_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TicketGuid { get; set; }

        [JsonProperty("instagram_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InstagramId { get; set; }

        [JsonProperty("instagram_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? InstagramSent { get; set; }

        [JsonProperty("on_behalf_of", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OnBehalfOf { get; set; }

        [JsonProperty("on_behalf_of_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OnBehalfOfName { get; set; }

        [JsonProperty("actionby_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionByAgentId { get; set; }

        [JsonProperty("warning_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WarningType { get; set; }

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; }

        [JsonProperty("actioncontractid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionContractId { get; set; }

        [JsonProperty("actisbillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActIsBillable { get; set; }

        [JsonProperty("actisreadyforprocessing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActIsReadyForProcessing { get; set; }

        [JsonProperty("actioninternetmessageid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionInternetMessageId { get; set; }

        [JsonProperty("senttowhatsapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SentToWhatsApp { get; set; }

        [JsonProperty("twa_delivered_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TwaDeliveredDate { get; set; }

        [JsonProperty("twa_read_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TwaReadDate { get; set; }

        [JsonProperty("travelisreadyforprocessing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TravelIsReadyForProcessing { get; set; }

        [JsonProperty("emailbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailBody { get; set; }

        [JsonProperty("emailsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailSubject { get; set; }

        [JsonProperty("note_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NoteHtml { get; set; }

        [JsonProperty("emailbody_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailBodyHtml { get; set; }

        [JsonProperty("actionuserdef", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionUserDef { get; set; }

        [JsonProperty("userdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserDesc { get; set; }

        [JsonProperty("actiondatecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ActionDateCreated { get; set; }

        [JsonProperty("actioninvoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionInvoiceNumber { get; set; }

        [JsonProperty("actioninvoicenumber_isproject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionInvoiceNumberIsProject { get; set; }

        [JsonProperty("action_invoice_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionInvoiceLineId { get; set; }

        [JsonProperty("actiontravelinvoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionTravelInvoiceNumber { get; set; }

        [JsonProperty("actionmileageinvoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionMileageInvoiceNumber { get; set; }

        [JsonProperty("externalinvoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExternalInvoiceNumber { get; set; }

        [JsonProperty("actprocessid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actprocessid { get; set; }

        [JsonProperty("actiontravelamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Actiontravelamount { get; set; }

        [JsonProperty("actionmileageamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Actionmileageamount { get; set; }

        [JsonProperty("actiontravelmileageinvoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actiontravelmileageinvoicenumber { get; set; }

        [JsonProperty("actionbillingplanid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionbillingplanid { get; set; }

        [JsonProperty("actiontravelbillingplanid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actiontravelbillingplanid { get; set; }

        [JsonProperty("actioncalendarstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actioncalendarstatus { get; set; }

        [JsonProperty("actionapptid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Actionapptid { get; set; }

        [JsonProperty("actionsmsstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionsmsstatus { get; set; }

        [JsonProperty("sitevisitunits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Sitevisitunits { get; set; }

        [JsonProperty("svid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Svid { get; set; }

        [JsonProperty("asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetId { get; set; }

        [JsonProperty("asset_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetSite { get; set; }

        [JsonProperty("lwwarrantyreported", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lwwarrantyreported { get; set; }

        [JsonProperty("from_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FromMailboxId { get; set; }

        [JsonProperty("sales_mailbox_override_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesMailboxOverrideId { get; set; }

        [JsonProperty("from_address_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FromAddressOverride { get; set; }

        [JsonProperty("actiontravelstartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Actiontravelstartdate { get; set; }

        [JsonProperty("actiontravelenddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Actiontravelenddate { get; set; }

        [JsonProperty("actionactualresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Actionactualresponse { get; set; }

        [JsonProperty("actionslaresponsestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Actionslaresponsestate { get; set; }

        [JsonProperty("labourwarranty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Labourwarranty { get; set; }

        [JsonProperty("actreviewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Actreviewed { get; set; }

        [JsonProperty("actprocesseddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Actprocesseddate { get; set; }

        [JsonProperty("dateinvoicedtraveltime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateinvoicedtraveltime { get; set; }

        [JsonProperty("dateinvoicedmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateinvoicedmileage { get; set; }

        [JsonProperty("actionuserdefineddata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Actionuserdefineddata { get; set; }

        [JsonProperty("emailtolistall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailtolistall { get; set; }

        [JsonProperty("reply_direct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReplyDirect { get; set; }

        [JsonProperty("actioninformownerofaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Actioninformownerofaction { get; set; }

        [JsonProperty("agentnotificationneeded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agentnotificationneeded { get; set; }

        [JsonProperty("surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Surchargeid { get; set; }

        [JsonProperty("travel_surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TravelSurchargeid { get; set; }

        [JsonProperty("achargetotalaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Achargetotalaction { get; set; }

        [JsonProperty("achargetotalprocessed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Achargetotalprocessed { get; set; }

        [JsonProperty("tweetsent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tweetsent { get; set; }

        [JsonProperty("tweetfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tweetfrom { get; set; }

        [JsonProperty("twitterid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Twitterid { get; set; }

        [JsonProperty("send_to_facebook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendToFacebook { get; set; }

        [JsonProperty("replyto_facebook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReplyToFacebookId { get; set; }

        [JsonProperty("senttofb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Senttofb { get; set; }

        [JsonProperty("facebookid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Facebookid { get; set; }

        [JsonProperty("facebookname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Facebookname { get; set; }

        [JsonProperty("facebook_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FacebookParentId { get; set; }

        [JsonProperty("calloutcomenum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Calloutcomenum { get; set; }

        [JsonProperty("actionresponsedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Actionresponsedate { get; set; }

        [JsonProperty("actiontargetresponsedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Actiontargetresponsedate { get; set; }

        [JsonProperty("pagerdutysendstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagerdutysendstatus { get; set; }

        [JsonProperty("mailentryid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailentryid { get; set; }

        [JsonProperty("replytoaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReplyToaddress { get; set; }

        [JsonProperty("actsapuuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Actsapuuid { get; set; }

        [JsonProperty("whowith", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Whowith { get; set; }

        [JsonProperty("chatid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chatid { get; set; }

        [JsonProperty("dynamicsactionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynamicsactionid { get; set; }

        [JsonProperty("action_appointment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionAppointmentId { get; set; }

        [JsonProperty("action_supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionSupplierId { get; set; }

        [JsonProperty("action_supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionSupplierName { get; set; }

        [JsonProperty("new_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewTicketType { get; set; }

        [JsonProperty("new_chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewChargeRate { get; set; }

        [JsonProperty("new_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewContractId { get; set; }

        [JsonProperty("new_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewParentId { get; set; }

        [JsonProperty("new_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewPriority { get; set; }

        [JsonProperty("new_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewCategory1 { get; set; }

        [JsonProperty("new_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewCategory2 { get; set; }

        [JsonProperty("new_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewCategory3 { get; set; }

        [JsonProperty("new_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewCategory4 { get; set; }

        [JsonProperty("new_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewEstimate { get; set; }

        [JsonProperty("new_estimatedays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewEstimateDays { get; set; }

        [JsonProperty("new_impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewImpact { get; set; }

        [JsonProperty("new_urgency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewUrgency { get; set; }

        [JsonProperty("new_source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSource { get; set; }

        [JsonProperty("new_matched_rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewMatchedRuleId { get; set; }

        [JsonProperty("new_firsttimefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewFirstTimeFix { get; set; }

        [JsonProperty("new_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewTeam { get; set; }

        [JsonProperty("new_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewAgent { get; set; }

        [JsonProperty("new_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSlaId { get; set; }

        [JsonProperty("new_slastatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSlaStatus { get; set; }

        [JsonProperty("new_fixbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewFixByDate { get; set; }

        [JsonProperty("new_followupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewFollowUpdate { get; set; }

        [JsonProperty("new_deadlinedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewDeadlineDate { get; set; }

        [JsonProperty("new_deadlinenotificationhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewDeadlineNotificationHours { get; set; }

        [JsonProperty("new_startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewStartDate { get; set; }

        [JsonProperty("new_startdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewStartDateTimezone { get; set; }

        [JsonProperty("new_startdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeZone? NewStartDateWithTimezone { get; set; }

        [JsonProperty("new_project_time_budget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewProjectTimeBudget { get; set; }

        [JsonProperty("new_project_money_budget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewProjectMoneyBudget { get; set; }

        [JsonProperty("new_starttime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewStartTime { get; set; }

        [JsonProperty("new_starttimeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStartTimeSlot { get; set; }

        [JsonProperty("new_targetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewTargetDate { get; set; }

        [JsonProperty("new_targetdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewTargetDateTimezone { get; set; }

        [JsonProperty("new_targetdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeZone? NewTargetDateWithTimezone { get; set; }

        [JsonProperty("new_targettime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewTargetTime { get; set; }

        [JsonProperty("new_targettimeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewTargetTimeslot { get; set; }

        [JsonProperty("new_oppcontactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOppcontactname { get; set; }

        [JsonProperty("new_oppcompanyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOppcompanyname { get; set; }

        [JsonProperty("new_oppemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOppemailaddress { get; set; }

        [JsonProperty("new_oppcustomertitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOppcustomertitle { get; set; }

        [JsonProperty("new_opptel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOpptel { get; set; }

        [JsonProperty("new_oppcountry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOppcountry { get; set; }

        [JsonProperty("new_oppregion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOppregion { get; set; }

        [JsonProperty("new_opptype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOpptype { get; set; }

        [JsonProperty("new_opphear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOpphear { get; set; }

        [JsonProperty("new_oppvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewOppvalue { get; set; }

        [JsonProperty("new_foppvalue_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewFoppvalueMonthly { get; set; }

        [JsonProperty("new_foppvalue_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewFoppvalueAnnual { get; set; }

        [JsonProperty("new_foppvalue_oneoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewFoppvalueOneoff { get; set; }

        [JsonProperty("new_oppconversionprobability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewOppconversionprobability { get; set; }

        [JsonProperty("new_oppprofit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewOppprofit { get; set; }

        [JsonProperty("new_oppcurrentsystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOppcurrentsystem { get; set; }

        [JsonProperty("new_oppcompetitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOppcompetitors { get; set; }

        [JsonProperty("new_opptrialdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewOpptrialdate { get; set; }

        [JsonProperty("new_oppdemodate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewOppdemodate { get; set; }

        [JsonProperty("new_oppdiscountdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewOppdiscountdate { get; set; }

        [JsonProperty("new_oppattemptsmade", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewOppattemptsmade { get; set; }

        [JsonProperty("new_oppconverteddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewOppconverteddate { get; set; }

        [JsonProperty("new_oppproductchosen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOppproductchosen { get; set; }

        [JsonProperty("new_oppreason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOppreason { get; set; }

        [JsonProperty("new_opptimezonename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOpptimezonename { get; set; }

        [JsonProperty("new_oppclosurecategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewOppclosurecategory { get; set; }

        [JsonProperty("new_oppdontaddtomailinglist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewOppdontaddtomailinglist { get; set; }

        [JsonProperty("new_approvalprocess", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewApprovalProcess { get; set; }

        [JsonProperty("new_approvalprocess_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewApprovalProcessAgentId { get; set; }

        [JsonProperty("new_approvalprocess_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewApprovalProcessUserId { get; set; }

        [JsonProperty("new_approvalprocess_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UsersList>? NewApprovalProcessUsers { get; set; }

        [JsonProperty("new_approvalprocess_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewApprovalProcessEmail { get; set; }

        [JsonProperty("new_approvalprocess_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewApprovalProcessCabId { get; set; }

        [JsonProperty("new_approvalprocess_cab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CabMember>? NewApprovalProcessCab { get; set; }

        [JsonProperty("new_product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewProductId { get; set; }

        [JsonProperty("new_component_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewComponentId { get; set; }

        [JsonProperty("new_version_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewVersionId { get; set; }

        [JsonProperty("new_matched_kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewMatchedKbId { get; set; }

        [JsonProperty("new_matched_linked_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewMatchedLinkedId { get; set; }

        [JsonProperty("new_linkedticket_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewLinkedticketTemplateId { get; set; }

        [JsonProperty("new_supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSupplierId { get; set; }

        [JsonProperty("new_supplier_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewSupplierRef { get; set; }

        [JsonProperty("new_customer_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewCustomerRef { get; set; }

        [JsonProperty("new_supplier_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSupplierContractId { get; set; }

        [JsonProperty("new_supplier_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSupplierPriorityId { get; set; }

        [JsonProperty("new_supplier_response_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewSupplierResponseDate { get; set; }

        [JsonProperty("new_supplier_fix_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewSupplierFixDate { get; set; }

        [JsonProperty("new_linkedticket_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewLinkedticketStatus { get; set; }

        [JsonProperty("new_appointment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewAppointmentType { get; set; }

        [JsonProperty("emailtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EmailtemplateId { get; set; }

        [JsonProperty("create_article", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateArticle { get; set; }

        [JsonProperty("sendemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendemail { get; set; }

        [JsonProperty("action_showpreview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionShowpreview { get; set; }

        [JsonProperty("setnotetoemailbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Setnotetoemailbody { get; set; }

        [JsonProperty("action_isresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionIsresponse { get; set; }

        [JsonProperty("validate_response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateResponse { get; set; }

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Attachments { get; set; }

        [JsonProperty("update_children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateChildren { get; set; }

        [JsonProperty("update_parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateParent { get; set; }

        [JsonProperty("send_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendSurvey { get; set; }

        [JsonProperty("signature_customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SignatureCustomer { get; set; }

        [JsonProperty("signature_customer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SignatureCustomerName { get; set; }

        [JsonProperty("signature_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SignatureAgent { get; set; }

        [JsonProperty("signature_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SignatureAgentName { get; set; }

        [JsonProperty("follow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Follow { get; set; }

        [JsonProperty("unfollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unfollow { get; set; }

        [JsonProperty("primaryserviceusersfollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primaryserviceusersfollow { get; set; }

        [JsonProperty("appointment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppointmentId { get; set; }

        [JsonProperty("appointment_complete_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppointmentCompleteStatus { get; set; }

        [JsonProperty("add_followup_appointment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddFollowupAppointment { get; set; }

        [JsonProperty("add_followup_task", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddFollowupTask { get; set; }

        [JsonProperty("_appointment_force", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AppointmentForce { get; set; }

        [JsonProperty("copy_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CopyToId { get; set; }

        [JsonProperty("third_party_product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyProductId { get; set; }

        [JsonProperty("third_party_version_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyVersionId { get; set; }

        [JsonProperty("_forcereassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceReassign { get; set; }

        [JsonProperty("_appointment01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Appointment01Ok { get; set; }

        [JsonProperty("_agent01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Agent01Ok { get; set; }

        [JsonProperty("_agent02_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Agent02Ok { get; set; }

        [JsonProperty("_ticketclash01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TicketClash01Ok { get; set; }

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanUpdate { get; set; }

        [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DeviceList>? Assets { get; set; }

        [JsonProperty("dont_do_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontDoRules { get; set; }

        [JsonProperty("_includeticketinresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeTicketInResponse { get; set; }

        [JsonProperty("jira_original_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? JiraOriginalEstimate { get; set; }

        [JsonProperty("jira_remaining_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? JiraRemainingEstimate { get; set; }

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; }

        [JsonProperty("actionoohtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ActionOohTime { get; set; }

        [JsonProperty("actionholidaytime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ActionHolidayTime { get; set; }

        [JsonProperty("actiontotaloohtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ActionTotalOohTime { get; set; }

        [JsonProperty("quotation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotationId { get; set; }

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesOrderId { get; set; }

        [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PurchaseOrderId { get; set; }

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InvoiceId { get; set; }

        [JsonProperty("recalculate_billing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecalculateBilling { get; set; }

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsImport { get; set; }

        [JsonProperty("_isinboundsales", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInboundSales { get; set; }

        [JsonProperty("sendactiontopagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendActionToPagerDuty { get; set; }

        [JsonProperty("oktoclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OkToClose { get; set; }

        [JsonProperty("remotetechid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RemoteTechId { get; set; }

        [JsonProperty("utcoffset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? UtcOffset { get; set; }

        [JsonProperty("statisfaction_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StatisfactionLevel { get; set; }

        [JsonProperty("senttoapisupplierid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SentToApiSupplierId { get; set; }

        [JsonProperty("send_jira_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendJiraAttachments { get; set; }

        [JsonProperty("jira_reporter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? JiraReporter { get; set; }

        /// <summary>
        /// If the action involved sending an SMS text message, then this is the recipient of the SMS message.
        /// </summary>
        [JsonProperty("smsto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SmsTo { get; set; }

        [JsonProperty("sendsms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendSms { get; set; }

        [JsonProperty("_dontupdate_devops", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontUpdateDevOps { get; set; }

        [JsonProperty("send_devops_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendDevOpsNote { get; set; }

        [JsonProperty("_isnotify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNotify { get; set; }

        [JsonProperty("move_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MoveToId { get; set; }

        [JsonProperty("sendactiontosplunkoncall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendActionToSplunkOnCall { get; set; }

        [JsonProperty("third_party_who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyWho { get; set; }

        [JsonProperty("_faultForce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FaultForce { get; set; }

        [JsonProperty("private_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrivateNote { get; set; }

        [JsonProperty("isBulkEmail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBulkEmail { get; set; }

        [JsonProperty("new_workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewWorkflowId { get; set; }

        [JsonProperty("_sendtweet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendTweet { get; set; }

        [JsonProperty("replyto_tweet_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReplyToTweetId { get; set; }

        [JsonProperty("replyto_tweet_haloid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplyToTweetHaloId { get; set; }

        [JsonProperty("changeinformationhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChangeInformationHtml { get; set; }

        [JsonProperty("justification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Justification { get; set; }

        [JsonProperty("impactlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ImpactLevel { get; set; }

        [JsonProperty("impactdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImpactDescription { get; set; }

        [JsonProperty("risklevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RiskLevel { get; set; }

        [JsonProperty("riskdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RiskDescription { get; set; }

        [JsonProperty("backoutplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BackoutPlan { get; set; }

        [JsonProperty("communicationplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CommunicationPlan { get; set; }

        [JsonProperty("testplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TestPlan { get; set; }

        [JsonProperty("showonroadmap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOnRoadmap { get; set; }

        [JsonProperty("roadmapnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RoadmapNote { get; set; }

        [JsonProperty("releasenote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReleaseNote { get; set; }

        [JsonProperty("releaseid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseId { get; set; }

        [JsonProperty("releaseid2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseId2 { get; set; }

        [JsonProperty("releaseid3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseId3 { get; set; }

        [JsonProperty("releasenotegroupid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseNoteGroupId { get; set; }

        [JsonProperty("releaseimportant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReleaseImportant { get; set; }

        [JsonProperty("new_jira_components", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? NewJiraComponents { get; set; }

        [JsonProperty("faultidfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FaultIdFrom { get; set; }

        [JsonProperty("actionnumberfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionNumberFrom { get; set; }

        [JsonProperty("new_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewTemplateId { get; set; }

        [JsonProperty("new_primary_asset_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewPrimaryAssetStatus { get; set; }

        [JsonProperty("primary_asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrimaryAssetId { get; set; }

        [JsonProperty("new_rule_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewRuleIds { get; set; }

        [JsonProperty("dont_update_fault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontUpdateFault { get; set; }

        [JsonProperty("new_article_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewArticleDescription { get; set; }

        [JsonProperty("new_article_resolution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewArticleResolution { get; set; }

        [JsonProperty("new_article_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewArticleNotes { get; set; }

        [JsonProperty("new_article_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewArticleType { get; set; }

        [JsonProperty("new_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tag>? NewTags { get; set; }

        [JsonProperty("new_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaqListHead>? NewFaqLists { get; set; }

        [JsonProperty("new_related_articles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KbArticleList>? NewRelatedArticles { get; set; }

        [JsonProperty("ignoredatedoneisstartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreDateDoneIsStartDate { get; set; }

        [JsonProperty("sentinel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelId { get; set; }

        [JsonProperty("_validate_travel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateTravel { get; set; }

        [JsonProperty("sync_to_sentinel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncToSentinel { get; set; }

        [JsonProperty("sentinel_classification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelClassification { get; set; }

        [JsonProperty("sentinel_classification_reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelClassificationReason { get; set; }

        [JsonProperty("g2aremote_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? G2ARemoteId { get; set; }

        [JsonProperty("dontcreatechild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontCreateChild { get; set; }

        [JsonProperty("needcreatechild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedCreateChild { get; set; }

        [JsonProperty("customfieldvalidationreason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CustomFieldValidationReason { get; set; }

        [JsonProperty("servicestatusnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceStatusNote { get; set; }

        [JsonProperty("updateservicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateServiceStatus { get; set; }

        [JsonProperty("new_child_cat_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewChildCat1 { get; set; }

        [JsonProperty("new_child_cat_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewChildCat2 { get; set; }

        [JsonProperty("new_child_cat_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewChildCat3 { get; set; }

        [JsonProperty("new_child_cat_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewChildCat4 { get; set; }

        [JsonProperty("usecroverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseCrOverride { get; set; }

        [JsonProperty("azure_action_complete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureActionComplete { get; set; }

        [JsonProperty("_dontupdate_jira", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontUpdateJira { get; set; }

        [JsonProperty("send_jira_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendJiraNote { get; set; }

        [JsonProperty("entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EntityType { get; set; }

        [JsonProperty("rmm_close", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RmmClose { get; set; }

        [JsonProperty("dattormm_close", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DattoRmmClose { get; set; }

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? ExternalLinks { get; set; }

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLinkList? NewExternalLink { get; set; }

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchThirdPartyId { get; set; }

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MatchIntegrationId { get; set; }

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchIntegrationName { get; set; }

        [JsonProperty("sync_to_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncToSalesforce { get; set; }

        [JsonProperty("isbillingaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBillingAction { get; set; }

        [JsonProperty("ishiddenfrominternalit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHiddenFromInternalIt { get; set; }

        [JsonProperty("new_consignment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ConsignmentHeader>? NewConsignment { get; set; }

        [JsonProperty("faultstimeentryid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FaultsTimeEntryId { get; set; }

        [JsonProperty("billingoverriddenbytimeentry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingOverriddenByTimeEntry { get; set; }

        [JsonProperty("sync_to_servicenow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncToServiceNow { get; set; }

        [JsonProperty("new_service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewServiceId { get; set; }

        [JsonProperty("new_asset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Asset? NewAsset { get; set; }

        [JsonProperty("contract_date_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ContractDateOverride { get; set; }

        [JsonProperty("parentactionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentActionNumber { get; set; }

        [JsonProperty("parentactiondetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentActionDetails { get; set; }

        [JsonProperty("parentactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ParentActionDate { get; set; }

        [JsonProperty("user_creation_failed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserCreationFailed { get; set; }

        [JsonProperty("followers_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UsersList>? FollowersUser { get; set; }

        [JsonProperty("new_items_issued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketItem>? NewItemsIssued { get; set; }

        [JsonProperty("purchaseordernumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PurchaseOrderNumber { get; set; }

        [JsonProperty("database_lookup_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DatabaseLookupResult? DatabaseLookupResult { get; set; }

        [JsonProperty("new_supplier_contact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSupplierContactId { get; set; }

        [JsonProperty("new_pr_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewPrId { get; set; }

        [JsonProperty("new_branch_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewBranchId { get; set; }

        [JsonProperty("_dontupdate_pagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontUpdatePagerDuty { get; set; }

        [JsonProperty("pagerdutyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PagerDutyId { get; set; }

        [JsonProperty("facebook_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FacebookFromId { get; set; }

        [JsonProperty("twitter_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwitterFromId { get; set; }

        [JsonProperty("sync_to_jira", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncToJira { get; set; }

        [JsonProperty("is_jira_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsJiraSupplier { get; set; }

        [JsonProperty("senttojirasupplierid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Senttojirasupplierid { get; set; }

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportType { get; set; }

        [JsonProperty("itsm_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItsmSummary { get; set; }

        [JsonProperty("send_to_halo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendToHalo { get; set; }

        [JsonProperty("send_to_whatsapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendToWhatsapp { get; set; }

        [JsonProperty("_ignore_ai", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreAi { get; set; }

        [JsonProperty("_ignore_translate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreTranslate { get; set; }

        [JsonProperty("translate_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TranslateNote { get; set; }

        [JsonProperty("new_approvalprocess_role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewApprovalProcessRoleId { get; set; }

        [JsonProperty("new_approvalprocess_customfieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewApprovalProcessCustomFieldId { get; set; }

        [JsonProperty("new_thirdpartyreviewscore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewThirdPartyReviewScore { get; set; }

        [JsonProperty("new_additional_agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketAdditionalAgents>? NewAdditionalAgents { get; set; }

        [JsonProperty("instagramid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InstagramId { get; set; }

        [JsonProperty("instagramname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InstagramName { get; set; }

        [JsonProperty("instagram_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InstagramParentId { get; set; }

        [JsonProperty("send_to_instagram", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendToInstagram { get; set; }

        [JsonProperty("replyto_instagram_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReplyToInstagramId { get; set; }

        [JsonProperty("senttoinsta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SentToInsta { get; set; }

        [JsonProperty("instagram_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InstagramFromId { get; set; }

        [JsonProperty("dont_recalculate_billing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontRecalculateBilling { get; set; }

        [JsonProperty("is_third_party_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsThirdPartySupplier { get; set; }

        [JsonProperty("senttoservicenowsupplierid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SentToServiceNowSupplierId { get; set; }

        [JsonProperty("timesheet_approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TimesheetApprovalStatus { get; set; }

        [JsonProperty("_changeprivate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChangePrivate { get; set; }

        [JsonProperty("defprepayinvoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefPrepayInvoiceNumber { get; set; }

        [JsonProperty("defprepaydateinvoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DefPrepayDateInvoiced { get; set; }

        [JsonProperty("defprepayamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DefPrepayAmount { get; set; }

        [JsonProperty("new_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewColour { get; set; }

        [JsonProperty("send_to_googlebusiness", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendToGoogleBusiness { get; set; }

        [JsonProperty("original_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OriginalAgent { get; set; }

        [JsonProperty("_isreplyaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReplyAction { get; set; }

        [JsonProperty("milestone_bill_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MilestoneBillId { get; set; }

        [JsonProperty("new_foppjobtitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewFOppJobTitle { get; set; }

        [JsonProperty("bigpanda_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BigPandaId { get; set; }

        [JsonProperty("servicenow_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceNowType { get; set; }

        [JsonProperty("internet_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InternetMessageId { get; set; }

        [JsonProperty("allow_automation_on_related", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAutomationOnRelated { get; set; }

        [JsonProperty("replying_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplyingTo { get; set; }

        [JsonProperty("lapsafe_expiry_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LapsafeExpiryDate { get; set; }

        [JsonProperty("lapsafe_asset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LapsafeAsset { get; set; }

        [JsonProperty("lapsafe_bay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LapsafeBay { get; set; }

        [JsonProperty("lapsafe_bay_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LapsafeBayId { get; set; }

        [JsonProperty("lapsafe_installation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LapsafeInstallation { get; set; }

        [JsonProperty("_slackaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlackAction { get; set; }

        [JsonProperty("_isportalagentnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPortalAgentNote { get; set; }

        [JsonProperty("devops_pipeline_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DevOpsPipelineId { get; set; }

        [JsonProperty("devops_pipeline_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DevOpsPipelineVersion { get; set; }

        [JsonProperty("new_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStep { get; set; }

        [JsonProperty("rr_log", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RoundRobinLog? RrLog { get; set; }

        [JsonProperty("new_contributors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Contributors>? NewContributors { get; set; }

        [JsonProperty("nextcalldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NextCallDate { get; set; }

        [JsonProperty("satisfaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Satisfaction { get; set; }

        [JsonProperty("new_CRM_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AreaNote? NewCrmNote { get; set; }

        [JsonProperty("new_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Template? NewTemplate { get; set; }

        [JsonProperty("_agent03_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Agent03Ok { get; set; }

        [JsonProperty("_can_edit_billing_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanEditBillingTime { get; set; }

        [JsonProperty("run_ai_insights", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RunAiInsights { get; set; }

        [JsonProperty("new_customer_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewCustomerSignature { get; set; }

        [JsonProperty("new_agent_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewAgentSignature { get; set; }

        [JsonProperty("_prevent_outgoing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PreventOutgoing { get; set; }

        [JsonProperty("new_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewClientId { get; set; }

        [JsonProperty("new_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSiteId { get; set; }

        [JsonProperty("new_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewUserId { get; set; }

        [JsonProperty("prepay_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PrePayThreshold? PrePayThreshold { get; set; }

        [JsonProperty("outgoingid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OutgoingId { get; set; }

        [JsonProperty("is_halo_ack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHaloAck { get; set; }

        [JsonProperty("isundeliverable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUndeliverable { get; set; }

        [JsonProperty("new_distribution_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewDistributionList { get; set; }

        [JsonProperty("new_bulkemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BulkEmail? NewBulkEmail { get; set; }

        [JsonProperty("bulkemail_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? BulkEmailUsers { get; set; }

        [JsonProperty("outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OutcomeId { get; set; }

        [JsonProperty("action_systemid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionSystemId { get; set; }

        [JsonProperty("dateemailed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateEmailed { get; set; }

        [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeTaken { get; set; }

        [JsonProperty("timetakendays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeTakenDays { get; set; }

        [JsonProperty("timetakenadjusted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeTakenAdjusted { get; set; }

        [JsonProperty("nonbilltime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NonBillTime { get; set; }

        [JsonProperty("traveltime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TravelTime { get; set; }

        [JsonProperty("mileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Mileage { get; set; }

        [JsonProperty("actionchargehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ActionChargeHours { get; set; }

        [JsonProperty("actionnonchargeamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ActionNonChargeAmount { get; set; }

        [JsonProperty("actionnonchargehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ActionNonChargeHours { get; set; }

        [JsonProperty("actionchargeamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ActionChargeAmount { get; set; }

        [JsonProperty("actionprepayhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ActionPrepayHours { get; set; }

        [JsonProperty("actionprepayamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ActionPrepayAmount { get; set; }

        [JsonProperty("actiontravelchargehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ActionTravelChargeHours { get; set; }

        [JsonProperty("chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargeRate { get; set; }

        [JsonProperty("travel_chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TravelChargeRate { get; set; }

        [JsonProperty("hiddenfromuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HiddenFromUser { get; set; }

        [JsonProperty("important", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Important { get; set; }

        [JsonProperty("old_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OldStatus { get; set; }

        [JsonProperty("new_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStatus { get; set; }

        [JsonProperty("new_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewStatusName { get; set; }

        [JsonProperty("emailfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailFrom { get; set; }

        [JsonProperty("emailtonew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailToNew { get; set; }

        [JsonProperty("emailto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailTo { get; set; }

        [JsonProperty("emailccnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailCcNew { get; set; }

        [JsonProperty("emaildirection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailDirection { get; set; }

        [JsonProperty("emailcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailCc { get; set; }

        [JsonProperty("emailsubjectnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailSubjectNew { get; set; }

        [JsonProperty("senttoapiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentToApiUrl { get; set; }

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; }

        [JsonProperty("attachment_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachmentCount { get; set; }

        [JsonProperty("unread", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unread { get; set; }

        [JsonProperty("actionby_application_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionByApplicationId { get; set; }

        [JsonProperty("action_travel_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionTravelContractRef { get; set; }

        [JsonProperty("actionby_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionByUserId { get; set; }

        [JsonProperty("hide_user_visibility_toggle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideUserVisibilityToggle { get; set; }

    }