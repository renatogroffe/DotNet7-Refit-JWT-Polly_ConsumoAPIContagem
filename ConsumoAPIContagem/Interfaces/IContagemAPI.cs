using Refit;
using ConsumoAPIContagem.Models;

namespace ConsumoAPIContagem.Interfaces;

public interface IContagemAPI
{
    [Get("/Contador")]
    Task<ResultadoContador> ObterValorAtualAsync(
        [Header("Authorization")]string token);       
}