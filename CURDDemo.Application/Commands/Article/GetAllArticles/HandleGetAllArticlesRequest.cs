using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CURDDemo.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace CURDDemo.Application.Commands.Article.GetAllArticles
{
    public class HandleGetAllArticlesRequest : IRequestHandler<GetAllArticlesRequest, List<GetAllArticlesResponse>>
    {
        private readonly IArticleRepository _articleRepository;

        public HandleGetAllArticlesRequest(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<List<GetAllArticlesResponse>> Handle(GetAllArticlesRequest request, CancellationToken cancellationToken)
        {
            var articlesList = await _articleRepository.GetAllAsync();

            if (articlesList == null)
                return new List<GetAllArticlesResponse>();

            return articlesList.Select(x => new GetAllArticlesResponse()
            {
                Description = x.Description,
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
