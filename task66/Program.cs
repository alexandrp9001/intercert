// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine(GetSumNum(9, 0));
int GetSumNum(int start, int end)
{
    if (start == 0)
    {
        return (end * (end + 1)) / 2;
    }
    else if (end == 0)
    {
        return (start * (start + 1) / 2);
    }
    else if (start == end)
    {
        return start;
    }
    else if (start < end)
    {
        return end + GetSumNum(start, end - 1);
    }
    else return end + GetSumNum(start, end + 1);
}




