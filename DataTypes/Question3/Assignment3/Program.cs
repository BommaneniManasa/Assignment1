using System;
class Program
{
static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        foreach (char ch in str)
        {
            char newChar=(char)(ch+1);
            if (char.IsUpper(newChar))
            {
                Console.Write(char.ToLower(newChar));
            }
            else if (char.IsLower(newChar))
            {
                Console.Write(char.ToUpper(newChar));
            }
            else
            {
                Console.Write(newChar);
            }
        }
    }
}

