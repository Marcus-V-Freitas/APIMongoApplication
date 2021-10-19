using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dominio.Models
{
    public class Grade
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }

        [BsonElement("student_id")]
        [BsonRequired()]
        public int StudentId { get; private set; }

        [BsonElement("scores")]
        [BsonRequired()]
        public dynamic Scores { get; private set; }

        [BsonElement("class_id")]
        [BsonRequired()]
        public int ClasseId { get; private set; }
    }
}