using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Enums;

namespace healthcalc_test_dotnet.Model
{
    public class MacroNutrientCalculatorTests
    {
        [Theory]
        [InlineData(ObjetivoFisicoEnum.Cutting, 2.0, 1.0, 2.0)]
        [InlineData(ObjetivoFisicoEnum.Bulking, 2.0, 1.0, 4.0)]
        [InlineData(ObjetivoFisicoEnum.Keep, 2.0, 1.0, 5.0)]
        public void CalcularMacronutrientes_ValidInput_ReturnsCorrectResult(
       ObjetivoFisicoEnum objetivoFisico, double expectedProteinas, double expectedGordura, double expectedCarboidratos)
        {
            // Arrange
            var calculator = new MacroNutrientCalculator();

            // Act
            var resultado = calculator.CalcularMacronutrientes(1.0, objetivoFisico);

            // Assert
            Assert.Equal(expectedProteinas, resultado.Proteinas, 2); // using a delta for double comparison
            Assert.Equal(expectedGordura, resultado.Gordura, 2);
            Assert.Equal(expectedCarboidratos, resultado.Carboidratos, 2);
        }

        [Fact]
        public void CalcularMacronutrientes_InvalidObjetivoFisico_ThrowsArgumentException()
        {
            // Arrange
            var calculator = new MacroNutrientCalculator();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.CalcularMacronutrientes(1.0, (ObjetivoFisicoEnum)(-1)));
        }
    }
}