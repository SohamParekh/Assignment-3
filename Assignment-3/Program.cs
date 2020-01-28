using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Program 
    {
        public static void Main(string[] args) 
        {

            List<Product> products = new List<Product>() {
                 new Product(){ Name="lettuce", Price=10.5,Quantity=50,Type="Leafy green"},
                 new Product(){ Name="cabbage", Price=20,Quantity=100,Type="Cruciferous"},
                 new Product(){ Name="pumpkin", Price=30,Quantity=30,Type="Marrow"},
                 new Product(){ Name="cauliflower", Price=10,Quantity=25,Type="Cruciferous"},
                 new Product(){ Name="zucchini", Price=20.5,Quantity=50,Type="Marrow"},
                 new Product(){ Name="yam", Price=30,Quantity=50,Type="Root"},
                 new Product(){ Name="spinach", Price=10,Quantity=100,Type="Leafy green"},
                 new Product(){ Name="broccoli", Price=20.2 ,Quantity=75,Type="Cruciferous"},
                 new Product(){ Name="Garlic", Price=30 ,Quantity=20,Type="Leafy green"},
                 new Product(){ Name="silverbeet", Price=10,Quantity=50,Type="Marrow"}
            };
            Console.WriteLine($"Total number of Products : {products.Count}");
            

            products.Add(new Product() { Name = "Potato", Price = 10, Quantity = 50, Type = "Root" });
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total number of Products : {products.Count}");
            Console.WriteLine("Finding Product with type Leafy green :- ");
            foreach (var item in products)
            {
                if(item.Type.Equals("Leafy green"))
                    Console.WriteLine(item);
            }
            var garlicremove = products.Single(p => p.Name == "Garlic");
            products.Remove(garlicremove);
            Console.WriteLine("Garlic Removed Successfullly");
            Console.WriteLine($"Total number of Products : {products.Count}");
            Console.WriteLine("Quantity of Cabbage Increased from 100 - 150 ");
            foreach (var item in products)
            {
                if (item.Name.Equals("cabbage"))
                {
                    item.Quantity += 50;
                    Console.WriteLine(item);
                }

            }
            double sum = 0;
            foreach (var item in products)
            {
                if (item.Name.Equals("lettuce"))
                    sum = sum + (1 * item.Price);
                if (item.Name.Equals("zucchini"))
                    sum = sum + (2 * item.Price);
                if (item.Name.Equals("broccoli"))
                    sum = sum + (1 * item.Price);
            }
            Console.WriteLine($"User Need to pay : {sum}");
            Console.Read();
        }
       

    }
}
