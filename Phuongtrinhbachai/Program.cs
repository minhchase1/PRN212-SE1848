using System.Text;

void first_degree_solution(double a, double b)
{
    if (a == 0 && b == 0)
    {
        Console.WriteLine("Vo so nghiem");
    }
    else if (a == 0 && b != 0)
    {
        Console.WriteLine("Vo nghiem");
    }
    else
    {
        Console.WriteLine("X={0}", -b / a);
    }
}
void quadratic_solution(double a, double b, double c)
{
    if (a == 0)
    {
        //Phuong trinh bac nhat
        first_degree_solution(b, c);
    }
    else
    {
        var delta = Math.Pow(b,2)- 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Vo nghiem");
        }
        else if (delta == 0)
        {
            Console.WriteLine("X1=X2={0}", -b / (2 * a));
        }
        else
        {
            var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        }
    }
}
Console.OutputEncoding = Encoding.UTF8; 
Console.WriteLine("Giai phuong trinh bac hai ax^2+bx+c=0");
Console.Write("Nhap a= ");
var a = double.Parse(Console.ReadLine());
Console.Write("Nhap b= ");
var b = double.Parse(Console.ReadLine());
Console.Write("Nhap c= ");
var c = double.Parse(Console.ReadLine());
Console.WriteLine("{0}x^2+{1}x+{2}=0", a, b, c);
quadratic_solution(a, b, c);
Console.ReadLine();

