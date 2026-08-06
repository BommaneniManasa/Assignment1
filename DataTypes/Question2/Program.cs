using System;
class Program
{
static void Main()
    {
        Console.Write("Enter a string: ");
        string str=Console.ReadLine();
        int letters=0;
        int digits=0;

        foreach (char ch in str)
        {
            if (char.IsLetter(ch))
            {
                letters++;
            }
            if (char.IsDigit(ch))
            {
                digits++;
            }
        }
        Console.WriteLine("Alphabets="+letters);
        Console.WriteLine("Digits ="+digits);
    }
}

