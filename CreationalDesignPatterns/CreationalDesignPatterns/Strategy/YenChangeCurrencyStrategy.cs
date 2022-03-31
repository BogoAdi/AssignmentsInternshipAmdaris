using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace DesignPatterns.Strategy
{
    public class YenChangeCurrencyStrategy : IChangeCurrencyStrategy
    {
        public string ChangeCurrency(double price)
        {
            CultureInfo jp = CultureInfo.GetCultureInfo("jp-JP");            
            return (27.46 * price).ToString("C", jp);
        }
    }
}
