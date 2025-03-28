using System;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class Function1
    {
        private readonly ILogger _logger;

        // Constructor to initialize the logger
        public Function1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Function1>();
        }

        // HTTP trigger function
        [Function("Function1")]
        public HttpResponseData Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            // Logging the incoming request
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            // Retrieve the secret from environment variables
            // In Azure, the environment variable will be populated by Key Vault or App Settings
            var mySecretValue = Environment.GetEnvironmentVariable("MySecret");

            // Logging the secret value for debugging (make sure to avoid logging sensitive info in production)
            _logger.LogInformation($"MySecret value: {mySecretValue ?? "null"}");

            // Creating the HTTP response
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            // Writing response message to the client
            response.WriteString(
                "Welcome to Azure Functions!\n\n" +
                $"Retrieved MySecret: {mySecretValue ?? "No secret found"}"
            );

            // Returning the response
            return response;
        }
    }
}
