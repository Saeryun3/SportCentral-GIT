using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralInterface
{
    public class NewsDTO
    {
        public int NewsID { get; set; }
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Text { get; set; }
        public DateTime Datetime { get; set; }
        public int Rating { get; set; }
    }
}
