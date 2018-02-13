using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week7Demo.Models.Interfaces;

namespace Week7Demo.Components
{
    public class TopArticles : ViewComponent
    {
        private readonly IArticleService _articleService;
        public TopArticles(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int number)
        {
            var articles = _articleService.GetTopArticles(number);
            return View(articles);
        }


    }
}
