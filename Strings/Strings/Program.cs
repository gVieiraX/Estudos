using System.ComponentModel;
using System.Text;

namespace Strings;

class Program
{
    static void Main(string[] args)
    {
      /*  var id = Guid.NewGuid();
        id.ToString();
        id = new Guid("144fced9-f7db-4c4c-bdee-d3a57f618dad\n");
        Console.WriteLine(id.ToString().Substring(2,8));*/
      
     /* var price = 10.2 + 9;
      var price2 = 10.2;
      //var texto = "O preço do produto é: " + price + " apenas na promoção.";
      //var texto = string.Format("O preço do produto é {0} e na promoção {1}", price,price2);
      var texto = $"O preço é {price}.";
      Console.WriteLine(texto);*/

    /* var text = "Testando";
     Console.WriteLine(text.Contains("testando",StringComparison.OrdinalIgnoreCase));
     Console.WriteLine(text.Contains(null));*/

    var texto = "Este texto é um teste";

    /*  Console.WriteLine(texto.StartsWith("Este"));
     Console.WriteLine(texto.StartsWith("este"));
     Console.WriteLine(texto.StartsWith("texto"));

     Console.WriteLine(texto.EndsWith("texto"));
     Console.WriteLine(texto.EndsWith("teste"));
     Console.WriteLine(texto.EndsWith("Teste"));

     Console.WriteLine(texto.Equals("Este texto é uma teste"));
     Console.WriteLine(texto.Equals("este texto é uma teste",StringComparison.OrdinalIgnoreCase));*/

    Console.WriteLine(texto.IndexOf("s"));
    Console.WriteLine(texto.LastIndexOf("e"));

    Console.WriteLine(texto.ToLower());
    Console.WriteLine(texto.ToUpper());
    Console.WriteLine(texto.Insert(10," aqui"));
    Console.WriteLine(texto.Remove(10,4));
    Console.WriteLine(texto.Length);
    Console.WriteLine(texto.Replace("e","x"));

    var divisao = texto.Split(" ");
    Console.WriteLine(divisao[0]);
    Console.WriteLine(divisao[3]);
    Console.WriteLine(divisao[2]);

    var resultado = texto.Substring(1,6);
    var resultado1 = texto.Substring(1,texto.Length - 5);
    var resultado2 = texto.Substring(1,texto.LastIndexOf("o"));
    
    Console.WriteLine(resultado);
    Console.WriteLine(resultado1);
    Console.WriteLine(resultado2);
    
    Console.WriteLine(texto.Trim());
    var text = new StringBuilder();
     text.Append("Estou testando novamente");
     text.Append(" aqui");
     text.Append(" testando");

    Console.WriteLine(text);
    
    }
}