using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CloudComputing.Model
{
    [Table("transaction")]
    public class Transaction
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("username")]
        public string username { get; set; }

        [Column("type")]
        public string type { get; set; }    //充值、购买

        [Column("amount")]
        public double amount { get; set; }

        [Column("time")]
        public DateTime time { get; set; }

        [Column("note")]
        public string note { get; set; }


    }
}
