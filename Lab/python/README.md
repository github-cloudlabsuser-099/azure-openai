Using your environment credentials for GitHub and your Azure Workshop Environment:

1. Fork the repo at ```https://github.com/DevExpGbb/azure-openai```
2. Start a GitHub Codespace
3. In your ```.env``` file enter in the required configuration infor for your Azure OpenAI credentials
4. Install the latest OpenAI SDK (e.g. ```openai==1.19.0``` @ April 15 2024)
5. Open your ```program.python``` file and start editing
5. Ensure your are importing/using the correct namespcae for the SDK (e.g. ```from openai import AzureOpenAI```)
6. Implement a version code that will call the Azure OpenAI endpoint
    - You will need to create a new client object that is an ```AzureOpenAI``` instance
    - You should include two Chat Messages
        - System Message (aka System Prompt)
        - User Message (aka User Prompt)
    - You can modify addtional parameters/settings when interacting with Azure OpenAI
        - MaxTokens
        - Temperature
        - Target Deployment Name (Deployed model type e.g. GPT3.5, GPT3.5T, GPT4)
            - In this lab, a model will have been already provisioned for you (this deployment name should be provided)
    - You should have a response object that will have a Property called ```choices``` and it will have an array of Messages which are the potential answers/responses form Azure OpenAI (generally you will target response at index [0])
    - Write/Print the response/completion to console