using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralLibLogic
{
    public class ReactContainer
    {
        private List<React> _reacts;

        public void AddReact(React react)
        {
            _reacts.Add(react);
        }

        public bool Rate(React react)
        {
            return true;
        }
    }
}
