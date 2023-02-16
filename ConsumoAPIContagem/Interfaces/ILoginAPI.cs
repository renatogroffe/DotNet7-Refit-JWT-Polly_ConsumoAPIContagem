using Refit;
using ConsumoAPIContagem.Models;

namespace ConsumoAPIContagem.Interfaces;

public interface ILoginAPI
{
    [Post("/login")]
    Task<Token> PostCredentialsAsync(User user);
}