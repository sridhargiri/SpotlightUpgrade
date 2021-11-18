using Microsoft.EntityFrameworkCore;
using Spotlight.Core.Models;
using Spotlight.WebApi.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotlight.WebApi.Implementation
{
    public class PlayerReportService : IPlayerReportService
    {
        private readonly SpotlightDevelopmentContext dbContext;
        public PlayerReportService(SpotlightDevelopmentContext context)
        {
            dbContext = context;
        }

        public IEnumerable<PlayerReportModel> GetPlayerReport(string username, string rptMasterId, string hostString)
        {
            //var spModels = dbContext.Set<PlayerReportModel>().FromSqlRaw("EXECUTE rpt.BuildPlayersReport {0},{1},{2}", username, rptMasterId, hostString).AsEnumerable().ToList();
            var spModels = dbContext.PlayerReportModel.FromSqlRaw("EXECUTE rpt.BuildPlayersReport {0},{1},{2}", username, rptMasterId, hostString).AsEnumerable().ToList();
            var query = spModels
              .Select(x => new PlayerReportModel
              {
                  PlayerId = x.PlayerId,
                  ExternalId = x.ExternalId,
                  FirstName = x.FirstName,
                  LastName = x.LastName,
                  HostName = x.HostName,
                  PlayerType = x.PlayerType,
                  Address = x.Address,
                  State = x.State,
                  City = x.City,
                  Zip = x.Zip,
                  AllowMail = x.AllowMail,
                  Tier = x.Tier,
                  Phone = x.Phone,
                  AlternativePhone = x.AlternativePhone,
                  EmailAddress = x.EmailAddress,
                  Status = x.Status,
                  Seasonal = x.Seasonal,
                  Prop90ADA = x.Prop90ADA,
                  Prop90ADT = x.Prop90ADT,
                  Prop90Tips = x.Prop90Tips,
                  Frequency = x.Frequency,
                  FavoriteActivity = x.FavoriteActivity??"",
                  FavoriteGame = x.FavoriteGame,
                  PatronHostLastContact = x.PatronHostLastContact,
                  OtherLastContact = x.OtherLastContact,
                  OtherContactHost = x.OtherContactHost,
                  LastVisit = x.LastVisit,
                  LengthHostString = x.LengthHostString,
                  FrequencyColor = x.FrequencyColor
              });
            return query;
        }
    }
}
