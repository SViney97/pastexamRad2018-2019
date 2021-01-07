using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pastexamRAD.models
{
    public class dbcontext: DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public dbcontext()
            : base("BankConnection")
        {
        }
        public static dbcontext Create()
        {
            return new dbcontext();
        }

    }
}
