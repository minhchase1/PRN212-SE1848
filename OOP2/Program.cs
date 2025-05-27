using OOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee obama = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "Barack Obama",
    Birthday = new DateTime(1961, 8, 4)
};


Console.WriteLine("Thông tin nhân viên Obama:");
Console.WriteLine("ID= " +obama.Id);
Console.WriteLine("ID Card= " +obama.IdCard);
Console.WriteLine("Name= " +obama.Name);
Console.WriteLine("Birthday= " +obama.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Luong cua Obama = " + obama.calSalary());



Console.WriteLine("-----------------------------------------------------");
ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 2,
    IdCard = "456",
    Name = "Donald Trump",
    Birthday = new DateTime(1946, 6, 14),
    WorkingHours = 2
};



Console.WriteLine("Thông tin nhân viên Trump:");
Console.WriteLine("ID= " + trump.Id);
Console.WriteLine("ID Card= " + trump.IdCard);
Console.WriteLine("Name= " + trump.Name);
Console.WriteLine("Birthday= " + trump.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Luong cua Obama = " + trump.calSalary());

Console.WriteLine("------------------THONG TIN CACH 2 CUA NHAN SU-------------------------");
Console.WriteLine(obama);
Console.WriteLine(trump);



