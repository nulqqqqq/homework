using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project
{
    public class ExchangeRate
    {
        public Currencies a = new Currencies();
        public string firstCurrency;
        public string secondCurrency;
        public float value;
        public int currencyCount = 1;

        public override string ToString()
        {
            return $"{currencyCount.ToString("F2")} {firstCurrency} = {value.ToString("F2")}";
        }

        public ExchangeRate(Currencies fCurrencies,Currencies sCurrencies)
        {
            
            
        }
        
        public ExchangeRate(Currencies fCurrencies, Currencies sCurrencies, float value):this(fCurrencies, sCurrencies)
        {
            
        }
        
    }
}
