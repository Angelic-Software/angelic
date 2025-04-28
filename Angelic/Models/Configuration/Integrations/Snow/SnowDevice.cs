using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Snow;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SnowDevice
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("organization", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Organization { get; set; } 

    [JsonProperty("orgChecksum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrgChecksum { get; set; } 

    [JsonProperty("manufacturer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Manufacturer { get; set; } 

    [JsonProperty("model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Model { get; set; } 

    [JsonProperty("operatingSystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OperatingSystem { get; set; } 

    [JsonProperty("operatingSystemServicePack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OperatingSystemServicePack { get; set; } 

    [JsonProperty("isVirtual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsVirtual { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("ipAddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IpAddresses { get; set; } 

    [JsonProperty("lastScanDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastScanDate { get; set; } 

    [JsonProperty("updatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UpdatedBy { get; set; } 

    [JsonProperty("updatedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? UpdatedDate { get; set; } 

    [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Domain { get; set; } 

    [JsonProperty("totalDiskSpace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalDiskSpace { get; set; } 

    [JsonProperty("physicalMemory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PhysicalMemory { get; set; } 

    [JsonProperty("processorType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProcessorType { get; set; } 

    [JsonProperty("processorCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProcessorCount { get; set; } 

    [JsonProperty("coreCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CoreCount { get; set; } 

    [JsonProperty("biosSerialNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BiosSerialNumber { get; set; } 

    [JsonProperty("hypervisorName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HypervisorName { get; set; } 

    [JsonProperty("mostFrequentUserId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MostFrequentUserId { get; set; } 

    [JsonProperty("mostRecentUserId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MostRecentUserId { get; set; } 

    [JsonProperty("hardware", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SnowHardware? Hardware { get; set; } 

    [JsonProperty("biosVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BiosVersion { get; set; } 

    [JsonProperty("biosDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? BiosDate { get; set; } 

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

    [JsonProperty("phoneNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneNumber { get; set; } 

    [JsonProperty("mobileDeviceType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MobileDeviceType { get; set; } 

}