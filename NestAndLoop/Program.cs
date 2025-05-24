void swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}
void sort_array(int []arr)
{
    for(int i = 0; i < arr.Length - 1; i++)
    {
        for(int j = 0; j < arr.Length; j++)
        {
            if(arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
        }
    }
}

void sort_array_while(int []arr)
{
    int i = 0, j = 0;
    while(i < arr.Length - 1)
    {
        j = i + 1;
        while(j < arr.Length)
        {
            if(arr[i] < arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        }
        i++;
    }
}


void sort_array_do_while(int []arr)
{
    int i = 0, j = 0;
    do
    {
        j = i + 1;
        do
        {
            if(arr[i] < arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        } while(j < arr.Length);
        i++;
    } while(i < arr.Length - 1);
}


int[] values = new int[5];
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
Console.WriteLine("--------------------------");
sort_array_do_while(values);
Console.WriteLine("Mang sau khi sap xep la: ");
printArray(values);