using System;
using System.Collections.Generic;
using System.Text;
using CURDDemo.Application.Contracts.Persistence.Repositories;
using CURDDemo.Domain.Models;

namespace CURDDemo.Infrastructure.Persistence.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(DemoDbContext demoDbContext) : base(demoDbContext)
        {

        }
    }
}
