// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// Выполнить с помощью рекурсии.

// void FromNToM(int end)
// {
//     if (end > 1)
//     {
//         FromNToM(end - 1);
//         Console.Write($"{end - 1}, ");
//     }
//}

// FromNToM(10);
// Console.Write(10);

string FromNToM(int end)
{
    if (end == 1) return end.ToString();
    else return FromNToM(end -1) + ", " + end;
}

Console.Write(FromNToM(10));
