using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Note:
    A.Implicit conversions:
        1.No syntax required 
        2.type safe conversions (No data will be lost)
        3.Example : 
            a.conversions from smaller to larger integral types :(int -> double)
            b.Conversions from derived classes to base classe 


    B.Explicit conversions (Cast):
        1.Syntax required 
        2.NOT type safe conversions (data loss might occur)
        3.Example : 
            a.conversions from larger to smaller integral types :(Double -> int)
            b.Conversions from base classe to derived classes

    C.Parse / TryParse
    
    D.Convert.To_X

*/
namespace Console_Casting_Implicit_Explicit
{
    class ClassBase { }
    class ClassDerived : ClassBase { }
    class Program
    {

        static void Main(string[] args)
        {
            // A1. Implicit conversions  (Smaller -> Larger)
            int x = 100;
            double y = x;

            // A2.Implicit conversions  (DrivedClass -> BaseClass)
            ClassDerived D = new ClassDerived();
            ClassBase B = D;

            //===================================================================

            // B1.Explicit conversions (Larger -> Smaller)
            double d = 123.4567;
            int nd = (int)d;   // Output: 123 

            // B2.Explicit conversions   (BaseClass -> DrivedClass)
            ClassBase Ba = new ClassBase();
            ClassDerived De= (ClassDerived)Ba;

            //===================================================================

            // C. Parse / TryParse

            string strName = "Reza";
            string strId = "0010";

            bool Result = int.TryParse(strName, out int converted_strName);  //bool:TryParse(string,Int) : Check possibility of converting digits-OnString -> int and retrun boolean
            int converted_strId = int.Parse(strId); // int.Parse(string) : Convert String -> int

            //===================================================================

            // D. Convert.To_X

            int I = 100;
            double J = Convert.ToDouble(I);

        }
    }
}

