using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace CURDDemo.Application.Commands.Comment.EditComment
{
    public class ValidateEditCommentRequest : AbstractValidator<EditCommentRequest>
    {
        public ValidateEditCommentRequest()
        {
            RuleFor(cur => cur.ArticleId)
                .NotEqual(0).WithMessage("Article Id is required.");

            RuleFor(cur => cur.Id)
                .NotEqual(0).WithMessage("Article comment id is required.");

            RuleFor(cur => cur.Comment)
                .NotEmpty().WithMessage("Comment is required.")
                .MinimumLength(10).WithMessage("Article comment must be minimum 10 char.");
        }
    }
}
