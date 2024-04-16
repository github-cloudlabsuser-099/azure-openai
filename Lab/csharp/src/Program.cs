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
    
void GetSummaryFromOpenAI(string text)  
{   
    Console.WriteLine("\nSending request for summary to Azure OpenAI endpoint...\n\n");

    if(string.IsNullOrEmpty(oaiEndpoint) || string.IsNullOrEmpty(oaiKey) || string.IsNullOrEmpty(oaiDeploymentName) )
    {
        Console.WriteLine("Please check your appsettings.json file for missing or incorrect values.");
        return;
    }

    // Add code to build request...
    // Initialize the Azure OpenAI client
    OpenAIClient client = new OpenAIClient(new Uri(oaiEndpoint), new AzureKeyCredential(oaiKey));

    // Build completion options object
    ChatCompletionsOptions chatCompletionsOptions = new ChatCompletionsOptions()
    {
        Messages =
        {
            new ChatRequestSystemMessage("You are a helpful assistant.  Please provide information about the following User Input and keep it to 20 words or less."),
            new ChatRequestUserMessage("User Input: \n" + text),
        },
        MaxTokens = 120,
        Temperature = 0.7f,
        DeploymentName = oaiDeploymentName
    };

    // Send request to Azure OpenAI model
    ChatCompletions response = client.GetChatCompletions(chatCompletionsOptions);
    string completion = response.Choices[0].Message.Content;

    Console.WriteLine("Summary: " + completion + "\n");
}  