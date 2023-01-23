using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Entry entry = new Entry();
        entry._date = "today";
        Console.WriteLine(entry.Display());

        Entry entry2 = new Entry();
        entry2._date = "tomorrow";
        Console.WriteLine(entry2.Display());
        
    }
}