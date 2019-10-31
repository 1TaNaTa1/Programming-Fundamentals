using System.Collections.Generic;

namespace _05._Shopping_Spree
{
    public class Person
    {
        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;

            this.BagOfProducts = new List<Product>();
        }

        public string Name { get; set; }

        public double Money { get; set; }

        public List<Product> BagOfProducts { get; set; }

        public override string ToString()
        {
            return string.Join(", ", this.BagOfProducts);
        }
    }
}
