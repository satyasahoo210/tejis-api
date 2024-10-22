using System;
using MongoDB.Bson.Serialization.Attributes;

namespace TejisApi.Models;

public class MemberEntity : Entity
{
    [BsonElement("name")]
    public string? Name { get; set; }
    public bool IsLeader { get; set; } = false;
}
