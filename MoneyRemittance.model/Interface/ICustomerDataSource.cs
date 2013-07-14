using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyRemittance.model.Interface
{
    public interface ICustomerDataSource
    {
        IQueryable<Customer> Customers { get; }
        IQueryable<Recipient> Recipients { get; }
        IQueryable<CustomerAccount> CustomerAccounts { get; }
        void Save();
    }
}
