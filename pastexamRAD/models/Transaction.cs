using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pastexamRAD.models
{
    public class Transaction
    {
        public int ID { get; set; }

        public enum TransactionTypeSource { Lodgement, Widthdrawal };

        public TransactionTypeSource TransactionType { get; set; } 

        public float Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        [ForeignKey("AccountsID")]
        public int AccountID { get; set; }

        public virtual Transaction AccountsID { get; set; }


        //enum TransactionType { Lodgement , Widthdrawal};
    }
}
