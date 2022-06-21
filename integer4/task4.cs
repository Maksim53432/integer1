Console.Write("Введите число: ");
// 
int num = Convert.ToInt32(Console.ReadLine());
// int numrev = Int32.Parse(new string(num.ToString().Reverse().ToArray()));
int dig1 = num / 100;
int dig2 = num / 10;
int dig3 = num % 10;
Console.Write("Обратная запись числа: " + numrev);  