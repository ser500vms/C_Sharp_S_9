// void FromNToM(int start, int end)
// {   
//     if (start < end)
//     {
//         Console.Write($"{start}, ");
//         FromNToM(start + 1, end);
//     }
//     else Console.Write(end);
// }
// FromNToM(3, 10);

string FromNToM(int start, int end)
{
    if (end == start) return start.ToString();
    else return FromNToM(start, end -1) + ", " + end;
}

Console.Write(FromNToM(5, 10));