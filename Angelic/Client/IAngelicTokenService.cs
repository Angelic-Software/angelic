namespace Angelic.Client;

public interface IAngelicTokenService
{
    Task<string> GetTokenAsync();
}