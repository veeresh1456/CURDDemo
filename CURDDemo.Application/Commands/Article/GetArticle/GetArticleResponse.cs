using System;
using System.Collections.Generic;
using System.Text;

namespace CURDDemo.Application.Commands.Article.GetArticle
{
    public class GetArticleResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public static GetArticleResponse ArticleToResponse(Domain.Models.Article article)
        {
            return new GetArticleResponse()
            {
                Id = article.Id,
                Name = article.Name,
                Content = article.Content,
                Author = article.Author,
                Description = article.Description,
                Image = article.Image
            };
        }
    }
}
