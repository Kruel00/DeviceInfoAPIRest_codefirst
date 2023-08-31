using DATA;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DeviceInfoAPI.Controllers
{
    [ApiController]
    [Route("[api/controller]")]
    public class DeviceController : Controller
    {

        private DeviceContext _context;
        private readonly ILogger<DeviceController> _logger;
        public DeviceController(ILogger<DeviceController> logger)
        {
            _logger = logger;
        }

        public DeviceController(DeviceContext context)
        {
            _context = context;
        }

    }
}
