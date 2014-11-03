using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Null_Values_Arithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? nullInt = null;
            double? nullDouble = null;
            Console.WriteLine("Nullable int = {0}\nNullable double = {1}",nullInt, nullDouble);
            nullInt = 15654;
            nullDouble = 1565.254;
            Console.WriteLine("Nullable int = {0}\nNullable double = {1}",nullInt, nullDouble);


        }
    }
}
