using System.CodeDom.Compiler;
using Angelic.Attributes;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Addresses;

// ReSharper disable once StringLiteralTypo
[HasEndpoint("Addressbook")]
[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AddressBook
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }

    [JsonProperty("global", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Global { get; set; }

    [JsonProperty("mailboxid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailboxId { get; set; }

    [JsonProperty("unum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unum { get; set; }

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }

    [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddress { get; set; }

    [JsonProperty("exchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Exchange { get; set; }

    [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Address { get; set; }

    [JsonProperty("section", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Section { get; set; }

    [JsonProperty("contactuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContactUid { get; set; }

    [JsonProperty("contactunum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContactUnum { get; set; }

    [JsonProperty("contactgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContactGroup { get; set; }

    [JsonProperty("contactgroupcontacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContactGroupContacts>? ContactGroupContacts { get; set; }

    [JsonProperty("contacttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContactType { get; set; }

    [JsonProperty("selectedaddressbook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SelectedAddressBook { get; set; }

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
