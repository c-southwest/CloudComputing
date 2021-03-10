using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CloudComputing.Model
{
    [Table("server")]
    public class Server
    {
        [Column("username")]
        public string username { get; set; }

        [Column("servername")]
        public string servername { get; set; }

        [Column("serverid")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int serverid { get; set; }

        [Column("os")]
        public string os { get; set; }

        [Column("ip")]
        public string ip { get; set; }

        [Column("cpu")]
        public int cpu { get; set; }

        [Column("memory")]
        public float memory { get; set; }

        [Column("bandwidth")]
        public int bandwidth { get; set; }

        [Column("switchname")]
        public string switchname { get; set; }

        [Column("state")]
        public string state { get; set; }

        [Column("disk")]
        public int disk { get; set; }

        [Column("expire")]
        public DateTime expire { get; set; }

    }
}
