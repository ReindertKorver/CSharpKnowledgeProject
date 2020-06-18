using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKnowledgeProject
{
    public class Info
    {
        public static void Main()
        {
            //Lets Start!
            //https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables
            //A variable exciting right?...
            //As this is C# so a variable is a value type or a reference type, value types directly contain their data,
            //reference types contain the reference to their data.
            //Below I havent given any type but C# knows the type by looking at the value when using var:
            var a = 0;
            //a is a local variable of type int, int is an alias for Int32 a struct (a value type).
            //Visual studio complains: The variable 'a' is assigned but its value is never used, lets use it then
            //We also see we can use int instead of var
            int b = a + 1;
            //here i'm adding 2 values to eachother using the + operator, the order in which they are evaluated is a, 1, +.
            //and because a contains 0, the end result will be 0 + 1 which equals to 1.
            //all forms of calculations like multiply subtract and divide are evaluated like math

            //==TYPES==
            //Lets step the speed up a bit
            //Simple value types:
            // ValueTypes/Integers.cs
            // ValueTypes/Chars.cs
            // ValueTypes/FloatingNumbers.cs
            // ValueTypes/BooleanLogic.cs
            // ValueTypes/Enums.cs
            // ValueTypes/Structs.cs
        }
    }
}