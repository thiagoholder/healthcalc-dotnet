using healthcalc_pack_dotnet.Models;

namespace healthcalc_test_dotnet.Pack
{
    public class ResultadoMacroNutrientesTests
    {
        [Fact]
        public void Constructor_WithNegativeProteinas_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            Action createWithNegativeProteinas = () => new ResultadoMacroNutrientesModel(-1, 0, 0);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(createWithNegativeProteinas);
        }

        [Fact]
        public void Constructor_WithNegativeGordura_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            Action createWithNegativeGordura = () => new ResultadoMacroNutrientesModel(0, -1, 0);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(createWithNegativeGordura);
        }

        [Fact]
        public void Constructor_WithNegativeCarboidratos_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            Action createWithNegativeCarboidratos = () => new ResultadoMacroNutrientesModel(0, 0, -1);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(createWithNegativeCarboidratos);
        }

        [Fact]
        public void Constructor_WithNonNegativeValues_CreatesInstance()
        {
            // Arrange & Act
            var resultado = new ResultadoMacroNutrientesModel(1, 2, 3);

            // Assert
            Assert.NotNull(resultado);
            Assert.Equal(1, resultado.Proteinas);
            Assert.Equal(2, resultado.Gordura);
            Assert.Equal(3, resultado.Carboidratos);
        }
    }
}