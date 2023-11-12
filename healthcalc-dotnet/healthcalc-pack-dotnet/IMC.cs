using healthcalc_pack_dotnet.Interfaces;

namespace healthcalc_pack_dotnet
{
    public class IMC : IIMC
    {
        private readonly IIMCCalculator imcCalculator;
        private readonly IIMCClassification imcClassification;

        public IMC(IIMCCalculator imcCalculator, IIMCClassification imcClassification)
        {
            this.imcCalculator = imcCalculator ?? throw new ArgumentNullException(nameof(imcCalculator));
            this.imcClassification = imcClassification ?? throw new ArgumentNullException(nameof(imcClassification));
        }

        public double CalcularIMC(double peso, double altura)
        {
            return imcCalculator.CalcularIMC(peso, altura);
        }

        public string RetornarClassificaoIMC(double imc)
        {
            return imcClassification.ClassificarIMC(imc);
        }
    }
}