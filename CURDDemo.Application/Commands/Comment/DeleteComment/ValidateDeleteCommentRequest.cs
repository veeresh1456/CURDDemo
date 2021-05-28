using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace CURDDemo.Application.Commands.Comment.DeleteComment
{
    public class ValidateDeleteCommentRequest : AbstractValidator<DeleteCommentRequest>
    {
        public ValidateDeleteCommentRequest()
        {
            RuleFor(cur => cur.Id)
                .NotEqual(0).WithMessage("Article comment id is required.");
        }
    }
}
