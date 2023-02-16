using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Serilog;
using ConsumoAPIContagem.Clients;

// Projeto com as APIs utilizadas nos testes:
// https://github.com/renatogroffe/ASPNETCore5-REST_API-JWT-Swagger_ContagemAcessos
var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile($"appsettings.json");
var config = builder.Build();


var logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

var apiContagemClient =
        new APIContagemClient(config, logger);
await apiContagemClient.Autenticar();
while (true)
{
    await apiContagemClient.ExibirResultadoContador();
    await Console.Out.WriteLineAsync(
        "Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}