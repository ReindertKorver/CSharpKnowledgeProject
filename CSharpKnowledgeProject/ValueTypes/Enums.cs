using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKnowledgeProject.ValueTypes
{
    internal class Enums
    {
        // Lets start with User defined types
        private enum A
        { A, B, C }

        private enum BookGenre
        { Crime, Romance, Comedy }

        public static void Main()
        {
            // A can now be used as a type
            A a = A.A;
            A b = A.B;
            // A better example would be:
            BookGenre bookGenre = BookGenre.Comedy;
            bookGenre = BookGenre.Crime;
            var otherGenre = bookGenre;
            //otherGenre would be BookGenre.Crime
            //TODO: Continue https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum#enumeration-types-as-bit-flags
        }
    }
}