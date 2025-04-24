using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;





    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LDAPConnection
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
        public string? Connection_type { get; set; } 

        [JsonProperty("hostname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hostname { get; set; } 

        [JsonProperty("domainname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domainname { get; set; } 

        [JsonProperty("authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Authentication_type { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("integrator_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integrator_password { get; set; } 

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
        public bool? Use_ssl { get; set; } 

        [JsonProperty("mappings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPName>? Mappings_user { get; set; } 

        [JsonProperty("mappings_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPName>? Mappings_agent { get; set; } 

        [JsonProperty("ldap_strings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPString>? Ldap_strings { get; set; } 

        [JsonProperty("useadauthentication", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Useadauthentication { get; set; } 

        [JsonProperty("_is_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_test { get; set; } 

        [JsonProperty("_connection_success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _connection_success { get; set; } 

        [JsonProperty("_connection_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _connection_message { get; set; } 

        [JsonProperty("_get_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _get_mappings { get; set; } 

        [JsonProperty("_containers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPString>? _containers { get; set; } 

        [JsonProperty("_containerfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _containerfilter { get; set; } 

        [JsonProperty("_get_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _get_users { get; set; } 

        [JsonProperty("_userfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _userfilter { get; set; } 

        [JsonProperty("_new_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _new_only { get; set; } 

        [JsonProperty("cab_ldap_strings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPString>? Cab_ldap_strings { get; set; } 

        [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegratorenabled { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_lastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_lasterror { get; set; } 

        [JsonProperty("halointegrator_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halointegrator_importtype { get; set; } 

        [JsonProperty("halointegrator_batch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halointegrator_batch { get; set; } 

        [JsonProperty("halointegrator_ipaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_ipaddress { get; set; } 

        [JsonProperty("halointegrator_allowedclientidslist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelKeyPair>? Halointegrator_allowedclientidslist { get; set; } 

        [JsonProperty("halointegrator_allowedclientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_allowedclientids { get; set; } 

        [JsonProperty("user_matching_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_matching_fields { get; set; } 

        [JsonProperty("agent_matching_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_matching_fields { get; set; } 

        [JsonProperty("user_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? User_matching_list { get; set; } 

        [JsonProperty("agent_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Agent_matching_list { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_password { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("allow_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_access { get; set; } 

        [JsonProperty("syncedstrings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Syncedstrings { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("uactguidmappingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Uactguidmappingfield { get; set; } 

        [JsonProperty("new_user_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_user_template { get; set; } 

        [JsonProperty("new_user_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_user_type { get; set; } 

        [JsonProperty("mappings_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPName>? Mappings_new_user { get; set; } 

        [JsonProperty("new_user_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_user_template_name { get; set; } 

    }