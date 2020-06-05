using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculo corrida = new Calculo();

            //Sem argumentos
            System.Console.WriteLine( corrida.Calcular() );

            //1 argumento int
            System.Console.WriteLine( corrida.Calcular(20) );

            //2 argumentos int
            System.Console.WriteLine( corrida.Calcular(20,5) );

            //2 argumentos string
            System.Console.WriteLine( corrida.Calcular("Mateus", "Gatti") );

        }
    }
}
