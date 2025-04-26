namespace Angelic.Internal.ApiClient;

internal interface IGet
{
    Task<T> GetAsync<T>(string endpoint, int entity, Dictionary<string, string>? parameters = null);
}