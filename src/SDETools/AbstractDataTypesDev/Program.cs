using System;
using System.Collections.Generic;
using AbstractDataTypes.BasicTypes;
namespace AbstractDataTypesDev
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerElement i = 10;

            StringElement st = "Toto";
            List<IElement> lae = new List<IElement>();
            lae.Add((IntegerElement)20);
            lae.Add((StringElement)"fly");


            Console.WriteLine("{0} {1}", i , st);

            foreach (IElement x in lae) Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
