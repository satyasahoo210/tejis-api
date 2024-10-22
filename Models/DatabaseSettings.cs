namespace TejisApi.Models;

public class DatabaseSettings : IDatabaseSettings
{
    public string ConnectionString { get; set; } = String.Empty;
    public string DatabaseName { get; set; } = String.Empty;
    public string ProgramCollectionName { get; set; } = String.Empty;
    public string OrgCollectionName { get; set; } = String.Empty;
}