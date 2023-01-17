/*27: Напишите программу, которая принимает на вход число и
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int i = getUserData("Введите число для получения суммы цифр");

int sum = 0;

while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}

Console.WriteLine($"Сумма всех цифр в числе равна: {sum}");
