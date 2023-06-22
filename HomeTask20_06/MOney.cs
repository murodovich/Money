using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask20_06
{
    public class MOney
    {
        public delegate decimal CurrencyConversion(decimal amount);

        public class CurrencyConverter
        {
            private Dictionary<string, decimal> rates;

            public CurrencyConverter()
            {
                // Valyuta kurslari:
                rates = new Dictionary<string, decimal>()
            {
                {"EUR", 0.000083m}, // Misol uchun, 1 UZS = 0.000083 EUR
                {"USD", 0.000087m},  // Misol uchun, 1 UZS = 0.000087 USD
                {"RUB", 0.009m},   // Misol uchun, 1 UZS = 0.009 RUB
                {"GBP", 0.000071m}, // Misol uchun, 1 UZS = 0.000071 GBP
                {"CHF", 0.000082m}, // Misol uchun, 1 UZS = 0.000082 CHF
                {"JPY", 0.014m}, // Misol uchun, 1 UZS = 0.014 JPY
                {"KZT", 0.067m} // Misol uchun, 1 UZS = 0.067 KZT
                

            };
            }

            public CurrencyConversion GetConversion(string currency)
            {
                if (rates.ContainsKey(currency))
                    return natija => natija * rates[currency];
                else
                    throw new ArgumentException($"konvertatsiya darajasi mavjud emas {currency}");
            }
        }

        
    }

}
