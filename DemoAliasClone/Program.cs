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

