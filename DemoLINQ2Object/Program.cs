
using System.Text;

int[] arr = { 100, 50, 120, 130, 80, 70, 123, 12, 237 };
//Dung LINQ2Object de loc ra cac so chan

//Cach Method syntax
var result = arr.Where(x => x % 2 == 0);

//Cach Query syntax
var result2 = from x in arr
              where x % 2 == 0
              select x;

Console.WriteLine("Cac so chan trong mang la: ");
result.ToList().ForEach(x => Console.Write(x + "\t"));



//Sap xep mang theo thu tu tang dan
var result3 = arr.OrderBy(x => x);
var result4 = from x in arr
              orderby x 
              select x;
Console.WriteLine("\nCac so trong mang sap xep theo thu tu tang dan la: ");
foreach (var item in result4)
{
    Console.Write(item + "\t");
}

//Sap xep mang theo thu tu giam dan
var result5 = arr.OrderByDescending(x => x);
var result6 = from x in arr
              orderby x descending
              select x;
Console.WriteLine("\nCac so trong mang sap xep theo thu tu giam dan la: ");
foreach (var item in result6)
{
    Console.Write(item + "\t");
}

//Cau 4: dem so luong cac so le
int dem = arr.Where(x=>x % 2 != 0).Count();
Console.WriteLine("");
