﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace DesignPatterns.Strategy
{
    internal interface IChangeCurrencyStrategy
    {
        string ChangeCurrency(double price);
    }
}
