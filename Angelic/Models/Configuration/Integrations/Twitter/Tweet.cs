using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Twitter;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Tweet
{
    [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreatedAt { get; set; } 

    [JsonProperty("timestamp_ms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? TimestampMs { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; } 

    [JsonProperty("id_str", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IdStr { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("truncated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Truncated { get; set; } 

    [JsonProperty("entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TweetEntities? Entities { get; set; } 

    [JsonProperty("in_reply_to_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? InReplyToStatusId { get; set; } 

    [JsonProperty("in_reply_to_status_id_str", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InReplyToStatusIdStr { get; set; } 

    [JsonProperty("in_reply_to_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? InReplyToUserId { get; set; } 

    [JsonProperty("in_reply_to_user_id_str", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InReplyToUserIdStr { get; set; } 

    [JsonProperty("in_reply_to_screen_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InReplyToScreenName { get; set; } 

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TweetUser? User { get; set; } 

    [JsonProperty("retweet_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RetweetCount { get; set; } 

    [JsonProperty("favorite_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FavoriteCount { get; set; } 

    [JsonProperty("favorited", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Favorited { get; set; } 

    [JsonProperty("retweeted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Retweeted { get; set; } 

    [JsonProperty("lang", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lang { get; set; } 

}