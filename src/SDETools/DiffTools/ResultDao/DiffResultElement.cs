﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffTools
{
    public class DiffResultElement<T>
    { 
        DiffElement<T> First;
        DiffElement<T> Second;
    }
}