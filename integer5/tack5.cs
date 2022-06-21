Console.WriteLine("введите число > 999");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1 / 1000 % 10;
Console.WriteLine(num2);