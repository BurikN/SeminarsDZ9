// Задача 64
/*Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

PrintNumbersToN(number);

void PrintNumbersToN(int n)
{
    if (n < 1) return;
    Console.Write(n + " ");
    PrintNumbersToN(n - 1);
}
*/
//Задача 66
/*Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > numberN)
{
    Console.WriteLine("Число M не может быть больше N");
}
else
{
    int sum = SumCountFromMToN(numberN, numberM);
    Console.WriteLine(sum);
}

int SumCountFromMToN(int n, int m)
{
    if (n < m) return 0;
    int sum = SumCountFromMToN(n - 1, m);
    return sum += n;
}
*/
//Задача 68
Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM >= 0 && numberN >= 0)
{
    int sum = SumCountFromMToN(numberN, numberM);
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Число M и N не могут быть отрицательными");
}

int SumCountFromMToN(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return SumCountFromMToN(m - 1, 1);
    }
    else
    {
        return SumCountFromMToN(m - 1, SumCountFromMToN(m, n - 1));
    }
}