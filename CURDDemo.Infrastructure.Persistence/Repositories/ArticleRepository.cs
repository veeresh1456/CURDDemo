using System;
using System.Collections.Generic;
using System.Text;
using CURDDemo.Application.Contracts.Persistence.Repositories;
using CURDDemo.Domain.Models;

namespace CURDDemo.Infrastructure.Persistence.Repositories
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(DemoDbContext demoDbContext) : base(demoDbContext)
        {

        }
    }
}
