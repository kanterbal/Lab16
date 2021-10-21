using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string path = "Products.json";
            Product[] product = new Product[n];
            for (int i = 0; i < n; i++)
            {
                product[i] = new Product();
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vvedite kod {0} tovara: ", i + 1);
                product[i].Code = Convert.ToInt32(Console.ReadLine());
                Console.Write("Vvedite nazvanie {0} tovara: ", i + 1);
                product[i].Name = Console.ReadLine();
                Console.Write("Vvedite cenu {0} tovara: ", i + 1);
                product[i].Price = Convert.ToDouble(Console.ReadLine());
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < n; i++)
                {


                    string jsonstring = JsonSerializer.Serialize(product[i]);
                    sw.WriteLine(jsonstring);
                }
            }
            //Console.ReadKey();
        }
    }
    class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

}
