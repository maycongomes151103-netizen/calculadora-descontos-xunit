# Calculadora de Descontos - xUnit & Theory (.NET 10)

Repositório desenvolvido para a atividade prática da disciplina de **Gestão e Qualidade de Software** (Professor Daniel Henrique Matos de Paiva). O foco principal deste projeto é demonstrar a diferença prática entre testes estáticos (`[Fact]`) e testes parametrizados (`[Theory]` com `[InlineData]`).

---

## 🔍 Diferença entre `[Fact]` e `[Theory]`

* **`[Fact]`**: É utilizado para testes unitários tradicionais e únicos, que não recebem parâmetros externos. Ele executa uma única vez validando um cenário específico.
* **`[Theory]`**: É utilizado para **testes parametrizados**. Ele permite executar a mesma lógica de teste múltiplas vezes passando conjuntos diferentes de dados fornecidos através dos atributos `[InlineData]`, evitando duplicação de código.

---

## 📋 Métodos Implementados (`DescontoService.cs`)

1. **`ObterCategoriaCliente(int totalCompras)`**: Retorna `"BRONZE"` (< 5), `"PRATA"` (entre 5 e 10) ou `"OURO"` (> 10).
2. **`CalcularDescontoPorPercentual(int valorOriginal, int percentualDesconto)`**: Aplica o percentual de desconto sobre o valor original e retorna o valor final.
3. **`EValidoParaCupom(int idade, bool primeiraCompra)`**: Retorna `true` se o cliente tiver 18 anos ou mais **OU** se for a primeira compra.

---

## 🚀 Como Executar os Testes

Certifique-se de ter o **.NET 10 SDK** instalado, abra o terminal na pasta raiz da solução e execute:

```bash
dotnet test
