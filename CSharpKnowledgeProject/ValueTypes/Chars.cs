using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKnowledgeProject.ValueTypes
{
    internal class Chars
    {
        public static void Main()
        {
            // # Unicode
            char l = 'a';
            char l1 = '\u000F';
            char l2 = '\xF';
            //a character (single quotes)
            //can also be assigned by \u or \x followed by hexadecimals \u needs to be 4 digits, looking at the execution it looks like \x is converted to \u
            int m = 'a' + 'b';
            // as char can only be 1 character, adding up will result in the integer representation of the chars added up to eachother
            char n = (char)m;
            //casting it back to a char will result in the char by the int 97('a') + 98('b') = 195('Ã')
            char o = (char)('a' + 1);
            //also 'a' + 1 will result in 98 which will be 'b' when casted back to char
        }
    }
}