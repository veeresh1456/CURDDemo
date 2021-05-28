using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CURDDemo.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace CURDDemo.Application.Commands.Comment.EditComment
{
    public class HandleEditCommentRequest : IRequestHandler<EditCommentRequest, bool>
    {
        private ICommentRepository _commentRepository;
        private IArticleRepository _articleRepository;

        public HandleEditCommentRequest(ICommentRepository commentRepository,
            IArticleRepository articleRepository)
        {
            _commentRepository = commentRepository;
            _articleRepository = articleRepository;
        }

        public async Task<bool> Handle(EditCommentRequest request, CancellationToken cancellationToken)
        {
            var article = await _articleRepository.GetAsync(request.ArticleId);

            if (article == null)
                throw new Exception("Invalid Article Id.");

            var comment = new Domain.Models.Comment(request.ArticleId, request.Comment);
            comment.Id = request.Id;

            await _commentRepository.UpdateAsync(comment);

            return true;
        }
    }

}
