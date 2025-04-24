using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Tweet
{
    [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Created_at { get; set; } 

    [JsonProperty("timestamp_ms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Timestamp_ms { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; } 

    [JsonProperty("id_str", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id_str { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("truncated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Truncated { get; set; } 

    [JsonProperty("entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TweetEntities? Entities { get; set; } 

    [JsonProperty("in_reply_to_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? In_reply_to_status_id { get; set; } 

    [JsonProperty("in_reply_to_status_id_str", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? In_reply_to_status_id_str { get; set; } 

    [JsonProperty("in_reply_to_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? In_reply_to_user_id { get; set; } 

    [JsonProperty("in_reply_to_user_id_str", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? In_reply_to_user_id_str { get; set; } 

    [JsonProperty("in_reply_to_screen_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? In_reply_to_screen_name { get; set; } 

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TweetUser? User { get; set; } 

    [JsonProperty("retweet_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Retweet_count { get; set; } 

    [JsonProperty("favorite_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Favorite_count { get; set; } 

    [JsonProperty("favorited", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Favorited { get; set; } 

    [JsonProperty("retweeted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Retweeted { get; set; } 

    [JsonProperty("lang", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lang { get; set; } 

}