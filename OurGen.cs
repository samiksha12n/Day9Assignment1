using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Assignment1
{
    
    
       public class OurGen<T>
        {
            T myField;
            public OurGen(T param)
            {
                myField = param;
            }
            public void Display()
            {
                Console.WriteLine($"Value Stored : {myField} " + $"and DataType {myField.GetType()}");
            }
        }      
}
