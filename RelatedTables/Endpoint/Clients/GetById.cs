using Carter;
using RelatedTables.Data;

namespace RelatedTables.Endpoint.Clients;

public class GetById : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app) 
    {
        
        app.MapGet("/client/{id}", (int id, 
            ClientData _data) => 
        {
            var address  = (from c in _data.ClientList
                         join a in _data.AddressList on c.Id equals a.ClientId
                         where c.Id == id
                         select a).ToList(); 

            var client = _data.ClientList
                            .FirstOrDefault(c => c.Id == id);

            client.Addresses = address;

            return address;
        })
        .WithTags("Client")
        .WithName("GetClientById");
    }

}
