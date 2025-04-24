using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class BusinessCentralCustomer
{
    [JsonProperty("odataetag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Odataetag { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Number { get; set; } 

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("addressLine1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AddressLine1 { get; set; } 

    [JsonProperty("addressLine2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AddressLine2 { get; set; } 

    [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? City { get; set; } 

    [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? State { get; set; } 

    [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Country { get; set; } 

    [JsonProperty("postalCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PostalCode { get; set; } 

    [JsonProperty("phoneNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneNumber { get; set; } 

    [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; } 

    [JsonProperty("website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Website { get; set; } 

    [JsonProperty("salespersonCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SalespersonCode { get; set; } 

    [JsonProperty("balanceDue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public float? BalanceDue { get; set; } 

    [JsonProperty("creditLimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreditLimit { get; set; } 

    [JsonProperty("taxLiable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TaxLiable { get; set; } 

    [JsonProperty("taxAreaId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxAreaId { get; set; } 

    [JsonProperty("taxAreaDisplayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxAreaDisplayName { get; set; } 

    [JsonProperty("taxRegistrationNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxRegistrationNumber { get; set; } 

    [JsonProperty("currencyId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CurrencyId { get; set; } 

    [JsonProperty("currencyCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CurrencyCode { get; set; } 

    [JsonProperty("paymentTermsId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PaymentTermsId { get; set; } 

    [JsonProperty("shipmentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ShipmentMethodId { get; set; } 

    [JsonProperty("paymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PaymentMethodId { get; set; } 

    [JsonProperty("blocked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Blocked { get; set; } 

    [JsonProperty("lastModifiedDateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastModifiedDateTime { get; set; } 

}