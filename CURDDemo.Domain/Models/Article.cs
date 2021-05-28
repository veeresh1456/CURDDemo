using System;
using System.Collections.Generic;
using System.Text;

namespace CURDDemo.Domain.Models
{
    public class Article : Entity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public readonly List<Comment> Comments;

        public Article(string name, string content)
        {
            Name = name;
            Content = content;

            Comments = new List<Comment>();
        }
    }
}
