using System.Text;

void calculate(double a, double b, char operation)
{
    switch (operation)
    {
        case '+':
            Console.WriteLine("Kết quả: {0} + {1} = {2}", a, b, a + b);
            break;
        case '-':
            Console.WriteLine("Kết quả: {0} - {1} = {2}", a, b, a - b);
            break;
        case '*':
            Console.WriteLine("Kết quả: {0} * {1} = {2}", a, b, a * b);
            break;
        case '/':
            if (b == 0)
            {
                Console.WriteLine("Không thể chia cho 0!");
            }
            else
            {
                Console.WriteLine("Kết quả: {0} / {1} = {2}", a, b, a / b);
            }
            break;
        default:
            Console.WriteLine("Phép tính không hợp lệ!");
            break;
    }
}

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Chương trình tính toán đơn giản");

Console.Write("Nhập số thứ nhất (a) = ");
var a = double.Parse(Console.ReadLine());

Console.Write("Nhập số thứ hai (b) = ");
var b = double.Parse(Console.ReadLine());

Console.WriteLine("Chọn phép tính (+, -, *, /): ");
var operation = Console.ReadKey().KeyChar;
Console.WriteLine();

calculate(a, b, operation);
Console.ReadLine();

