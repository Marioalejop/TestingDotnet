using System.Reflection;
using System.Threading.Tasks;
using testUnit.Data;

namespace testUnit;

public class Tests
{
    [Test]
    public async Task testSuma()
    {
        var Calculadora = new Calculadora();
        var resultado = Calculadora.Sumar(1, 3);
        await Assert.That(resultado).IsEqualTo(4);
        Console.WriteLine();
    }

}
