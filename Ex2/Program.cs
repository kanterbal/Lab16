using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Products.json";
            int n = 0;
            double maxPrice = 0;
            string maxName = "";
            string[] jsonString;
            using (StreamReader sr = new StreamReader(path))
            {
                jsonString = sr.ReadToEnd().Split('\n');

            }
            n = jsonString.Length;
            Product[] product = new Product[n];
            for (int i = 0; i < n; i++)
            {
                product[i] = JsonSerializer.Deserialize<Product>(jsonString[i]);
            }
            foreach (Product a in product)
            {
                if (maxPrice < a.Price)
                {
                    maxPrice = a.Price;
                    maxName = a.Name;
                }
            }

            Console.WriteLine(maxName);
            Console.ReadKey();
        }
        class Product
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
        }
    }

}
