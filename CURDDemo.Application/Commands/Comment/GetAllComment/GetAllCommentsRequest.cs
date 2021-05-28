using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CURDDemo.Application.Commands.Comment.GetAllComment
{
    public class GetAllCommentsRequest : IRequest<List<GetAllCommentsResponse>>
    {
        public GetAllCommentsRequest(int articleId)
        {
            ArticleId = articleId;
        }
        public int ArticleId { get; set; }
    }
}
