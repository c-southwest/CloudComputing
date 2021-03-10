using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CloudComputing.Model
{
    [Table("switch")]
    public class Switch
    {
        [Key]
        [Column("name")]
        public string name { get; set; }

        [Column("virtualswitch")]
        public string virtualswitch { get; set; }
    }
}
