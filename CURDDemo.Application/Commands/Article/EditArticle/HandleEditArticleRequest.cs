using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CURDDemo.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace CURDDemo.Application.Commands.Article.EditArticle
{
    public class HandleEditArticleRequest : IRequestHandler<EditArticleRequest, bool>
    {
        private readonly IArticleRepository _articleRepository;

        public HandleEditArticleRequest(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<bool> Handle(EditArticleRequest request, CancellationToken cancellationToken)
        {
            var entity = request.ToArticle();

            await _articleRepository.UpdateAsync(entity);

            return true;
        }
    }
}
