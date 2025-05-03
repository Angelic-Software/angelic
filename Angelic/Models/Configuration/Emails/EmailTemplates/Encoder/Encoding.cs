using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailTemplates.Encoder;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Encoding
{
    [JsonProperty("bodyName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BodyName { get; set; } 

    [JsonProperty("encodingName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EncodingName { get; set; } 

    [JsonProperty("headerName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HeaderName { get; set; } 

    [JsonProperty("webName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebName { get; set; } 

    [JsonProperty("windowsCodePage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WindowsCodePage { get; set; } 

    [JsonProperty("isBrowserDisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsBrowserDisplay { get; set; } 

    [JsonProperty("isBrowserSave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsBrowserSave { get; set; } 

    [JsonProperty("isMailNewsDisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsMailNewsDisplay { get; set; } 

    [JsonProperty("isMailNewsSave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsMailNewsSave { get; set; } 

    [JsonProperty("isSingleByte", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSingleByte { get; set; } 

    [JsonProperty("encoderFallback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public EncoderFallback? EncoderFallback { get; set; } 

    [JsonProperty("decoderFallback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DecoderFallback? DecoderFallback { get; set; } 

    [JsonProperty("isReadOnly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsReadOnly { get; set; } 

    [JsonProperty("codePage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CodePage { get; set; } 

}