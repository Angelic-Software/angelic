using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft.Csp;


    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public record CspCustomer
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("companyProfile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CspCustomerProfile? CompanyProfile { get; set; } 

        [JsonProperty("relationshipToPartner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RelationshipToPartner { get; set; } 

    }