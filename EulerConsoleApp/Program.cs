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
        BitMulti bm = new BitMulti();
        Console.WriteLine("10 * 321 = " + bm.Multiply(10, 321));
        Console.WriteLine("10 * 322 = " + bm.Multiply(10, 322));
        Console.WriteLine("10 * 323 = " + bm.Multiply(10, 323));
        Console.WriteLine("10 * 324 = " + bm.Multiply(10, 324));
        Console.WriteLine("10 * 325 = " + bm.Multiply(10, 325));
        Console.WriteLine("10 * 326 = " + bm.Multiply(10, 326));
        Console.WriteLine("10 * 327 = " + bm.Multiply(10, 327));
        Console.WriteLine("10 * 328 = " + bm.Multiply(10, 328));
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