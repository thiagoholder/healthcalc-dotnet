using healthcalc_pack_dotnet.Enums;
using healthcalc_pack_dotnet.Models;

namespace healthcalc_pack_dotnet.Interfaces
{
    public interface IMacroNutrientCalculator
    {
        ResultadoMacroNutrientesModel CalcularMacronutrientes(double peso, ObjetivoFisicoEnum objetivoFisico);
    }
}