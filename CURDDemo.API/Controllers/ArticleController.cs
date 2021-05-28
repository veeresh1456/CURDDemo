using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CURDDemo.Application.Commands.Article.CreateArticle;
using CURDDemo.Application.Commands.Article.DeleteArticle;
using CURDDemo.Application.Commands.Article.EditArticle;
using CURDDemo.Application.Commands.Article.GetAllArticles;
using CURDDemo.Application.Commands.Article.GetArticle;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CURDDemo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ArticleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<GetAllArticlesResponse>> Get()
        {
            return await _mediator.Send(new GetAllArticlesRequest());
        }

        [HttpGet("{id:int}")]
        public async Task<GetArticleResponse> Get(int id)
        {
            return await _mediator.Send(new GetArticleRequest(id));
        }

        [HttpPost]
        public async Task<int> Post(CreateArticleRequest createArticleRequest)
        {
            return await _mediator.Send(createArticleRequest);
        }

        [HttpPut]
        public async Task<bool> Put(EditArticleRequest editArticleRequest)
        {
            return await _mediator.Send(editArticleRequest);
        }

        [HttpDelete("{id:int}")]
        public async Task<bool> Delete(int id)
        {
            return await _mediator.Send(new DeleteArticleRequest(id));
        }

    }
}
