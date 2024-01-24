using System.Linq.Expressions;
using Carter;
using RelatedTables.Data;
using RelatedTables.Models;

namespace RelatedTables.Endpoint.Clients;

public class GetAll : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        
        app.MapGet("/client", (ClientData _data) => 
        {

            return _data.ClientList
                .Select(a => new Client
                {
                    Id = a.Id,
                    Name = a.Name,
                    Addresses =  _data.AddressList
                                .Where(b => b.ClientId == a.Id)
                                .Select(b => new Address()
                                {
                                    Id = b.Id,
                                    FullAddress = b.FullAddress 
                                }).ToList()
                });        
        })
        .WithTags("Client")
        .WithName("GetAllClients");
    }
}
