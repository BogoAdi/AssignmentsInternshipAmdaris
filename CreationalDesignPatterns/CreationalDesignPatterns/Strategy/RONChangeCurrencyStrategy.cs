using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DesignPatterns.Strategy
{
    public class RONChangeCurrencyStrategy : IChangeCurrencyStrategy
    {
        public string ChangeCurrency(double price)
        {
            CultureInfo ro = CultureInfo.GetCultureInfo("ro-RO");
            return (1 * price).ToString("C", ro);
        }   
    }
}
