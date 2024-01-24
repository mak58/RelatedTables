using Carter;
using RelatedTables.Data;
using RelatedTables.Models;

namespace RelatedTables.Endpoint.Clients;

public class PostClient : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/post", (Client request,
             ClientData _data) =>
        {
            var newClient = new Client()
            {   
                Id = _data.ClientList.Last().Id,
                Name = request.Name
            };

            _data.ClientList.Add(newClient);

            foreach (var item in request.Addresses)
            {
                Address address = new()
                {
                    Id = _data.AddressList.Last().Id + 1,
                    FullAddress = item.FullAddress,
                    ClientId = newClient.Id
                };
                _data.AddressList.Add(address);
            }

            return Results.Created();
        })
        .WithTags("Client")
        .WithName("PostClient");
    }

}
