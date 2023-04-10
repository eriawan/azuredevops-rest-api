using Rx.AzDo.DistributedTask.VariableGroups;
using System.Net.Http.Json;

namespace AzureDevOpsRESTPlayground;
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, Azure DevOps REST Playground!");
        // TEST caling Azure DevOps REST API using HttpClient here
        // Test calling REST API to get a list of all build definitions
        var webClient = new HttpClient();
        var orgname = "yourorganizationname";
        var teamprojectName = "teamprojectName";
        var azdoPAT = "yourPAT";
        webClient.DefaultRequestHeaders.Add("Authorization", $"Basic {azdoPAT}");
        var rawBuildDefinitions = await webClient.GetFromJsonAsync<TfsVariableGroups>($"https://dev.azure.com/{orgname}/{teamprojectName}/_apis/build/definitions?api-version=7.0");
        Console.WriteLine(rawBuildDefinitions);
    }
}
