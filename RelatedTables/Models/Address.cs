using System.Text.Json.Serialization;

namespace RelatedTables.Models;

public class Address
{
    public int Id { get; set; }
    
    public string? FullAddress { get; set; }    
   
    [JsonIgnore]
    public int ClientId { get; set; }    
}
