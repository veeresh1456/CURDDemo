using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CURDDemo.Application.Commands.Article.DeleteArticle
{
    public class DeleteArticleRequest : IRequest<bool>
    {
        public DeleteArticleRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
