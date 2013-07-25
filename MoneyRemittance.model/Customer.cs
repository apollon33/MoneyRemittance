using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MoneyRemittance.model
{
    public class Customer
    {
        /// <summary>
        /// Defines the customer model of online money remittance.
        /// </summary>

        [ScaffoldColumn(false)]
        public virtual int CustomerId { get; set; }

        [StringLength(50)]
        public virtual string CustLName { get; set; }

        [StringLength(80)]
        public virtual string CustFName { get; set; }

        [StringLength(250)]
        public virtual string CustAddress { get; set; }

        [StringLength(80)]
        public virtual string CustLocation { get; set; } //This is the City property

        [StringLength(50)]
        public virtual string CustCountry { get; set; }

        [StringLength(20)]
        public virtual string CustGender { get; set; }

        [StringLength(80)]
        public virtual string CustEmail { get; set; }

        public virtual bool IAgree { get; set; }

        //public DateTime DateRegistered { get; set; }  

        public virtual ICollection<Recipient> CustomerRecipients { get; set; }
        public virtual ICollection<CustomerAccount> CustomerAccounts { get; set; }
    }
}
