using System.CodeDom.Compiler;
using Angelic.Appointments;
using Angelic.Configuration.Emails;
using Angelic.Items;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Microsoft.ExchangeWebServices;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class EwsAppointmentBasic
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ItemId? Id { get; set; } 

        [JsonProperty("iCalUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CalUid { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start { get; set; } 

        [JsonProperty("end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End { get; set; } 

        [JsonProperty("organizer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EmailAddress? Organizer { get; set; } 

        [JsonProperty("appointmentType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppointmentType? AppointmentType { get; set; } 

        [JsonProperty("isAllDayEvent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAllDayEvent { get; set; } 

        [JsonProperty("isRecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRecurring { get; set; } 

        [JsonProperty("isMeeting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMeeting { get; set; } 

    }