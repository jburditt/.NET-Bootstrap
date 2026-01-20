using System.Text;

namespace Demo.Prototype;

public interface Cloneable<T>
{
    T Clone();
}

public interface Document
{
    string Name { get; set; }
    string Address { get; set; }

    void Print();
}

public class Lease : Document, Cloneable<Document>
{
    public string Tenant { get; set; }
    public string Agreement { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    public Document Clone()
    {
        return (Document)MemberwiseClone();
    }

    public void Print()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Tenant: {Tenant}");
        sb.AppendLine($"Agreement: {Agreement}");
        return sb.ToString();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var originalLease = new Lease
        {
            Tenant = "John Doe",
            Agreement = "12 months lease",
            Name = "Lease Document",
            Address = "123 Main St"
        };
        var clonedLease = originalLease.Clone();
        clonedLease.Name = "Cloned Lease Document";
        clonedLease.Address = "456 Elm St";
        originalLease.Print();
        Console.WriteLine();
        clonedLease.Print();
    }
}