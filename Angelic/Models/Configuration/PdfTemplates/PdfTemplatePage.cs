using System.CodeDom.Compiler;
using Angelic.Models.HtmlDesigns;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.PdfTemplates;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PdfTemplatePage
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PdfTemplateId { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("mainhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MainHtml { get; set; } 

        [JsonProperty("maindesign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public HtmlDesign? MainDesign { get; set; } 

        [JsonProperty("subhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SubHtml { get; set; } 

        [JsonProperty("subhtml2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SubHtml2 { get; set; } 

        [JsonProperty("subhtml3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SubHtml3 { get; set; } 

        [JsonProperty("istitlepage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTitlePage { get; set; } 

        [JsonProperty("backgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BackgroundImageUrl { get; set; } 

        [JsonProperty("content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Content { get; set; } 

        [JsonProperty("toggle_editor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ToggleEditor { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }