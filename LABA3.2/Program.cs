Console.Write("Введите натуральное число n (n >= 10): ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 10)
{
    Console.WriteLine("Число должно быть не менее 10.");
    return;
}

Console.WriteLine("Нечетные кратные 5 числа от 10 до {0}:", n);

for (int i = 11; i <= n; i += 2)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}

