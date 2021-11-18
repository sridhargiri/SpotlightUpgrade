using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Spotlight.Core.Models;
using Spotlight.WebApi.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotlight.WebApi.Controllers
{
    [ApiController]
    [EnableCors("MyPolicy")]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly ILogger<ReportController> _logger;

        private readonly IPlayerReportService _playerReportService;

        public ReportController(ILogger<ReportController> logger, IPlayerReportService playerReportService)
        {
            _logger = logger; _playerReportService = playerReportService;
        }

        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<PlayerReportModel> Get()
        {
            return _playerReportService.GetPlayerReport("Ian.Bassett", "1", "");
        }
    }
}
