Console.WriteLine("введите размер файла в байтах");
int bayt = Convert.ToInt32(Console.ReadLine());
int kl = bayt / 1024;
Console.WriteLine($"{kl} килобайт");
