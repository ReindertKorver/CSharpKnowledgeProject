using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKnowledgeProject.ValueTypes
{
    internal class FloatingNumbers
    {
        public static void Main()
        {
            //Aliases followed by real struct
            // # Binary floating-point
            float p = 0.01F;
            Single pS = 0.01F;
            //precision ~6-9 digits
            double p1 = 0.01;
            Double pS1 = 0.01;
            //precision ~15-17 digits
            // # High-precision decimal floating-point
            decimal p2 = 0.01M;
            Decimal pS2 = 0.01M;
            //precision 28-29 digits
        }
    }
}