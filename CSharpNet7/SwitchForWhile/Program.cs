using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int number1 = Random.Shared.Next(0, 9);
int number2 = Random.Shared.Next(0, 9);

Console.WriteLine($"{nameof(number1)}={number1}, {nameof(number2)}={number2}");


Console.WriteLine("vui lòng nhập dấu của phép toán:");
string? dau = Console.ReadLine();

switch (dau)
{
    case "+":
        Console.WriteLine(number1 + number2);
        break;
    case "-":
        Console.WriteLine(number1 - number2);
        break;
    case "*":
        Console.WriteLine(number1 + number2);
        break;
    case "/":
        Console.WriteLine(number1 + number2);
        break;
    default:
        Console.WriteLine("hi, i can't");
        break;
}