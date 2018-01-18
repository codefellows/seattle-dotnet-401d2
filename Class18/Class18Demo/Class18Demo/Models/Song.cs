using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Class18Demo.Models
{
    public class Song
    {

        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Artist { get; set; }
        [Required]
        public string Album { get; set; }
       
        public int PlaylistID { get; set; }
    }
}
