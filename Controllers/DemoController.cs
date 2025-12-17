using DI_Demo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        private readonly IMessageService _messageService;

        // 👇 YAHIN INJECTION HOTA HAI
        public DemoController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public string Get()
        {
            return _messageService.GetMessage();
        }
    }
}
