using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Snow;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record SnowHardware
{
    [JsonProperty("biosSerialNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BiosSerialNumber { get; set; } 

    [JsonProperty("biosVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BiosVersion { get; set; } 

    [JsonProperty("biosDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? BiosDate { get; set; } 

    [JsonProperty("processorType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProcessorType { get; set; } 

    [JsonProperty("numberOfProcessors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NumberOfProcessors { get; set; } 

    [JsonProperty("coresPerProcessor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CoresPerProcessor { get; set; } 

    [JsonProperty("physicalMemoryMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PhysicalMemoryMb { get; set; } 

    [JsonProperty("memorySlots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MemorySlots { get; set; } 

    [JsonProperty("memorySlotsAvailable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MemorySlotsAvailable { get; set; } 

    [JsonProperty("systemDiskSpaceMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SystemDiskSpaceMb { get; set; } 

    [JsonProperty("systemDiskSpaceAvailableMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SystemDiskSpaceAvailableMb { get; set; } 

    [JsonProperty("totalDiskSpaceMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalDiskSpaceMb { get; set; } 

    [JsonProperty("totalDiskSpaceAvailableMb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalDiskSpaceAvailableMb { get; set; } 

}