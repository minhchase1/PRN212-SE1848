using System.Windows.Markup;

(int, double) SumAndAverage(int[] values)
{
    int s = 0;
    double avg = 0;
    foreach(int value in values)
        s += value;
    avg = (s)/ values.Length;
    return (s, avg);
}
int [] values = new int[10];
void createArray(int[] values)
{
    Random random = new Random();
    for (int i = 0; i < values.Length; i++)
    {
        Console.WriteLine("Nhap phan tu thu {0} = ", i);
        values[i] = int.Parse(Console.ReadLine());
    }
}

void printArray(int[] values)
{
    Console.WriteLine("Cac phan tu trong mang la: ");
    foreach (int value in values)
        Console.Write(value + " ");
    Console.WriteLine();
}

createArray(values);
printArray(values);
Console.WriteLine("\n Thong tin Sum + AVG");
(int s, double avg) = SumAndAverage(values);
Console.WriteLine("Tong = {0}", s);
Console.WriteLine("Trung binh = {0}", avg);
