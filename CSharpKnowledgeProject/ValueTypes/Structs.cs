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
            Integer integerInstanciated = new Integer();
            Integer integer;
            //Now we use the new keyword this means a new instance of Integer is created and saved inside the integer variable
            //Also Integer() calls a constructor which is called the same as the struct
            //The constructor isnt needed but then values inside the struct arent instanciated.
            //A constructor needs to be public or internal because it needs to be accessed outside of the struct itself

            //A struct can have a field:
            var r = integerInstanciated.Field;
            //r is 0 as 0 is the default of an int

            //the integer.Field is unassigned so first assign it
            integer.Field = 1;

            integerInstanciated.Field = 1;
            //integer.Field is 1

            //A struct can have a property:
            var r1 = integerInstanciated.Property;
            //r is 0 as 0 is the default of an int
            integerInstanciated.Property = 1;
            //integer.Property is 1
            //A propery is more customizable then a field:
            //for example: you can change other variables when the property is set
            //notice that a field is needed to store the value
            //when leaving the get and set empty the field isnt needed
            //value is the value which is passed after the = sign for assignment
            //it is not needed for others to see this field so with the private access modifier we can hide it
            //integer.propertyExpanded; is inaccessible due to its protection level
            integerInstanciated.PropertyExpanded = 10;
            //while the property is accesible
            //and because we update the field Field inside this property Field will now contain 2

            //Now lets make a more sensible struct
            //Lets make a Point in a 3D space
            Point point;
            point.X = 9;
            point.Y = 5;
            point.Z = 2;
            var result = point.Sum;
            //result: 16
            //because we dont want to be able to assign Sum
            //like point.Sum=10;
            //we dont specify a set so Sum is readonly

            //Lets make another struct called Line
            //It will have 2 Point's the start and end of the line
            //but we can see the start and end aren't assigned to as this is not possible in a struct
            //so we will now make use of the constructor of a struct
            //so we can pass the 2 points to the line when making a new instance
            //lets pass a new Point and the one used before
            Line line = new Line(new Point(), point);
            //as the defaults of an int are 0 our line will start from x,y,z -> 0,0,0 to x,y,z -> 9,5,2
            //you can imagine what this will look like in a 3d space
            //if we also implement the Sum property here and sum the sum of the start point to the sum of the end point
            var res = line.Sum;
            //res will also result int 16 as the start point doesnt contain a x,y,z higher then 0
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

        private struct Point
        {
            public int X;
            public int Y;
            public int Z;

            public int Sum { get => X + Y + Z; }
        }

        private struct Line
        {
            public Point Start;
            public Point End;

            public Line(Point start, Point end)
            {
                Start = start;
                End = end;
            }

            public int Sum { get => Start.Sum + End.Sum; }
        }
    }
}