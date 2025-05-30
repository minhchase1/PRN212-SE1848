using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Product { get; set; } // de luu tru cac category cua pro

        public Category()
        {
            Product = new Dictionary<int, Product>();
        }
        public override string ToString()
        {
            return $"{Id}\t{Name}";

        }
        //Khi quan ly moi doi tuong ta deu phai dap ung 
        //day du tinh nang CRUD

        public void AddProduct(Product p)
        {
            //Kiem tra xem product da ton tai chua
            //Neu chua thi them moi
            if (p == null)
            {
                return; // du lieu dau vao la null
            }
            if (Product.ContainsKey(p.Id))
            {
                return; //Id da ton tai thi khog them
            }
            //them moi peoduct vao dictionary
            Product.Add(p.Id, p);
        }
        //Xuat toan bo san pham
        public void PrintAllProduct()
        {
            foreach (KeyValuePair<int, Product> kvp in Product)
            {
                Product p = kvp.Value;
                Console.WriteLine(p);
            }
        }

        //Loc cac san pham co gia tu min den max
        public Dictionary<int, Product> FilterProductByPrice(Double min, double max)
        {
            return Product.Where(item => item.Value.Price >= min && item.Value.Price <= max)
                .ToDictionary<int, Product>();
        }

        //sap xep san pham theo don gia tang dan
        public Dictionary<int, Product> SortProdcutByPrice()
        {
            return Product.OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }

        //Sap xep tang gia trung nhau thi giam dan
        public Dictionary<int, Product> SortComplex()
        {
            return Product.OrderByDescending(item => item.Value.Quantity)
                .OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }

        //Sua 1 san pham moi
        public bool Update(Product p)
        {
            if (p == null)
            {
                return false; // Dữ liệu đầu vào là null
            }
            if (!Product.ContainsKey(p.Id))
            {
                return false; // Id không tồn tại trong dictionary
            }
            // Cập nhật sản phẩm
            Product[p.Id] = p;
            return true; // Cập nhật thành công
        }

        //Xoa 1 san pham
        public bool Remove(int id)
        {
            if (Product.ContainsKey(id))
            {
                Product.Remove(id);
                return true; //Xoa thanh cong
            }
            return false; //Khong tim thay san pham de xoa
        }


        //Viet ham xoa cac san pham co don gia tu a den b
        public void RemoveByPrice(double a, double b)
        {
            //Loc cac san pham co don gia tu a den b
            var productsToRemove = Product.Where(item => item.Value.Price >= a && item.Value.Price <= b).ToList();
            foreach (var item in productsToRemove)
            {
                Product.Remove(item.Key);
            }
        }
    }
}
