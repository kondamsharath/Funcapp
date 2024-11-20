using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace TCS
{
    public class WelcomeAzure
    {
        private readonly ILogger<WelcomeAzure> _logger;

        public WelcomeAzure(ILogger<WelcomeAzure> logger)
        {
            _logger = logger;
        }

        [Function("WelcomeAzure")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
