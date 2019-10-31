using System;
using System.Collections.Generic;

namespace _05._Shopping_Spree
{
    class Program
    {
        static void Main()
        {
            string[] peopleInfo = Console.ReadLine().Split(';');

            List<Person> people = new List<Person>();

            for (int i = 0; i < peopleInfo.Length; i++)
            {
                string[] personInfo = peopleInfo[i].Split('=');

                string name = personInfo[0];
                double money = int.Parse(personInfo[1]);

                Person person = new Person(name, money);

                people.Add(person);
            }

            string[] productsInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            List<Product> products = new List<Product>();

            for (int i = 0; i < productsInfo.Length; i++)
            {
                string[] productInfo = productsInfo[i].Split('=');

                string name = productInfo[0];
                double price = int.Parse(productInfo[1]);

                Product product = new Product(name, price);

                products.Add(product);
            }

            string[] purchase = Console.ReadLine().Split(' ');

            while(purchase[0] != "END")
            {
                string personName = purchase[0];
                string productName = purchase[1];

                Person person = people.Find(x => x.Name == personName);

                Product product = products.Find(x => x.Name == productName);

                if(person.Money >= product.Price)
                {
                    person.Money -= product.Price;

                    person.BagOfProducts.Add(product);

                    Console.WriteLine($"{personName} bought {productName}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }

                purchase = Console.ReadLine().Split(' ');
            }

            foreach (Person person in people)
            {
                if(person.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {person}");
                }
            }
        }
    }
}
