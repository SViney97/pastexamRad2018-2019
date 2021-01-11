using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pastexamRAD.models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string AccountName { get; set; }

        public DateTime InceptionDate { get; set; }

       // [ForeignKey("CustomersID")]
       public int CustomerID { get; set; }

        public float CurrentBalance { get; set; }

        public int AccountTypeID { get; set; }

       //public virtual Customer CustomersID { get; set; }
    }
}
