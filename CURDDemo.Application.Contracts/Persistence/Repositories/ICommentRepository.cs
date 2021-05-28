using System;
using System.Collections.Generic;
using System.Text;
using CURDDemo.Domain.Models;

namespace CURDDemo.Application.Contracts.Persistence.Repositories
{
    public interface ICommentRepository : IRepository<Comment>
    {
    }
}
