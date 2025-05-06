

```markdown
# Azure Serverless Function App – `cloud_pract2`

This project demonstrates a basic **Azure Function App** written in **C#** using **.NET Core**,
designed to respond to HTTP-triggered events. It serves as a foundational example of how to create, configure,
and deploy serverless applications using Microsoft Azure's cloud platform.

---

##  Features

-  **HTTP Trigger**: Responds to incoming HTTP requests with customizable messages.
-  **Serverless Architecture**: Built on Azure Functions for lightweight, event-driven execution.
-  **.NET Project Structure**: Organized using standard `.csproj` format.
-  **Configurable Settings**: Includes `host.json` and `local.settings.json` for runtime and local environment setup.

---

## Tech Stack

- **Language:** C#  
- **Framework:** .NET Core  
- **Cloud Platform:** Azure Functions  
- **Tools:** Visual Studio / VS Code, Azure CLI

---

##  Project Structure

```

cloud\_pract2/
├── FunctionApp1/
│   ├── Function1.cs             # Main Azure Function (HTTP Trigger)
│   ├── FunctionApp1.csproj      # Project file
│   ├── host.json                # Runtime configuration
│   ├── local.settings.json      # Local development settings (not uploaded to Git)

````

---

##  Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/quran-yeamen/cloud_pract2.git
   cd cloud_pract2/FunctionApp1
````

2. **Install .NET SDK**
   Make sure you have [.NET Core SDK](https://dotnet.microsoft.com/download) installed.

3. **Run the function locally**

   ```bash
   func start
   ```

4. **Test the endpoint**
   After starting, visit:

   ```
   http://localhost:7071/api/Function1?name=Quran
   ```

---

##  Sample Request

**GET Request:**

```
GET /api/Function1?name=Quran
```

**Response:**

```json
Hello, Quran. This HTTP triggered function executed successfully.
```

---

##  Deployment (Optional)

You can deploy the function directly to Azure using:

```bash
func azure functionapp publish <YourFunctionAppName>
```

Make sure your Azure CLI is authenticated and set to the correct subscription.

---

## Notes

* `local.settings.json` is excluded from source control for security.
* The project can be extended to support additional triggers like Blob, Timer, or Queue.

---

## Contact

For questions, feel free to connect:
**Quran Yeamen**
[LinkedIn](https://www.linkedin.com/in/quran-yeamen/) | [GitHub](https://github.com/quran-yeamen)

---
