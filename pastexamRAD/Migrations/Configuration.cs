namespace pastexamRAD.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using models;

    internal sealed class Configuration : DbMigrationsConfiguration<pastexamRAD.models.dbcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(pastexamRAD.models.dbcontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Customers.AddOrUpdate(new Customer[]
            {
              new Customer
              {
                  ID =1, Name = "Customer 1", Address = "Address for Customer 1"
              },
              new Customer
              {
                  ID =2, Name = "Customer 2", Address = "Address for Customer 2"
              },
              new Customer
              {
                  ID =3, Name = "Customer 3", Address = "Address for Customer 3"
              }

            });
            context.SaveChanges();


            context.AccountTypes.AddOrUpdate(new AccountType[]
            {

               new AccountType
               {
                   ID = 1, TypeName = "Current", Conditions = "current Account terms and cnditions apply"
               },
                new AccountType
               {
                   ID = 2, TypeName = "savings", Conditions = "savings Account terms and cnditions apply"
               },
                 new AccountType
               {
                   ID = 3, TypeName = "Deposit", Conditions = "deposit Account terms and cnditions apply"
               }

            });
            context.SaveChanges();


 
            context.Accounts.AddOrUpdate(new Account[]
           {
             
                new Account
                {
                    ID = 1 ,
                    AccountName = "Current 1" ,
                    InceptionDate = DateTime.Now,
                    CustomerID =  1,
                    CurrentBalance =  0f,
                    AccountTypeID = 1,
                },


                //new Account
                //{
                //    ID = 2 , AccountName = "Current 2" , InceptionDate = DateTime.Parse("31/10/2004"),
                //    CustomerID = 1,CurrentBalance =  20000f, AccountTypeID = 1
                //},


           });
            context.SaveChanges();

            //  context.Transactions.AddOrUpdate(new Transaction[]
            //{
            //    new Transaction
            //    {
            //        ID = 1 ,TransactionType = Transaction.TransactionTypeSource.Lodgement , 
            //        Amount = 300f, TransactionDate = DateTime.Now,AccountID = 1
            //    },
            //    new Transaction
            //    {
            //        ID = 2 ,TransactionType = Transaction.TransactionTypeSource.Widthdrawal ,
            //        Amount = 500f, TransactionDate = DateTime.Now,AccountID = 1
            //    }


            //});
            //  context.SaveChanges();
        }
    }
}
