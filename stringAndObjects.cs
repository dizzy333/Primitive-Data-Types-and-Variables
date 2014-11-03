using System;

class stringAndObjects
{
    static void Main()
    {
        string var = "Hello";
        string var1 = "World";
        object both = var + " " + var1;
        string sentence = (string)both;
        Console.WriteLine(sentence);
            
    }
}

