public abstract class StorageService
{
    public abstract void Upload(string file);
    public abstract bool Delete(string file);
}

// abstract factory
public abstract class StorageServiceFactory
{
    public abstract StorageService CreateStorageService();
}

// concrete class
public class AzureStorageService : StorageService
{
    public override void Upload(string file)
    {
        // upload to Azure Blob Storage
    }

    public override bool Delete(string file)
    {
        // delete file on Azure Blob Storage
        return true;
    }
}

public class AzureStorageServiceFactory : StorageServiceFactory
{
    public override StorageService CreateStorageService()
    {
        return new AzureStorageService();
    }
}

public class Program
{
    public static void Main(String[] args)
    {
        var factory = new AzureStorageServiceFactory();
        var storage = factory.CreateStorageService();
        storage.Upload("test.md");
        storage.Delete("test.md");
    }
}