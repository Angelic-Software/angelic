namespace Angelic.Client;

public interface IAngelicClient
{
    Task<T> GetAsync<T>(int id, Dictionary<string, string> queryParams = null);
    Task<T> PostAsync<T>(T body);
    Task<T> DeleteAsync<T>(int id);
}