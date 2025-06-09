using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ2ObjectModeClass
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();
        }
        public void gen_product()
        {
            products.Add(new Product() { Id = 1, Name = "P1", Price = 20, Quantity = 15 });
            products.Add(new Product() { Id = 2, Name = "P2", Price = 30, Quantity = 25 });
            products.Add(new Product() { Id = 3, Name = "P3", Price = 40, Quantity = 35 });
            products.Add(new Product() { Id = 4, Name = "P4", Price = 50, Quantity = 45 });
            products.Add(new Product() { Id = 5, Name = "P5", Price = 60, Quantity = 45 });
            products.Add(new Product() { Id = 6, Name = "P6", Price = 50, Quantity = 35 });
            products.Add(new Product() { Id = 7, Name = "P7", Price = 50, Quantity = 45 });
            products.Add(new Product() { Id = 8, Name = "P8", Price = 100, Quantity = 45 });
            products.Add(new Product() { Id = 9, Name = "P9", Price = 150, Quantity = 45 });
            products.Add(new Product() { Id = 10, Name = "P10", Price = 50, Quantity = 45 });
        }

    public List<Product> FilterProductByPrice(double price1, double price2)
        {
            var result = from p in products
                         where p.Price >= price1 && p.Price <= price2
                         select p;
            return result.ToList();
        }

        //Cach method syntax
        public List<Product> FilterProductByPriceMethod(double price1, double price2)
        {
            return products.Where(p => p.Price >= price1 && p.Price <= price2).ToList();
        }

        public List<Product> SortProductByPriceAsc()
        {
            return products.OrderBy(p => p.Price).ToList();
                
        }

        public List<Product> SortProductByPriceAsc2()
        {
            var result = from p in products
                         orderby p.Price
                         select p;
            return result.ToList();
        }

        public List<Product> SortProductByPriceDesc()
        {
            return products.OrderByDescending(p => p.Price).ToList();
        }
        public List<Product> SortProductByPriceDes2()
        {
            var result = from p in products
                         orderby p.Price descending
                         select p;
            return result.ToList();
        }

        public double SumOfValue()
        {
            return products.Sum(p => p.Price * p.Quantity);
        }
        public double SumOfValue2()
        {
            var result = from p in products
                         select p.Price * p.Quantity;
            return result.Sum();
        }

        public Product SearchProductDetail(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product SearchProductDetail2(int id)
        {
            var result = from p in products
                         where p.Id == id
                         select p;
            return result.FirstOrDefault();
        }
        //Cau 6: loc ra top N san pham co gia tri lon nhat
        //Cach LINQ2Object
        public List<Product> SearchTopProductByPrice(int n)
        {
            return products.OrderByDescending(p => p.Price*p.Quantity).Take(n).ToList();
        }

        //Cach LINQ2Object Query syntax
        public List<Product> SearchTopProductByPrice2(int n)
        {
            var result = from p in products
                         orderby p.Price * p.Quantity descending
                         select p;
            return result.Take(n).ToList();
        }

    }
}