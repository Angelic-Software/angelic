namespace Angelic.Internal.ApiClient;

internal interface IGetAll
{
    Task<T> GetAllAsync<T>(string endpoint, Dictionary<string, string>? parameters = null);
}