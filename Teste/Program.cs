using System;

namespace Teste
{
    class Program
    {
        static void Main(string[ ] args){



            Console.WriteLine("Qual sua idade??");
            string idadeH = Console.ReadLine();
            int idadeHiago = int.Parse (idadeH);
            int maioridade = 18;
            int velhice = 65;

            if( idadeHiago >= maioridade && idadeHiago <= velhice )
            {
                Console.WriteLine("Vc é um adulto");
            }      
           else if(idadeHiago > velhice)
           {
            Console.WriteLine("Vc já é idoso");
           }
           else if(idadeHiago < maioridade)
           {
                Console.WriteLine("Vc é menor de idade");
           }
           }
    }
}