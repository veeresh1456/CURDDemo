using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace CURDDemo.Application.Commands.Comment.AddComment
{
    public class ValidateAddCommentRequest : AbstractValidator<AddCommentRequest>
    {
        public ValidateAddCommentRequest()
        {
            RuleFor(cur => cur.ArticleId)
                .NotEqual(0).WithMessage("Article Id is required.");

            RuleFor(cur => cur.Comment)
                .NotEmpty().WithMessage("Comment is required.")
                .MinimumLength(10).WithMessage("Article comment must be minimum 10 char.");
        }
    }
}
