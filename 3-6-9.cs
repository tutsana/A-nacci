using System;
					
public class Program
{
	public static void Main()
	{
		long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long result = 0;

        if (b == 3)
        {
            result = a + c;
        }

        if (b == 6)
        {
            result = a * c;
        }

        if (b == 9)
        {
            result = a % c;
        }

        long remainder = result % 3;

        if (remainder == 0)
        {
            Console.WriteLine(result / 3);
            Console.WriteLine(result);
        }

        else
        {
            Console.WriteLine(remainder);
            Console.WriteLine(result);
        }
	}
}
