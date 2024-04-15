Using your environment credentials for GitHub and your Azure Workshop Environment:

1. Fork the repo at ```https://github.com/DevExpGbb/azure-openai```
2. Start a GitHub Codespace
3. In your ```appsettings.json``` file enter in the required configuration infor for your Azure OpenAI credentials
4. Install the latest Azure OpenAI SDK (e.g. ```--version 1.0.0-beta.16``` @ April 15 2024)
5. Open your ```Program.cs``` file and start editing
5. Ensure your are importing/using the correct namespcae for the SDK (e.g. ```using Azure.AI.OpenAI```)
6. Implement a version of the ```GetSummaryFromOpenAI``` Function
    - You will need to create a new ```ChatCompletionsOptions``` instance
    - You should include two Chat Messages
        - System Message (aka System Prompt)
        - User Message (aka User Prompt)
    - You can modify addtional parameters/settings when interacting with Azure OpenAI
        - MaxTokens
        - Temperature
        - Target Deployment Name (Deployed model type e.g. GPT3.5, GPT3.5T, GPT4)
            - In this lab, a model will have been already provisioned for you (this deployment name should be provided)
    - You should have a response object which will be of type ```ChatCompletions```
        - This type will have a Property called ```Choices``` and it will have an array of Messages which are the potential answers/responses form Azure OpenAI (generally you will target response at index [0])
    - Write the response/completion to console