using RelatedTables.Models;

namespace RelatedTables.Data;

public class ClientData
{
    public List<Client> ClientList {get; set;}
    public List<Address> AddressList {get; set;}
    
    public ClientData()
    {
        ClientList = [
            new() {Id = 1, Name = "client1"},
            new() {Id = 2, Name = "client2"}                    
        ];

        AddressList = [
                new() { Id = 101, FullAddress = "Valter Scarpelini 912", ClientId = 1 },
                new() { Id = 102, FullAddress = "Egídio Véscia 318", ClientId = 1 },
                new() { Id = 103, FullAddress = "Orestes Pedrassani 480", ClientId = 1 },
                new() { Id = 104, FullAddress = "Anita Garibaldi 236", ClientId = 2 }
        ];
    }
}

