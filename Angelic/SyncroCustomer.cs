using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

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