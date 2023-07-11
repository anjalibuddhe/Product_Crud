using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOpreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCurd curd = new ProductCurd();

            int option = 0;
            do
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. Display All Products");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        // Add product
                        Product p1 = new Product();
                        Console.WriteLine("Enter Product Id");
                        p1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name");
                        p1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Product price");
                        p1.Price = Convert.ToDouble(Console.ReadLine());

                        curd.AddProduct(p1);
                        break;

                    case 2:
                        //Update
                        Product p2 = new Product();
                        Console.WriteLine("Enter id to modify");
                        p2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name");
                        p2.Name = Console.ReadLine();
                        Console.WriteLine("Enter product price");
                        p2.Price = Convert.ToDouble(Console.ReadLine());
                        curd.UpdateProduct(p2);
                        break;

                    case 3:
                        //delete
                        Console.WriteLine("Enter id to delete");
                        int id= Convert.ToInt32(Console.ReadLine());
                        curd.DeleteProduct(id);
                        break;
                    case 4:
                        //Display all product
                        List<Product> list = curd.GetProducts();
                        foreach (Product p in list)
                        {
                            Console.WriteLine($"{p.Id} -{p.Name}-{p.Price}");
                        }
                        break;


                }
                Console.WriteLine("Press 1 for Continue");
                option = Convert.ToInt32(Console.ReadLine());

            }
            while (option == 1);
        }
    }
}
