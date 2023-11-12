using healthcalc_pack_dotnet.Models;

namespace healthcalc_test_dotnet.Model
{
    public class IMCClassificationTests
    {
        [Theory]
        [InlineData(17.5, "ABAIXO DO PESO")]
        [InlineData(22, "PESO NORMAL")]
        [InlineData(28.5, "SOBREPESO")]
        [InlineData(33, "OBESIDADE I")]
        [InlineData(37.5, "OBESIDADE II")]
        [InlineData(42, "OBESIDADE III")]
        public void ClassificarIMC_ValidInput_ReturnsCorrectResult(double imc, string expectedClassification)
        {
            // Arrange
            var classification = new IMCClassification();

            // Act
            var result = classification.ClassificarIMC(imc);

            // Assert
            Assert.Equal(expectedClassification, result);
        }
    }
}