using healthcalc_pack_dotnet.Models;

namespace healthcalc_test_dotnet.Model
{
    public class  IMCCalculatorTests
    {
        [Theory]
        [InlineData(70, 1.75, 22.86)]
        [InlineData(80, 1.80, 24.69)]
        public void CalcularIMC_ValidInput_ReturnsCorrectResult(double peso, double altura, double expectedIMC)
        {
            // Arrange
            var calculator = new IMCCalculator();

            // Act
            var result = calculator.CalcularIMC(peso, altura);

            // Assert
            Assert.Equal(expectedIMC, result, 2);
        }

        [Fact]
        public void CalcularIMC_InvalidAltura_ThrowsArgumentException()
        {
            // Arrange
            var calculator = new IMCCalculator();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.CalcularIMC(70, 0));
        }
    }
}