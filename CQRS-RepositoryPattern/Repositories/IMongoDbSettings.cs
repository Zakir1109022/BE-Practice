namespace BE_Practice.Repositories
{
    public interface IMongoDbSettings
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}