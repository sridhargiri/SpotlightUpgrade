using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spotlight.Core.Models;

namespace Spotlight.WebApi.Abstraction
{
    public interface IPlayerReportService
    {
        IEnumerable<PlayerReportModel> GetPlayerReport(string username, string rptMasterId, string hostString);
    }
}
