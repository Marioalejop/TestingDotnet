using System; 
namespace MiAppConsola
{
    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        
        public int Dividir(int a, int b)
        { 
            return a / b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();
            Console.WriteLine("5 + 3 = " + calc.Sumar(5, 3));
            Console.WriteLine("5 - 3 = " + calc.Restar(5, 3));
            Console.WriteLine("5 * 3 = " + calc.Multiplicar(5, 3));
            Console.WriteLine("6 / 3 = " + calc.Dividir(6, 3));
            
        }
    }
}