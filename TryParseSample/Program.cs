// Nhap vao 1 so >=0, neu sai thi bat nhap lai
//Neu dung thi tinh giai thua so do

using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int n = -1;
while(n<0)
{
    Console.Write("Nhap n >= 0: ");
    String s = Console.ReadLine();
    if(int.TryParse(s, out n)==false)
    {
        Console.WriteLine("Nhap sai, nhap lai!");
    }
    else
    {
        if(n<0)
        {
            Console.WriteLine("Nhap sai, nhap lai!");
        }
    }
}

int gt = 1;
for(int i=1; i<=n; i++)
{
    gt *= i;
}
Console.WriteLine("{0}! = {1}", n, gt);