using MongoDB.Driver;
using TejisApi.Models;

namespace TejisApi.Services;

public class OrgService : IService<OrgEntity>
{
    private readonly IMongoCollection<OrgEntity> _orgs;
    public OrgService(IDatabaseSettings settings, IMongoClient mongoClient)
    {
        var database = mongoClient.GetDatabase(settings.DatabaseName);
        _orgs = database.GetCollection<OrgEntity>(settings.OrgCollectionName);
    }

    public OrgEntity Create(OrgEntity org)
    {
        _orgs.InsertOne(org);
        return org;
    }

    public List<OrgEntity> Get()
    {
        return _orgs.Find(org => true).ToList();
    }

    public OrgEntity Get(string Id)
    {
        return _orgs.Find(org => org.Id == Id).FirstOrDefault();
    }

    public void Update(string Id, OrgEntity org)
    {
        _orgs.ReplaceOne(org => org.Id == Id, org);
    }

    public void Delete(string Id)
    {
        _orgs.DeleteOne(org => org.Id == Id);
    }
}