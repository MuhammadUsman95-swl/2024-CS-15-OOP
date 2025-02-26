using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class store
    {
        public int Pid;
        public float Pprice;
        public string Pname, Pcategory, PbrandName, Pcountry;
        public store(int id, float price, string name, string category, string brandName, string contry)
        {
            Pid = id;
            Pprice = price;
            Pname = name;
            Pcategory = category;
            PbrandName = brandName;
            Pcountry = contry;
        }
        public void showProduct()
        {
            Console.WriteLine($"Product ID: {Pid}, Product Price: {Pprice}, Product name: {Pname}");
            Console.WriteLine($"Product Category: {Pcategory}, Product Brand name: {PbrandName}, Product Country: {Pcountry}");
        }

    }
    internal class Program
    {
        static List<store> product = new List<store>();
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 4)
            {
                Console.Clear();
                choice = menu();
                switch (choice)
                {
                    case 1:
                        addProduct();
                        Console.ReadKey();
                        break;
                    case 2:
                        showProduct();
                        Console.ReadKey();
                        break;
                    case 3:
                        float storePrice = storeWorth();
                        Console.WriteLine("The total worth of store is: {0}", storePrice);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("In valid option...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static int menu()
        {
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Show product");
            Console.WriteLine("3. Total worth of store");
            Console.Write("Enter an option.... ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static string addProduct()
        {
            Console.Write("Enter name of product.. ");
            string name = Console.ReadLine();
            Console.Write("Enter price of product.. ");
            float price = float.Parse(Console.ReadLine());
            Console.Write("Enter id of product.. ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter category of product.. ");
            string category = Console.ReadLine();
            Console.Write("Enter brand of product.. ");
            string brandname = Console.ReadLine();
            Console.Write("Enter country of product.. ");
            string contry = Console.ReadLine();
            store productDetail = new store(id, price, name, category, brandname, contry);
            product.Add(productDetail);
            return "Product add successful.";
        }
        static void showProduct()
        {
            int i = 1;
            foreach (store productDetail in product)
            {
                Console.WriteLine();
                Console.WriteLine($"Product {i}");
                productDetail.showProduct();
                i++;
            }
        }
        static float storeWorth()
        {
            float totalPrice = 0;
            foreach (var store in product)
            {
                totalPrice += store.Pprice;
            }
            return totalPrice;
            
        }
       
    }

}
