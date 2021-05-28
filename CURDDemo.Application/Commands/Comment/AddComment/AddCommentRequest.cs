using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CURDDemo.Application.Commands.Comment.AddComment
{
    public class AddCommentRequest : IRequest<int>
    {
        public int ArticleId { get; set; }
        public string Comment { get; set; }
    }
}
