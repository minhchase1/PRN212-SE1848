using System.Diagnostics;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
void ham1(int n)
{
    n = 8;
    Console.WriteLine("Trong ham1, n = {0}", n);

}
int n= 5;
Console.WriteLine("Truoc khi goi ham1, n = {0}", n);
ham1(n);
Console.WriteLine("Sau khi goi ham1, n = {0}", n);

void ham2(ref int n)
{     n = 8;
    Console.WriteLine("Trong ham2, n = {0}", n);
}
Console.WriteLine("---------------------------------");
int n1 = 5;
Console.WriteLine("Truoc khi goi ham2, n1 = {0}", n1);
ham2(ref n1);
Console.WriteLine("Sau khi goi ham2, n1 = {0}", n1);

//int m;
//ham2(ref m); Bao loi vi m chua co gia tri


void ham3(out int n)
{
    n = 20;
}
Console.WriteLine("---------------------------------");
int n = 5;
ham3(out n);


