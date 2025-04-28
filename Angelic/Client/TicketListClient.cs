using System.Globalization;
using System.Text;
using Angelic.Models.Tickets.Client;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace Angelic.Client;

public class TicketListClient
{
        public async Task GetAllAsync(TicketListQueryParams? queryParams = null)
        {
            var client = new RestClient(configureSerialization: s => s.UseNewtonsoftJson());
        }

}