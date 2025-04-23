using System.CodeDom.Compiler;
using Angelic.Dtos;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class HaloNews
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("css", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Css { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("button_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Button_label { get; set; } 

        [JsonProperty("button_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Button_url { get; set; } 

        [JsonProperty("height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; } 

        [JsonProperty("theme_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Theme_name { get; set; } 

        [JsonProperty("theme_base", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Theme_base { get; set; } 

        [JsonProperty("theme_css", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Theme_css { get; set; } 

        [JsonProperty("theme_colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Theme_colour_type { get; set; } 

        [JsonProperty("theme_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Theme_colour { get; set; } 

        [JsonProperty("one_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? One_version { get; set; } 

        [JsonProperty("one_patch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? One_patch { get; set; } 

        [JsonProperty("min_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Min_version { get; set; } 

        [JsonProperty("min_version_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Min_version_seq { get; set; } 

        [JsonProperty("max_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Max_version { get; set; } 

        [JsonProperty("max_version_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Max_version_seq { get; set; } 

        [JsonProperty("one_dbid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? One_dbid { get; set; } 

        [JsonProperty("one_product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? One_product { get; set; } 

        [JsonProperty("db_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Db_location { get; set; } 

        [JsonProperty("version_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Version_group { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_date { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; } 

        [JsonProperty("agent_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_type { get; set; } 

        [JsonProperty("customer_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customer_type { get; set; } 

        [JsonProperty("enabled_module", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Enabled_module { get; set; } 

        [JsonProperty("read", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Read { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Header
    {
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Offset { get; set; } 

        [JsonProperty("field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public HeaderId? Id { get; set; } 

        [JsonProperty("rawField", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[]? RawField { get; set; } 

        [JsonProperty("rawValue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[]? RawValue { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum HeaderId
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

        _3 = 3,

        _4 = 4,

        _5 = 5,

        _6 = 6,

        _7 = 7,

        _8 = 8,

        _9 = 9,

        _10 = 10,

        _11 = 11,

        _12 = 12,

        _13 = 13,

        _14 = 14,

        _15 = 15,

        _16 = 16,

        _17 = 17,

        _18 = 18,

        _19 = 19,

        _20 = 20,

        _21 = 21,

        _22 = 22,

        _23 = 23,

        _24 = 24,

        _25 = 25,

        _26 = 26,

        _27 = 27,

        _28 = 28,

        _29 = 29,

        _30 = 30,

        _31 = 31,

        _32 = 32,

        _33 = 33,

        _34 = 34,

        _35 = 35,

        _36 = 36,

        _37 = 37,

        _38 = 38,

        _39 = 39,

        _40 = 40,

        _41 = 41,

        _42 = 42,

        _43 = 43,

        _44 = 44,

        _45 = 45,

        _46 = 46,

        _47 = 47,

        _48 = 48,

        _49 = 49,

        _50 = 50,

        _51 = 51,

        _52 = 52,

        _53 = 53,

        _54 = 54,

        _55 = 55,

        _56 = 56,

        _57 = 57,

        _58 = 58,

        _59 = 59,

        _60 = 60,

        _61 = 61,

        _62 = 62,

        _63 = 63,

        _64 = 64,

        _65 = 65,

        _66 = 66,

        _67 = 67,

        _68 = 68,

        _69 = 69,

        _70 = 70,

        _71 = 71,

        _72 = 72,

        _73 = 73,

        _74 = 74,

        _75 = 75,

        _76 = 76,

        _77 = 77,

        _78 = 78,

        _79 = 79,

        _80 = 80,

        _81 = 81,

        _82 = 82,

        _83 = 83,

        _84 = 84,

        _85 = 85,

        _86 = 86,

        _87 = 87,

        _88 = 88,

        _89 = 89,

        _90 = 90,

        _91 = 91,

        _92 = 92,

        _93 = 93,

        _94 = 94,

        _95 = 95,

        _96 = 96,

        _97 = 97,

        _98 = 98,

        _99 = 99,

        _100 = 100,

        _101 = 101,

        _102 = 102,

        _103 = 103,

        _104 = 104,

        _105 = 105,

        _106 = 106,

        _107 = 107,

        _108 = 108,

        _109 = 109,

        _110 = 110,

        _111 = 111,

        _112 = 112,

        _113 = 113,

        _114 = 114,

        _115 = 115,

        _116 = 116,

        _117 = 117,

        _118 = 118,

        _119 = 119,

        _120 = 120,

        _121 = 121,

        _122 = 122,

        _123 = 123,

        _124 = 124,

        _125 = 125,

        _126 = 126,

        _127 = 127,

        _128 = 128,

        _129 = 129,

        _130 = 130,

        __1 = -1,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Holidays
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; } 

        [JsonProperty("holid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Holid { get; set; } 

        [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workday_id { get; set; } 

        [JsonProperty("workday_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Workday_guid { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; } 

        [JsonProperty("allday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allday { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Duration { get; set; } 

        [JsonProperty("holiday_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Holiday_type { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity { get; set; } 

        [JsonProperty("_force", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _force { get; set; } 

        [JsonProperty("date_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_only { get; set; } 

        [JsonProperty("end_date_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date_only { get; set; } 

        [JsonProperty("isrecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isrecurring { get; set; } 

        [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Schedule? Schedule { get; set; } 

        [JsonProperty("schedulehandledtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Schedulehandledtype { get; set; } 

        [JsonProperty("createnextappt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createnextappt { get; set; } 

        [JsonProperty("approval_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approval_start { get; set; } 

        [JsonProperty("approvalnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvalnote { get; set; } 

        [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_status { get; set; } 

        [JsonProperty("_return_appointment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _return_appointment { get; set; } 

        [JsonProperty("appointmentobj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Appointment? Appointmentobj { get; set; } 

        [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartyid { get; set; } 

        [JsonProperty("date_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_datetime { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class HtmlDesign
    {
        [JsonProperty("design", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Design { get; set; } 

        [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Html { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class HubspotWebhook
    {
        [JsonProperty("eventId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EventId { get; set; } 

        [JsonProperty("subscriptionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SubscriptionId { get; set; } 

        [JsonProperty("portalId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PortalId { get; set; } 

        [JsonProperty("appId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? AppId { get; set; } 

        [JsonProperty("occurredAt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? OccurredAt { get; set; } 

        [JsonProperty("subscriptionType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SubscriptionType { get; set; } 

        [JsonProperty("attemptNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AttemptNumber { get; set; } 

        [JsonProperty("objectId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ObjectId { get; set; } 

        [JsonProperty("objectTypeId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ObjectTypeId { get; set; } 

        [JsonProperty("propertyName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PropertyName { get; set; } 

        [JsonProperty("propertyValue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PropertyValue { get; set; } 

        [JsonProperty("changeSource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChangeSource { get; set; } 

        [JsonProperty("sourceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SourceId { get; set; } 

        [JsonProperty("isSensitive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSensitive { get; set; } 

        [JsonProperty("changeFlag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChangeFlag { get; set; } 

        [JsonProperty("eventTypeNum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RelayEventType? EventTypeNum { get; set; } 

        [JsonProperty("eventCategoryNum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RelayEventCategory? EventCategoryNum { get; set; } 

    }