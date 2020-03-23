using System;
public class PrimeNumberExample
{
    public static void Main(string[] args)
    {
        int n, m = 0, t=0;
        Console.Write("Enter the Number to check Prime: ");
        n = int.Parse(Console.ReadLine());
        m = metoda1(n);
        t = metoda2(n);
        Console.Write("verifcare nr prim prin metoda 1 "+m+"\n");
        Console.Write("verifcare nr prim prin metoda 2 "+t);
    }
    public static int isPrim(int n)
    {
        int m,i, flag = 0;
        m = n / 2;
        for (i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                flag = 1;
                break;
            }
        }
        return flag;
    }
    public static int metoda1(int n)
    {
        int m = 0, i;
        for (i = 2; i < n; i++)
        {
            if (isPrim(i) == 0)
            {
                m = i;
            }
        }
        return m;
    }
    public static int metoda2(int n)
    {
        int i;
        for (i = n-1; i >= 2; i--)
        {
            if (isPrim(i) == 0)
            {
                return i;
            }
        }
        return 2;
    }
}