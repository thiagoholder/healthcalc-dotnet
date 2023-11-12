using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using healthcalc_pack_dotnet.Interfaces;
using healthcalc_pack_dotnet.Models;
using healthcalc_pack_dotnet;

var builder = new HostBuilder()
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton<IIMCCalculator, IMCCalculator>();
        services.AddSingleton<IIMCClassification, IMCClassification>();
        // Add other services as needed
    });

using var host = builder.Build();

var calculator = host.Services.GetRequiredService<IIMCCalculator>();
var classification = host.Services.GetRequiredService<IIMCClassification>();

var imcService = new IMC(calculator, classification);

var imcCalculado = imcService.CalcularIMC(84, 1.70);
var classificacao = imcService.RetornarClassificaoIMC(imcCalculado);



// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Com base no seu {imcCalculado} ele foi classificado em {classificacao}");
Console.ReadLine();
