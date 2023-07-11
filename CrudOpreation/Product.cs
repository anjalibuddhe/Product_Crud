using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOpreation
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class ProductCurd {

        private List<Product> products;
        
        public ProductCurd()
        {
            products = new List<Product>();

            //Or private List<Product>{set;get;}


        }
        public void AddProduct(Product prod) {
            products.Add(prod);
        
        }
        public List<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProduct(Product prod)
        {
            foreach (Product p in products)
            {
                if(p.Id == prod.Id)
                {
                    p.Name = prod.Name;//p == old data in collection
                    p.Price = prod.Price;// prod == new data
                    break;
                }
            }
        }

        public void DeleteProduct(int id)
        {
            foreach  (Product p in products) 
            {
                if (p.Id == id)
                {
                    products.Remove(p);
                    break;
                }
            }
        }


    }
}
