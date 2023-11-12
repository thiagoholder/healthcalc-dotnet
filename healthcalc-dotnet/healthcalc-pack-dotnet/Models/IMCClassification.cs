using healthcalc_pack_dotnet.Interfaces;

namespace healthcalc_pack_dotnet.Models
{
    public class IMCClassification : IIMCClassification
    {
        public string ClassificarIMC(double imc)
        {
            if (imc <= 18.5)
                return "ABAIXO DO PESO";
            else if (imc <= 24.9)
                return "PESO NORMAL";
            else if (imc <= 29.9)
                return "SOBREPESO";
            else if (imc <= 34.9)
                return "OBESIDADE I";
            else if (imc <= 39.9)
                return "OBESIDADE II";
            else
                return "OBESIDADE III";
        }
    }
}