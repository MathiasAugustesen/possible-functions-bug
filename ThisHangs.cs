using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Mathias.Augustesen.BugDemo
{
    public class ThisHangs
    {
        private readonly ILogger<ThisHangs> _logger;

        public ThisHangs(ILogger<ThisHangs> logger)
        {
            _logger = logger;
        }

        [Function("ThisHangs")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Admin, "get", "post")] HttpRequest req)
        {
            throw new AccessViolationException();
        }
    }
}
