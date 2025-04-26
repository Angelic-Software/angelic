namespace Angelic.Internal.ApiClient;

internal interface IPost
{
    Task<T> PostAsync<T>(string endpoint, T? data);
}