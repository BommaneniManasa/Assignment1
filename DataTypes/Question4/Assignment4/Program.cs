using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string:");
        string str = Console.ReadLine();
        Console.Write("Reverse String:");
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Substring:"+str.Substring(1));
        Console.Write("Enter character to replace:");
        char ch = Convert.ToChar(Console.ReadLine());
        string newStr = str.Replace(ch, '$');
        Console.WriteLine("After Replace:"+newStr);
        string str2=str;
        str2=str2+" Wipro";
        Console.WriteLine("Original String: " + str);
        Console.WriteLine("Copied String: " + str2);
    }
}

