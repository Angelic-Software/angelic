using System.CodeDom.Compiler;
using Angelic.Areas;
using Angelic.Assets;
using Angelic.Attachments;
using Angelic.Configuration;
using Angelic.Configuration.CustomFields;
using Newtonsoft.Json;

namespace Angelic.Users;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Users
{
    [JsonProperty("is_comms_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsCommsUser { get; set; } 

    [JsonProperty("ischangeapprover2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ischangeapprover2 { get; set; } 

    [JsonProperty("sitephonenumberint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Sitephonenumberint { get; set; } 

    [JsonProperty("phonenumberint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Phonenumberint { get; set; } 

    [JsonProperty("homenumberint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Homenumberint { get; set; } 

    [JsonProperty("mobileint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Mobileint { get; set; } 

    [JsonProperty("mobilenumber2int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Mobilenumber2Int { get; set; } 

    [JsonProperty("faxint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Faxint { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? SiteId { get; set; } 

    [JsonProperty("site_id_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteIdInt { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("firstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Firstname { get; set; } 

    [JsonProperty("surname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Surname { get; set; } 

    [JsonProperty("initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Initials { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; } 

    [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddress { get; set; } 

    [JsonProperty("phonenumber_preferred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhonenumberPreferred { get; set; } 

    [JsonProperty("sitephonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sitephonenumber { get; set; } 

    [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phonenumber { get; set; } 

    [JsonProperty("homenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Homenumber { get; set; } 

    [JsonProperty("mobilenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mobilenumber { get; set; } 

    [JsonProperty("mobilenumber2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mobilenumber2 { get; set; } 

    [JsonProperty("fax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fax { get; set; } 

    [JsonProperty("telpref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Telpref { get; set; } 

    [JsonProperty("activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActivedirectoryDn { get; set; } 

    [JsonProperty("onpremise_activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OnpremiseActivedirectoryDn { get; set; } 

    [JsonProperty("container_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContainerDn { get; set; } 

    [JsonProperty("login", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Login { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("isimportantcontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimportantcontact { get; set; } 

    [JsonProperty("other1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Other1 { get; set; } 

    [JsonProperty("other2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Other2 { get; set; } 

    [JsonProperty("other3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Other3 { get; set; } 

    [JsonProperty("other4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Other4 { get; set; } 

    [JsonProperty("other5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Other5 { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("neversendemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Neversendemails { get; set; } 

    [JsonProperty("default_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultCurrencyCode { get; set; } 

    [JsonProperty("site_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteGuid { get; set; } 

    [JsonProperty("area_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AreaGuid { get; set; } 

    [JsonProperty("site_cautomate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteCautomateGuid { get; set; } 

    [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PriorityId { get; set; } 

    [JsonProperty("linked_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedAgentId { get; set; } 

    [JsonProperty("covered_by_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CoveredByContract { get; set; } 

    [JsonProperty("contract_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ContractValue { get; set; } 

    [JsonProperty("software_role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SoftwareRoleName { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Attachment>? Attachments { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("relationship_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RelationshipId { get; set; } 

    [JsonProperty("user_relationships", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<XTypeRole>? UserRelationships { get; set; } 

    [JsonProperty("uddevsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Uddevsite { get; set; } 

    [JsonProperty("uddevnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Uddevnum { get; set; } 

    [JsonProperty("uduserid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Uduserid { get; set; } 

    [JsonProperty("userdevicerolecount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Userdevicerolecount { get; set; } 

    [JsonProperty("site_hubspot_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteHubspotGuid { get; set; } 

    [JsonProperty("isserviceaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isserviceaccount { get; set; } 

    [JsonProperty("ignoreautomatedbilling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ignoreautomatedbilling { get; set; } 

    [JsonProperty("isimportantcontact2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimportantcontact2 { get; set; } 

    [JsonProperty("connectwiseid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Connectwiseid { get; set; } 

    [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Autotaskid { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessagegroupId { get; set; } 

    [JsonProperty("role_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleList { get; set; } 

    [JsonProperty("sitetimezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sitetimezone { get; set; } 

    [JsonProperty("client_account_manager_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientAccountManagerId { get; set; } 

    [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datecreated { get; set; } 

    [JsonProperty("inv1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv1 { get; set; } 

    [JsonProperty("inv2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv2 { get; set; } 

    [JsonProperty("inv3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv3 { get; set; } 

    [JsonProperty("inv4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv4 { get; set; } 

    [JsonProperty("slaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Slaid { get; set; } 

    [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewPassword { get; set; } 

    [JsonProperty("dontackemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontackemails { get; set; } 

    [JsonProperty("web_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WebAccessLevel { get; set; } 

    [JsonProperty("showmeonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ShowMeonly { get; set; } 

    [JsonProperty("showrecentonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Showrecentonly { get; set; } 

    [JsonProperty("inform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inform { get; set; } 

    [JsonProperty("inv1site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv1Site { get; set; } 

    [JsonProperty("inv2site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv2Site { get; set; } 

    [JsonProperty("inv3site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv3Site { get; set; } 

    [JsonProperty("inv4site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv4Site { get; set; } 

    [JsonProperty("inv5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv5 { get; set; } 

    [JsonProperty("inv6", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv6 { get; set; } 

    [JsonProperty("inv7", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv7 { get; set; } 

    [JsonProperty("inv8", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv8 { get; set; } 

    [JsonProperty("inv9", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv9 { get; set; } 

    [JsonProperty("inv10", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv10 { get; set; } 

    [JsonProperty("inv5site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv5Site { get; set; } 

    [JsonProperty("inv6site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv6Site { get; set; } 

    [JsonProperty("inv7site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv7Site { get; set; } 

    [JsonProperty("inv8site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv8Site { get; set; } 

    [JsonProperty("inv9site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv9Site { get; set; } 

    [JsonProperty("inv10site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv10Site { get; set; } 

    [JsonProperty("informaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Informaction { get; set; } 

    [JsonProperty("informclearance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Informclearance { get; set; } 

    [JsonProperty("inv11", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv11 { get; set; } 

    [JsonProperty("inv12", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv12 { get; set; } 

    [JsonProperty("inv13", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv13 { get; set; } 

    [JsonProperty("inv14", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv14 { get; set; } 

    [JsonProperty("inv15", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv15 { get; set; } 

    [JsonProperty("inv16", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv16 { get; set; } 

    [JsonProperty("inv17", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv17 { get; set; } 

    [JsonProperty("inv18", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv18 { get; set; } 

    [JsonProperty("inv19", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv19 { get; set; } 

    [JsonProperty("inv20", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv20 { get; set; } 

    [JsonProperty("inv21", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv21 { get; set; } 

    [JsonProperty("inv22", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv22 { get; set; } 

    [JsonProperty("inv23", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv23 { get; set; } 

    [JsonProperty("inv24", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv24 { get; set; } 

    [JsonProperty("inv25", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv25 { get; set; } 

    [JsonProperty("inv11site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv11Site { get; set; } 

    [JsonProperty("inv12site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv12Site { get; set; } 

    [JsonProperty("inv13site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv13Site { get; set; } 

    [JsonProperty("inv14site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv14Site { get; set; } 

    [JsonProperty("inv15site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv15Site { get; set; } 

    [JsonProperty("inv16site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv16Site { get; set; } 

    [JsonProperty("inv17site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv17Site { get; set; } 

    [JsonProperty("inv18site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv18Site { get; set; } 

    [JsonProperty("inv19site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv19Site { get; set; } 

    [JsonProperty("inv20site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv20Site { get; set; } 

    [JsonProperty("inv21site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv21Site { get; set; } 

    [JsonProperty("inv22site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv22Site { get; set; } 

    [JsonProperty("inv23site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv23Site { get; set; } 

    [JsonProperty("inv24site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv24Site { get; set; } 

    [JsonProperty("inv25site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inv25Site { get; set; } 

    [JsonProperty("showslatimes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showslatimes { get; set; } 

    [JsonProperty("canadd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canadd { get; set; } 

    [JsonProperty("allowviewsitedocs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowviewsitedocs { get; set; } 

    [JsonProperty("third_party_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyGuid { get; set; } 

    [JsonProperty("third_party_sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartySql { get; set; } 

    [JsonProperty("ischangeapprover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ischangeapprover { get; set; } 

    [JsonProperty("cancreateuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Cancreateuser { get; set; } 

    [JsonProperty("department", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Department { get; set; } 

    [JsonProperty("isheadofdept", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isheadofdept { get; set; } 

    [JsonProperty("deputysite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Deputysite { get; set; } 

    [JsonProperty("deputyusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Deputyusername { get; set; } 

    [JsonProperty("cat2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cat2 { get; set; } 

    [JsonProperty("lastlogindate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastlogindate { get; set; } 

    [JsonProperty("email2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email2 { get; set; } 

    [JsonProperty("email3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email3 { get; set; } 

    [JsonProperty("iscontractcontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Iscontractcontact { get; set; } 

    [JsonProperty("informnewarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Informnewarea { get; set; } 

    [JsonProperty("informactionarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Informactionarea { get; set; } 

    [JsonProperty("informclearancearea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Informclearancearea { get; set; } 

    [JsonProperty("disclaimermatchstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Disclaimermatchstring { get; set; } 

    [JsonProperty("viewallcleared", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Viewallcleared { get; set; } 

    [JsonProperty("isexternal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isexternal { get; set; } 

    [JsonProperty("question1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Question1 { get; set; } 

    [JsonProperty("question2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Question2 { get; set; } 

    [JsonProperty("question3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Question3 { get; set; } 

    [JsonProperty("question4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Question4 { get; set; } 

    [JsonProperty("question5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Question5 { get; set; } 

    [JsonProperty("dontaddtomailinglist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontaddtomailinglist { get; set; } 

    [JsonProperty("caneditwebdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Caneditwebdetails { get; set; } 

    [JsonProperty("cataloglevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cataloglevel { get; set; } 

    [JsonProperty("canaccesscatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canaccesscatalog { get; set; } 

    [JsonProperty("hasbeentrained", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hasbeentrained { get; set; } 

    [JsonProperty("admanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Admanager { get; set; } 

    [JsonProperty("canviewcontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canviewcontracts { get; set; } 

    [JsonProperty("ispoapprover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ispoapprover { get; set; } 

    [JsonProperty("encmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Encmethod { get; set; } 

    [JsonProperty("adconnection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Adconnection { get; set; } 

    [JsonProperty("useadlogin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Useadlogin { get; set; } 

    [JsonProperty("sendwelcomeemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sendwelcomeemail { get; set; } 

    [JsonProperty("welcomeemail_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WelcomeemailTemplateId { get; set; } 

    [JsonProperty("resetpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Resetpassword { get; set; } 

    [JsonProperty("_anonymise", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Anonymise { get; set; } 

    [JsonProperty("_reassign_all_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReassignAllToUser { get; set; } 

    [JsonProperty("ismaincontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ismaincontact { get; set; } 

    [JsonProperty("primary_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? PrimaryAddress { get; set; } 

    [JsonProperty("addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AddressStore>? Addresses { get; set; } 

    [JsonProperty("departments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserDepartment>? Departments { get; set; } 

    [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrganisationId { get; set; } 

    [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AreaPopup>? PopupNotes { get; set; } 

    [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenTicketCount { get; set; } 

    [JsonProperty("onhold_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OnholdTicketCount { get; set; } 

    [JsonProperty("total_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalTicketCount { get; set; } 

    [JsonProperty("opened_thismonth_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenedThismonthCount { get; set; } 

    [JsonProperty("_isnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isnew { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

    [JsonProperty("memberof", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Memberof { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("usercompany", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserCompany>? Usercompany { get; set; } 

    [JsonProperty("supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public UserSupplier? Supplier { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierName { get; set; } 

    [JsonProperty("claims", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<NhdClaim>? Claims { get; set; } 

    [JsonProperty("app_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppColour { get; set; } 

    [JsonProperty("emailconfirmed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Emailconfirmed { get; set; } 

    [JsonProperty("agent_app_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentAppUrl { get; set; } 

    [JsonProperty("imagedata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Imagedata { get; set; } 

    [JsonProperty("webannouncement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webannouncement { get; set; } 

    [JsonProperty("cautomateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cautomateid { get; set; } 

    [JsonProperty("azure_connectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AzureConnectionid { get; set; } 

    [JsonProperty("_importtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Importtoken { get; set; } 

    [JsonProperty("jira_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraId { get; set; } 

    [JsonProperty("zapier_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ZapierClientName { get; set; } 

    [JsonProperty("delegation_activated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DelegationActivated { get; set; } 

    [JsonProperty("delegation_timebased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DelegationTimebased { get; set; } 

    [JsonProperty("delegation_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DelegationStart { get; set; } 

    [JsonProperty("delegation_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DelegationEnd { get; set; } 

    [JsonProperty("delegation_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DelegationUserId { get; set; } 

    [JsonProperty("delegation_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DelegationUserName { get; set; } 

    [JsonProperty("googleworkplace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GoogleworkplaceId { get; set; } 

    [JsonProperty("isnhserveremaildefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isnhserveremaildefault { get; set; } 

    [JsonProperty("matchprimaryemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Matchprimaryemail { get; set; } 

    [JsonProperty("servicenow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicenowId { get; set; } 

    [JsonProperty("servicenow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicenowUsername { get; set; } 

    [JsonProperty("site_servicenow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteServicenowId { get; set; } 

    [JsonProperty("sgatewayid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sgatewayid { get; set; } 

    [JsonProperty("software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetApplications>? Software { get; set; } 

    [JsonProperty("canaccessinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canaccessinvoices { get; set; } 

    [JsonProperty("samaccountname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Samaccountname { get; set; } 

    [JsonProperty("oktaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Oktaid { get; set; } 

    [JsonProperty("okta_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OktaStatus { get; set; } 

    [JsonProperty("authenticatorapp_configured", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AuthenticatorappConfigured { get; set; } 

    [JsonProperty("_revoke_authenticatorapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RevokeAuthenticatorapp { get; set; } 

    [JsonProperty("ulastupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Ulastupdate { get; set; } 

    [JsonProperty("_isopp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isopp { get; set; } 

    [JsonProperty("oppcompanyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Oppcompanyname { get; set; } 

    [JsonProperty("oppcontactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Oppcontactname { get; set; } 

    [JsonProperty("oppemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Oppemailaddress { get; set; } 

    [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DeviceList>? Assets { get; set; } 

    [JsonProperty("locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Locked { get; set; } 

    [JsonProperty("site_guid2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteGuid2 { get; set; } 

    [JsonProperty("allowviewclientdocs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowviewclientdocs { get; set; } 

    [JsonProperty("azure_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureTenantId { get; set; } 

    [JsonProperty("azure_last_login_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? AzureLastLoginDate { get; set; } 

    [JsonProperty("linked_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedUserId { get; set; } 

    [JsonProperty("linked_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LinkedUserName { get; set; } 

    [JsonProperty("hubspot_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HubspotId { get; set; } 

    [JsonProperty("hubspot_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HubspotUrl { get; set; } 

    [JsonProperty("hubspot_dont_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HubspotDontSync { get; set; } 

    [JsonProperty("hubspot_archived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HubspotArchived { get; set; } 

    [JsonProperty("passportal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? PassportalId { get; set; } 

    [JsonProperty("passportal_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? PassportalClientId { get; set; } 

    [JsonProperty("opportunity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpportunityId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("isuserdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isuserdetails { get; set; } 

    [JsonProperty("hudu_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HuduUrl { get; set; } 

    [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlimportId { get; set; } 

    [JsonProperty("sqlimport_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlimportUser { get; set; } 

    [JsonProperty("unsubscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Unsubscribed { get; set; } 

    [JsonProperty("canviewopps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canviewopps { get; set; } 

    [JsonProperty("azure_tenant_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureTenantDomain { get; set; } 

    [JsonProperty("servicenow_companyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicenowCompanyid { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? ExternalLinks { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchThirdpartyId { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchIntegrationId { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchIntegrationName { get; set; } 

    [JsonProperty("salesforce_dontsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SalesforceDontsync { get; set; } 

    [JsonProperty("_hascontactsenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hascontactsenabled { get; set; } 

    [JsonProperty("new_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewSiteName { get; set; } 

    [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isbatch { get; set; } 

    [JsonProperty("roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserRoles>? Roles { get; set; } 

    [JsonProperty("azure_roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AzureRoleid { get; set; } 

    [JsonProperty("add_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserRoles>? AddRoles { get; set; } 

    [JsonProperty("facebook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? FacebookId { get; set; } 

    [JsonProperty("facebook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FacebookUsername { get; set; } 

    [JsonProperty("twitter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? TwitterId { get; set; } 

    [JsonProperty("twitter_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TwitterUsername { get; set; } 

    [JsonProperty("_merge_user_into", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MergeUserInto { get; set; } 

    [JsonProperty("_email_collision", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailCollision { get; set; } 

    [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontFireAutomations { get; set; } 

    [JsonProperty("device_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeviceAccessLevel { get; set; } 

    [JsonProperty("ticket_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? TicketCustomFields { get; set; } 

    [JsonProperty("manager_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ManagerEmail { get; set; } 

    [JsonProperty("_remove_licenses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RemoveLicenses { get; set; } 

    [JsonProperty("_new_usersite_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewUsersiteOnly { get; set; } 

    [JsonProperty("thirdpartygroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserThirdPartyGroup>? Thirdpartygroups { get; set; } 

    [JsonProperty("linked_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? LinkedSites { get; set; } 

    [JsonProperty("dontackemails2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontackemails2 { get; set; } 

    [JsonProperty("instagram_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? InstagramId { get; set; } 

    [JsonProperty("instagram_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InstagramUsername { get; set; } 

    [JsonProperty("jira_instance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? JiraInstance { get; set; } 

    [JsonProperty("jira_instance_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraInstanceName { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("no_manager_roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NoManagerRoleid { get; set; } 

    [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchingValue { get; set; } 

    [JsonProperty("theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Theme { get; set; } 

    [JsonProperty("lang", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lang { get; set; } 

    [JsonProperty("gocardless_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, string?>? GocardlessCustomFields { get; set; } 

    [JsonProperty("service_account_overridden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ServiceAccountOverridden { get; set; } 

    [JsonProperty("sendaccountsemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sendaccountsemails { get; set; } 

    [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tabname>? Extratabs { get; set; } 

    [JsonProperty("informifack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Informifack { get; set; } 

    [JsonProperty("informnewareaifack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Informnewareaifack { get; set; } 

    [JsonProperty("marketing_unsubscribes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MarketingUnsubscribe>? MarketingUnsubscribes { get; set; } 

    [JsonProperty("new_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAccountName { get; set; } 

    [JsonProperty("prospect_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProspectAccountId { get; set; } 

    [JsonProperty("open_opportunity_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenOpportunityCount { get; set; } 

    [JsonProperty("_convert_phonenumbers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConvertPhonenumbers { get; set; } 

    [JsonProperty("update_user_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateUserTickets { get; set; } 

    [JsonProperty("check_update_user_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CheckUpdateUserTickets { get; set; } 

    [JsonProperty("canuploaddocuments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canuploaddocuments { get; set; } 

    [JsonProperty("runbook_button_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RunbookButtonId { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Key { get; set; } 

    [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TableEnum? Table { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemTaxCode { get; set; } 

    [JsonProperty("automatic_sales_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutomaticSalesTax { get; set; } 

    [JsonProperty("client_taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ClientTaxable { get; set; } 

    [JsonProperty("overridepdftemplatequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Overridepdftemplatequote { get; set; } 

    [JsonProperty("overridepdftemplatequote_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverridepdftemplatequoteName { get; set; } 

    [JsonProperty("contract_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ContractEndDate { get; set; } 

    [JsonProperty("okta_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OktaId { get; set; } 

    [JsonProperty("azure_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureId { get; set; } 

    [JsonProperty("user_with_clientsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserWithClientsite { get; set; } 

    [JsonProperty("client_automatic_callscript_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientAutomaticCallscriptId { get; set; } 

    [JsonProperty("neversendmarketingemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Neversendmarketingemails { get; set; } 

    [JsonProperty("is_prospect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsProspect { get; set; } 

    [JsonProperty("whatsapp_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WhatsappNumber { get; set; } 

    [JsonProperty("azureoid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Azureoid { get; set; } 

    [JsonProperty("date_of_birth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateOfBirth { get; set; } 

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportTypeId { get; set; } 

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Importthirdpartyid { get; set; } 

}