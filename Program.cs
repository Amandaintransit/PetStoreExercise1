using System.Data.Common;
using System;
using System.Transactions;
using System.ComponentModel.Design;

namespace PetStore
{
    public class Product
    {
        public string Name { get; set; }
        public  decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

    }
    public class CatFood : Product
    {
        double weightPounds { get; set; }
        bool kittenFood { get; set; }
    }
    public class DogLeash : Product
    {
        int lengthInches { get; set; }
        public string Material { get; set; }
        
    }
    public class Program
    {
        static void Main(string[] args)

        {
            string userInput = string.Empty;
            
            var repeat = true;

            while (repeat)
            {
                Console.WriteLine("Press 1 to add a product ");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
               

                if (userInput == "1")
                {
                    DogLeash blingDogLeash = new();
                    var product = blingDogLeash;
                    Console.WriteLine("Enter Product Name");
                    product.Name = Console.ReadLine();
                    Console.WriteLine("Enter Product Material");
                    product.Material = Console.ReadLine();
                    Console.WriteLine("Enter Product Description");
                    product.Description = Console.ReadLine();
                    Console.WriteLine($"Product Name = {product.Name}, Description = {product.Description} and it is made of {product.Material}\n");
                }
                else if (userInput == "exit")
                    userInput.ToLower();
                {
                    break;
                }
            }
             
        }
    }
}




