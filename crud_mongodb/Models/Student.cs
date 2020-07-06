using System;
using MongoDB.Bson.Serialization.Attributes;

namespace crud_mongodb
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Roll { get; set; }
        
    }
}
