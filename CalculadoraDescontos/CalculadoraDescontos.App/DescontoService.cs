namespace CalculadoraDescontos.App
{
    public class DescontoService
    {
        // 1. Retorno string — ObterCategoriaCliente
        public string ObterCategoriaCliente(int totalCompras)
        {
            if (totalCompras < 5)
            {
                return "BRONZE";
            }
            else if (totalCompras <= 10)
            {
                return "PRATA";
            }
            else
            {
                return "OURO";
            }
        }

        // 2. Retorno int — CalcularDescontoPorPercentual
        public int CalcularDescontoPorPercentual(int valorOriginal, int percentualDesconto)
        {
            int valorDesconto = (valorOriginal * percentualDesconto) / 100;
            return valorOriginal - valorDesconto;
        }

        // 3. Retorno bool — EValidoParaCupom
        public bool EValidoParaCupom(int idade, bool primeiraCompra)
        {
            return idade >= 18 || primeiraCompra;
        }
    }
}