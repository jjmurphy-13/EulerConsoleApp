using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        string str1 = "anagram";
        string str2 = "palindrome";
        string str3 = "antidisestablishmentarianism";
        char[] str4 = "victimless".ToCharArray();

        Console.WriteLine(str1 + " => " + NoBufferReverse(str1.ToCharArray()));
        Console.WriteLine(str2 + " => " + NoBufferReverse(str2.ToCharArray()));
        Console.WriteLine(str3 + " => " + NoBufferReverse(str3.ToCharArray()));
        Console.WriteLine(new string(str4) + " => " + NoBufferReverse(str4));
        Console.WriteLine();

        //  This section performs multiplication without using the * operator
        //  or loops.  Instead it uses bitshifting and addition.  It also breaks
        //  down the multiplier into its constituent bit mask to be able to 
        //  correctly bit-shift to do the math.
        BitMulti bm = new BitMulti();
        Console.WriteLine("11 * 321 = " + bm.Multiply(11, 321));
        /* */
        Console.WriteLine("11 * 322 = " + bm.Multiply(11, 322));
        Console.WriteLine("11 * 323 = " + bm.Multiply(11, 323));
        Console.WriteLine("11 * 324 = " + bm.Multiply(11, 324));
        Console.WriteLine("11 * 325 = " + bm.Multiply(11, 325));
        Console.WriteLine("11 * 326 = " + bm.Multiply(11, 326));
        Console.WriteLine("11 * 327 = " + bm.Multiply(11, 327));
        Console.WriteLine("11 * 328 = " + bm.Multiply(11, 328));
        /* */
    }

    static string NoBufferReverse(char[] s)
    {
        int l = s.Length;
        for (int i = 0; i < l/2; i++)
        {
            Swap(ref s[i], ref s[l - i - 1]);
        }
        return new string(s);
    }

    static void Swap(ref char a, ref char b) {
        char temp = a;
        a = b;
        b = temp;
    }
}