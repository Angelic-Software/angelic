using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.HtmlDesigns;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record HtmlDesign
{
    [JsonProperty("design", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Design { get; set; } 
    
    [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Html { get; set; } 

}