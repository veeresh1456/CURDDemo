using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CURDDemo.Application.Commands.Article.EditArticle
{
    public class EditArticleRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Domain.Models.Article ToArticle()
        {
            var article = new Domain.Models.Article(Name, Content);
            article.Id = Id;
            article.Image = Image;
            article.Author = Author;
            article.Description = Description;
            return article;
        }
    }
}

