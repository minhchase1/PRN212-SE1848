using System.Text;

void first_degree_solution(double a, double b)
{
    if(a==0 && b==0)
    {
        Console.WriteLine("Vo so nghiem");
    }
    else if(a==0 && b!=0)
    {
        Console.WriteLine("Vo nghiem");
    }
    else
    {
        Console.WriteLine("X={0}", -b/a);
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Giai phuong trinh bac nhat ax+b=0");
Console.Write("Nhap a= ");
double a = double.Parse(Console.ReadLine());
Console.Write("Nhap b= ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("{0}x+{1}=0", a, b);
first_degree_solution(a, b);
Console.ReadLine();