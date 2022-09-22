
Console.WriteLine("ВВедите число:");
int number = new Random().Next(100,1000);
int result = (number % 100 - number % 10)/10;
Console.WriteLine($"Случайное число: {number}, второе число = {result}");
