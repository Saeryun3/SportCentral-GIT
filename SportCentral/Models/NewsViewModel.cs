using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportCentral.Models
{
    public class NewsViewModel
    {
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Text { get; set; }
        public DateTime Datetime { get; set; }
        public int Rating { get; set; }
    }
}
