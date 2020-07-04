using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKnowledgeProject.ValueTypes
{
    internal class BooleanLogic
    {
        public static void Main()
        {
            //Aliases followed by real struct
            // # Boolean
            //for logic
            bool q = true;
            Boolean q1 = false;
            //default = false

            //Sample logic
            bool q2 = !true;
            //output: false

            //example function:
            bool test() => true;

            //Logical AND
            //test is executed when the first value is false
            bool q3a = false & test();
            //output: false
            bool q4b = true & true;
            //output: true

            //Conditional logical AND
            //test is not executed when the first value is false
            bool q3 = false && test();
            //output: false
            bool q4 = true && true;
            //output: true

            //Logical OR
            //test is executed while the first value is true
            bool q5 = true | test();
            //output: true

            //Conditional logical OR
            //test is not executed when the first value is true
            bool q6 = false || test();
            //output: true

            //XOR
            bool q7 = true ^ false || false ^ true;
            //output: true
            bool q8 = true ^ true;
            //output: false

            //Compound assignment
            //evaluating and assigning
            bool r = true;
            r &= false;
            // ==
            r = r & false;

            r |= true;
            // ==
            r = r | true;

            r ^= true;
            // ==
            r = r ^ true;

            // Operator repetition
            bool a = false || false || test() && false;
            //output: false
            //Sequence:
            // Logical negation operator !
            // Logical AND operator &
            // Logical exclusive OR operator ^
            //Logical OR operator |
            // Conditional logical AND operator &&
            // Conditional logical OR operator ||
            //ofcourse you are able to use parentheses ()
            bool b = (false || (false || test())) && true;
            //output: true
            //when parentheses arent needed Visual Studio will color them a darker grey
            //so above can be simplified:
            bool b1 = (false || false || test()) && true;

            bool c = true == true;
            //which is not equal to
            bool c1 = true && true;
            //I never thought of that really
        }
    }
}