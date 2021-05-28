using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace CURDDemo.Application.Commands.Article.DeleteArticle
{
    public class ValidateDeleteArticleRequest : AbstractValidator<DeleteArticleRequest>
    {
        public ValidateDeleteArticleRequest()
        {
            RuleFor(cur => cur.Id)
                .NotEqual(0).WithMessage("Article Id is required.");
        }
    }
}
