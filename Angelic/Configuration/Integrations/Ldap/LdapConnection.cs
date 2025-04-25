using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Ldap;





    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LdapConnection
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectionType { get; set; } 

        [JsonProperty("hostname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hostname { get; set; } 

        [JsonProperty("domainname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domainname { get; set; } 

        [JsonProperty("authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuthenticationType { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("integrator_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegratorPassword { get; set; } 

        [JsonProperty("basedn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Basedn { get; set; } 

        [JsonProperty("synccontacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Synccontacts { get; set; } 

        [JsonProperty("external", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? External { get; set; } 

        [JsonProperty("phppassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phppassword { get; set; } 

        [JsonProperty("pagesize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagesize { get; set; } 

        [JsonProperty("port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Port { get; set; } 

        [JsonProperty("use_ssl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSsl { get; set; } 

        [JsonProperty("mappings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LdapName>? MappingsUser { get; set; } 

        [JsonProperty("mappings_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LdapName>? MappingsAgent { get; set; } 

        [JsonProperty("ldap_strings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LdapString>? LdapStrings { get; set; } 

        [JsonProperty("useadauthentication", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Useadauthentication { get; set; } 

        [JsonProperty("_is_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTest { get; set; } 

        [JsonProperty("_connection_success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConnectionSuccess { get; set; } 

        [JsonProperty("_connection_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectionMessage { get; set; } 

        [JsonProperty("_get_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GetMappings { get; set; } 

        [JsonProperty("_containers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LdapString>? Containers { get; set; } 

        [JsonProperty("_containerfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Containerfilter { get; set; } 

        [JsonProperty("_get_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GetUsers { get; set; } 

        [JsonProperty("_userfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userfilter { get; set; } 

        [JsonProperty("_new_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewOnly { get; set; } 

        [JsonProperty("cab_ldap_strings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LdapString>? CabLdapStrings { get; set; } 

        [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegratorenabled { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HalointegratorLastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HalointegratorLasterror { get; set; } 

        [JsonProperty("halointegrator_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HalointegratorImporttype { get; set; } 

        [JsonProperty("halointegrator_batch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HalointegratorBatch { get; set; } 

        [JsonProperty("halointegrator_ipaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HalointegratorIpaddress { get; set; } 

        [JsonProperty("halointegrator_allowedclientidslist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelKeyPair>? HalointegratorAllowedclientidslist { get; set; } 

        [JsonProperty("halointegrator_allowedclientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HalointegratorAllowedclientids { get; set; } 

        [JsonProperty("user_matching_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserMatchingFields { get; set; } 

        [JsonProperty("agent_matching_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AgentMatchingFields { get; set; } 

        [JsonProperty("user_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? UserMatchingList { get; set; } 

        [JsonProperty("agent_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? AgentMatchingList { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewPassword { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewMethod { get; set; } 

        [JsonProperty("allow_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAccess { get; set; } 

        [JsonProperty("syncedstrings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Syncedstrings { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("uactguidmappingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Uactguidmappingfield { get; set; } 

        [JsonProperty("new_user_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewUserTemplate { get; set; } 

        [JsonProperty("new_user_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewUserType { get; set; } 

        [JsonProperty("mappings_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LdapName>? MappingsNewUser { get; set; } 

        [JsonProperty("new_user_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewUserTemplateName { get; set; } 

    }