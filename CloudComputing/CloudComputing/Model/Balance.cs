using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CloudComputing.Model
{
    [Table("balance")]
    public class Balance
    {
        [Column("username")][Key][Required]
        public string username { get; set; }

        [Column("amount")][Required]
        public double amount { get; set; }
    }
}
