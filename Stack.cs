using System;
using System.Collections;
using System.Collections.Generic;

namespace Desing_a_Stack
{
    public class Stack
    {
        public List<object> stack = new List<object>();


        // This method stores the given object on top of the stack
        public void Push(object obj)
        {
            if (obj != null) // if the object is not null
            {
                stack.Add(obj); // the object will be added to the stack
            }
            else
            {
                throw new InvalidOperationException("The object can't be null!"); // or an exception will be throwed because the object can't be null
            }
        }


        // This method takes the object on top of the stack and returns it 
        public void Pop()
        {
            
            stack.Reverse(); // revert the order of objects in the stack

            foreach (var item in stack)
            {
                Console.WriteLine(item); // shows all items in stack
            }

            
        }

        
        // This method removes all objects from the stack
        void Clear()
        {
            stack.Clear();
        }
    }
}
