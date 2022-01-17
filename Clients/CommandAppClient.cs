using RestSharp;

namespace CommandAppClient.Clients;
public static class ApiClients
{
    public async static Task<RestResponse> GetCommands()
    {
        var client = new RestClient($"{Environment.GetEnvironmentVariable("BASE_URL")}/api/commands");

        var request = new RestRequest();

        return await client.GetAsync(request);
    }

    public async static Task<RestResponse> GetCommandById(int id)
    {
        var client = new RestClient($"{Environment.GetEnvironmentVariable("BASE_URL")}/api/commands/{id}");

        var request = new RestRequest();

        return await client.GetAsync(request);
    }

}
