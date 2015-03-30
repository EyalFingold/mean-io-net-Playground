using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mean.io.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson.Serialization;

namespace Mean.io.DataServices.MongoDB
{
    public class MongoDBDataService : IDataService
    {

        public MongoDBDataService()
        {
           BsonClassMap.RegisterClassMap<IArticle>();
        }

        public IEnumerable<IArticle> GetAllArticles()
        {
            IEnumerable<IArticle> retCollection = null;
            try
            {
                var connectionString = "mongodb://localhost";
                var client = new MongoClient(connectionString);
                var server = client.GetServer();
                var database = server.GetDatabase("mean-dev");
                var collection =  database.GetCollection("articles");
                var result = collection.FindAllAs<IArticle>();

                foreach (IArticle item in result)
                {
                    Console.WriteLine("item _id:" + item._id + "item title:" + item.title + "item username");// + item.user.username);
                }

                server.Disconnect();
                client = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
            return retCollection; 
        } 

        public IArticle GetArticle(int id)
        {

            IArticle entity = null;
            try
            {
                //var connectionString = "mongodb://localhost";
                //var client = new MongoClient(connectionString);
                //var server = client.GetServer();
                //var database = server.GetDatabase("mean-dev");
                //var collection = database.GetCollection<IArticle>("articles");
                //var query = Query<IArticle>.EQ(e => e._id, id);
                //entity = collection.FindOne(query);
                //server.Disconnect();
                //client = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }
    }
}
