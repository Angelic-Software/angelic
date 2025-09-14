using System.CodeDom.Compiler;
using Angelic.Attributes;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.BookingTypes;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    [HasEndpoint("BookingType")]
    public record BookingType
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetTypeId { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("duration_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationType { get; set; } 

        [JsonProperty("duration_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationMins { get; set; } 

        [JsonProperty("duration_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationDays { get; set; } 

        [JsonProperty("appointment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppointmentType { get; set; } 

        [JsonProperty("customslots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Timeslot>? CustomSlots { get; set; } 

        [JsonProperty("messagehtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MessageHtml { get; set; } 

        [JsonProperty("resourcebooking_buffer_minutes_before", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceBookingBufferMinutesBefore { get; set; } 

        [JsonProperty("resourcebooking_buffer_minutes_after", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceBookingBufferMinutesAfter { get; set; } 

        [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TypeName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }