using OOP6;
using System.Net.Http.Headers;
using System.Xml.Linq;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nuoc ngot";

Product p1 = new Product();
p1.Id = 1;
p1.Name = "Pessi";
p1.Quantity = 10;
p1.Price = 25;
c1.AddProduct(p1);

Product p2 = new Product();
p2.Id = 2;          
p2.Name = "Coca";   
p2.Quantity = 10;   
p2.Price = 20;      
c1.AddProduct(p2);

Product p3 = new Product();
p3.Id = 3;
p3.Name = "RedB";
p3.Quantity = 10;
p3.Price = 28;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;          
p4.Name = "String"; 
p4.Quantity = 11;   
p4.Price = 12;      
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 5;          
p5.Name = "Xa Xi";  
p5.Quantity = 9;    
p5.Price = 15;      
c1.AddProduct(p5);

Console.WriteLine("--Thong tin danh muc--");
Console.WriteLine(c1);
Console.WriteLine("--Danh sach san pham--");
c1.PrintAllProduct();


double min_price = 10;
double max_price = 20;
Dictionary<int, Product> product_by_price = c1.FilterProductByPrice(min_price, max_price);
Console.WriteLine($"Danh sach san pham co gia tu {min_price} {max_price}");
foreach(KeyValuePair<int,Product> kvp in product_by_price)
{
        Product p = kvp.Value;
        Console.WriteLine(p);
}


Dictionary<int, Product> SortProdcutByPrice = c1.SortProdcutByPrice();
Console.WriteLine("--Danh sach san pham sau khi sap xep gia tang dan");
foreach(KeyValuePair<int, Product> kvp in SortProdcutByPrice)
{
             Product p = kvp.Value;
             Console.WriteLine(p);
}



p5.Name = "Fanta";
p5.Price = 30;
p5.Quantity= 20;
bool update_result = c1.Update(p5);
Console.WriteLine("--Danh sach san pham sau khi sua doi--");
c1.PrintAllProduct();




int id_to_delete = 2;
bool delete_result = c1.Remove(id_to_delete);
Console.WriteLine($"Ket qua xoa san pham co id {id_to_delete}: {delete_result}");
Console.WriteLine("--Danh sach san pham sau khi xoa--");
c1.PrintAllProduct();



double min = 10;
double max = 20;
c1.RemoveByPrice(min, max);
Console.WriteLine("--Danh sach san pham sau khi xoa theo gia--");
Console.WriteLine($"Gia tu {min} den {max}");
c1.PrintAllProduct();



//Dung linklist de quan ly danh muc
LinkedList<Category> categories = new LinkedList<Category>();
categories.AddLast(c1);

Category c2 = new Category();
c2.Id = 2;
c2.Name = "Bia cac loai";

c2.AddProduct(new Product() { Id = 1, Name = "Bia Hoi", Quantity = 10, Price = 200 });
c2.AddProduct(new Product() { Id = 2, Name = "Bia Sai Gon", Quantity = 10, Price = 250 });
c2.AddProduct(new Product() { Id = 3, Name = "Bia Tiger", Quantity = 10, Price = 300 });

categories.AddFirst(c2);
Console.WriteLine("--Danh sach toan bo san pham theo danh muc--");
foreach(Category c in categories)
{
    Console.WriteLine(c);
    Console.WriteLine("-----------------------------");
    c.PrintAllProduct();
    Console.WriteLine("-----------------------------");
}