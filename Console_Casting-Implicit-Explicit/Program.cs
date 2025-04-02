using System;

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
            ClassDerived derivedClass = new ClassDerived();
            ClassBase baseClass = derivedClass;

            //===================================================================

            // B1.Explicit conversions (Larger -> Smaller)
            double doubleValue = 123.4567;
            int intValue = (int)doubleValue;   // Output: 123 

            // B2.Explicit conversions   (BaseClass -> DrivedClass)
            ClassBase baseClass2 = new ClassDerived();
            ClassDerived deliveredClass2 = (ClassDerived)baseClass2;

            //===================================================================

            // C. Parse / TryParse

            string strName = "Reza";
            string strId = "0010";

            bool Result = int.TryParse(strName, out int converted_strName);
            //bool:int.TryParse(string,out Int) : Check possibility of converting digits-OnString -> int and retruns a Boolean result + int of converted string!

            int converted_strId = int.Parse(strId); // int.Parse(string) : Convert String -> int and returns int value!

            //===================================================================

            // D. Convert.To_X

            int I = 100;
            double J = Convert.ToDouble(I);

        }
    }
}

