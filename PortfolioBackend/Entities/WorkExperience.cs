using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PortfolioBackend.Entities;

public class WorkExperience
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    [BsonElement("role_name")]
    public string RoleName { get; set; } = string.Empty;

    [BsonElement("company_name")]
    public string CompanyName { get; set; } = string.Empty;

    [BsonElement("start_date")]
    public DateOnly StartDate { get; set; }

    [BsonElement("end_date")]
    public DateOnly EndDate { get; set; }

    [BsonElement("responsibilities")]
    public List<Responsibility> Responsibilities { get; set; } = [];

    [BsonElement("achievements")]
    public List<Achievement> Achievements { get; set; } = [];

}


public class Responsibility
{
    [BsonElement("description")]
    public string Description { get; set; } = string.Empty;
}

public class Achievement
{
    [BsonElement("description")]
    public string Description { get; set; } = string.Empty;
}