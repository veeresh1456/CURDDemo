using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CURDDemo.Application.Commands.Comment.AddComment;
using CURDDemo.Application.Commands.Comment.DeleteComment;
using CURDDemo.Application.Commands.Comment.EditComment;
using CURDDemo.Application.Commands.Comment.GetAllComment;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CURDDemo.API.Controllers
{
    [ApiController]
    [Route("api/article/{articleId:int}/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<GetAllCommentsResponse>> Get(int articleId)
        {
            return await _mediator.Send(new GetAllCommentsRequest(articleId));
        }


        [HttpPost]
        public async Task<int> Post(int articleId, AddCommentRequest addCommentRequest)
        {
            addCommentRequest.ArticleId = articleId;
            return await _mediator.Send(addCommentRequest);
        }

        [HttpPut]
        public async Task<bool> Put(int articleId, EditCommentRequest editCommentRequest)
        {
            editCommentRequest.ArticleId = articleId;
            return await _mediator.Send(editCommentRequest);
        }

        [HttpDelete("{id:int}")]
        public async Task<bool> Delete(int articleId, int id)
        {
            return await _mediator.Send(new DeleteCommentRequest(id));
        }

    }
}
