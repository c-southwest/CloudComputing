using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudComputing.Model
{
    public class CreateServerModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "Server name is too long.")]
        public string servername { get; set; }

        [Required]
        public string os { get; set; }

        [Required]
        public int memory { get; set; }

        [Required]
        public int bandwidth { get; set; }

        [Required]
        public string switchname { get; set; }

        [Required]
        public int cpu { get; set; }

        [Required]
        public int disk { get; set; }
    }
}
