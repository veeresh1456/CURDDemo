using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CURDDemo.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace CURDDemo.Application.Commands.Comment.DeleteComment
{
    public class HandleDeleteCommentRequest : IRequestHandler<DeleteCommentRequest, bool>
    {
        private ICommentRepository _commentRepository;

        public HandleDeleteCommentRequest(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<bool> Handle(DeleteCommentRequest request, CancellationToken cancellationToken)
        {
            await _commentRepository.RemoveAsync(request.Id);

            return true;
        }
    }
}
