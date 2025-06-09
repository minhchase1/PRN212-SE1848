using DemoLINQ2ObjectModeClass;

ListProduct lp = new ListProduct();
lp.gen_product();

//Cau 1: loc ra cac gia san pham co gia tu a den b
Console.WriteLine("Cac san pham co gia tu 20 den 30 la: ");
lp = new ListProduct();
lp.gen_product();
var result1 = lp.FilterProductByPrice(10, 30);
foreach (var item in result1)
{
    Console.WriteLine(item);
}

//Cau 2: Sap xep cac san pham theo don gia tang dan

Console.WriteLine("\nCac san pham sap xep theo don gia tang dan la: ");
var result2 = lp.SortProductByPriceAsc2();
result2.ForEach(x => Console.WriteLine(x)) ;
//Cau 3: Sap xep cac san pham theo don gia giam dan
Console.WriteLine("Cac san pham don gia giam dan");
var result3 = lp.SortProductByPriceDes2();


//Cau 4: tinh tong gia tri cac san pham co trong kho
Console.WriteLine("Tong gia tri cac san pham co trong kho la: "+lp.SumOfValue());


//Cau 5: tim chi tiet cac san pha, khi biet id cua san pham
Product p = lp.SearchProductDetail(1);
if (p!= null)
{
    Console.WriteLine("Tim thay san pham, thong tin chi tiet");
    Console.WriteLine(p);
}
else
{
       Console.WriteLine("Khong tim thay san pham");
}


//Cau 6: loc ra top N san pham co gia tri lon nhat
Console.WriteLine("Top 3 san pham co gia tri lon nhat la: ");
var result6 = lp.SearchTopProductByPrice(3);
foreach (var item in result6)
{
    Console.WriteLine(item);
}