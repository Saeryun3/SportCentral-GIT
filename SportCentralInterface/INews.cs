using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralInterface
{
    public interface INews
    {
        bool CreateNews(NewsDTO newsDTO);
        void UpdateNews(NewsDTO newsDTO);
        List<NewsDTO> GetAllNews();
        List<NewsDTO> GetAllNewsByCategory(string name);
        NewsDTO GetNewsByID(int ID);
        void DeleteNews(int newsID);
    }
}
