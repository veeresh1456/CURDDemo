using System;
using System.Collections.Generic;
using System.Text;

namespace CURDDemo.Domain.Models
{
    public class Comment : Entity
    {
        public int ArticleId { get; set; }
        public string Text { get; set; }

        public Comment(int articleId, string text)
        {
            ArticleId = articleId;
            Text = text;
        }
    }
}
