using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DesignPatterns.Strategy 
{
    public class PoundChangeCurrencyStrategy : IChangeCurrencyStrategy
    {
        public string ChangeCurrency(double price)
        {

            CultureInfo gb = CultureInfo.GetCultureInfo("gb-GB");
            return (0.17 * price).ToString("C", gb);
        }
    }
}
