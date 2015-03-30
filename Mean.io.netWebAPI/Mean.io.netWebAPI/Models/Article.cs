using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mean.io.netWebAPI.Models
{
    public class Article : IArticle
    {

        public int _id { get; set; }
        public string username { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}