using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dominio.Models
{
    public class Zip
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }

        [BsonElement("city")]
        [BsonRequired()]
        public string City { get; private set; }

        [BsonElement("zip")]
        [BsonRequired()]
        public string Zip { get; private set; }

        [BsonElement("loc")]
        [BsonRequired()]
        [BsonRepresentation(BsonType.Double, AllowTruncation = true)]
        public double[] Loc { get; private set; }

        [BsonElement("pop")]
        [BsonRequired()]
        public int Pop { get; private set; }

        [BsonElement("state")]
        [BsonRequired()]
        public string State { get; private set; }
    }
}