using System;
using System.Diagnostics;

namespace StopWatch{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância do Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Inicia o Stopwatch
            stopwatch.Start();

            // Simula uma operação que leva tempo (por exemplo, um loop)
            for (int i = 0; i < 1000000; i++)
            {
                // Operação simulada
            }

            // Para o Stopwatch
            stopwatch.Stop();

            // Exibe o tempo decorrido em milissegundos
            Console.WriteLine($"Tempo decorrido: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
