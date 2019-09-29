﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataTypes.BasicTypes
{
    public class ListOfStrings<T>  where T : IList<StringElement>
    {
        protected IList<StringElement> list;

        public ListOfStrings(T initList)
        {
            list = initList;
        }

        public ListOfStrings()
        {
            list = new List<StringElement>();
        }
    }
}
