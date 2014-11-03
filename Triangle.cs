using System;
using System.Text;
class Triangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char c = '\u00A9';
        Console.WriteLine("   {0}   \n  {0} {0} \n {0}   {0} \n{0} {0} {0} {0}", c);
    }
}

