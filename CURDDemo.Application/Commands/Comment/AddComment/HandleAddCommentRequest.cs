using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CURDDemo.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace CURDDemo.Application.Commands.Comment.AddComment
{
    public class HandleAddCommentRequest : IRequestHandler<AddCommentRequest, int>
    {
        private ICommentRepository _commentRepository;
        private IArticleRepository _articleRepository;

        public HandleAddCommentRequest(ICommentRepository commentRepository,
            IArticleRepository articleRepository)
        {
            _commentRepository = commentRepository;
            _articleRepository = articleRepository;
        }

        public async Task<int> Handle(AddCommentRequest request, CancellationToken cancellationToken)
        {
            var article = await _articleRepository.GetAsync(request.ArticleId);

            if (article == null)
                throw new Exception("Invalid Article Id.");

            var comment = new Domain.Models.Comment(request.ArticleId, request.Comment);

            await _commentRepository.AddAsync(comment);

            return comment.Id;
        }
    }

}
