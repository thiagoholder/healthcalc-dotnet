using healthcalc_pack_dotnet;
using healthcalc_pack_dotnet.Interfaces;

namespace healthcalc_test_dotnet.Pack
{
    public class IMCTest
    {
        [Fact]
        public void CalculaIMC_QuandoPesoEAlturaValidos_EntaoRetornaIndice()
        {
            //Arrange
            IIMC imc = new IMC();
            double Peso = 85;
            double Altura = 1.70;
            double IndiceIMC = 29.41;

            //Act
            var IndiceIMCRetornado = imc.CalcularIMC(Peso, Altura);

            //Asserts
            Assert.Equal(IndiceIMC, IndiceIMCRetornado);
        }

        [Fact]
        public void CalculaIMC_QuandoPesoValidoEAlturaInvalida_EntaoRetornaExcecao()
        {
            //Arrange
            IIMC imc = new IMC();
            double Peso = 85;
            double Altura = 0;
           
            //Act
            try
            {
                imc.CalcularIMC(Peso, Altura);
            }
            catch(Exception ex) 
            {
                Assert.Equal("ALTURA INVÁLIDA!", ex.Message.ToString().ToUpper());
            }

        }

        [Theory]
        [InlineData(15.23, "ABAIXO DO PESO")]
        [InlineData(17.66, "ABAIXO DO PESO")]
        [InlineData(18.50, "ABAIXO DO PESO")]

        [InlineData(18.60, "PESO NORMAL")]
        [InlineData(22.00, "PESO NORMAL")]
        [InlineData(24.90, "PESO NORMAL")]

      
        [InlineData(25.00, "SOBREPESO")]
        [InlineData(26.21, "SOBREPESO")]
        [InlineData(27.81, "SOBREPESO")]
        [InlineData(28.35, "SOBREPESO")]
        [InlineData(29.90, "SOBREPESO")]

        [InlineData(30.00, "OBESIDADE I")]
        [InlineData(32.00, "OBESIDADE I")]
        [InlineData(34.90, "OBESIDADE I")]

        [InlineData(35.00, "OBESIDADE II")]
        [InlineData(37.30, "OBESIDADE II")]
        [InlineData(39.90, "OBESIDADE II")]

        [InlineData(40.00, "OBESIDADE III")]
        [InlineData(42.00, "OBESIDADE III")]
        [InlineData(50.00, "OBESIDADE III")]



        public void RetornaClassificacaoIMC_AcimaDoPeso_QuandoIndiceDentroDaFaixa(double IndiceIMC, string Classificao)
        {
            //Arrange
            IIMC imc = new IMC();
            
            //Act
            var Classificacao = imc.RetornarClassificaoIMC(IndiceIMC);

            //Asserts
            Assert.Equal(Classificao, Classificacao);
        } 
        
    }
}