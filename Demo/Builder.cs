namespace Demo.Builder;

public class DocumentDirector
{
    public void Construct(DocumentBuilder builder)
    {
        builder.BuildHead();
        builder.BuildBody();
    }
}

public abstract class DocumentBuilder
{
    public Document Document { get; private set; } = new();
    public abstract void BuildHead();
    public abstract void BuildBody();
}

public class JsonDocumentBuilder : DocumentBuilder
{
    private JsonDocumentBuilder AddProperty(string key, object value)
    {
        Document[key] = value;
        return this;
    }

    public override void BuildHead() => AddProperty("head", "This is the head section");

    public override void BuildBody() => AddProperty("body", "This is the body section");

    public override string ToString() => System.Text.Json.JsonSerializer.Serialize(Document);
}

public class Document
{
    private Dictionary<string, object> _properties = new();

    public object this[string key]
    {
        get { return _properties[key]; }
        set { _properties[key] = value; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var director = new DocumentDirector();
        var builder = new JsonDocumentBuilder();
        director.Construct(builder);
        var document = builder.Document;
        Console.WriteLine(builder.ToString());
    }
}
