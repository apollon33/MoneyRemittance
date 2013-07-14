namespace MoneyRemittance.data.Migrations
{
    using MoneyRemittance.model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebMatrix.WebData;

    internal sealed class Configuration : DbMigrationsConfiguration<MoneyRemittance.data.Infrastructure.MoneyRemittanceDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MoneyRemittance.data.Infrastructure.MoneyRemittanceDb context)
        {
            //if (!WebSecurity.Initialized)
            //{
            //    WebSecurity.InitializeDatabaseConnection("MoneyRemitConnDb", "UserProfile", "UserId", "UserName", autoCreateTables: true);
            //}

            context.Customers.AddOrUpdate(c => c.CustEmail,
                    new Customer() { CustLName = "Dela Cruz", CustFName = "John", CustEmail = "john@yahoo.com", CustAddress = "Macroville Park", CustCountry = "Philippines", CustGender = "Male", CustLocation = "Cebu City", IAgree = true },
                    new Customer() { CustLName = "Pedro", CustFName = "Juan", CustEmail = "juan@gmail.com", CustAddress = "KISAN LU, Iponan", CustCountry = "Philippines", CustGender = "Male", CustLocation = "Cagayan de Oro City", IAgree = true },
                    new Customer() { CustLName = "Estrada", CustFName = "Missy", CustEmail = "missy@hotmail.com", CustAddress = "Tibanga, Hi-way", CustCountry = "Philippines", CustGender = "Female", CustLocation = "Iligan City", IAgree = true },
                    new Customer() { CustLName = "Giganto", CustFName = "Rey", CustEmail = "rey@operamail.com", CustAddress = "101 Ferndale Street", CustCountry = "New Zealand", CustGender = "Male", CustLocation = "Christ Church", IAgree = true }
                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
