using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudComputing.Model
{
    
    [Table("application")]
    public class Application
    {
        [Column("username")]
        public string username { get; set; }

        [Column("appname")]
        public string appname { get; set; }

        [Column("appid")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int appid { get; set; }

        [Column("image")]
        public string image { get; set; }

        [Column("ip")]
        public string ip { get; set; }

        [Column("replicas")]
        public int replicas { get; set; }
        [Column("port")]
        public int port { get; set; }
        [Column("targetport")]
        public int targetport { get; set; }

        [Column("readyReplicas")]
        public int readyReplicas { get; set; }

        [Column("expire")]
        public DateTime expire { get; set; }

    }
}
