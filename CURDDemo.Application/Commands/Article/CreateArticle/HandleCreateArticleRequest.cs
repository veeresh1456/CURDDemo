using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CURDDemo.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace CURDDemo.Application.Commands.Article.CreateArticle
{
    public class HandleCreateArticleRequest : IRequestHandler<CreateArticleRequest, int>
    {
        private readonly IArticleRepository _articleRepository;

        public HandleCreateArticleRequest(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<int> Handle(CreateArticleRequest request, CancellationToken cancellationToken)
        {
            var entity = request.ToArticle();

            await _articleRepository.AddAsync(entity);

            return entity.Id;
        }
    }

}
