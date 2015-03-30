using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Mean.io.netWebAPI.Models;


namespace Mean.io.netWebAPI.Controllers
{
    public class ArticlesController : ApiController
    {

        Article[] articles = new Article[]
       {
            new Article { _id = 1, username = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Article { _id = 2, username = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Article { _id = 3, username = "Hammer", Category = "Hardware", Price = 16.99M }
       };

        public IEnumerable<Article> GetAllProducts()
        {
            return articles;
        }

        public IHttpActionResult GetArticle(int id)
        {
            var article = articles.FirstOrDefault((p) => p._id == id);
            if (article == null)
            {
                return NotFound();
            }
            return Ok(article);
        }
    }

}

