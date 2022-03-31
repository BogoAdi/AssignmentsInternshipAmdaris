using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DesignPatterns.Strategy
{
    public class USDollarChangeCurrencyStrategy : IChangeCurrencyStrategy
    {
        public string ChangeCurrency(double price)
        {
            CultureInfo us = CultureInfo.GetCultureInfo("us-US");
            return (0.22 * price).ToString("C", us);
        }
    }
}
