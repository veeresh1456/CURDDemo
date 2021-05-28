using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace CURDDemo.Application.Commands.Comment.GetAllComment
{
    public class ValidateGetAllCommentsRequest : AbstractValidator<GetAllCommentsRequest>
    {
        public ValidateGetAllCommentsRequest()
        {
            RuleFor(cur => cur.ArticleId)
                .NotEqual(0).WithMessage("Article Id is required.");
        }
    }
}
