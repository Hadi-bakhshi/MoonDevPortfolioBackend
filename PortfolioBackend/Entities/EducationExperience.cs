using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PortfolioBackend.Entities;

public class EducationExperience
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    [BsonElement("degree")]
    public string Degree { get; set; } = string.Empty;

    [BsonElement("university_name")]
    public string UniversityName { get; set; } = string.Empty;

    [BsonElement("GPA")]
    public int GPA { get; set; }

    [BsonElement("short_date")]
    public DateOnly ShortDate { get; set; }

    [BsonElement("end_date")]
    public DateOnly EndDate { get; set; }
}
