using healthcalc_pack_dotnet.Interfaces;

namespace healthcalc_pack_dotnet.Models
{
    public class IMCCalculator : IIMCCalculator
    {
        public double CalcularIMC(double peso, double altura)
        {
            if (altura == 0)
                throw new ArgumentException("Altura inválida!");

            return Math.Round(peso / (altura * altura), 2);
        }
    }
}