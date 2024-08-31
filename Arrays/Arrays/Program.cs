namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        /* Console.Clear();

         var meuArray = new Teste[21];
         meuArray[0] = new Teste();
         Console.WriteLine(meuArray[0].Id);
         Console.WriteLine(meuArray[1].Id);
         Console.WriteLine(meuArray[2].Id);
         Console.WriteLine(meuArray[3].Id);
         Console.WriteLine(meuArray[4].Id);
     }*/
        
        var meuArray = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11,12 };
        meuArray[10] = 11;

      /*  for (var index = 0; index < meuArray.Length; index++)
        {
            Console.WriteLine(index);
        }*/

      var funcionarios = new Funcionario[10];
      funcionarios[1] = new Funcionario() {Id = 234, Nome = "Gabriel"};
      foreach (var funcionario in funcionarios)
      {
          Console.WriteLine(funcionario.Id);
          Console.WriteLine(funcionario.Nome);
      }
      
      Console.Clear();
      var arr = new int[4];
      var arrb = arr;
      arr[0] = 1;
      Console.WriteLine(arrb[0]);
      Console.Clear();

      var primeiro = new int[4];
      var segundo = new int[4];
      
      segundo[0] = primeiro[0];
      primeiro[0] = 23;
      Console.WriteLine(segundo[0]);
      Console.WriteLine(primeiro[0]);
    }

/*struct  Teste
{
    public int Id { get; set; }
}*/
    struct Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}