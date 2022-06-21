// Дано двузначное число. Найти сумму и произведение его цифр.
Console.WriteLine("введите двухзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
int Dig1 = num1 / 10;
int Dig2 = num1 % 10;
Console.WriteLine($"первая слава цифра {Dig1}, вторая слева цифра {Dig2}");