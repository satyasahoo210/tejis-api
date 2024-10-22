using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TejisApi.Models;

public class ProgramEntity : Entity
{
    [BsonElement("summary")]
    public string? Summary { get; set; }

    public string? Name { get; set; }

    public string? Section { get; set; }
    public string? Zone { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public string? Venue { get; set; }

    [BsonElement("orgId")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? OrgId { get; set; }
}