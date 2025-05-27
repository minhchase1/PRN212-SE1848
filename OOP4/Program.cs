using OOP2;
using OOP4;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
FulltimeEmployee fe = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "Barack Obama",
    Birthday = new DateTime(1961, 8, 4)
};

Console.WriteLine("Thông tin nhân viên Obama:");
Console.WriteLine(fe);
Console.WriteLine("Tuoi = " + fe.Tuoi());
Console.WriteLine("---------------------------");
if (fe.CheckSinhNhat())
{
    Console.WriteLine($"Tháng này là sinh nhật của {fe.Name}!");
}
else
{
    Console.WriteLine("Chưa tới tháng sinh nhật.");
}