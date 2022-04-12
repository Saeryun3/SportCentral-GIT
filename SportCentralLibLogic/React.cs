using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralLibLogic
{
    public class React
    {
        public string Text { get; private set; }
        public DateTime DateTime { get; private set; }
        public bool Rating { get; private set; }

        public React(string text, DateTime date, bool rating)
        {
            Text = text;
            DateTime = date;
            Rating = rating;
        }
    }
}
