using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TejisApi.Models;

public class Entity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
}
