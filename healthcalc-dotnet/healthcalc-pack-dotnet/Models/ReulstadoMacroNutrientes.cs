namespace healthcalc_pack_dotnet.Models
{
    public class ResultadoMacroNutrientesModel
    {
        public double Proteinas { get; }
        public double Gordura { get; }
        public double Carboidratos { get; }

        public ResultadoMacroNutrientesModel(double proteinas, double gordura, double carboidratos)
        {
            ValidateNonNegativeValue(nameof(proteinas), proteinas);
            ValidateNonNegativeValue(nameof(gordura), gordura);
            ValidateNonNegativeValue(nameof(carboidratos), carboidratos);

            Proteinas = proteinas;
            Gordura = gordura;
            Carboidratos = carboidratos;
        }

        private void ValidateNonNegativeValue(string propertyName, double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(propertyName, $"{propertyName} não deve ser negativo.");
            }
        }
    }
}