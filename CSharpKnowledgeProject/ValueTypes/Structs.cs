using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKnowledgeProject.ValueTypes
{
    internal class Structs
    {
        public static void Main()
        {
            //Structure types
            // We just had Enums and we saw they had their own user-defined type we also saw that Int32 was a struct
            // Let see if we can create such a type:
            Integer integer = new Integer();
            //Now we use the new keyword this means a new instance of Integer is created and saved inside the integer variable
            //Also Integer() calls a constructor which is called the same as the struct
            //The constructor isnt needed when there are no parameters to be given to the struct.
            //A constructor needs to be public or internal because it needs to be accessed outside of the struct itself

            //A struct can have a field:
            var r = integer.Field;
            //r is 0 as 0 is the default of an int
            integer.Field = 1;
            //integer.Field is 1

            //A struct can have a property:
            var r1 = integer.Property;
            //r is 0 as 0 is the default of an int
            integer.Property = 1;
            //integer.Property is 1
            //A propery is more customizable then a field:
            //for example: you can change other variables when the property is set
            //notice that a field is needed to store the value
            //when leaving the get and set empty the field isnt needed
            //value is the value which is passed after the = sign for assignment
            //it is not needed for others to see this field so with the private access modifier we can hide it
            //integer.propertyExpanded; is inaccessible due to its protection level
        }

        private struct Integer
        {
            public int Field;
            public int Property { get; set; }

            private int propertyExpanded;

            public int PropertyExpanded
            {
                get { return propertyExpanded; }
                set { Field += 1; propertyExpanded = value; }
            }
        }
    }
}