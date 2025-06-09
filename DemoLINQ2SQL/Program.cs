using DemoLINQ2SQL;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//Khai bao chuoi ket noi toi CSDL
string connectionstring = @"server=LAPTOP-N56PGGE3\SQLEXPRESS;database=MyStore;uid=sa;pwd=12345";

MyStoreDataContext context = new MyStoreDataContext(connectionstring);

//Câu 1: TRuy Vấn toàn bộ danh mục
var dsdm = context.Categories.ToList();
Console.WriteLine("---------Danh sách danh mục:--------");
foreach (var d in dsdm)
    Console.WriteLine(d.CategoryID + "\t" + d.CategoryName);

//Caau 2 : Laasy thoong tin chi tiết danh mục khi biết mã
int madm = 7;
Category cate = context.Categories.FirstOrDefault(c => c.CategoryID == madm);
if (cate == null)
{
    Console.WriteLine("Khong tìm thấy danh mục có mã =" + madm);
}
else
{
    Console.WriteLine("tìm thấy danh mục có mã =" + madm);
    Console.WriteLine(cate.CategoryID + "\t" + cate.CategoryName);

}
//Câu 3: Dùng query syntax để truy vấn toàn bộ sản phầm
var dssp = from p in context.Products
           select p;
Console.WriteLine("danh sách sản phẩm");
foreach (var p in dssp)
{
    Console.WriteLine(p.ProductID + "\t" + p.ProductName + "\t" + p.UnitPrice);
}


//Cau 4: Dung Query syntax va Anonymous type de loc ra 
//Cac san pham nhung chi lay ma san pham, va don gia
//dong thoi sap xep giam dan theo don gia

var dssp4 = from p in context.Products
            orderby p.UnitPrice descending
            select new { p.ProductID, p.UnitPrice };
Console.WriteLine("Danh sách sản phẩm theo yêu cầu câu 4");

foreach (var p in dssp4)
{
    Console.WriteLine(p.ProductID + "\t" + p.UnitPrice);
}


//Cau 5: sua cau 4 theo extention method (Method syntax)
Console.WriteLine("Danh sách sản phẩm theo yêu cầu câu 5");
var dssp5 = context.Products
    .OrderByDescending(p => p.UnitPrice)
    .Select(p => new {p.ProductID, p.UnitPrice });
foreach (var p in dssp5)
{
    Console.WriteLine(p.ProductID + "\t" + p.UnitPrice);
}

//Cau 6: Loc ra TOP 3 san pham co gia lon nhat he thong
//Yeu cau dung method systax

Console.WriteLine("Danh sách 3 sản phẩm có giá lớn nhất");
var dssp6 = context.Products.OrderByDescending(p=> p.UnitPrice)
    .Take(3)
    .Select(p => new { p.ProductID, p.ProductName, p.UnitPrice });

foreach (var p in dssp6)
{
    Console.WriteLine(p.ProductID + "\t" + p.ProductName + "\t" + p.UnitPrice);
}

//Cau 7: Sua ten danh muc khi biet ma danh muc do
int madm_sua = 7;
Category cate_sua = context.Categories.FirstOrDefault(c => c.CategoryID == madm_sua);

if(cate_sua != null)
{
    cate_sua.CategoryName = "Danh mục sửa đổi";
    context.SubmitChanges(); //Xac nhan thay doi
}

//Cau 8: Xoa danh muc khi biet ma danh muc do
int madm_xoa = 5;
Category cate_xoa = context.Categories.FirstOrDefault(c => c.CategoryID == madm_xoa);

if (cate_xoa != null)
{
    context.Categories.DeleteOnSubmit(cate_xoa);
    context.SubmitChanges(); //Xac nhan thay doi
    Console.WriteLine("Đã xóa danh mục có mã = " + madm_xoa);
}
else
{
    Console.WriteLine("Không tìm thấy danh mục có mã = " + madm_xoa);
}

//Cau 9: xoa cac danh muc neu khong co bat ki san pham nao thuoc danh muc do
//luu y cac cung luc nhieu danh muc, ma cac danh muc nay 
//khong chua bat ki san pham nao

var dsdm_empty_products = context.Categories
    .Where(c=>c.Products
    .Count() == 0).ToList();
context.Categories.DeleteAllOnSubmit(dsdm_empty_products);
context.SubmitChanges(); //Xac nhan thay doi

Console.WriteLine("Da xoa cac danh muc khong co san pham nao");

//Cau 10: Them moi mot danh muc
Category c_new = new Category();
c_new.CategoryName = "Iphone 14";
context.Categories.InsertOnSubmit(c_new);
context.SubmitChanges(); //Xac nhan thay doi


//Cau11: Them moi nhieu danh muc 