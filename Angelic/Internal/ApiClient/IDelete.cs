namespace Angelic.Internal.ApiClient;

internal interface IDelete
{
   Task DeleteAsync(string endpoint, int entity); 
}