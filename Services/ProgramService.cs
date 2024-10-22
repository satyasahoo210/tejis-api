using MongoDB.Driver;
using TejisApi.Models;

namespace TejisApi.Services;

public class ProgramService : IService<ProgramEntity>
{
    private readonly IMongoCollection<ProgramEntity> _programs;
    public ProgramService(IDatabaseSettings settings, IMongoClient mongoClient)
    {
        var database = mongoClient.GetDatabase(settings.DatabaseName);
        _programs = database.GetCollection<ProgramEntity>(settings.ProgramCollectionName);
    }

    public ProgramEntity Create(ProgramEntity program)
    {
        _programs.InsertOne(program);
        return program;
    }

    public List<ProgramEntity> Get()
    {
        return _programs.Find(program => true).ToList();
    }

    public ProgramEntity Get(string Id)
    {
        return _programs.Find(program => program.Id == Id).FirstOrDefault();
    }

    public void Update(string Id, ProgramEntity program)
    {
        _programs.ReplaceOne(program => program.Id == Id, program);
    }

    public void Delete(string Id)
    {
        _programs.DeleteOne(program => program.Id == Id);
    }
}