using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week7Demo.Models.Interfaces;

namespace Week7Demo.Models
{
    public class ArticleService : IArticleService
    {
        private readonly Week7DemoContext _context;

        public ArticleService(Week7DemoContext context)
        {
            _context = context;
        }
        public List<Page> GetTopArticles(int number)
        {
            var articleList = _context.Page.ToList();
           
            return articleList;
        }
    }
}
