// int SummOfNumbers(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number = SummOfNumbers(number / 10);
//     }
//     return sum;
// }

// int sum = SummOfNumbers(454);
// Console.WriteLine(sum);

int SummOfNumbers(int number)
{
    if (number == 0) return number;
    return number % 10 + SummOfNumbers(number / 10); 
}

int result = SummOfNumbers(111);
Console.WriteLine(result);