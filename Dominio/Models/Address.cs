using MongoDB.Bson.Serialization.Attributes;

namespace Dominio.Models
{
    public class Address
    {
        [BsonElement("city")]
        [BsonRequired()]
        public string City { get; private set; }

        [BsonElement("zip")]
        [BsonRequired()]
        public int Zip { get; private set; }

        [BsonElement("street")]
        [BsonRequired()]
        public string Street { get; private set; }

        [BsonElement("number")]
        [BsonRequired()]
        public int Number { get; private set; }
    }
}