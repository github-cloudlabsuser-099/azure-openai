import os
from dotenv import load_dotenv

# Add Azure OpenAI package
from openai import AzureOpenAI

def main(): 
        
    try: 
    
        # Get configuration settings 
        load_dotenv()
        azure_oai_endpoint = os.getenv("AZURE_OAI_ENDPOINT")
        azure_oai_key = os.getenv("AZURE_OAI_KEY")
        azure_oai_deployment = os.getenv("AZURE_OAI_DEPLOYMENT")
        
        
        # Get text from user input
        print("Please enter the text you want to summarize:")
        text = input()
        
        print("\nSending request for summary to Azure OpenAI endpoint...\n\n")
        
        # Add code to build request...
        # Initialize the Azure OpenAI client
        client = AzureOpenAI(
                azure_endpoint = azure_oai_endpoint, 
                api_key=azure_oai_key,  
                api_version="2023-05-15"
                )

        # Implement Code

    except Exception as ex:
        print(ex)

if __name__ == '__main__': 
    main()  