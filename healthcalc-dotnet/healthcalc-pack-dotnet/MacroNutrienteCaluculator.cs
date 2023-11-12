using healthcalc_pack_dotnet.Enums;
using healthcalc_pack_dotnet.Interfaces;
using healthcalc_pack_dotnet.Models;

namespace healthcalc_pack_dotnet
{
    public class MacroNutrientCalculator : IMacroNutrientCalculator
    {
        private static readonly Dictionary<ObjetivoFisicoEnum, (double Proteinas, double Gordura, double Carboidratos)> RatioMappings =
        new Dictionary<ObjetivoFisicoEnum, (double, double, double)>
        {
            [ObjetivoFisicoEnum.Cutting] = (2.0, 1.0, 2.0),
            [ObjetivoFisicoEnum.Bulking] = (2.0, 1.0, 4.0),
            [ObjetivoFisicoEnum.Keep] = (2.0, 1.0, 5.0),
        };

        public ResultadoMacroNutrientesModel CalcularMacronutrientes(double peso, ObjetivoFisicoEnum objetivoFisico)
        {
            if (RatioMappings.TryGetValue(objetivoFisico, out var ratios))
            {
                return new ResultadoMacroNutrientesModel(ratios.Proteinas * peso, ratios.Gordura * peso, ratios.Carboidratos * peso);
            }

            throw new ArgumentException("Valor do objetivo fisico invalido", nameof(objetivoFisico));
        }
    }
}