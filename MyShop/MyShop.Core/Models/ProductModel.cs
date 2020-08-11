using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class ProductModel
    {

        List<Product> products = new List<Product>();
        public ProductModel()
        {
           
                this.products = new List<Product>() {
                new Product {
                    Id = "01",
                    Name = "Lego",
                    Price = 50,
                    Image = "Lego.jpg"
                },
                new Product {
                    Id = "02",
                    Name = "Teddy Bear",
                    Price = 20,
                    Image = "teddy.jpg"
                },
                new Product {
                    Id = "03",
                    Name = "Laptop",
                    Price = 500,
                    Image = "laptop.jpg"
                }
            };
            }
        public List<Product> findAll()
        {
            return this.products;
        }

        public Product find(string id)
        {
            return this.products.Single(p => p.Id.Equals(id));
        }

    }

}

