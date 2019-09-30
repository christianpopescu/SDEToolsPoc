using System;
using System.Collections;
using System.Collections.Generic;
using AbstractDataTypes.BasicTypes;
namespace AbstractDataTypesDev
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBasicTypes();
            TestListOfStrings();

            Console.ReadKey();

            void TestBasicTypes()
            {
                IntegerElement i = 10;

                StringElement st = "Toto";
                List<IElement> lae = new List<IElement>();
                lae.Add((IntegerElement) 20);
                lae.Add((StringElement) "fly");


                Console.WriteLine("{0} {1}", i, st);

                foreach (IElement x in lae) Console.WriteLine(x);
            }

            void TestListOfStrings()
            {
                RowOfStringsElements<List<StringElement>> lst = new RowOfStringsElements<List<StringElement>>(new List<StringElement> {"alpha", "beta", "gamma"});

                IReadOnlyList< StringElement > aList = lst.GetList();
                foreach (var se in aList) Console.WriteLine(se.Value);
                
            }
        }
    }
}
