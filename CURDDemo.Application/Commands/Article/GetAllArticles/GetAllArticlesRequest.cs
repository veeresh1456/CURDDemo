using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CURDDemo.Application.Commands.Article.GetAllArticles
{
    public class GetAllArticlesRequest : IRequest<List<GetAllArticlesResponse>>
    {

    }
}
