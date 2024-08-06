using System;
using System.Reflection.Metadata;
using System.Windows.Markup;

namespace MeuApp{
    class Program


    {
        static void Main(string [] args)
        {
           /* byte meuByte = 133;
            int idade;
            idade = 2;
            object quantidade;
            quantidade = 1.2;
            quantidade = 2;
            quantidade = true;
            quantidade = "fola";
            Console.WriteLine("Hello World! " + idade);
            Console.WriteLine (meuByte);

            int? show = null; */
       
            /*int number = 100;
            float real = 23.3f;

            number = Convert.ToInt32(real);
            Console.WriteLine(Convert.ToBoolean(0));*/

            /* int x = 5;
            x += 5;
            Console.WriteLine(x);
            x *= 10;
            Console.WriteLine(x);*/

            /*int x = 25;
            x = 2+2;
            Console.WriteLine(x);       

            if(x > 4) {
                Console.WriteLine("X É MAIOR");
            }  else{
                Console.WriteLine("X É MENOR");
            }

            string valore = "gabriel";
            switch(valore)
            {
                case "Joao": Console.WriteLine("Nop");break;
                case "Gabriel": Console.WriteLine("maybe");break;
                default: Console.WriteLine("Not fond");break;
            }

            for(var i = 0; i <=5;i = i++){
                Console.WriteLine(i);
            }
                            Console.WriteLine("-------------");
                   for(var i = 1; i <=5;i++){
                Console.WriteLine(i);
            }
                            Console.WriteLine("-------------");


                   for(var i = 0; i <5;i++){
                Console.WriteLine(i);

            }
                            Console.WriteLine("-------------");


                   for(var i = 5; i >=0;i++){
                Console.WriteLine(i);

            } */

          /*   int loop = 0;
                while (loop <= 4)
                {
                   Console.WriteLine(loop);
                   loop++;

                }

            int y = 0;
            do{
                Console.WriteLine(y);
                y++;
            } while (y<=5);

            MeuMetodo();
            string nome = RetornNome("Gabriel","Vieira", 21);
            Console.WriteLine(nome);*/

           /* int x  = 10;
            int y = 22;
            Console.WriteLine(x + " " + y);
             x  = 16;
            Console.WriteLine(x + " " + y);

            var arr = new string[2];
            arr[0] = "item 1";

            var arr2 = arr;
                 Console.WriteLine(arr[0]);
                      Console.WriteLine(arr2[0]);
                    

                    arr[0] = "item 2";
                       Console.WriteLine(arr[0]);
                      Console.WriteLine(arr2[0]);*/
                      Product keyboard = new Product(1,"Keyboard",222,EProductType.Product);
                      Product headseat = new Product(2,"Headseat",22,EProductType.Service);
                      Console.WriteLine(keyboard.Id);
                      Console.WriteLine(keyboard.Name);
                      Console.WriteLine(keyboard.Price);
                      Console.WriteLine((int)keyboard.Type);
                      

        } 





       static void MeuMetodo(){
            Console.WriteLine("C# é legal!");
        }

        static string RetornNome(String nome, String sobrenome, int idade ){
            return nome + " " + sobrenome + " " + idade;
        }
    }

    struct Product

    {
    
        public int Id;
        public string Name;
        public double Price; 
        public EProductType Type;   
           public Product(int id, string name, double price, EProductType type){
            Id=id;
            Name = name;
            Price = price;
            Type = type;
        }
        public double PriceInDolar(double dolar){
            return Price * dolar;
        }

    }
    enum  EProductType{
        Product = 22,
        Service = 2
    }
}
