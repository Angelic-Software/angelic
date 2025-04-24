using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Organisation
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("reply_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Reply_address { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Messagegroup_id { get; set; } 

    [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? Address { get; set; } 

    [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phone { get; set; } 

    [JsonProperty("fax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fax { get; set; } 

    [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; } 

    [JsonProperty("website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Website { get; set; } 

    [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Logo { get; set; } 

    [JsonProperty("portal_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Portal_logo { get; set; } 

    [JsonProperty("portalbackgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(500)]
    public string? Portalbackgroundimageurl { get; set; } 

    [JsonProperty("deliverysite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Deliverysite { get; set; } 

    [JsonProperty("portalurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Portalurl { get; set; } 

    [JsonProperty("portalcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Portalcolour { get; set; } 

    [JsonProperty("portalfolderlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Portalfolderlocation { get; set; } 

    [JsonProperty("departments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tree_List>? Departments { get; set; } 

    [JsonProperty("linked_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Linked_client_id { get; set; } 

    [JsonProperty("allowall_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_tickettypes { get; set; } 

    [JsonProperty("allowed_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<RequestType_List>? Allowed_tickettypes { get; set; } 

    [JsonProperty("faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FAQListHead>? Faqlists { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("isorganisationdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isorganisationdetails { get; set; } 

    [JsonProperty("bank_details_line_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Bank_details_line_1 { get; set; } 

    [JsonProperty("bank_details_line_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Bank_details_line_2 { get; set; } 

    [JsonProperty("bank_details_line_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Bank_details_line_3 { get; set; } 

    [JsonProperty("bank_details_line_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Bank_details_line_4 { get; set; } 

    [JsonProperty("bank_details_line_5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Bank_details_line_5 { get; set; } 

    [JsonProperty("tax_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tax_number { get; set; } 

    [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_icon { get; set; } 

    [JsonProperty("portal_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Portal_title { get; set; } 

    [JsonProperty("user_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FAQListHead>? User_faqlists { get; set; } 

    [JsonProperty("all_user_faqlists_allowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? All_user_faqlists_allowed { get; set; } 

    [JsonProperty("portal_chat_profile_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Portal_chat_profile_override { get; set; } 

    [JsonProperty("portal_chat_profile_override_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Portal_chat_profile_override_name { get; set; } 

}