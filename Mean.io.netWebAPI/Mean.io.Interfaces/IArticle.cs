using System;

namespace Mean.io.Interfaces
{
    public interface IArticle
    {
         int _id { get; set; }
         IUser user { get; set; }
         string title { get; set; }

         string content { get; set; }

         DateTime created { get; set; }
    }
}