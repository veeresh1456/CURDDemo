using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace CURDDemo.Application.Commands.Article.GetArticle
{
    public class ValidateGetArticleRequest : AbstractValidator<GetArticleRequest>
    {
        public ValidateGetArticleRequest()
        {
            RuleFor(cur => cur.Id)
                .NotEqual(0).WithMessage("Article Id is required.");
        }
    }
}
