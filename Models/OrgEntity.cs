using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TejisApi.Models;

public class OrgEntity : Entity
{
    [BsonElement("name")]
    public string? OrgName { get; set; }

    [BsonElement("members")]
    public List<MemberEntity>? Members { get; set; } = null;

}