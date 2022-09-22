int result = -1;
int number = new Random().Next(10,99999);
Console.WriteLine($"случайное число :{number}");
while (number > 99)
{
    result = number % 10;
    number = number/10;

}
if (result >= 0)
{
 Console.WriteLine($"Третье число: {result}");
}
else Console.WriteLine("Треетей цифры нет");