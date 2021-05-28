using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CURDDemo.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace CURDDemo.Application.Commands.Comment.GetAllComment
{
    public class HandleGetAllCommentsRequest : IRequestHandler<GetAllCommentsRequest, List<GetAllCommentsResponse>>
    {
        private ICommentRepository _commentRepository;
        private IArticleRepository _articleRepository;

        public HandleGetAllCommentsRequest(ICommentRepository commentRepository,
            IArticleRepository articleRepository)
        {
            _commentRepository = commentRepository;
            _articleRepository = articleRepository;
        }

        public async Task<List<GetAllCommentsResponse>> Handle(GetAllCommentsRequest request, CancellationToken cancellationToken)
        {
            var article = await _articleRepository.GetAsync(request.ArticleId);

            if (article == null)
                throw new Exception("Invalid Article Id.");

            var comments = await _commentRepository
                .FindAsync(c => c.ArticleId == request.ArticleId);

            if (comments == null)
                return new List<GetAllCommentsResponse>();

            return comments.Select(x => new GetAllCommentsResponse()
            {
                Comment = x.Text,
                Id = x.Id
            }).ToList();
        }
    }

}
