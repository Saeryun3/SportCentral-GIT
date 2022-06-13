using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralInterface
{
    public class CommentDTO
    {
        public int CommentID { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public bool Rating { get; set; }
        public int NewsID { get; set; }
    }
}
