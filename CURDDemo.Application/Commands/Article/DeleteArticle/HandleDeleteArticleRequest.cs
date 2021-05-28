using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CURDDemo.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace CURDDemo.Application.Commands.Article.DeleteArticle
{
    public class HandleDeleteArticleRequest : IRequestHandler<DeleteArticleRequest, bool>
    {
        private readonly IArticleRepository _articleRepository;

        public HandleDeleteArticleRequest(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<bool> Handle(DeleteArticleRequest request, CancellationToken cancellationToken)
        {
            await _articleRepository.RemoveAsync(request.Id);

            return true;
        }
    }
}
