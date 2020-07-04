using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKnowledgeProject.Other
{
    public class ListsAndMore
    {
        public static void Main()
        {
            //Look at the part on generics for <> charachters when mentioning a class and creating a new instance
            //Now we will look at Lists
            List<int> list = new List<int>();
            //for creating a new instance of a List of type int
            //lets add some items to the List
            list.Add(1);
            //now lets add a range of items to the List
            //you are able to add anything that extends from IEnumerable<> with the same generic type
            list.AddRange(new List<int>() { 2, 3 });
            //or an array
            list.AddRange(new int[] { 4, 5, 6 });
            //Lets create a Stack to add to the current list we have
            //The cool thing about a stack is the Last in First Out functionality
            Stack<int> stack = new Stack<int>();
            stack.Push(7);
            stack.Push(8);
            //there doesnt seem to be a push range although I think this could be implemented
            //where the last item goes on top the first goes first
            stack.Peek();
            //-> 8
            stack.Push(9);
            //shows the top item without removing
            stack.Pop();
            //-> 9
            //returns and removes the top item
            list.AddRange(stack);
            //lets add the stack to the list

            //A list seems to have a Length aswell but its resized when needed
            //we can look into it by looking at the Capacity property
            var res = list.Capacity;
            //it looks like the capacity is updated every 4 items
            //so when you add an certain amount of items where you know the length of its probably better to change the capacity
            //so you need less computing to do it every 4 items
            //Lets show an example of an array where this is the case manually
            int[] arr = new int[4] { 1, 2, 3, 4 };
            //we need to give the default length of 4
            //because an array is immutable and the length cant be changed
            //so we need to copy the array to a new one with a different length
            //there is a method for this but lets do this mannually
            int[] newarr = new int[arr.Length + list.Capacity];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];
            }

            //in this example we add 4 to the existing 4 just like the list
            //Capacity would be that number 4 which could be changed
        }
    }
}