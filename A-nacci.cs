using System;

class A_nacci
{
    static void Main()
    {
        char inputFirst = char.Parse(Console.ReadLine());
        char inputSecond = char.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        char[] a_Nacci = new char[26];

        int counter = 0;
        for (char i = 'A'; i <= 'Z'; i++)
        {
            a_Nacci[counter] = i;
            //Console.WriteLine(a_Nacci[counter]); // to see if the array is filled correctly
            counter++;
        }

        long a = 1 + Array.IndexOf(a_Nacci, inputFirst); // the index starts from 0 (Example: in our array index of C = 2, we need it to be C = 3)
        long b = 1 + Array.IndexOf(a_Nacci, inputSecond); // same as the above
        long result = 0;
        string whiteSpace = "";

        for (int i = 1; i <= l; i++)
        {
            if (i == 1)
            {
                Console.Write(a_Nacci[a - 1]);
            }
            else if (i == 2)
            {
                Console.Write(a_Nacci[b - 1]);
                result = a + b;
                a = b;
                b = result;
                Console.Write("{0}{1}", whiteSpace, a_Nacci[(result - 1) % 26]); // 
            }
            else if (i > 2)
            {
                whiteSpace = whiteSpace + " ";
                result = a + b;
                a = b;
                b = result;
                Console.Write(a_Nacci[(result - 1) % 26]);
                result = a + b;
                a = b;
                b = result;
                Console.Write("{0}{1}", whiteSpace, a_Nacci[(result - 1) % 26]);
            }
            Console.WriteLine();
        }
    }
}

