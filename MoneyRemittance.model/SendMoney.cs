using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyRemittance.model
{
    public class SendMoney
    {
        public int TransactionId { get; set; }
        public int RecipientId { get; set; }
        public int CustomerId { get; set; }
    }
}
