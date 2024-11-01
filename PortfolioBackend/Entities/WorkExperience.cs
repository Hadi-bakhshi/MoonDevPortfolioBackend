using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PortfolioBackend.Entities;

public class WorkExperience
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    [BsonElement("degree")]
    public required string Degree { get; set; }

    [BsonElement("university_name")]
    public required string UniversityName { get; set; }


    [BsonElement("GPA")]
    public int GPA { get; set; }

    [BsonElement("short_date")]
    public DateOnly ShortDate { get; set; }

    [BsonElement("end_date")]
    public DateOnly EndDate { get; set; }
}
