using MongoDB.Bson.Serialization.Attributes;

namespace Dominio.Models
{
    public class Airline
    {
        [BsonElement("id")]
        [BsonRequired()]
        public int Id { get; private set; }

        [BsonElement("name")]
        [BsonRequired()]
        public string Name { get; private set; }

        [BsonElement("alias")]
        [BsonRequired()]
        public string Alias { get; private set; }

        [BsonElement("iata")]
        [BsonRequired()]
        public string Iata { get; private set; }
    }
}