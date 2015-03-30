using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mean.io.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Mean.io.DataServices.MongoDB
{
    public class MongoDBDataService : IDataService
    {

        public MongoDBDataService()
        {
          
        }

        public IEnumerable<IArticle> GetAllArticles()
        {
            IEnumerable<IArticle> collection = null;
            try
            {
                var connectionString = "mongodb://localhost";
                var client = new MongoClient(connectionString);
                var server = client.GetServer();
                var database = server.GetDatabase("mean-dev");
                collection = (IEnumerable<IArticle>) database.GetCollection<IArticle>("articles");
                server.Disconnect();
                client = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
            return collection; 
        } 

        public IArticle GetArticle(int id)
        {

            IArticle entity = null;
            try
            {
                var connectionString = "mongodb://localhost";
                var client = new MongoClient(connectionString);
                var server = client.GetServer();
                var database = server.GetDatabase("mean-dev");
                var collection = database.GetCollection<IArticle>("articles");
                var query = Query<IArticle>.EQ(e => e._id, id);
                entity = collection.FindOne(query);
                server.Disconnect();
                client = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }
    }
}
