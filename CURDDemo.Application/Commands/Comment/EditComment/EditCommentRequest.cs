using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CURDDemo.Application.Commands.Comment.EditComment
{
    public class EditCommentRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Comment { get; set; }
    }
}
