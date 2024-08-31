using System.Globalization;

namespace Moedas;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var valor = 10.25;
        var valorMoedas = 10.6M;
        
        Console.WriteLine(valor);
        Console.WriteLine(valorMoedas.ToString(
            "C",
            CultureInfo.CreateSpecificCulture("pt-BR")));
        
        Console.WriteLine(
            Math.Round(valorMoedas)
            );
    }
}