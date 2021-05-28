using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CURDDemo.Application.Commands.Comment.DeleteComment
{
    public class DeleteCommentRequest : IRequest<bool>
    {
        public DeleteCommentRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
