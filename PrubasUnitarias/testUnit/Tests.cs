using testUnit.Data;

namespace testUnit;

public class Tests
{
    [Test]
    public void testSuma()
    {
        var Calculadora = new Calculadora();
        var resultado = Calculadora.Sumar(1,3);
        Console.WriteLine();
    }

}
