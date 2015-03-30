using System;
using System.Collections.Generic;


namespace Mean.io.Interfaces
{
    public interface IDataService
    {
        IEnumerable<IArticle> GetAllArticles();
        IArticle GetArticle(int id);
    }
}
