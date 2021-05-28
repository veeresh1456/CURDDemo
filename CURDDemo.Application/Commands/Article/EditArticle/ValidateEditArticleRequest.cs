using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace CURDDemo.Application.Commands.Article.EditArticle
{
    public class ValidateEditArticleRequest : AbstractValidator<EditArticleRequest>
    {
        public ValidateEditArticleRequest()
        {
            RuleFor(cur => cur.Id)
                .NotEqual(0).WithMessage("Article Id is required.");

            RuleFor(cur => cur.Name)
                .NotEmpty().WithMessage("Article Name is required.")
                .MinimumLength(50).WithMessage("Article Name must be minimum 50 char.");

            RuleFor(cur => cur.Content)
                .NotEmpty().WithMessage("Article Content is required.")
                .MinimumLength(100).WithMessage("Article Content must be minimum 100 char.");
        }
    }
}
