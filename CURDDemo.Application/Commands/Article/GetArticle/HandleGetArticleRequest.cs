using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CURDDemo.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace CURDDemo.Application.Commands.Article.GetArticle
{
    public class HandleGetArticleRequest : IRequestHandler<GetArticleRequest, GetArticleResponse>
    {
        private readonly IArticleRepository _articleRepository;

        public HandleGetArticleRequest(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<GetArticleResponse> Handle(GetArticleRequest request, CancellationToken cancellationToken)
        {
            return GetArticleResponse
                .ArticleToResponse(await _articleRepository.GetAsync(request.Id));
        }
    }
}
