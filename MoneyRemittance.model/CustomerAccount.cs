using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MoneyRemittance.model
{
    public class CustomerAccount
    {
        /// <summary>
        /// Customer Account model describe each registered account by an online customer.
        /// </summary>

        [ScaffoldColumn(false)]
        public virtual int CustomerAccountId { get; set; }

        [StringLength(50)]
        public virtual string CustAccountNo { get; set; }

        [StringLength(25)]
        public virtual string CustPassword { get; set; }

        public virtual int CustomerId { get; set; }
    }
}
