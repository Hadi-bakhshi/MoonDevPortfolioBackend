using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PortfolioBackend.Entities;

public class AboutMe
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    [BsonElement("description")]
    public required string Description { get; set; }
}
