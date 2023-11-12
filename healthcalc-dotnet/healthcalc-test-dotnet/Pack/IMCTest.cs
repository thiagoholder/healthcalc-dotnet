using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Models;

namespace healthcalc_test_dotnet.Pack
{
    public class IMCTests
    {
        [Theory]
        [InlineData(60, 1.85, "ABAIXO DO PESO")]
        [InlineData(70, 1.75, "PESO NORMAL")]
        [InlineData(80, 1.75, "SOBREPESO")]
        [InlineData(80, 1.60, "OBESIDADE I")]
        [InlineData(80, 1.50, "OBESIDADE II")]
        [InlineData(100, 1.50, "OBESIDADE III")]

        public void RetornarClassificaoIMC_ValidInput_ReturnsCorrectResult(double peso, double altura, string expectedClassification)
        {
            // Arrange
            var imcCalculator = new IMCCalculator();
            var imcClassification = new IMCClassification();
            var imcCalculatorWrapper = new IMC(imcCalculator, imcClassification);

            // Act
            var resultIMC = imcCalculatorWrapper.CalcularIMC(peso, altura);
            var resultClassification = imcCalculatorWrapper.RetornarClassificaoIMC(resultIMC);

            // Assert
            Assert.Equal(expectedClassification, resultClassification);
        }
    }
}