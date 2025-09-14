namespace Angelic;

public class AngelicClientOptions
{
    public const string sectionName = "AngelicClient";
    public string HaloBaseUrl { get; set; } = string.Empty;
    public string HaloClientId { get; set; } = string.Empty;
    public string HaloClientSecret { get; set; } = string.Empty;
    public string[] HaloApiScopes { get; set; } = [];
}