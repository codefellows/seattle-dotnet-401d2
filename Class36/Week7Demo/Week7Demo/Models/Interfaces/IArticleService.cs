using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week7Demo.Models.Interfaces
{
    public interface IArticleService
    {
        List<Page> GetTopArticles(int number);
    }
}
