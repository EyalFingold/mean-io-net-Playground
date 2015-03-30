using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mean.io.Interfaces;

namespace Mean.io.netWebAPI.Models
{
    public class Article : IArticle
    {

        public int _id { get; set; }
        public IUser user { get; set; }
        public string title { get; set; }

        public string content { get; set; }

        public DateTime created { get; set; }

    }
}