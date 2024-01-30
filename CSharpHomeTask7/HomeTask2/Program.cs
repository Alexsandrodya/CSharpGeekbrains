 int result = Ackermann(2, 4);
Console.WriteLine("Результат функции Аккермана: " + result);
 int Ackermann(int m, int n)
    {
        Console.WriteLine($"m {m},n {n}");
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        else if (m > 0 && n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));
        else
            return 0; // Для остальных случаев
    }