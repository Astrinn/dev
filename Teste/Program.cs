using System;

namespace Teste
{
    class Program
    {
        static void Main(string[ ] args){
           Console.WriteLine("Qual seu nome?");
           var nome = Console.ReadLine();
           Console.WriteLine($"seu nome é " + nome);
            
           
        }
    }
}