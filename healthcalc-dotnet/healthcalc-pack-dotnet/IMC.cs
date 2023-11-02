using healthcalc_pack_dotnet.Interfaces;

namespace healthcalc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double CalcularIMC(double Peso, double Altura)
        {
            if (Altura == 0)
                throw new Exception("Altura inválida!");

            return Math.Round(Peso / (Altura * Altura),  2);
        }

        public string RetornarClassificaoIMC(double IMC)
        {
            if (IMC <= 18.5)
                return "ABAIXO DO PESO";
            else if (IMC >= 18.6 && IMC <= 24.9)
                return "PESO NORMAL";
            else if (IMC > 24.9 && IMC <= 29.9)
                return "SOBREPESO";
            else if (IMC > 29.9 && IMC <= 34.9)
                return "OBESIDADE I";
            else if (IMC > 34.9 && IMC <= 39.9)
                return "OBESIDADE II";
            else
                return "OBESIDADE III";
        }
    }
}