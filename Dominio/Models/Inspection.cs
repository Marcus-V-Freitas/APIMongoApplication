using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dominio.Models
{
    public class Inspection
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }

        [BsonElement("id")]
        [BsonRequired()]
        public string InspectionId { get; private set; }

        [BsonElement("certificate_number")]
        [BsonRequired()]
        public int CertificateNumber { get; private set; }

        [BsonElement("business_name")]
        [BsonRequired()]
        public string BusinessName { get; private set; }

        [BsonElement("date")]
        [BsonRequired()]
        public string Date { get; private set; }

        [BsonElement("result")]
        [BsonRequired()]
        public string Result { get; private set; }

        [BsonElement("sector")]
        [BsonRequired()]
        public string Sector { get; private set; }

        [BsonElement("address")]
        [BsonRequired()]
        public Address Address { get; private set; }
    }
}