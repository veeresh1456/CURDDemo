using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CURDDemo.Application.Commands.Article.GetArticle
{
    public class GetArticleRequest : IRequest<GetArticleResponse>
    {
        public GetArticleRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
