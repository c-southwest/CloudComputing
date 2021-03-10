using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CloudComputing.Model
{

    [Table("template")]
    public class Template
    {
        [Key]
        [Column("name")]
        public string name { get; set; }
        [Column("path")]
        public string path { get; set; }
        [Column("password")]
        public string password { get; set; }
    }
}
