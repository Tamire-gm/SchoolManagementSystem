using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace simple_rest_api
{
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private IRepository _repository;

        public ArticlesController(IRepository repository)
        {
            // Console.WriteLine("Sample debug output");
            _repository = repository;
        }
        // POST api/<ArticlesController>
        [HttpPost]
        [Route("/api/articles")]
        public Guid Post(Article value)
        {
            return _repository.Create(value);
        }

        // DELETE api/<ArticlesController>/
        [HttpDelete("/api/articles/{id}")]

        public bool Delete(Guid id)
        {
            return _repository.Delete(id);
        }
        // PUT api/<ArticlesController>
        [HttpPut("/api/articles/{id}")]
        public bool Put(Article articlUpdate)
        {
            return _repository.Update(articlUpdate);
        }
        // GET: api/<ArticlesController>
        [HttpGet("/api/articles/{id}")]
        public Article GetArticle(Guid id)
        {
            return _repository.Get(id);
        }
    }
}


public interface IRepository
{
    // Returns a found article or null.    
    Article Get(Guid id);
    // Creates a new article and returns its identifier.
    // Throws an exception if a article is null.
    // Throws an exception if a title is null or empty.
    Guid Create(Article article);
    // Returns true if an article was deleted or false if it was not possible to find it.
    bool Delete(Guid id);
    // Returns true if an article was updated or false if it was not possible to find it.
    // Throws an exception if an articleToUpdate is null.
    // Throws an exception or if a title is null or empty.
    bool Update(Article articleToUpdate);
}



public class Article
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
}

