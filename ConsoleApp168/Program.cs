using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp168
{
    class Program
    {
        static void Main(string[] args)
        {
            object objectValue = "hello";
            var stringValue = "good bye";
            char[] characterArray = { 'a', 'b', 'c', 'd', 'e', 'f' };
            var booleanValue = true;
            var characterValue = 'k';
            var integerValue = 7;
            var longValue = 1000000L;
            var floatValue = 2.5F;
            var doubleValue = 33.333;
            var buffer = new StringBuilder();

            buffer.Insert(0, objectValue);
            buffer.Insert(0, " ");
            buffer.Insert(0, stringValue);
            buffer.Insert(0, " ");
            buffer.Insert(0, characterArray);
            buffer.Insert(0, " ");
            buffer.Insert(0, booleanValue);
            buffer.Insert(0, " ");
            buffer.Insert(0, characterValue);
            buffer.Insert(0, " ");
            buffer.Insert(0, integerValue);
            buffer.Insert(0, " ");
            buffer.Insert(0, longValue);
            buffer.Insert(0, " ");
            buffer.Insert(0, floatValue);
            buffer.Insert(0, " ");
            buffer.Insert(0, doubleValue);
            buffer.Insert(0, " ");

            Console.WriteLine($"buffer after Inserts:\n{buffer}\n");

            buffer.Remove(10, 1);
            buffer.Remove(4, 4);

            Console.WriteLine($"buffer after Removes:\n{buffer}\n");

            Console.ReadLine();

         

        }
    }
}
