// Задача 69 Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.

int SummOfNumbers(int numberA, int numberB)
{
    if (numberB == 1) return numberA;
    return numberA * SummOfNumbers(numberA, numberB - 1);
}

int result = SummOfNumbers(2, 4);
Console.WriteLine(result);