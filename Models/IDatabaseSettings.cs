namespace TejisApi.Models;

public interface IDatabaseSettings
{
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
    string ProgramCollectionName { get; set; }
    string OrgCollectionName { get; set; }
}