namespace Angelic.Models.Action;

internal class ActionsClient : IActionsClient
{
    public async Task<T> GetAsync<T>(int id, Dictionary<string, string> queryParams = null)
    {
        throw new NotImplementedException();
    }

    public async Task<T> PostAsync<T>(T body)
    {
        throw new NotImplementedException();
    }

    public async Task<T> DeleteAsync<T>(int id)
    {
        throw new NotImplementedException();
    }
}