using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MoneyRemittance.model
{
    public class Bank
    {
        [ScaffoldColumn(false)]
        public virtual int BankId { get; set; }

        public virtual string BankName { get; set; }
        public virtual string BankCountry { get; set; }
        public virtual string BankAddress { get; set; }
        public virtual string BankBranch { get; set; }
        public virtual string BankAccount { get; set; }
        public virtual string ContactPerson { get; set; }
    }
}
