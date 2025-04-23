using System.CodeDom.Compiler;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

   [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class VMWorkspaceDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("region", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Region { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("vmworkspace_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Vmworkspace_clientid { get; set; } 

        [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_integration_key { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_integration_method { get; set; } 

        [JsonProperty("default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_devicesite { get; set; } 

        [JsonProperty("default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_devicesite_name { get; set; } 

        [JsonProperty("default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_devicetype { get; set; } 

        [JsonProperty("default_devicetypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_devicetypename { get; set; } 

        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetimportidentifier { get; set; } 

        [JsonProperty("assetimportidentifier_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetimportidentifier_fieldname { get; set; } 

        [JsonProperty("vmworkspace_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Vmworkspace_fieldmappings { get; set; } 

        [JsonProperty("sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Sitemappings { get; set; } 

        [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableintegrator { get; set; } 

        [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastsyncdate { get; set; } 

        [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastsyncerror { get; set; } 

        [JsonProperty("halo_integrator_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_integrator_import_list { get; set; } 

        [JsonProperty("halo_integrator_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Halo_integrator_import_types { get; set; } 

        [JsonProperty("delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delete_devices { get; set; } 

        [JsonProperty("dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_create_new_devices { get; set; } 

        [JsonProperty("dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_update_device_type { get; set; } 

        [JsonProperty("dont_move_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_move_site { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Mappings_xtype { get; set; } 

        [JsonProperty("default_assetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_assetgroup { get; set; } 

        [JsonProperty("default_assetgroupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_assetgroupname { get; set; } 

        [JsonProperty("assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_choice { get; set; } 

        [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_field { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ViewColumns
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("tile_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tile_html { get; set; } 

        [JsonProperty("columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ViewColumnsDetails>? Columns { get; set; } 

        [JsonProperty("_temp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _temp { get; set; } 

        [JsonProperty("card_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Card_html { get; set; } 

        [JsonProperty("linked_dashboard_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_dashboard_id { get; set; } 

        [JsonProperty("use_dashboard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_dashboard { get; set; } 

        [JsonProperty("include_children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_children { get; set; } 

        [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restriction_type { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Team_id { get; set; } 

        [JsonProperty("team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Team_guid { get; set; } 

        [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ViewColumnsDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("columns_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Columns_id { get; set; } 

        [JsonProperty("column_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Column_seq { get; set; } 

        [JsonProperty("column_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Column_name { get; set; } 

        [JsonProperty("width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; } 

        [JsonProperty("order_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Order_seq { get; set; } 

        [JsonProperty("order_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Order_desc { get; set; } 

        [JsonProperty("column_title_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Column_title_override { get; set; } 

        [JsonProperty("groupbystatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Groupbystatus { get; set; } 

        [JsonProperty("columns_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Columns_guid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ViewFilter
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Team_id { get; set; } 

        [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type_name { get; set; } 

        [JsonProperty("sys_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sys_id { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ViewFilterDetails>? Filters { get; set; } 

        [JsonProperty("_temp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _temp { get; set; } 

        [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restriction_type { get; set; } 

        [JsonProperty("team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Team_guid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ViewFilterDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("filter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filter_id { get; set; } 

        [JsonProperty("list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? List_id { get; set; } 

        [JsonProperty("itemsupplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itemsupplier_id { get; set; } 

        [JsonProperty("area_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Area_id { get; set; } 

        [JsonProperty("filter_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filter_name { get; set; } 

        [JsonProperty("filter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filter_type { get; set; } 

        [JsonProperty("filter_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filter_value { get; set; } 

        [JsonProperty("filter_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? Filter_values { get; set; } 

        [JsonProperty("multiselect_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MultiselectFilter>? Multiselect_value { get; set; } 

        [JsonProperty("filter_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Filter_guid { get; set; } 

        [JsonProperty("list_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? List_guid { get; set; } 

        [JsonProperty("itemsupplier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Itemsupplier_guid { get; set; } 

        [JsonProperty("filter_value_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Filter_value_guid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ViewListGroup
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("collapsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Collapsed { get; set; } 

        [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ViewLists
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restriction_type { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Team_id { get; set; } 

        [JsonProperty("team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Team_guid { get; set; } 

        [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type_name { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("showcounts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showcounts { get; set; } 

        [JsonProperty("column_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Column_profile_id { get; set; } 

        [JsonProperty("column_profile_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Column_profile_guid { get; set; } 

        [JsonProperty("filter_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filter_profile_id { get; set; } 

        [JsonProperty("filter_profile_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Filter_profile_guid { get; set; } 

        [JsonProperty("lock_view_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lock_view_type { get; set; } 

        [JsonProperty("connectedinstance_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectedinstance_id { get; set; } 

        [JsonProperty("connectedinstance_list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectedinstance_list_id { get; set; } 

        [JsonProperty("show_in_team_tree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_in_team_tree { get; set; } 

        [JsonProperty("show_in_team_tree_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Show_in_team_tree_team_id { get; set; } 

        [JsonProperty("show_in_team_tree_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Show_in_team_tree_team_name { get; set; } 

        [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_count { get; set; } 

        [JsonProperty("connectedinstance_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Connectedinstance_error { get; set; } 

        [JsonProperty("column_profile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Column_profile_name { get; set; } 

        [JsonProperty("filter_profile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filter_profile_name { get; set; } 

        [JsonProperty("connectedinstance_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectedinstance_name { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ViewFilterDetails>? Filters { get; set; } 

        [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Group_name { get; set; } 

        [JsonProperty("group_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_seq { get; set; } 

        [JsonProperty("group_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_type { get; set; } 

        [JsonProperty("group_collapsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Group_collapsed { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class VirimaDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenantid { get; set; } 

        [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_integration_key { get; set; } 

        [JsonProperty("default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_devicesite { get; set; } 

        [JsonProperty("default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_devicesite_name { get; set; } 

        [JsonProperty("default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_devicetype { get; set; } 

        [JsonProperty("default_devicetypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_devicetypename { get; set; } 

        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetimportidentifier { get; set; } 

        [JsonProperty("assetimportidentifier_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetimportidentifier_fieldname { get; set; } 

        [JsonProperty("fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Fieldmappings { get; set; } 

        [JsonProperty("sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Sitemappings { get; set; } 

        [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableintegrator { get; set; } 

        [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastsyncdate { get; set; } 

        [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastsyncerror { get; set; } 

        [JsonProperty("delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delete_devices { get; set; } 

        [JsonProperty("dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_create_new_devices { get; set; } 

        [JsonProperty("dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_update_device_type { get; set; } 

        [JsonProperty("dont_move_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_move_site { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Mappings_xtype { get; set; } 

        [JsonProperty("default_assetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_assetgroup { get; set; } 

        [JsonProperty("default_assetgroupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_assetgroupname { get; set; } 

        [JsonProperty("assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_choice { get; set; } 

        [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_field { get; set; } 

        [JsonProperty("use_user_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_user_site { get; set; } 

        [JsonProperty("override_site_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override_site_rules { get; set; } 

        [JsonProperty("dont_remove_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_remove_users { get; set; } 

        [JsonProperty("relation_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Relation_sync { get; set; } 

        [JsonProperty("software_import_licence_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Software_import_licence_matching { get; set; } 

        [JsonProperty("default_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_status { get; set; } 

        [JsonProperty("default_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_status_name { get; set; } 

        [JsonProperty("delete_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Delete_status { get; set; } 

        [JsonProperty("delete_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delete_status_name { get; set; } 

        [JsonProperty("user_matching_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_matching_field { get; set; } 

        [JsonProperty("_clearlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _clearlastsync { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class VirtualAgent
    {
        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connection_type { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Use { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("_connection_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _connection_enabled { get; set; } 

        [JsonProperty("_instructions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _instructions { get; set; } 

        [JsonProperty("_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _model { get; set; } 

        [JsonProperty("_update_tools", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _update_tools { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }