using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Mean.io.netWebAPI.Models;
using Mean.io.Interfaces;
using Mean.io.DataServices;

namespace Mean.io.netWebAPI.Controllers
{
    public class ArticlesController : ApiController
    {


    

        IDataService MyDataservice = new DataServices.MongoDB.MongoDBDataService();




        public IEnumerable<IArticle> GetAllProducts()
        {
            return MyDataservice.GetAllArticles();
        }

        public IHttpActionResult GetArticle(int id)
        {
            var article = MyDataservice.GetArticle(id);//  articles.FirstOrDefault((p) => p._id == id);
            if (article == null)
            {
                return NotFound();
            }
            return Ok(article);
        }
    }

}

