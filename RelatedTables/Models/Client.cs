namespace RelatedTables.Models;

public class Client
{

    public int Id { get; set; }
    public string?  Name { get; set; }
    public virtual ICollection<Address> Addresses { get; set; } = [];
}
