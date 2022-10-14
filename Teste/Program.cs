using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var teclado = new Product (1,"Teclado Redragon", 200.00);
            Console.WriteLine(teclado.Id);
            Console.WriteLine(teclado.Name);
            Console.WriteLine(teclado.Price);
            
        }
    }
    struct Product
    {
       public Product (int id, string name, double price)
       {
            Id = id;
            Name = name;
            Price = price;

       }
       public int Id;
       public string Name;
       public double Price;

       public string QuantidadeEmEstoque (string estoque)
       {
        return  Name + "está em estoque";
       }

    }

}