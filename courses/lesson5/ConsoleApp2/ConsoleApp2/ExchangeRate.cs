using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project
{
    public class ExchangeRate
    {
        public string firstCurrency;
        public string secondCurrency;
        public float value { get; set; }
        public int currencyCount { get; set; } = 1;

        public override string ToString()
        {
            return $"{currencyCount.ToString("F2")} {firstCurrency} = {value.ToString("F2")}";
        }

        public ExchangeRate(Currencies fCurrencies,Currencies sCurrencies)
        {
            this.firstCurrency = firstCurrency;
            this.secondCurrency = secondCurrency;
        }

        public ExchangeRate(Currencies fCurrencies, Currencies sCurrencies, float value) : this(fCurrencies,
            sCurrencies)
        {
            this.value = value;
        }
    }
}
