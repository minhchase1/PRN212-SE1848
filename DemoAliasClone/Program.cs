using DemoAliasClone;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Customer c1 = new Customer
{
    Id = 1,
    Name = "Alice"
};

Customer c2 = new Customer
{
    Id = 2,
    Name = "Slimz"
};

c1 = c2;
//c1 tro den vung nho ma c2 dang quan li
//chu khong phai c1 = c2
//Luc nay xay ra 2 tinh huong 
//(1) O nho alpha ma c1 quan li luc nay bi trong
//=> he dieu hanh se thu hoi o nho alpha
//goi la che do Garbage Collection (gom rac tu dong)
//ta khong the nao lay duoc gia tri tai o nho nay nua
//(2) O nho beta se co 2 doi tuong quan li
//doi tuong ban dau la c2
//bay gio co them c1
//trung hop 1 o nho tu tu 2 doi tuong tro len tham gia quan li
//no duoc goi la "alias" (ten goi khac)
//bat ki 1 doi tuong nao doi gia tri tai o nho beta
//-> thi cac doi tuong con lai deu bi anh huong

c1.Name = "Ho Do";
//thi luc nay c2 cung bi thay doi
//vi chung no cung quan li o nho beta
Console.WriteLine("Ten cua c2 la: " + c2.Name);



Customer c3 = new Customer
{
    Id = 3,
    Name = "Raz"
};

Customer c4 = c3;
c3 = c1;
Console.WriteLine("Ten cua c4 la: " + c4.Name);
Console.WriteLine("Ten cua c3 la: " + c3.Name);


Product p1 = new Product
{
    Id = 1,
    Name = "Iphone 15 Pro",
    Quantity = 10,
    Price = 20
};

Product p2 = new Product
{
    Id = 2,
    Name = "Iphone 14 Pro",
    Quantity = 5,
    Price = 15
};

p1 = p2;
Console.WriteLine("-----Thong tin cua p1------");
Console.WriteLine(p1);
Console.WriteLine("-----Thong tin cua p2------");
Console.WriteLine(p2);

p2.Name = "Iphone 13";
p2.Quantity = 50;
p2.Price = 40;

Console.WriteLine("-----Thong tin da duoc thay doi------");
Console.WriteLine(p1);


Product p3 = new Product
{
    Id = 3,
    Name = "p3",
    Quantity = 55,
    Price = 45
};

Product p4 = new Product
{
    Id = 4,
    Name = "p4",
    Quantity = 23,
    Price = 29
};

Product p5 = p3;
p3 = p4;
//neu bo sung 
p5 = p3;
//thi co thu hoi o nho da cap phat cho p3 hay khong
Console.WriteLine(p5);

Product p6 = p4.Clone();
//he dieu hanh se sao chep toan bo du lieu ma p4 dang quan li qua 1 o nho moi
//va giao cho p6 quan li o nho moi nay
//p4 va p6 quan li 2 o nho khac nhau hoan toan, nhung co gia tri giong nhau
//==>p6 doi khong lien quan den p4, va nguoc lai
Console.WriteLine("Thong tin cua p6");
Console.WriteLine(p6);
Console.WriteLine("Thong tin cua p4");
Console.WriteLine(p4);


