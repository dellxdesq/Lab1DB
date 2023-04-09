namespace laba1;
public class Customer
{
    private string? _name;
    public Customer(string? name, long? id)
    {
        Name = name;
        Id = id;
    }

    public string? Name { get; set; }
    public long? Id { get; set; }
}
