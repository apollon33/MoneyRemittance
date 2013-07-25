using MoneyRemittance.model;
using MoneyRemittance.model.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace MoneyRemittance.data.Infrastructure
{
    public class MoneyRemittanceDb: DbContext, ICustomerDataSource
    {
        public MoneyRemittanceDb()
            : base("MoneyRemitConnDb")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<Inquiry> Inquiries { get; set; }
        public DbSet<ExchangeRates> Rates { get; set; }

        IQueryable<Customer> ICustomerDataSource.Customers
        {
            get { return Customers; }
        }

        IQueryable<Recipient> ICustomerDataSource.Recipients
        {
            get { return Recipients; }
        }

        IQueryable<CustomerAccount> ICustomerDataSource.CustomerAccounts
        {
            get { return CustomerAccounts; }
        }

        IQueryable<Inquiry> ICustomerDataSource.CustomerInquiries
        {
            get { return Inquiries; }
        }

        IQueryable<ExchangeRates> ICustomerDataSource.MoneyRates
        {
            get { return Rates; }
        }

        void ICustomerDataSource.Save()
        {
            SaveChanges();
        }
    }
}
