// Задача 2: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке
// от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int numberM = Prompt("Enter M number, please: ");
int numberN = Prompt("Enter N number, please: ");
Console.WriteLine();
int sum = PrintSumOfNaturalElements(numberM, numberN);
Console.WriteLine($"The sum of all natural elements in range from {numberM} to {numberN} is {sum}");

int PrintSumOfNaturalElements(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return 0;
    }

    return PrintSumOfNaturalElements(numberM, numberN - 1) + numberN;
}

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}