using System;
using System.Collections.Generic;
using System.Text;

namespace CURDDemo.Application.Commands.Article.GetAllArticles
{
    public class GetAllArticlesResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
