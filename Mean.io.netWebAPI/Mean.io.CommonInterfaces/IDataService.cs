using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mean.io.CommonInterfaces
{
    public interface IDataService
    {
        IEnumerable<IArticle> GetAllProducts();

    }
}
