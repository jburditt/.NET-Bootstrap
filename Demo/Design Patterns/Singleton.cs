namespace Demo.Singleton;

public sealed class DatabaseManager
{
    private static readonly Lazy<DatabaseManager> _instance = new Lazy<DatabaseManager>(() => new DatabaseManager());
    public static DatabaseManager Instance => _instance.Value;

    public void Query(string sql)
    {
        Console.WriteLine($"Executing query: {sql}");
    }
}

class Program
{
    static void Main()
    {
        var db1 = DatabaseManager.Instance;
        var db2 = DatabaseManager.Instance;

        db1.Query("SELECT * FROM Users");

        // Verification: Both variables point to the same object
        Console.WriteLine($"Are both instances the same? {ReferenceEquals(db1, db2)}");
    }
}