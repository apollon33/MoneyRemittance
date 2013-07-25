using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MoneyRemittance.model
{
    public class ExchangeRates
    {
        /// <summary>
        /// Defines the exchange rates of currency value
        /// </summary>

        [ScaffoldColumn(false)]
        public virtual int ExchangeRatesId { get; set; }

        public virtual string FromCurrency { get; set; }
        public virtual string ToCurrency { get; set; }
        public virtual double FromRate { get; set; }
        public virtual double ToRate { get; set; }
    }
}
