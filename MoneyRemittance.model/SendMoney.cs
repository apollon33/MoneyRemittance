using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MoneyRemittance.model
{
    public class SendMoney
    {
        
        public virtual int TransactionId { get; set; }
        public virtual string ReceiveCode { get; set; }
        public virtual string PaymentCode { get; set; }
        public virtual string FromExchangeCurrCode { get; set; }
        public virtual string ToExchangeCurrCode { get; set; }

        public virtual int RecipientId { get; set; }
        public virtual int CustomerId { get; set; }
        public virtual int BankId { get; set; }

        public virtual double AmountToSend { get; set; }
        public virtual double ExchangeRate { get; set; }
        public virtual double ServiceFee { get; set; }
        public virtual double AmountToReceive { get; set; }


    }
}
