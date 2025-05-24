using OOP1;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.OutputEncoding = Encoding.UTF8;
// Tao doi dc Category1
Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nước Mắm";
//Xuat thong tin
c1.PrintInfor();

//Gia su ta doi gia tri trong o nho do
c1.Name = "Tương Ớt ";
Console.WriteLine("Sau khi thay đổi giá trị ");
c1.PrintInfor();

//Su dung lop employee
Console.WriteLine("------------Employee1-----------");
Employee e1 = new Employee();
e1 .Id = 1; //Goi setter Id
e1.IdCard = "001";
e1.Name1 = "Nguyên Văn  A"; //Goi setter Name
e1.Email1 = "nguyenvana@gmail.com"; //Goi setter Email
e1.Phone1 = "0917273112"; //Goi setter Phone

//Xuat thong tin
e1.PrintInfor();

Employee e2 = new Employee()
{
    ID = 2, //Goi setter Id
    IdCard = "002",
    Name1 = "Nguyên Văn  B", //Goi setter Name
    Email1 = "nguyenvanb@gmail.com",
    Phone = "0917273113" //Goi setter Phone
};
Console.WriteLine("------------Employee2-----------");
e2.PrintInfor();

Employee e3 = new Employee();
Console.WriteLine("------------Employee3-----------");
e3.PrintInfor();

//Tao eployee4
Console.WriteLine("------------Employee4-----------");
Employee e4 = new Employee(4, "004", "Nguyên Văn  C", "nguyenvanc@gmail.com", "091727371");
e4.PrintInfor();
Console.WriteLine("---------Employee4 Cach 2-------");
Console.WriteLine(e4);


Console.WriteLine("---------Customer 1-------");
Customer cus1 = new Customer()
{
    Id = 1,
    Name = "Nguyen thi Linh",
    Email = "nguyenthilinh@gmail.com",
    Phone = "0917281823",
    Address = "Le Van Viet"
};

cus1.PrintInfor();
cus1.Address ="Nguyen Van Cu";
Console.WriteLine("Customer 1 sau khi thay dia chi");
cus1.PrintInfor();