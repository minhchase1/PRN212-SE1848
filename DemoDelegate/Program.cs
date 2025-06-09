class Program
{
    public delegate int MyDelegate(int x, int y);
    public delegate int[] YourDelegate(int y);
    static int Cong(int a, int b)
    {
        return a + b;
    }
    static int Tru(int a, int b)
    {
        return a - b;
    }

    static int[]DanhSachSoChan(int n)
    {
        List<int> list = new List<int>();
        for(int i = 2;  i < n; i = i + 2)
        {
            list.Add(i);
        }
        return list.ToArray();
    }

    static int[]DanhSachSoNGuyenTo(int n)
    {
        List<int> list = new List<int>();
        for (int i = 2; i < n; i++)
        {
            int count = 0;
            for(int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    count++;
            }
            if (count == 2)
                list.Add(i);
        }
        return list.ToArray();
    } 
    public static void Main(string[] args)
    {
        MyDelegate m = new MyDelegate(Cong);
        Console.WriteLine("5+8=" + m(5, 8));
        m = new MyDelegate(Tru);
        Console.WriteLine("5-8=" + m(5, 8));

        YourDelegate y = new YourDelegate(DanhSachSoChan);
        int[] arr = y(10);
        foreach(var item in arr)
        {
            Console.Write(item + "\t");
        }

        Console.WriteLine();
        y = new YourDelegate(DanhSachSoNGuyenTo);
        arr = y(10);
        foreach (var item in arr)
        {
            Console.Write(item + "\t");
        }
    }
}