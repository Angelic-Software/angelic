namespace Angelic;

public class AngelicClientOptions
{
    public const string SectionName = "AngelicClient"; // Optional: A constant for your config section name
    public string HaloBaseUrl { get; set; } = string.Empty;
    public string HaloClientId { get; set; } = string.Empty;
    public string HaloClientSecret { get; set; } = string.Empty;
    public string[] HaloApiScopes { get; set; } = [];
}