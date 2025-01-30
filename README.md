# AssistBot

## Overview
AssistBot is a conversational AI bot built using the **Microsoft Bot Framework** and **.NET Core**. It is designed to handle user interactions, provide assistance through various services, and can integrate with enterprise tools like **Microsoft 365, Azure Cognitive Services, and external APIs**.

## Features
- 🌐 **Built with .NET Core & Microsoft Bot Framework**
- 🤖 **Conversational AI** powered by **LUIS** (Language Understanding Intelligent Service)
- 🔗 **Integration with Microsoft Teams, Slack, and Web Chat**
- 🏢 **Enterprise-Ready** with **Azure Deployment**
- 🛡️ **Secure API & Authentication with Azure AD**

## Project Structure
```
AssistBot/
│── AssistBot.sln             # Solution file
│── .gitignore                # Git ignored files
│── README.md                 # Project documentation
│── AssistBotApp/             # Main bot application
│   ├── AssistBotApp.csproj   # Project file
│   ├── Controllers/
│   │   ├── BotController.cs  # Handles bot interactions
│   ├── Bots/
│   │   ├── AssistBot.cs      # Core bot logic
│   ├── appsettings.json      # Configuration file
│   ├── Program.cs            # Entry point
│   ├── Startup.cs            # Dependency injection & middleware setup
│   ├── bin/                  # Build output (Ignored by Git)
│   ├── obj/                  # Compiled binaries (Ignored by Git)
```

## Setup Instructions
### **1. Clone the Repository**
```bash
git clone https://github.com/your-username/AssistBot.git
cd AssistBot
```

### **2. Open the Project in VS Code**
```bash
code .
```

### **3. Restore Dependencies**
```bash
dotnet restore
```

### **4. Configure App Settings**
Edit `appsettings.json` and add your Microsoft **App ID** and **App Password**.

### **5. Run the Application Locally**
```bash
dotnet run --project AssistBotApp
```

### **6. Test the Bot**
#### **Using Web Browser (Test GET Method)**
Open:
```
http://localhost:5000/api/messages
```
You should see:
```
AssistBot is running!
```

#### **Using Bot Framework Emulator (Test POST Method)**
1. Open **Bot Framework Emulator**.
2. Connect to:
   ```
   http://localhost:5000/api/messages
   ```
3. Send a message and see the response.

## Deployment
### **Deploy to Azure**
To deploy the bot to **Azure**, follow these steps:

1. **Login to Azure CLI:**
   ```bash
   az login
   ```
2. **Create a resource group:**
   ```bash
   az group create --name AssistBotResourceGroup --location eastus
   ```
3. **Deploy to Azure Bot Service:**
   ```bash
   az bot create --name AssistBot --resource-group AssistBotResourceGroup --kind webapp --sku F0 --location eastus --appid <APP_ID> --password <APP_PASSWORD>
   ```
4. **Update the messaging endpoint in Azure Portal:**
   ```
   https://<your-bot-name>.azurewebsites.net/api/messages
   ```

## Future Enhancements
✅ **Integrate AI (LUIS, QnA Maker) for advanced responses**
✅ **Enable proactive notifications with Azure Event Grid**
✅ **Support multiple languages using Azure Translator API**
✅ **Improve response formatting with Adaptive Cards**

## Contributing
Contributions are welcome! 🚀 Please **fork the repository, create a branch, and submit a pull request** for any enhancements or bug fixes.

## License
This project is licensed under the **MIT License**.

---
**🚀 Need Help?** Open an issue on **GitHub** or reach out to the project maintainers!
