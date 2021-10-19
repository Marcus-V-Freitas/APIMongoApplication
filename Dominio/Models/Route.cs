using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dominio.Models
{
    public class Route
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }

        [BsonElement("airline")]
        [BsonRequired()]
        public Airline Airline { get; private set; }

        [BsonElement("src_airport")]
        [BsonRequired()]
        public string SourceAirport { get; private set; }

        [BsonElement("dst_airport")]
        [BsonRequired()]
        public string DestinationAirport { get; private set; }

        [BsonElement("codeshare")]
        public string Codeshare { get; private set; }

        [BsonElement("stops")]
        [BsonRequired()]
        public int Stops { get; private set; }

        [BsonElement("airplane")]
        [BsonRequired()]
        public string Airplane { get; private set; }
    }
}