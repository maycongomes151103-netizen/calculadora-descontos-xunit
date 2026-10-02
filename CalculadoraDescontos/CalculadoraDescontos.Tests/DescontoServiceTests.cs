using CalculadoraDescontos.App;
using Xunit;

namespace CalculadoraDescontos.Tests
{
    public class DescontoServiceTests
    {
        private readonly DescontoService _descontoService;

        public DescontoServiceTests()
        {
            _descontoService = new DescontoService();
        }

        [Theory]
        [InlineData(2, "BRONZE")]
        [InlineData(7, "PRATA")]
        [InlineData(15, "OURO")]
        public void ObterCategoriaCliente_DeveRetornarCategoriaCorreta(int totalCompras, string categoriaEsperada)
        {
            // Act
            string resultado = _descontoService.ObterCategoriaCliente(totalCompras);

            // Assert
            Assert.Equal(categoriaEsperada, resultado);
        }

        [Theory]
        [InlineData(100, 10, 90)]
        [InlineData(200, 20, 160)]
        [InlineData(50, 0, 50)]
        public void CalcularDescontoPorPercentual_DeveCalcularValorFinalCorretamente(int valorOriginal, int percentual, int valorEsperado)
        {
            // Act
            int resultado = _descontoService.CalcularDescontoPorPercentual(valorOriginal, percentual);

            // Assert
            Assert.Equal(valorEsperado, resultado);
        }

        [Theory]
        [InlineData(20, false, true)]
        [InlineData(16, true, true)]
        [InlineData(17, false, false)]
        public void EValidoParaCupom_DeveValidarElegibilidadeCorretamente(int idade, bool primeiraCompra, bool esperado)
        {
            // Act
            bool resultado = _descontoService.EValidoParaCupom(idade, primeiraCompra);

            // Assert
            Assert.Equal(esperado, resultado);
        }
    }
}