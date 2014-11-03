using System;

class QuotesInStrings
{
    static void Main()
    {
        string firstVar = "The \"use\" of quotations causes difficulties.";
        string secoundVar = "The use of quotations causes difficulties.";
        Console.WriteLine("{0}" + "\n{1}", firstVar, secoundVar);
    }
}

