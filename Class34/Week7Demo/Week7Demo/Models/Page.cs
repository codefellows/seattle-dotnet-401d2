using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week7Demo.Models
{
    public class Page
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool IsPublished { get; set; }
    }
}
