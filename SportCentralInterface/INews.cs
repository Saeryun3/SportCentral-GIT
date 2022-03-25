using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralInterface
{
    public interface INews
    {
        void Addnews(NewsDTO news);
        void UpdateNews(NewsDTO news);        
    }
}
