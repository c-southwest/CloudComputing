using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudComputing.Model
{
    public class CreateAppModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "App name is too long.")]
        public string appname { get; set; }

        [Required]
        public string image { get; set; }

        [Required]
        public int replicas { get; set; }
        [Required]
        public int port { get; set; }
        [Required]
        public int targetport { get; set; }
    }
}
