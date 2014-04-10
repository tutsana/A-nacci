using System;
					
public class Program
{
	public static void Main()
	{
		int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        ulong[] numbers = new ulong[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = ulong.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            ulong remainder = 0;
            string result = null;

            while (numbers[i] > 0)
            {
                remainder = numbers[i] % 2;
                numbers[i] /= 2;
                result = remainder.ToString() + result;
            }

            int digitCounter = 0;
            for (int j = 0; j < result.Length; j++)
            {
                if (int.Parse(result[j].ToString()) == b)
                {
                    digitCounter++;
                }
            }
            Console.WriteLine(digitCounter);
        }
	}
}
