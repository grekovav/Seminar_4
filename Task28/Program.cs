// 28. Напишите программу, которая принимает на вход число N и
// выдает произведение чисел от 1 до N. 4 -> 24. 5 -> 120.
int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int getMultiply(int start, int end)
{
    int mult = 1;
    for (int i = start; i <= end; i++)
    {
        mult *= i; //mult = mult * 1
    }
    return mult;
}
void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}
int end = getUserData("Введите число N для получения произведения");
int mult = getMultiply(1, end);
showData($"Произведение чисел от 1 до {end} = ", mult);
