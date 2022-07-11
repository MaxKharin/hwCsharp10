// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все чётные натуральные числа в промежутке
// от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int numberM = Prompt("Enter M number, please: ");
int numberN = Prompt("Enter N number, please: ");
Console.WriteLine();
Console.WriteLine($"All even natural numbers in range from {numberM} to {numberN}: ");
PrintNaturalEvenNumbers(numberM, numberN);

void PrintNaturalEvenNumbers(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return;
    }
    if (numberN % 2 == 1)
    {
        numberN--;
    }

    PrintNaturalEvenNumbers(numberM, numberN - 2);
    Console.WriteLine($"{numberN}");
}

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}