using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Angelic.AdobeAcrobatDocument;

namespace Angelic.AdobeAcrobatDocumentsinfo;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AdobeAcrobatDocumentsInfo
{
    [JsonProperty("documents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AdobeAcrobatDocument>? Documents { get; set; }
}
