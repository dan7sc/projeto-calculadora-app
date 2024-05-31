using Xunit.Sdk;

namespace CalculadoraApp.Tests;

public class UnitTest1
{

    public static Calculadora CriarCalculadora()
    {
        return new Calculadora();
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int a, int b, int resultadoEsperado)
    {
        Calculadora calc = CriarCalculadora();

        int resultado = calc.Somar(a, b);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData (2, 1, 1)]
    [InlineData (9, 5, 4)]
    public void TesteSubtrair(int a, int b, int resultadoEsperado)
    {
        Calculadora calc = CriarCalculadora();

        int resultado = calc.Subtrair(a, b);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData (2, 3, 6)]
    [InlineData (4, 1, 4)]
    public void TesteMultiplicar(int a, int b, int resultadoEsperado)
    {
        Calculadora calc = CriarCalculadora();

        int resultado = calc.Multiplicar(a, b);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData (16, 8, 2)]
    [InlineData (4, 4, 1)]
    public void TesteDividir(int a, int b, int resultadoEsperado)
    {
        Calculadora calc = CriarCalculadora();

        int resultado = calc.Dividir(a, b);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void TesteDividirPorZero()
    {
        Calculadora calc = CriarCalculadora();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(4, 0)
        );
    }

    [Fact]
    public void TesteHistorico()
    {
        Calculadora calc = CriarCalculadora();

        calc.Somar(1, 2);
        calc.Somar(3, 4);
        calc.Somar(5, 6);
        calc.Somar(7, 8);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}