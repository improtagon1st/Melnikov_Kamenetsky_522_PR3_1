using System;
using System.Text;

class ArrayExample
{
    static void Main()
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        StringBuilder name = new StringBuilder();
        int[] a = new int[letters.Length]; 

        for (int i = 0; i < letters.Length; i++)
        {
            name.Append(letters[i]);
            a[i] = i + 1;
            SendMessage(name.ToString(), a[i]);
        }

        Console.ReadKey();
    }

    static void SendMessage(string name, int msg)
    {
        Console.WriteLine($"Hello, {name}! Count to {msg}"); 
    }
}
