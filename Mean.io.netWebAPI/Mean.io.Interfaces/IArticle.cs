using System;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace Mean.io.Interfaces
{
    public interface IArticle
    {
        [BsonId]
        int _id { get; set; }
        //IUser user { get; set; }

        [BsonElement]
        string title { get; set; }


        [BsonElement]
        string content { get; set; }


        [BsonElement]
        DateTime created { get; set; }
    }
}