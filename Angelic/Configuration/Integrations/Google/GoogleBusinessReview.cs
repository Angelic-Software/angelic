using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class GoogleBusinessReview
{
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("reviewId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReviewId { get; set; } 

    [JsonProperty("reviewer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GoogleReviewer? Reviewer { get; set; } 

    [JsonProperty("starRating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StarRating { get; set; } 

    [JsonProperty("comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Comment { get; set; } 

    [JsonProperty("createTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreateTime { get; set; } 

    [JsonProperty("updateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UpdateTime { get; set; } 

    [JsonProperty("reviewReply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GoogleBusinessReviewReply? ReviewReply { get; set; } 

    [JsonProperty("gbdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Gbdid { get; set; } 

    [JsonProperty("starRating_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StarRatingInt { get; set; } 

}