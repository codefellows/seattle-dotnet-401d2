using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Class18Demo.Models
{
    public class Playlist
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }

    }
}
