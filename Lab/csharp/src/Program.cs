// Implicit using statements are included
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Azure.AI.OpenAI;
using Azure;

// Add Azure OpenAI package


// Build a config object and retrieve user settings.
IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

string? oaiEndpoint = config["AzureOAIEndpoint"];
string? oaiKey = config["AzureOAIKey"];
string? oaiDeploymentName = config["AzureOAIDeploymentName"];

if(string.IsNullOrEmpty(oaiEndpoint) || string.IsNullOrEmpty(oaiKey) || string.IsNullOrEmpty(oaiDeploymentName) )
{
    Console.WriteLine("Please check your appsettings.json file for missing or incorrect values.");
    return;
}

do {
    Console.WriteLine("Enter your prompt text (or type 'quit' or 'exit' to exit): ");
    string? inputText = Console.ReadLine();
    if (inputText == "quit" || inputText =="exit") break;

    // Generate summary from Azure OpenAI
    if (inputText == null) {
        Console.WriteLine("Please enter a prompt.");
        continue;
    }
    // Add code to send request...

    GetSummaryFromOpenAI(inputText);
    
} while (true);
    
// Implement a version of GetSummaryFromOpenAI
void GetSummaryFromOpenAI(string text)  
{   

}
