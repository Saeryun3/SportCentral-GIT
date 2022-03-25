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
        public DateTime Date { get; private set; }
        public DateTime Time { get; private set; }
        public bool Rating { get; private set; }

        public React(string text, DateTime date, DateTime time, bool rating)
        {
            Text = text;
            Date = date;
            Time = time;
            Rating = rating;
        }
    }
}
