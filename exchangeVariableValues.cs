using System;

class exchangeVariableValues
{
    static void Main()
    {

        int a, b;
        a = 5;
        b = 10;
       
        Console.WriteLine("a={0}, b={1}", a, b);
        
        int c;      
        c = a;    
        a = b; 
        b = c;  
   
        Console.WriteLine("a={0}, b={1}", a, b);
 
    }
}

