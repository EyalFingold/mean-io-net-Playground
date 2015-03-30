using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mean.io.Interfaces
{
    public interface IUser
    {
        int _id { get; set; }
        string username { get; set; }
        string name { get; set; }
    }
}
