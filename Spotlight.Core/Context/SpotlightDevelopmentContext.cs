using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Spotlight.Core.Models;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SpotlightDevelopmentContext : DbContext
    {
        public SpotlightDevelopmentContext()
        {
        }

        public SpotlightDevelopmentContext(DbContextOptions<SpotlightDevelopmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }
        public virtual DbSet<AlertTitle31PlayerRaw> AlertTitle31PlayerRaws { get; set; }
        public virtual DbSet<AlertsConfig> AlertsConfigs { get; set; }
        public virtual DbSet<ArchiveHostPatronEmail> ArchiveHostPatronEmails { get; set; }
        public virtual DbSet<ArchiveSourcePatron> ArchiveSourcePatrons { get; set; }
        public virtual DbSet<ArchiveWhosHere> ArchiveWhosHeres { get; set; }
        public virtual DbSet<ArchivedAlert> ArchivedAlerts { get; set; }
        public virtual DbSet<ArchivedAlert1> ArchivedAlerts1 { get; set; }
        public virtual DbSet<ArchivedAlertsOld> ArchivedAlertsOlds { get; set; }
        public virtual DbSet<AuditSourcePatron> AuditSourcePatrons { get; set; }
        public virtual DbSet<ChangeCompContactLog> ChangeCompContactLogs { get; set; }
        public virtual DbSet<ChangeHost> ChangeHosts { get; set; }
        public virtual DbSet<ChangeHostsXrefMl> ChangeHostsXrefMls { get; set; }
        public virtual DbSet<ChangePatronStatus> ChangePatronStatuses { get; set; }
        public virtual DbSet<ChangePatronTripCount> ChangePatronTripCounts { get; set; }
        public virtual DbSet<ChangeSummaryByPeriod> ChangeSummaryByPeriods { get; set; }
        public virtual DbSet<ChangeSummaryByTrip> ChangeSummaryByTrips { get; set; }
        public virtual DbSet<CompContactLog> CompContactLogs { get; set; }
        public virtual DbSet<ConfigAlertEmailTo> ConfigAlertEmailTos { get; set; }
        public virtual DbSet<ConfigAlertSubType> ConfigAlertSubTypes { get; set; }
        public virtual DbSet<ConfigAlertType> ConfigAlertTypes { get; set; }
        public virtual DbSet<ConfigAlertValue> ConfigAlertValues { get; set; }
        public virtual DbSet<ConfigCardLevel> ConfigCardLevels { get; set; }
        public virtual DbSet<ConfigDate> ConfigDates { get; set; }
        public virtual DbSet<ConfigDatum> ConfigData { get; set; }
        public virtual DbSet<ConfigDaysOfWeek> ConfigDaysOfWeeks { get; set; }
        public virtual DbSet<ConfigFiscalYear> ConfigFiscalYears { get; set; }
        public virtual DbSet<ConfigHoursOfDay> ConfigHoursOfDays { get; set; }
        public virtual DbSet<ConfigPeriod> ConfigPeriods { get; set; }
        public virtual DbSet<ConfigProduct> ConfigProducts { get; set; }
        public virtual DbSet<ConfigProductType> ConfigProductTypes { get; set; }
        public virtual DbSet<ConfigProperty> ConfigProperties { get; set; }
        public virtual DbSet<ConfigRfm> ConfigRfms { get; set; }
        public virtual DbSet<ConfigRfmdate> ConfigRfmdates { get; set; }
        public virtual DbSet<ConfigRfmpatron> ConfigRfmpatrons { get; set; }
        public virtual DbSet<ConfigRfmscore> ConfigRfmscores { get; set; }
        public virtual DbSet<ConfigRfmscore1> ConfigRfmscores1 { get; set; }
        public virtual DbSet<ContactLog> ContactLogs { get; set; }
        public virtual DbSet<ContactLogsAudit> ContactLogsAudits { get; set; }
        public virtual DbSet<ContactSigned> ContactSigneds { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Counter> Counters { get; set; }
        public virtual DbSet<Csr> Csrs { get; set; }
        public virtual DbSet<DailyHostSummaryCount> DailyHostSummaryCounts { get; set; }
        public virtual DbSet<DailyHostSummaryCount1> DailyHostSummaryCounts1 { get; set; }
        public virtual DbSet<DailyRoisummary> DailyRoisummaries { get; set; }
        public virtual DbSet<Dapuser> Dapusers { get; set; }
        public virtual DbSet<DeclinerAlert> DeclinerAlerts { get; set; }
        public virtual DbSet<EmailAlert> EmailAlerts { get; set; }
        public virtual DbSet<EmailAlertsArchive> EmailAlertsArchives { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeComp> EmployeeComps { get; set; }
        public virtual DbSet<Ethnicity> Ethnicities { get; set; }
        public virtual DbSet<Hash> Hashes { get; set; }
        public virtual DbSet<HeatConfig> HeatConfigs { get; set; }
        public virtual DbSet<Host> Hosts { get; set; }
        public virtual DbSet<Host1> Hosts1 { get; set; }
        public virtual DbSet<Host2> Hosts2 { get; set; }
        public virtual DbSet<HostDeviceSession> HostDeviceSessions { get; set; }
        public virtual DbSet<HostEnrolled> HostEnrolleds { get; set; }
        public virtual DbSet<HostEvent> HostEvents { get; set; }
        public virtual DbSet<HostIssuedComp> HostIssuedComps { get; set; }
        public virtual DbSet<HostLog> HostLogs { get; set; }
        public virtual DbSet<HostNoContact> HostNoContacts { get; set; }
        public virtual DbSet<HostNote> HostNotes { get; set; }
        public virtual DbSet<HostNote1> HostNotes1 { get; set; }
        public virtual DbSet<HostNotesCategory> HostNotesCategories { get; set; }
        public virtual DbSet<HostPatronEmail> HostPatronEmails { get; set; }
        public virtual DbSet<HostReferral> HostReferrals { get; set; }
        public virtual DbSet<HostRole> HostRoles { get; set; }
        public virtual DbSet<HostSession> HostSessions { get; set; }
        public virtual DbSet<HostTaskAssigned> HostTaskAssigneds { get; set; }
        public virtual DbSet<HostTaskAutoGenerator> HostTaskAutoGenerators { get; set; }
        public virtual DbSet<HostTaskCategory> HostTaskCategories { get; set; }
        public virtual DbSet<HostTaskHost> HostTaskHosts { get; set; }
        public virtual DbSet<HostTaskManager> HostTaskManagers { get; set; }
        public virtual DbSet<HostTaskPatron> HostTaskPatrons { get; set; }
        public virtual DbSet<HostUnderSpotlightAlertEmail> HostUnderSpotlightAlertEmails { get; set; }
        public virtual DbSet<HostedAlert> HostedAlerts { get; set; }
        public virtual DbSet<HostedAlert1> HostedAlerts1 { get; set; }
        public virtual DbSet<HostedalertsBackup> HostedalertsBackups { get; set; }
        public virtual DbSet<HostsTemp> HostsTemps { get; set; }
        public virtual DbSet<HostsXrefMl> HostsXrefMls { get; set; }
        public virtual DbSet<HotSpotsBuyIn> HotSpotsBuyIns { get; set; }
        public virtual DbSet<HotSpotsRop> HotSpotsRops { get; set; }
        public virtual DbSet<HotSpotsUncardedJackpot> HotSpotsUncardedJackpots { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobParameter> JobParameters { get; set; }
        public virtual DbSet<JobQueue> JobQueues { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<NonHostedAlert> NonHostedAlerts { get; set; }
        public virtual DbSet<NonHostedAlert1> NonHostedAlerts1 { get; set; }
        public virtual DbSet<NotificationConfig> NotificationConfigs { get; set; }
        public virtual DbSet<ParamDate> ParamDates { get; set; }
        public virtual DbSet<ParamYear> ParamYears { get; set; }
        public virtual DbSet<PatronDailyStat> PatronDailyStats { get; set; }
        public virtual DbSet<PatronDailyStatsAdjusted> PatronDailyStatsAdjusteds { get; set; }
        public virtual DbSet<PatronDailyStatsOver100Adt> PatronDailyStatsOver100Adts { get; set; }
        public virtual DbSet<PatronDailyStatsRatingTime> PatronDailyStatsRatingTimes { get; set; }
        public virtual DbSet<PatronDailyStatsRatingTime1> PatronDailyStatsRatingTimes1 { get; set; }
        public virtual DbSet<PatronDailyStatsRedemption> PatronDailyStatsRedemptions { get; set; }
        public virtual DbSet<PatronDailyStatsRevenue> PatronDailyStatsRevenues { get; set; }
        public virtual DbSet<PatronLifecycle> PatronLifecycles { get; set; }
        public virtual DbSet<PatronLifecycle1> PatronLifecycles1 { get; set; }
        public virtual DbSet<PatronTripCount> PatronTripCounts { get; set; }
        public virtual DbSet<PatronTripSummary> PatronTripSummaries { get; set; }
        public virtual DbSet<PatronTripSummaryUpdate> PatronTripSummaryUpdates { get; set; }
        public virtual DbSet<Player90DayStat> Player90DayStats { get; set; }
        public virtual DbSet<PlayerPeriodStat> PlayerPeriodStats { get; set; }
        public virtual DbSet<PlayerUnderSpotlightAlert> PlayerUnderSpotlightAlerts { get; set; }
        public virtual DbSet<PlayersUnderSpotlight> PlayersUnderSpotlights { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<ReportAudit> ReportAudits { get; set; }
        public virtual DbSet<ReportMaster> ReportMasters { get; set; }
        public virtual DbSet<ReportParameter> ReportParameters { get; set; }
        public virtual DbSet<ReportProduct> ReportProducts { get; set; }
        public virtual DbSet<ReportProperty> ReportProperties { get; set; }
        public virtual DbSet<ReportSubscription> ReportSubscriptions { get; set; }
        public virtual DbSet<ReportSubscriptionArchive> ReportSubscriptionArchives { get; set; }
        public virtual DbSet<ReportUser> ReportUsers { get; set; }
        public virtual DbSet<ReportUserFavorite> ReportUserFavorites { get; set; }
        public virtual DbSet<ReportUserSecurity> ReportUserSecurities { get; set; }
        public virtual DbSet<Schema> Schemas { get; set; }
        public virtual DbSet<SecurityRole> SecurityRoles { get; set; }
        public virtual DbSet<SecurityRoleClaim> SecurityRoleClaims { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<Set> Sets { get; set; }
        public virtual DbSet<SlotMachineUnderSpotlight> SlotMachineUnderSpotlights { get; set; }
        public virtual DbSet<SourceAccountStatus> SourceAccountStatuses { get; set; }
        public virtual DbSet<SourceAccountStatus1> SourceAccountStatuses1 { get; set; }
        public virtual DbSet<SourceComp> SourceComps { get; set; }
        public virtual DbSet<SourceComp1> SourceComps1 { get; set; }
        public virtual DbSet<SourceCompAdjustment> SourceCompAdjustments { get; set; }
        public virtual DbSet<SourceEmployee> SourceEmployees { get; set; }
        public virtual DbSet<SourceEmployee1> SourceEmployees1 { get; set; }
        public virtual DbSet<SourceFavorite> SourceFavorites { get; set; }
        public virtual DbSet<SourceHostReferral> SourceHostReferrals { get; set; }
        public virtual DbSet<SourceHotelActivity> SourceHotelActivities { get; set; }
        public virtual DbSet<SourceNextCardLevel> SourceNextCardLevels { get; set; }
        public virtual DbSet<SourceOffersDay> SourceOffersDays { get; set; }
        public virtual DbSet<SourcePatron> SourcePatrons { get; set; }
        public virtual DbSet<SourcePatron1> SourcePatrons1 { get; set; }
        public virtual DbSet<SourcePatronAvg5Day> SourcePatronAvg5Days { get; set; }
        public virtual DbSet<SourcePatronBalance> SourcePatronBalances { get; set; }
        public virtual DbSet<SourcePatronBalance1> SourcePatronBalances1 { get; set; }
        public virtual DbSet<SourcePatronBanned> SourcePatronBanneds { get; set; }
        public virtual DbSet<SourcePatronCard> SourcePatronCards { get; set; }
        public virtual DbSet<SourcePatronClubLevel> SourcePatronClubLevels { get; set; }
        public virtual DbSet<SourcePatronClubLevel1> SourcePatronClubLevels1 { get; set; }
        public virtual DbSet<SourcePatronDailyStat> SourcePatronDailyStats { get; set; }
        public virtual DbSet<SourcePatronDailyStat1> SourcePatronDailyStats1 { get; set; }
        public virtual DbSet<SourcePatronDailyStatsAvgBet> SourcePatronDailyStatsAvgBets { get; set; }
        public virtual DbSet<SourcePatronEthnicity> SourcePatronEthnicities { get; set; }
        public virtual DbSet<SourcePatronFavorite> SourcePatronFavorites { get; set; }
        public virtual DbSet<SourcePatronFreePlayBalance> SourcePatronFreePlayBalances { get; set; }
        public virtual DbSet<SourcePatronFreePlayBalance1> SourcePatronFreePlayBalances1 { get; set; }
        public virtual DbSet<SourcePatronFrequency> SourcePatronFrequencies { get; set; }
        public virtual DbSet<SourcePatronFrequency6Month> SourcePatronFrequency6Months { get; set; }
        public virtual DbSet<SourcePatronFrequency6MonthsHistory> SourcePatronFrequency6MonthsHistories { get; set; }
        public virtual DbSet<SourcePatronFrequencyHistory> SourcePatronFrequencyHistories { get; set; }
        public virtual DbSet<SourcePatronHostReferral> SourcePatronHostReferrals { get; set; }
        public virtual DbSet<SourcePatronHostReferral1> SourcePatronHostReferrals1 { get; set; }
        public virtual DbSet<SourcePatronLastPosition> SourcePatronLastPositions { get; set; }
        public virtual DbSet<SourcePatronLastPosition1> SourcePatronLastPositions1 { get; set; }
        public virtual DbSet<SourcePatronMerge> SourcePatronMerges { get; set; }
        public virtual DbSet<SourcePatronNameAddress> SourcePatronNameAddresses { get; set; }
        public virtual DbSet<SourcePatronNameAddress1> SourcePatronNameAddresses1 { get; set; }
        public virtual DbSet<SourcePatronReinvestment> SourcePatronReinvestments { get; set; }
        public virtual DbSet<SourcePatronReinvestment1> SourcePatronReinvestments1 { get; set; }
        public virtual DbSet<SourcePitActivity> SourcePitActivities { get; set; }
        public virtual DbSet<SourcePokerActivity> SourcePokerActivities { get; set; }
        public virtual DbSet<SourceReferral> SourceReferrals { get; set; }
        public virtual DbSet<SourceSlotActivity> SourceSlotActivities { get; set; }
        public virtual DbSet<SourceSlotMachine> SourceSlotMachines { get; set; }
        public virtual DbSet<SourceSlotMachine1> SourceSlotMachines1 { get; set; }
        public virtual DbSet<SourceSlotMachineRevision> SourceSlotMachineRevisions { get; set; }
        public virtual DbSet<SourceSlotMachineRevision1> SourceSlotMachineRevisions1 { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StreakBuyoutAlert> StreakBuyoutAlerts { get; set; }
        public virtual DbSet<StreakBuyoutException> StreakBuyoutExceptions { get; set; }
        public virtual DbSet<SummaryByPeriod> SummaryByPeriods { get; set; }
        public virtual DbSet<SummaryByTrip> SummaryByTrips { get; set; }
        public virtual DbSet<SurveillanceAlert> SurveillanceAlerts { get; set; }
        public virtual DbSet<SurveillanceAlertEmail> SurveillanceAlertEmails { get; set; }
        public virtual DbSet<TaxRate> TaxRates { get; set; }
        public virtual DbSet<Top20LogPoker> Top20LogPokers { get; set; }
        public virtual DbSet<Top20LogPoker1> Top20LogPokers1 { get; set; }
        public virtual DbSet<Top20LogSlot> Top20LogSlots { get; set; }
        public virtual DbSet<Top20LogSlot1> Top20LogSlots1 { get; set; }
        public virtual DbSet<Top20LogTable> Top20LogTables { get; set; }
        public virtual DbSet<Top20LogTable1> Top20LogTables1 { get; set; }
        public virtual DbSet<TransactionIndex21ad9499C1a84722B3695e34c23a0851> TransactionIndex21ad9499C1a84722B3695e34c23a0851s { get; set; }
        public virtual DbSet<TransactionIndex77b58f20Fd424d4dA99cF1aec513bc29> TransactionIndex77b58f20Fd424d4dA99cF1aec513bc29s { get; set; }
        public virtual DbSet<ViewAllComp> ViewAllComps { get; set; }
        public virtual DbSet<ViewConfigAlert> ViewConfigAlerts { get; set; }
        public virtual DbSet<ViewConfigAlertAmlthreshold> ViewConfigAlertAmlthresholds { get; set; }
        public virtual DbSet<ViewConfigAlertCalendarReminder> ViewConfigAlertCalendarReminders { get; set; }
        public virtual DbSet<ViewConfigAlertContactThreshold> ViewConfigAlertContactThresholds { get; set; }
        public virtual DbSet<ViewConfigAlertCtrthreshold> ViewConfigAlertCtrthresholds { get; set; }
        public virtual DbSet<ViewConfigAlertCustomerServiceThreshold> ViewConfigAlertCustomerServiceThresholds { get; set; }
        public virtual DbSet<ViewConfigAlertJackpotThreshold> ViewConfigAlertJackpotThresholds { get; set; }
        public virtual DbSet<ViewConfigAlertSlotReferral> ViewConfigAlertSlotReferrals { get; set; }
        public virtual DbSet<ViewConfigAlertSlotThreshold> ViewConfigAlertSlotThresholds { get; set; }
        public virtual DbSet<ViewConfigAlertTableThreshold> ViewConfigAlertTableThresholds { get; set; }
        public virtual DbSet<ViewConfigAlertWhosHere> ViewConfigAlertWhosHeres { get; set; }
        public virtual DbSet<ViewConfigAlertsWithId> ViewConfigAlertsWithIds { get; set; }
        public virtual DbSet<ViewHostReferralCurrent> ViewHostReferralCurrents { get; set; }
        public virtual DbSet<ViewHostedReferredPatron> ViewHostedReferredPatrons { get; set; }
        public virtual DbSet<ViewLastContactDateTime> ViewLastContactDateTimes { get; set; }
        public virtual DbSet<ViewLastContactDateTimeView> ViewLastContactDateTimeViews { get; set; }
        public virtual DbSet<ViewPatronsIn24Hour> ViewPatronsIn24Hours { get; set; }
        public virtual DbSet<ViewReportSecurity> ViewReportSecurities { get; set; }
        public virtual DbSet<ViewSourceCompsAdjusted> ViewSourceCompsAdjusteds { get; set; }
        public virtual DbSet<ViewSourceCompsComp> ViewSourceCompsComps { get; set; }
        public virtual DbSet<ViewSourceCompsExpired> ViewSourceCompsExpireds { get; set; }
        public virtual DbSet<ViewSourceCompsVoid> ViewSourceCompsVoids { get; set; }
        public virtual DbSet<ViewWhosHereLastPosition> ViewWhosHereLastPositions { get; set; }
        public virtual DbSet<ViewWhosHerePokerMostRecent> ViewWhosHerePokerMostRecents { get; set; }
        public virtual DbSet<ViewWhosHereSlotMostRecent> ViewWhosHereSlotMostRecents { get; set; }
        public virtual DbSet<ViewWhosHereTableMostRecent> ViewWhosHereTableMostRecents { get; set; }
        public virtual DbSet<VwHostWithPlayerHosted> VwHostWithPlayerHosteds { get; set; }
        public virtual DbSet<WhosHereHotel> WhosHereHotels { get; set; }
        public virtual DbSet<WhosHereHotel1> WhosHereHotels1 { get; set; }
        public virtual DbSet<WhosHerePoker> WhosHerePokers { get; set; }
        public virtual DbSet<WhosHerePoker1> WhosHerePokers1 { get; set; }
        public virtual DbSet<WhosHereSlot> WhosHereSlots { get; set; }
        public virtual DbSet<WhosHereSlot1> WhosHereSlots1 { get; set; }
        public virtual DbSet<WhosHereTable> WhosHereTables { get; set; }
        public virtual DbSet<WhosHereTable1> WhosHereTables1 { get; set; }
        public virtual DbSet<PlayerReportModel> PlayerReportModel { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<PlayerReportModel>(entity =>
            {
                entity.HasNoKey();
                entity.Property(e => e.OtherLastContact).HasColumnType("datetime");
                entity.Property(e => e.LastVisit).HasColumnType("datetime");
                entity.Property(e => e.PatronHostLastContact).HasColumnType("datetime");

                entity.Property(e => e.Prop90Tips).HasColumnType("int").HasColumnName("90Trips");
                entity.Property(e => e.Prop90ADA).HasColumnType("decimal(14, 9)").HasColumnName("90ADA");
                entity.Property(e => e.Prop90ADT).HasColumnType("decimal(14, 9)").HasColumnName("90ADT");

            });
            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.Key, "UX_HangFire_CounterAggregated_Key")
                    .IsUnique();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AlertTitle31PlayerRaw>(entity =>
            {
                entity.HasKey(e => e.AlertId);

                entity.ToTable("AlertTitle31PlayerRaw");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.TotalBuyIn).HasColumnType("money");
            });

            modelBuilder.Entity<AlertsConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AlertsConfig", "Reporting");

                entity.Property(e => e.AlertType).HasMaxLength(30);

                entity.Property(e => e.AlertTypeId).HasColumnName("AlertTypeID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ArchiveHostPatronEmail>(entity =>
            {
                entity.HasKey(e => e.EmailKey)
                    .HasName("PK_dbo.ArchiveHostPatronEmails");

                entity.Property(e => e.EmailKey).ValueGeneratedNever();

                entity.Property(e => e.EmailMessage).IsRequired();

                entity.Property(e => e.EmailSubject)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FromHostEmailAddress)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ToPatronEmailAddress)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ArchiveSourcePatron>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.AlternativePhone).HasMaxLength(250);

                entity.Property(e => e.AnniversaryDate).HasColumnType("datetime");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.Country).HasMaxLength(250);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.DateTimeAdded).HasColumnType("datetime");

                entity.Property(e => e.DateTimeUpdated).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.Property(e => e.Ethnicity).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.Gender).HasMaxLength(250);

                entity.Property(e => e.HomePhone).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.MiddleInitial).HasMaxLength(1);

                entity.Property(e => e.Nickname).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.Referral).HasMaxLength(250);

                entity.Property(e => e.State).HasMaxLength(250);

                entity.Property(e => e.StreetAddress1).HasMaxLength(250);

                entity.Property(e => e.StreetAddress2).HasMaxLength(250);

                entity.Property(e => e.WeddingAnniversaryDate).HasColumnType("datetime");

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ArchiveWhosHere>(entity =>
            {
                entity.HasKey(e => e.ArchiveAlertId);

                entity.ToTable("ArchiveWhosHere");

                entity.Property(e => e.Activity).HasMaxLength(250);

                entity.Property(e => e.ActivityDateTime).HasColumnType("datetime");

                entity.Property(e => e.Adt).HasColumnName("ADT");

                entity.Property(e => e.AlertSentTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(250);

                entity.Property(e => e.RecipientEmailAddress).HasMaxLength(250);
            });

            modelBuilder.Entity<ArchivedAlert>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ArchivedAlerts", "Reporting");

                entity.Property(e => e.Ada)
                    .HasColumnType("money")
                    .HasColumnName("ADA");

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.AlertSentDate).HasColumnType("datetime");

                entity.Property(e => e.AlertType).HasMaxLength(100);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(501);

                entity.Property(e => e.MaxAlertSentTimestamp).HasColumnType("datetime");

                entity.Property(e => e.NextContactDate).HasColumnType("datetime");

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(501);
            });

            modelBuilder.Entity<ArchivedAlert1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ArchivedAlerts", "rpt");

                entity.Property(e => e.Ada)
                    .HasColumnType("money")
                    .HasColumnName("ADA");

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.AlertSentDate).HasColumnType("datetime");

                entity.Property(e => e.AlertType).HasMaxLength(100);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(501);

                entity.Property(e => e.MaxAlertSentTimestamp).HasColumnType("datetime");

                entity.Property(e => e.NextContactDate).HasColumnType("datetime");

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(501);
            });

            modelBuilder.Entity<ArchivedAlertsOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ArchivedAlertsOld", "Reporting");

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.AlertSentDate).HasColumnType("datetime");

                entity.Property(e => e.AlertType).HasMaxLength(100);

                entity.Property(e => e.HostName).HasMaxLength(50);

                entity.Property(e => e.MaxAlertSentTimestamp).HasColumnType("datetime");

                entity.Property(e => e.NextContactDate).HasColumnType("datetime");

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(501);
            });

            modelBuilder.Entity<AuditSourcePatron>(entity =>
            {
                entity.HasKey(e => e.AuditKey)
                    .HasName("PK_dbo.AuditSourcePatrons");

                entity.Property(e => e.CellPhone).HasMaxLength(250);

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.Country).HasMaxLength(250);

                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.Property(e => e.Ethnicity).HasMaxLength(250);

                entity.Property(e => e.HomePhone).HasMaxLength(250);

                entity.Property(e => e.NickName).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.State).HasMaxLength(250);

                entity.Property(e => e.StreetAddress1).HasMaxLength(250);

                entity.Property(e => e.StreetAddress2).HasMaxLength(250);

                entity.Property(e => e.ZipCode).HasMaxLength(250);
            });

            modelBuilder.Entity<ChangeCompContactLog>(entity =>
            {
                entity.HasKey(e => e.CompContactLogId);

                entity.ToTable("changeCompContactLogs", "mdl");

                entity.Property(e => e.CompContactLogId).ValueGeneratedNever();

                entity.Property(e => e.ContactDateTime).HasColumnType("datetime");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.PatronId)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ChangeHost>(entity =>
            {
                entity.HasKey(e => e.HostsId)
                    .HasName("PK_mdlchangeHosts");

                entity.ToTable("changeHosts", "mdl");

                entity.Property(e => e.HostsId).ValueGeneratedNever();

                entity.Property(e => e.ActiveFlag).HasMaxLength(1);

                entity.Property(e => e.AllowSelect).HasMaxLength(1);

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.HostUserName).HasMaxLength(250);

                entity.Property(e => e.LdapuserName)
                    .HasMaxLength(250)
                    .HasColumnName("LDAPUserName");
            });

            modelBuilder.Entity<ChangeHostsXrefMl>(entity =>
            {
                entity.HasKey(e => e.HostsXrefId)
                    .HasName("PK_mdlchangeHostsXRef");

                entity.ToTable("changeHostsXRef_ML", "mdl");

                entity.Property(e => e.HostsXrefId)
                    .ValueGeneratedNever()
                    .HasColumnName("HostsXRefId");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.HostStatus).HasMaxLength(1);

                entity.Property(e => e.HostUserName).HasMaxLength(250);

                entity.Property(e => e.PlayerStatus).HasMaxLength(250);

                entity.Property(e => e.XrefHostStatus)
                    .HasMaxLength(1)
                    .HasColumnName("XRefHostStatus");

                entity.Property(e => e.XrefHostUserId).HasColumnName("XRefHostUserId");

                entity.Property(e => e.XrefHostUserName)
                    .HasMaxLength(250)
                    .HasColumnName("XRefHostUserName");
            });

            modelBuilder.Entity<ChangePatronStatus>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.PlayerBk })
                    .HasName("PK_mdlchangePatronStatus");

                entity.ToTable("changePatronStatus", "mdl");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<ChangePatronTripCount>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("changePatronTripCount", "mdl");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.MaxDate).HasColumnType("datetime");

                entity.Property(e => e.MinDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChangeSummaryByPeriod>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("changeSummaryByPeriod", "mdl");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.Crc).HasColumnName("CRC");
            });

            modelBuilder.Entity<ChangeSummaryByTrip>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("changeSummaryByTrip", "mdl");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.ActualWin).HasColumnType("money");

                entity.Property(e => e.CashIn).HasColumnType("money");

                entity.Property(e => e.CompsAdjusted).HasColumnType("money");

                entity.Property(e => e.CompsRedeemed).HasColumnType("money");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.DollarsAdjusted).HasColumnType("money");

                entity.Property(e => e.DollarsRedeemed).HasColumnType("money");

                entity.Property(e => e.FreePlayPlayed).HasColumnType("money");

                entity.Property(e => e.PeriodAda)
                    .HasColumnType("money")
                    .HasColumnName("PeriodADA");

                entity.Property(e => e.PeriodAdt)
                    .HasColumnType("money")
                    .HasColumnName("PeriodADT");

                entity.Property(e => e.PeriodDesc).HasMaxLength(250);

                entity.Property(e => e.Redemptions).HasColumnType("money");

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.TheoWin).HasColumnType("money");
            });

            modelBuilder.Entity<CompContactLog>(entity =>
            {
                entity.ToTable("CompContactLogs", "mdl");

                entity.Property(e => e.ContactDateTime).HasColumnType("datetime");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.PatronId)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ConfigAlertEmailTo>(entity =>
            {
                entity.HasKey(e => e.AlertEmailToId)
                    .HasName("PK_dbo.ConfigAlertSubTypes");

                entity.ToTable("ConfigAlertEmailTo", "mdl");
            });

            modelBuilder.Entity<ConfigAlertSubType>(entity =>
            {
                entity.HasKey(e => e.AlertSubTypeId)
                    .HasName("PK_dbo.ConfigAlertSubTypes");

                entity.Property(e => e.SubTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConfigAlertType>(entity =>
            {
                entity.HasKey(e => e.AlertTypeId)
                    .HasName("PK_dbo.configAlertTypes");

                entity.Property(e => e.AlertName).HasMaxLength(100);

                entity.Property(e => e.EmailHeaderCasinoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Htmlenabled).HasColumnName("HTMLEnabled");

                entity.Property(e => e.ProfileName).HasMaxLength(100);

                entity.Property(e => e.RecipientMail).HasMaxLength(250);
            });

            modelBuilder.Entity<ConfigAlertValue>(entity =>
            {
                entity.HasKey(e => e.AlertValueId)
                    .HasName("PK_dbo.ConfigAlertValues");

                entity.HasIndex(e => e.AlertTypeId, "IX_ConfigAlertValues");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ConfigCardLevel>(entity =>
            {
                entity.HasKey(e => e.CardLevelKey)
                    .HasName("PK_dbo.ConfigCardLevels");

                entity.Property(e => e.BgcardLevelColor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("BGCardLevelColor");

                entity.Property(e => e.CardLevelColor)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CardLevelEndDate).HasColumnType("datetime");

                entity.Property(e => e.CardLevelName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CardLevelStartDate).HasColumnType("datetime");

                entity.Property(e => e.CardLevelTextColor)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DisplayVvipicon)
                    .HasColumnName("DisplayVVIPIcon")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ConfigDate>(entity =>
            {
                entity.HasKey(e => e.DateKey)
                    .HasName("PK_dbo.ConfigDate");

                entity.ToTable("ConfigDate");

                entity.HasIndex(e => e.ActualDate, "IDX_ActualDate")
                    .IsUnique();

                entity.Property(e => e.ActualDate).HasColumnType("datetime");

                entity.Property(e => e.Isoweek).HasColumnName("ISOWeek");
            });

            modelBuilder.Entity<ConfigDatum>(entity =>
            {
                entity.HasKey(e => e.ConfigDataId)
                    .HasName("PK_dbo.ConfigData");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DurationType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ConfigDaysOfWeek>(entity =>
            {
                entity.HasKey(e => e.DaysOfWeekId)
                    .HasName("PK_dbo.ConfigDaysOfWeek");

                entity.ToTable("ConfigDaysOfWeek");

                entity.Property(e => e.DayOfWeek).HasMaxLength(2);
            });

            modelBuilder.Entity<ConfigFiscalYear>(entity =>
            {
                entity.HasKey(e => e.FiscalYearId)
                    .HasName("PK_FiscalYears");

                entity.Property(e => e.EndQ1).HasColumnType("datetime");

                entity.Property(e => e.EndQ2).HasColumnType("datetime");

                entity.Property(e => e.EndQ3).HasColumnType("datetime");

                entity.Property(e => e.EndQ4).HasColumnType("datetime");

                entity.Property(e => e.StartQ1).HasColumnType("datetime");

                entity.Property(e => e.StartQ2).HasColumnType("datetime");

                entity.Property(e => e.StartQ3).HasColumnType("datetime");

                entity.Property(e => e.StartQ4).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConfigHoursOfDay>(entity =>
            {
                entity.HasKey(e => e.HoursOfDayId)
                    .HasName("PK_dbo.ConfigHoursOfDay");

                entity.ToTable("ConfigHoursOfDay");

                entity.Property(e => e.HourToDisplay).HasMaxLength(50);
            });

            modelBuilder.Entity<ConfigPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId)
                    .HasName("PK_Period");

                entity.Property(e => e.PeriodDesc).HasMaxLength(250);

                entity.Property(e => e.PeriodType).HasMaxLength(1);
            });

            modelBuilder.Entity<ConfigProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(e => e.ConnectionString).HasMaxLength(250);

                entity.Property(e => e.SsispackageRoute).HasColumnName("SSISPackageRoute");
            });

            modelBuilder.Entity<ConfigProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeId);

                entity.Property(e => e.Activity).HasMaxLength(250);

                entity.Property(e => e.ProductType).HasMaxLength(250);
            });

            modelBuilder.Entity<ConfigProperty>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.HasIndex(e => e.PropertyId, "IX_ConfigProperties");

                entity.Property(e => e.Adtdays).HasColumnName("ADTDays");

                entity.Property(e => e.Adttype).HasColumnName("ADTType");

                entity.Property(e => e.AllowComps)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BaseClubLevel)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CompContactLogCategoryId).HasDefaultValueSql("((3))");

                entity.Property(e => e.CompNoteCategoryId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CompTextLineMemo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('On Floor Comp Issued')");

                entity.Property(e => e.DomainName).HasMaxLength(250);

                entity.Property(e => e.EmailCompTo)
                    .IsRequired()
                    .HasDefaultValueSql("('support@icintelligence.com')");

                entity.Property(e => e.EmailEnrollmentTo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('support@icintelligence.com')");

                entity.Property(e => e.EnableGeolocationFeature)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ExpireHostUnit)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ExpireReferralUnit)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.HasHosts).HasMaxLength(1);

                entity.Property(e => e.HostManagerEmail).HasMaxLength(250);

                entity.Property(e => e.LastGamingDate).HasColumnType("datetime");

                entity.Property(e => e.MaxComp).HasColumnType("money");

                entity.Property(e => e.MaxCompApplyTo).HasMaxLength(250);

                entity.Property(e => e.MaxCompMonthly).HasColumnType("money");

                entity.Property(e => e.MaxCompWeekly).HasColumnType("money");

                entity.Property(e => e.NewSignupDefaultSort)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('TW')");

                entity.Property(e => e.Online).HasMaxLength(1);

                entity.Property(e => e.PitActualWinFlag).HasMaxLength(1);

                entity.Property(e => e.PitActualWinThreshold).HasColumnType("money");

                entity.Property(e => e.PitCoinInFlag).HasMaxLength(1);

                entity.Property(e => e.PitCoinInThreshold).HasColumnType("money");

                entity.Property(e => e.PitJackpotThreshold).HasColumnType("money");

                entity.Property(e => e.PitTheoWinFlag).HasMaxLength(1);

                entity.Property(e => e.PitTheoWinThreshold).HasColumnType("money");

                entity.Property(e => e.PlayersClubEmail).HasMaxLength(250);

                entity.Property(e => e.Property).HasMaxLength(250);

                entity.Property(e => e.RibbonStats).HasMaxLength(1);

                entity.Property(e => e.SearchResultAddress)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SearchResultCardLevel)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SearchResultEmail)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SearchResultEthnicity)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SearchResultGender)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SearchResultHost)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SearchResultName)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SearchResultPatronId)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SearchResultStatus)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SlotActualWinFlag).HasMaxLength(1);

                entity.Property(e => e.SlotActualWinThreshold).HasColumnType("money");

                entity.Property(e => e.SlotCoinInFlag).HasMaxLength(1);

                entity.Property(e => e.SlotCoinInThreshold).HasColumnType("money");

                entity.Property(e => e.SlotJackpotThreshold).HasColumnType("money");

                entity.Property(e => e.SlotTheoWinFlag).HasMaxLength(1);

                entity.Property(e => e.SlotTheoWinThreshold).HasColumnType("money");

                entity.Property(e => e.TimeRemove).HasMaxLength(250);

                entity.Property(e => e.Top20DefaultSort)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('TW')");

                entity.Property(e => e.Version).HasMaxLength(250);

                entity.Property(e => e.Xmlpath)
                    .HasMaxLength(250)
                    .HasColumnName("XMLPath");
            });

            modelBuilder.Entity<ConfigRfm>(entity =>
            {
                entity.HasKey(e => e.Rfmid)
                    .HasName("PK_RFM");

                entity.ToTable("ConfigRFM");

                entity.Property(e => e.Rfmid).HasColumnName("RFMId");

                entity.Property(e => e.RfmfrequencyFrom).HasColumnName("RFMFrequencyFrom");

                entity.Property(e => e.RfmfrequencyTo).HasColumnName("RFMFrequencyTo");

                entity.Property(e => e.RfmgamingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RFMGamingDate");

                entity.Property(e => e.RfmmonetaryFrom)
                    .HasColumnType("money")
                    .HasColumnName("RFMMonetaryFrom");

                entity.Property(e => e.RfmmonetaryTo)
                    .HasColumnType("money")
                    .HasColumnName("RFMMonetaryTo");

                entity.Property(e => e.RfmpercentFrom).HasColumnName("RFMPercentFrom");

                entity.Property(e => e.RfmpercentTo).HasColumnName("RFMPercentTo");

                entity.Property(e => e.RfmperiodDays).HasColumnName("RFMPeriodDays");

                entity.Property(e => e.RfmpropertyId).HasColumnName("RFMPropertyId");

                entity.Property(e => e.RfmrecencyFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("RFMRecencyFrom");

                entity.Property(e => e.RfmrecencyTo)
                    .HasColumnType("datetime")
                    .HasColumnName("RFMRecencyTo");

                entity.Property(e => e.Rfmscore).HasColumnName("RFMScore");
            });

            modelBuilder.Entity<ConfigRfmdate>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_RFMDate");

                entity.ToTable("ConfigRFMDate");

                entity.Property(e => e.RfmgamingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RFMGamingDate");
            });

            modelBuilder.Entity<ConfigRfmpatron>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_RFMPatrons");

                entity.ToTable("ConfigRFMPatrons");

                entity.HasIndex(e => new { e.RecType, e.PropertyId }, "IDX_RFM_Frequency")
                    .HasFilter("([RecType]='F')");

                entity.HasIndex(e => new { e.RecType, e.PropertyId }, "IDX_RFM_Monetary")
                    .HasFilter("([RecType]='M')");

                entity.HasIndex(e => new { e.RecType, e.PropertyId }, "IDX_RFM_Recency")
                    .HasFilter("([RecType]='R')");

                entity.Property(e => e.Monetary).HasColumnType("money");

                entity.Property(e => e.PatronId)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RecType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Recency).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConfigRfmscore>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_changeRFMScores");

                entity.ToTable("ConfigRFMScores", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.Monetary).HasColumnType("money");

                entity.Property(e => e.Recency).HasColumnType("datetime");

                entity.Property(e => e.Rfmpercent).HasColumnName("RFMPercent");

                entity.Property(e => e.Rfmscore).HasColumnName("RFMScore");
            });

            modelBuilder.Entity<ConfigRfmscore1>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_RFMScores");

                entity.ToTable("ConfigRFMScores");

                entity.HasIndex(e => new { e.PropertyId, e.PatronId, e.GamingDate }, "IDX_PropertyId_PatronId_GamingDate")
                    .IsUnique();

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.Monetary).HasColumnType("money");

                entity.Property(e => e.PatronId)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Recency).HasColumnType("datetime");

                entity.Property(e => e.Rfmpercent).HasColumnName("RFMPercent");

                entity.Property(e => e.Rfmscore).HasColumnName("RFMScore");
            });

            modelBuilder.Entity<ContactLog>(entity =>
            {
                entity.HasIndex(e => e.PatronId, "IDX_PatronId");

                entity.HasIndex(e => new { e.PropertyId, e.ContactDateTime }, "IXContactLogByContactTime");

                entity.HasIndex(e => new { e.PropertyId, e.ContactDateTime }, "IXContactLogByContactTime2");

                entity.HasIndex(e => new { e.PropertyId, e.PatronId, e.ContactTypeId }, "IX_ContactLogs");

                entity.HasIndex(e => e.ContactLogId, "IX_ContactLogs_1");

                entity.HasIndex(e => e.PropertyId, "IX_ContactLogs_2");

                entity.HasIndex(e => e.ContactTypeId, "IX_ContactLogs_ContactTypeId");

                entity.HasIndex(e => e.PropertyId, "IX_ContactLogs_PropertyId");

                entity.HasIndex(e => new { e.PropertyId, e.ContactHostId }, "IX_ContactLogs_PropertyId_ContactHostId");

                entity.HasIndex(e => new { e.PropertyId, e.PatronId, e.ContactDateTime }, "IX_PropertyId_PatronId_ContactDateTime");

                entity.HasIndex(e => new { e.PropertyId, e.ContactHostId }, "IX_UserDigestReport");

                entity.Property(e => e.AttachmentUrl).HasMaxLength(250);

                entity.Property(e => e.ContactDateTime).HasColumnType("datetime");

                entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PatronId).HasMaxLength(250);

                entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.ContactLogs)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ContactLogs_dbo.ContactTypes_ContactTypeId");
            });

            modelBuilder.Entity<ContactLogsAudit>(entity =>
            {
                entity.HasKey(e => e.ContactLogId)
                    .HasName("PK_dbo.ContactLogsAudit");

                entity.ToTable("ContactLogsAudit");

                entity.Property(e => e.ContactLogId).ValueGeneratedNever();

                entity.Property(e => e.AttachmentUrl).HasMaxLength(250);

                entity.Property(e => e.ContactDateTime).HasColumnType("datetime");

                entity.Property(e => e.ContactLogAuditId).ValueGeneratedOnAdd();

                entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PatronId).HasMaxLength(250);
            });

            modelBuilder.Entity<ContactSigned>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ContactSigned", "Reporting");

                entity.Property(e => e.ContactDateTime).HasColumnType("datetime");

                entity.Property(e => e.ContactHostName).HasMaxLength(501);

                entity.Property(e => e.ContactType).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.OtherHostName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatronId).HasMaxLength(250);

                entity.Property(e => e.SignId).HasColumnName("SignID");

                entity.Property(e => e.Signed)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.Property(e => e.AllowContactLog).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactType1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ContactType");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsEmail).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key, "IX_HangFire_Counter_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Csr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CSR", "security");

                entity.Property(e => e.HostUserName).HasMaxLength(501);

                entity.Property(e => e.Property).HasMaxLength(250);

                entity.Property(e => e.UserAd)
                    .HasMaxLength(501)
                    .HasColumnName("UserAD");
            });

            modelBuilder.Entity<DailyHostSummaryCount>(entity =>
            {
                entity.HasKey(e => e.DailyCountsId)
                    .HasName("PK_changeDailyHostSummaryCounts");

                entity.ToTable("DailyHostSummaryCounts", "change");

                entity.Property(e => e.DailyCountsId).ValueGeneratedNever();

                entity.Property(e => e.GamingDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DailyHostSummaryCount1>(entity =>
            {
                entity.HasKey(e => e.DailyCountsId);

                entity.ToTable("DailyHostSummaryCounts", "report");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DailyRoisummary>(entity =>
            {
                entity.ToTable("DailyROISummary", "report");

                entity.Property(e => e.DailyRoisummaryId).HasColumnName("DailyROISummaryId");

                entity.Property(e => e.Adaafter)
                    .HasColumnType("money")
                    .HasColumnName("ADAAfter");

                entity.Property(e => e.Adabefore)
                    .HasColumnType("money")
                    .HasColumnName("ADABefore");

                entity.Property(e => e.Adaincrease)
                    .HasColumnType("money")
                    .HasColumnName("ADAIncrease");

                entity.Property(e => e.Adtafter)
                    .HasColumnType("money")
                    .HasColumnName("ADTAfter");

                entity.Property(e => e.Adtbefore)
                    .HasColumnType("money")
                    .HasColumnName("ADTBefore");

                entity.Property(e => e.Adtincrease)
                    .HasColumnType("money")
                    .HasColumnName("ADTIncrease");

                entity.Property(e => e.CardLevel).HasMaxLength(250);

                entity.Property(e => e.FirstContactMade).HasColumnType("datetime");

                entity.Property(e => e.LastContactMade).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.LastVisit).HasColumnType("datetime");

                entity.Property(e => e.PatronId).HasMaxLength(250);

                entity.Property(e => e.PatronName).HasMaxLength(250);

                entity.Property(e => e.TotalActualAfter).HasColumnType("money");

                entity.Property(e => e.TotalActualBefore).HasColumnType("money");

                entity.Property(e => e.TotalActualIncrease).HasColumnType("money");

                entity.Property(e => e.TotalTheoAfter).HasColumnType("money");

                entity.Property(e => e.TotalTheoBefore).HasColumnType("money");

                entity.Property(e => e.TotalTheoIncrease).HasColumnType("money");
            });

            modelBuilder.Entity<Dapuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DAPUsers", "temp");

                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.Property(e => e.RecId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeclinerAlert>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("DeclinerAlert", "mdl");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<EmailAlert>(entity =>
            {
                entity.HasKey(e => e.AlertId)
                    .HasName("PK_Alerts");

                entity.Property(e => e.Activity).HasMaxLength(250);

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.AlertSent).HasMaxLength(1);

                entity.Property(e => e.AlertSentTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.HostFullName).HasMaxLength(250);

                entity.Property(e => e.JackpotAmount).HasColumnType("money");

                entity.Property(e => e.LastActivity).HasColumnType("datetime");

                entity.Property(e => e.LastContactDate).HasColumnType("datetime");

                entity.Property(e => e.LastContactDateText).HasMaxLength(250);

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.Pit).HasMaxLength(250);

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(250);

                entity.Property(e => e.TableId).HasMaxLength(250);

                entity.Property(e => e.TablePosition).HasMaxLength(250);

                entity.Property(e => e.TheoWin).HasColumnType("money");

                entity.Property(e => e.TotalBuyIn).HasColumnType("money");

                entity.Property(e => e.UniversalId).HasMaxLength(250);

                entity.Property(e => e.WinLoss).HasColumnType("money");

                entity.Property(e => e._24hourActualWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourActualWin");

                entity.Property(e => e._24hourCashIn)
                    .HasColumnType("money")
                    .HasColumnName("24HourCashIn");

                entity.Property(e => e._24hourTheoWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourTheoWin");
            });

            modelBuilder.Entity<EmailAlertsArchive>(entity =>
            {
                entity.HasKey(e => e.AlertId)
                    .HasName("PK_AlertsArchive");

                entity.ToTable("EmailAlertsArchive");

                entity.HasIndex(e => e.GamingDate, "IDX_GamingDate_Include");

                entity.HasIndex(e => new { e.PropertyId, e.AlertTypeId, e.PlayerId, e.AlertSentTimestamp }, "IDX_PropertyId_AlertTypeId_PlayerId_AlertSentTimestamp");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerId, e.GamingDate }, "IDX_PropertyId_PlayerId_GamingDate");

                entity.Property(e => e.Activity).HasMaxLength(250);

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.AlertSentTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.HostFullName).HasMaxLength(250);

                entity.Property(e => e.JackpotAmount).HasColumnType("money");

                entity.Property(e => e.LastActivity).HasColumnType("datetime");

                entity.Property(e => e.LastContactDate).HasColumnType("datetime");

                entity.Property(e => e.LastContactDateText).HasMaxLength(250);

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.Pit).HasMaxLength(250);

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(250);

                entity.Property(e => e.RecipientEmailAddress).HasMaxLength(250);

                entity.Property(e => e.TableId).HasMaxLength(250);

                entity.Property(e => e.TablePosition).HasMaxLength(250);

                entity.Property(e => e.TheoWin).HasColumnType("money");

                entity.Property(e => e.TotalBuyIn).HasColumnType("money");

                entity.Property(e => e.UniversalId).HasMaxLength(250);

                entity.Property(e => e.WinLoss).HasColumnType("money");

                entity.Property(e => e._24hourActualWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourActualWin");

                entity.Property(e => e._24hourCashIn)
                    .HasColumnType("money")
                    .HasColumnName("24HourCashIn");

                entity.Property(e => e._24hourTheoWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourTheoWin");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Employee", "security");

                entity.Property(e => e.Administrator).HasMaxLength(1);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName).HasMaxLength(501);

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.UserAd)
                    .HasMaxLength(501)
                    .HasColumnName("UserAD");
            });

            modelBuilder.Entity<EmployeeComp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeComps", "Reporting");

                entity.Property(e => e.Comp).HasColumnType("money");

                entity.Property(e => e.CompDescription).HasMaxLength(250);

                entity.Property(e => e.CompType)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.HostId).HasColumnName("HostID");

                entity.Property(e => e.HostName).HasMaxLength(501);

                entity.Property(e => e.IssueDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.PlayerName).HasMaxLength(501);

                entity.Property(e => e.PrizeId).HasColumnName("Prize_ID");

                entity.Property(e => e.SettleDateTime).HasColumnType("datetime");

                entity.Property(e => e.VoidDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ethnicity>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt");

                entity.HasIndex(e => e.Key, "IX_HangFire_Hash_Key");

                entity.HasIndex(e => new { e.Key, e.Field }, "UX_HangFire_Hash_Key_Field")
                    .IsUnique();

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HeatConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HeatConfig", "Reporting");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.Descr).HasMaxLength(250);
            });

            modelBuilder.Entity<Host>(entity =>
            {
                entity.HasKey(e => e.HostsId)
                    .HasName("PK_changeHosts");

                entity.ToTable("Hosts", "change");

                entity.Property(e => e.HostsId).ValueGeneratedNever();

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.HostUserName).HasMaxLength(250);
            });

            modelBuilder.Entity<Host1>(entity =>
            {
                entity.HasKey(e => e.HostsId);

                entity.ToTable("Hosts");

                entity.HasIndex(e => new { e.PropertyId, e.HostUserId }, "IX_Hosts");

                entity.HasIndex(e => e.PropertyId, "IX_Hosts_1");

                entity.Property(e => e.ActiveFlag).HasMaxLength(1);

                entity.Property(e => e.Administrator).HasMaxLength(1);

                entity.Property(e => e.Adtflag)
                    .IsRequired()
                    .HasColumnName("ADTFlag")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AllHostsFlag).HasMaxLength(1);

                entity.Property(e => e.AllowLogin)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AllowSelect).HasMaxLength(1);

                entity.Property(e => e.ChangeHostFlag).HasMaxLength(1);

                entity.Property(e => e.ChangeReferralFlag).HasMaxLength(1);

                entity.Property(e => e.CompDollarsFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Crc)
                    .HasColumnName("CRC")
                    .HasDefaultValueSql("((-9))");

                entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");

                entity.Property(e => e.HostEmail).HasMaxLength(250);

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.HostPassword).HasMaxLength(50);

                entity.Property(e => e.HostUserName).HasMaxLength(250);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChange).HasColumnType("datetime");

                entity.Property(e => e.LastVisitFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LdapuserName)
                    .HasMaxLength(255)
                    .HasColumnName("LDAPUserName");

                entity.Property(e => e.PointsFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SendAlerts).HasMaxLength(1);

                entity.Property(e => e.SendVvipalerts).HasColumnName("SendVVIPAlerts");

                entity.Property(e => e.Sqlsearch)
                    .HasMaxLength(3000)
                    .HasColumnName("SQLSearch");

                entity.Property(e => e.SystemAdministrator).HasMaxLength(1);

                entity.Property(e => e.TemporaryPassword).HasMaxLength(250);

                entity.Property(e => e.TheoTodayFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TheoYesterdayFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TripsLast90Flag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TripsThisYearFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Host2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Hosts", "security");

                entity.Property(e => e.HostUserName).HasMaxLength(501);

                entity.Property(e => e.Property).HasMaxLength(250);

                entity.Property(e => e.UserAd)
                    .HasMaxLength(501)
                    .HasColumnName("UserAD");
            });

            modelBuilder.Entity<HostDeviceSession>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.HostId, e.HostUserId, e.DeviceId, e.Ipaddress })
                    .HasName("PK_dbo.HostDeviceSessions");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(128)
                    .HasColumnName("IPAddress")
                    .HasDefaultValueSql("('127.0.0.1')");
            });

            modelBuilder.Entity<HostEnrolled>(entity =>
            {
                entity.ToTable("HostEnrolled");

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.Country).HasMaxLength(250);

                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Gender).HasMaxLength(1);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.IdNumber).HasMaxLength(250);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MiddleInitial).HasMaxLength(1);

                entity.Property(e => e.State).HasMaxLength(250);

                entity.Property(e => e.StreetAddress1).HasMaxLength(250);

                entity.Property(e => e.StreetAddress2).HasMaxLength(250);

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<HostEvent>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.Property(e => e.DateTimeCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateTimeDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateTimeEntered).HasColumnType("datetime");

                entity.Property(e => e.DateTimeLastUpdated).HasColumnType("datetime");

                entity.Property(e => e.DateTimeReminderRemoved).HasColumnType("datetime");

                entity.Property(e => e.DateTimeReminderSet).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.ReminderDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReminderEndDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<HostIssuedComp>(entity =>
            {
                entity.Property(e => e.CompensationAmmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PatronId)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<HostLog>(entity =>
            {
                entity.ToTable("HostLog");

                entity.Property(e => e.LoginDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<HostNoContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HostNoContact", "Reporting");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.AlternativePhone).HasMaxLength(250);

                entity.Property(e => e.Banned).HasMaxLength(50);

                entity.Property(e => e.CardLevel).HasMaxLength(250);

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.Homephone).HasMaxLength(250);

                entity.Property(e => e.LastContact).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.LastVisit).HasColumnType("datetime");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerID");

                entity.Property(e => e.State).HasMaxLength(250);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(50)
                    .HasColumnName("zipcode");
            });

            modelBuilder.Entity<HostNote>(entity =>
            {
                entity.HasKey(e => e.NotesId)
                    .HasName("PK_ChangeHostNotes");

                entity.ToTable("HostNotes", "change");

                entity.Property(e => e.NotesId).ValueGeneratedNever();

                entity.Property(e => e.DateTimeCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateTimeDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateTimeReminderRemoved).HasColumnType("datetime");

                entity.Property(e => e.DateTimeReminderSet).HasColumnType("datetime");

                entity.Property(e => e.ExternalKeyField).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.ReminderDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<HostNote1>(entity =>
            {
                entity.HasKey(e => e.NotesId);

                entity.ToTable("HostNotes");

                entity.HasIndex(e => e.PropertyId, "IX_HOST_NOTE_CATEGORY_BY_PROPETY");

                entity.HasIndex(e => new { e.PropertyId, e.CategoryId }, "IX_PROPERTY_CATEGORY");

                entity.Property(e => e.DateTimeCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateTimeDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateTimeReminderRemoved).HasColumnType("datetime");

                entity.Property(e => e.DateTimeReminderSet).HasColumnType("datetime");

                entity.Property(e => e.ExternalKeyField).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.ReminderDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.HostNote1s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.HostNotes_dbo.HostNotesCategories_CategoryId");
            });

            modelBuilder.Entity<HostNotesCategory>(entity =>
            {
                entity.HasKey(e => e.NoteCategoryId)
                    .HasName("PK_dbo.HostNotesCategories");

                entity.Property(e => e.NotesCategoryDescription)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<HostPatronEmail>(entity =>
            {
                entity.HasKey(e => e.EmailKey)
                    .HasName("PK_dbo.HostPatronEmails");

                entity.Property(e => e.EmailMessage).IsRequired();

                entity.Property(e => e.EmailSubject)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FromHostEmailAddress)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ToPatronEmailAddress)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<HostReferral>(entity =>
            {
                entity.ToTable("HostReferral");

                entity.HasIndex(e => e.CurrentRow, "IDX_Id_PropertyId_PatronId_HostUserId");

                entity.HasIndex(e => new { e.PropertyId, e.HostUserId }, "IDX_PropertyId_HostUserId_Include");

                entity.HasIndex(e => new { e.PropertyId, e.PatronId, e.CurrentRow }, "IDX_PropertyId_PatronId_CurrentRow");

                entity.HasIndex(e => new { e.PropertyId, e.ReferralChanged }, "IDX_PropertyId_ReferralChanged_Include");

                entity.HasIndex(e => new { e.PropertyId, e.CurrentRow }, "IX_HostReferral");

                entity.HasIndex(e => e.HostReferralId, "IX_HostReferral_1");

                entity.HasIndex(e => e.SourceSystem, "IX_HostReferral_2");

                entity.HasIndex(e => new { e.PropertyId, e.UserChanged }, "IX_UserChanged");

                entity.Property(e => e.AuthorizedBy).HasMaxLength(250);

                entity.Property(e => e.DateTimeChanged).HasColumnType("datetime");

                entity.Property(e => e.SourceSystem).HasMaxLength(250);

                entity.Property(e => e.UserChanged).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<HostRole>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.HostHostsId })
                    .HasName("PK_dbo.HostRoles");

                entity.HasIndex(e => e.HostHostsId, "IX_Host_HostsId");

                entity.HasIndex(e => e.RoleId, "IX_Role_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.HostHostsId).HasColumnName("Host_HostsId");

                entity.HasOne(d => d.HostHosts)
                    .WithMany(p => p.HostRoles)
                    .HasForeignKey(d => d.HostHostsId)
                    .HasConstraintName("FK_dbo.HostRoles_dbo.Hosts_Host_HostsId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.HostRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.HostRoles_dbo.SecurityRoles_Role_Id");
            });

            modelBuilder.Entity<HostSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK_dbo.HostSessions");

                entity.HasIndex(e => new { e.PropertyId, e.HostUserId, e.ExpiredTime }, "IDX_PropertyId_HostUserId_ExpiredTime_Include");

                entity.Property(e => e.SessionId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<HostTaskAssigned>(entity =>
            {
                entity.HasKey(e => new { e.HostTaskKey, e.HostUserId })
                    .HasName("PK_dbo.HostTaskAssigned");

                entity.ToTable("HostTaskAssigned");

                entity.HasOne(d => d.HostTaskKeyNavigation)
                    .WithMany(p => p.HostTaskAssigneds)
                    .HasForeignKey(d => d.HostTaskKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.HostTaskAssigned_dbo.HostTaskManager_HostTaskKey");

                entity.HasOne(d => d.HostUser)
                    .WithMany(p => p.HostTaskAssigneds)
                    .HasForeignKey(d => d.HostUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.HostTaskAssigned_dbo.Hosts_HostUserId");
            });

            modelBuilder.Entity<HostTaskAutoGenerator>(entity =>
            {
                entity.HasKey(e => e.HostTaskGeneratorKey)
                    .HasName("PK_dbo.HostTaskAutoGenerator");

                entity.ToTable("HostTaskAutoGenerator");

                entity.HasIndex(e => e.HostTaskManagerId, "IX_HostTaskManagerId");

                entity.Property(e => e.DurationPeriod).HasMaxLength(50);

                entity.Property(e => e.EnteredDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.HostTaskManager)
                    .WithMany(p => p.HostTaskAutoGenerators)
                    .HasForeignKey(d => d.HostTaskManagerId)
                    .HasConstraintName("FK_dbo.HostTaskAutoGenerator_dbo.HostTaskManager_HostTaskManagerId");
            });

            modelBuilder.Entity<HostTaskCategory>(entity =>
            {
                entity.HasKey(e => e.HostTaskCategoryKey)
                    .HasName("PK_dbo.HostTaskCategories");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HostTaskHost>(entity =>
            {
                entity.HasIndex(e => new { e.HostTaskKey, e.HostTaskPatronId }, "IDX_HostTaskKey_HostTaskPatronId");

                entity.HasIndex(e => e.HostId, "IX_HostId");

                entity.HasIndex(e => e.HostTaskKey, "IX_HostTaskKey");

                entity.HasIndex(e => e.HostTaskPatronId, "IX_HostTaskPatronId");

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.HostTaskHosts)
                    .HasForeignKey(d => d.HostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.HostTaskHosts_dbo.Hosts_HostId");

                entity.HasOne(d => d.HostTaskKeyNavigation)
                    .WithMany(p => p.HostTaskHosts)
                    .HasForeignKey(d => d.HostTaskKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.HostTaskHosts_dbo.HostTaskManager_HostTaskKey");

                entity.HasOne(d => d.HostTaskPatron)
                    .WithMany(p => p.HostTaskHosts)
                    .HasForeignKey(d => d.HostTaskPatronId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.HostTaskHosts_dbo.HostTaskPatrons_HostTaskPatronId");
            });

            modelBuilder.Entity<HostTaskManager>(entity =>
            {
                entity.HasKey(e => e.HostTaskKey)
                    .HasName("PK_dbo.HostTaskManager");

                entity.ToTable("HostTaskManager");

                entity.HasIndex(e => e.HostTaskCategoryId, "IX_HostTaskCategoryId");

                entity.Property(e => e.Archived).HasColumnName("archived");

                entity.Property(e => e.HostTaskDescription)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.HostTaskStatus)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Preview)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PropertyId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.HostTaskManagers)
                    .HasForeignKey(d => d.ContactTypeId)
                    .HasConstraintName("FK_dbo.HostTaskManager_dbo.ContactTypes_ContactTypeId");

                entity.HasOne(d => d.HostTaskCategory)
                    .WithMany(p => p.HostTaskManagers)
                    .HasForeignKey(d => d.HostTaskCategoryId)
                    .HasConstraintName("FK_dbo.HostTaskManager_dbo.HostTaskCategories_HostTaskCategoryId");
            });

            modelBuilder.Entity<HostTaskPatron>(entity =>
            {
                entity.HasKey(e => e.HostTaskPatronKey)
                    .HasName("PK_dbo.HostTaskPatrons");

                entity.Property(e => e.HostTaskPatronId)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.HostTaskKeyNavigation)
                    .WithMany(p => p.HostTaskPatrons)
                    .HasForeignKey(d => d.HostTaskKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.HostTaskPatrons_dbo.HostTaskManager_HostTaskKey");

                entity.HasOne(d => d.SourcePatron1)
                    .WithMany(p => p.HostTaskPatrons)
                    .HasForeignKey(d => new { d.PropertyId, d.HostTaskPatronId })
                    .HasConstraintName("FK_dbo.HostTaskPatrons_dbo.SourcePatrons_PropertyId_HostTaskPatronId");
            });

            modelBuilder.Entity<HostUnderSpotlightAlertEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HostUnderSpotlightAlertEmail", "mdl");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<HostedAlert>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HostedAlerts", "change");

                entity.Property(e => e.Activity).HasMaxLength(250);

                entity.Property(e => e.ActivityDateTime).HasColumnType("datetime");

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.AlertSent).HasMaxLength(1);

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.PatronId).HasMaxLength(250);

                entity.Property(e => e.PatronName).HasMaxLength(250);

                entity.Property(e => e.StatusDescription).HasMaxLength(250);
            });

            modelBuilder.Entity<HostedAlert1>(entity =>
            {
                entity.HasKey(e => e.AlertLogId);

                entity.ToTable("HostedAlerts");

                entity.HasIndex(e => e.Activity, "IDX_Activity_Include");

                entity.HasIndex(e => new { e.PropertyId, e.AlertType }, "IX_HostedAlerts");

                entity.HasIndex(e => new { e.HostId, e.Activity, e.ActivityDateTime }, "IX_HostedAlerts_1");

                entity.HasIndex(e => new { e.PropertyId, e.AlertType, e.HostId, e.Activity, e.ActivityDateTime }, "IX_HostedAlerts_2");

                entity.Property(e => e.Activity).HasMaxLength(250);

                entity.Property(e => e.ActivityDateTime).HasColumnType("datetime");

                entity.Property(e => e.ActualCheckInDate).HasColumnType("datetime");

                entity.Property(e => e.ActualCheckOutDate).HasColumnType("datetime");

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.AlertSent).HasMaxLength(1);

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.PatronId).HasMaxLength(250);

                entity.Property(e => e.PatronName).HasMaxLength(250);

                entity.Property(e => e.ReservationCheckInDate).HasColumnType("datetime");

                entity.Property(e => e.ReservationCheckOutDate).HasColumnType("datetime");

                entity.Property(e => e.StatusDescription).HasMaxLength(250);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<HostedalertsBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hostedalerts_backup");

                entity.Property(e => e.Activity).HasMaxLength(250);

                entity.Property(e => e.ActivityDateTime).HasColumnType("datetime");

                entity.Property(e => e.ActualCheckInDate).HasColumnType("datetime");

                entity.Property(e => e.ActualCheckOutDate).HasColumnType("datetime");

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.AlertLogId).ValueGeneratedOnAdd();

                entity.Property(e => e.AlertSent).HasMaxLength(1);

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.PatronId).HasMaxLength(250);

                entity.Property(e => e.PatronName).HasMaxLength(250);

                entity.Property(e => e.ReservationCheckInDate).HasColumnType("datetime");

                entity.Property(e => e.ReservationCheckOutDate).HasColumnType("datetime");

                entity.Property(e => e.StatusDescription).HasMaxLength(250);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<HostsTemp>(entity =>
            {
                entity.HasKey(e => e.HostsId)
                    .HasName("PK_Hosts");

                entity.ToTable("HostsTemp", "change");

                entity.Property(e => e.HostsId).ValueGeneratedNever();

                entity.Property(e => e.ActiveFlag).HasMaxLength(1);

                entity.Property(e => e.Administrator).HasMaxLength(1);

                entity.Property(e => e.Adtflag)
                    .IsRequired()
                    .HasColumnName("ADTFlag")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AllHostsFlag).HasMaxLength(1);

                entity.Property(e => e.AllowLogin)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AllowSelect).HasMaxLength(1);

                entity.Property(e => e.ChangeHostFlag).HasMaxLength(1);

                entity.Property(e => e.ChangeReferralFlag).HasMaxLength(1);

                entity.Property(e => e.CompDollarsFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Crc)
                    .HasColumnName("CRC")
                    .HasDefaultValueSql("((-9))");

                entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");

                entity.Property(e => e.HostEmail).HasMaxLength(250);

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.HostPassword).HasMaxLength(50);

                entity.Property(e => e.HostUserName).HasMaxLength(250);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChange).HasColumnType("datetime");

                entity.Property(e => e.LastVisitFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PointsFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SendAlerts).HasMaxLength(1);

                entity.Property(e => e.Sqlsearch)
                    .HasMaxLength(250)
                    .HasColumnName("SQLSearch");

                entity.Property(e => e.SystemAdministrator).HasMaxLength(1);

                entity.Property(e => e.TemporaryPassword).HasMaxLength(250);

                entity.Property(e => e.TheoTodayFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TheoYesterdayFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TripsLast90Flag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TripsThisYearFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HostsXrefMl>(entity =>
            {
                entity.HasKey(e => e.HostsXrefId)
                    .HasName("PK_mdlHostsXRef");

                entity.ToTable("HostsXRef_ML", "mdl");

                entity.Property(e => e.HostsXrefId).HasColumnName("HostsXRefId");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.HostStatus).HasMaxLength(1);

                entity.Property(e => e.HostUserName).HasMaxLength(250);

                entity.Property(e => e.PlayerStatus).HasMaxLength(250);

                entity.Property(e => e.XrefHostStatus)
                    .HasMaxLength(1)
                    .HasColumnName("XRefHostStatus");

                entity.Property(e => e.XrefHostUserId).HasColumnName("XRefHostUserId");

                entity.Property(e => e.XrefHostUserName)
                    .HasMaxLength(250)
                    .HasColumnName("XRefHostUserName");
            });

            modelBuilder.Entity<HotSpotsBuyIn>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("HotSpotsBuyIn", "mdl");

                entity.Property(e => e.AlertSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.AlertSentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.GameName).HasMaxLength(250);

                entity.Property(e => e.LocationName).HasMaxLength(250);

                entity.Property(e => e.PitName).HasMaxLength(250);

                entity.Property(e => e.ProcessedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<HotSpotsRop>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("HotSpotsROP", "mdl");

                entity.Property(e => e.AlertSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.AlertSentDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.PlayerName).HasMaxLength(250);

                entity.Property(e => e.PlayerType).HasMaxLength(250);

                entity.Property(e => e.ProcessedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RevisionBk)
                    .HasMaxLength(250)
                    .HasColumnName("RevisionBK");

                entity.Property(e => e.Rop).HasColumnName("ROP");

                entity.Property(e => e.SlotMastBk)
                    .HasMaxLength(250)
                    .HasColumnName("SlotMastBK");

                entity.Property(e => e.SlotNumber).HasMaxLength(250);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<HotSpotsUncardedJackpot>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("HotSpotsUncardedJackpots", "mdl");

                entity.Property(e => e.AlertSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.AlertSentDateTime).HasColumnType("datetime");

                entity.Property(e => e.BufferBk)
                    .HasMaxLength(250)
                    .HasColumnName("BufferBK");

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.ProcessedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RevisionBk)
                    .HasMaxLength(250)
                    .HasColumnName("RevisionBK");

                entity.Property(e => e.SlotMastBk)
                    .HasMaxLength(250)
                    .HasColumnName("SlotMastBK");

                entity.Property(e => e.SlotNumber).HasMaxLength(250);

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt");

                entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.ToTable("JobParameter", "HangFire");

                entity.HasIndex(e => new { e.JobId, e.Name }, "IX_HangFire_JobParameter_JobIdAndName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameters)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.ToTable("JobQueue", "HangFire");

                entity.HasIndex(e => new { e.Queue, e.FetchedAt }, "IX_HangFire_JobQueue_QueueAndFetchedAt");

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt");

                entity.HasIndex(e => e.Key, "IX_HangFire_List_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<NonHostedAlert>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NonHostedAlerts", "change");

                entity.Property(e => e.Activity).HasMaxLength(250);

                entity.Property(e => e.ActivityDateTime).HasColumnType("datetime");

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.AlertSent).HasMaxLength(1);

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.PatronId).HasMaxLength(250);

                entity.Property(e => e.PatronName).HasMaxLength(250);

                entity.Property(e => e.StatusDescription).HasMaxLength(250);

                entity.Property(e => e.TheoToday).HasColumnType("money");
            });

            modelBuilder.Entity<NonHostedAlert1>(entity =>
            {
                entity.HasKey(e => e.AlertLogId);

                entity.ToTable("NonHostedAlerts");

                entity.HasIndex(e => e.ActivityDateTime, "IDX_ActivityDateTime");

                entity.HasIndex(e => e.PatronId, "IDX_PatronId_Include");

                entity.HasIndex(e => new { e.PropertyId, e.Activity }, "IDX_PropertyId_Activity_Include");

                entity.Property(e => e.Activity).HasMaxLength(250);

                entity.Property(e => e.ActivityDateTime).HasColumnType("datetime");

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.AlertSent).HasMaxLength(1);

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.PatronId).HasMaxLength(250);

                entity.Property(e => e.PatronName).HasMaxLength(250);

                entity.Property(e => e.StatusDescription).HasMaxLength(250);

                entity.Property(e => e.TheoToday).HasColumnType("money");
            });

            modelBuilder.Entity<NotificationConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NotificationConfig");

                entity.Property(e => e.EmailHeaderCasinoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Htmlenabled).HasColumnName("HTMLEnabled");

                entity.Property(e => e.ProcessName).HasMaxLength(100);

                entity.Property(e => e.ProfileName).HasMaxLength(100);
            });

            modelBuilder.Entity<ParamDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ParamDates", "Reporting");

                entity.Property(e => e.Days).HasColumnType("datetime");

                entity.Property(e => e.EndGamingDate).HasColumnType("datetime");

                entity.Property(e => e.StartGamingDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ParamYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ParamYears", "Reporting");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<PatronDailyStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PatronDailyStats", "Reporting");

                entity.Property(e => e.CashIn).HasColumnType("money");

                entity.Property(e => e.CashOut).HasColumnType("money");

                entity.Property(e => e.CompsRedeemed).HasColumnType("money");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.Jackpot).HasColumnType("money");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerID");

                entity.Property(e => e.TheoWin).HasColumnType("money");

                entity.Property(e => e.Win).HasColumnType("money");
            });

            modelBuilder.Entity<PatronDailyStatsAdjusted>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("PatronDailyStatsAdjusted", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.CompsAdjusted).HasColumnType("money");

                entity.Property(e => e.Crcadjustments).HasColumnName("CRCAdjustments");

                entity.Property(e => e.DollarsAdjusted).HasColumnType("money");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.PointsAdjusted).HasColumnType("money");
            });

            modelBuilder.Entity<PatronDailyStatsOver100Adt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PatronDailyStatsOver100ADT", "Reporting");

                entity.Property(e => e.ActualWin).HasColumnType("money");

                entity.Property(e => e.CashIn).HasColumnType("money");

                entity.Property(e => e.CashOut).HasColumnType("money");

                entity.Property(e => e.CompsRedeemed).HasColumnType("money");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.Jackpot).HasColumnType("money");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerID");

                entity.Property(e => e.TheoWin).HasColumnType("money");
            });

            modelBuilder.Entity<PatronDailyStatsRatingTime>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_PatronDailyStatsRatings");

                entity.ToTable("PatronDailyStatsRatingTimes", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.MaxDateTime).HasColumnType("datetime");

                entity.Property(e => e.MinDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.StatType)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<PatronDailyStatsRatingTime1>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.PlayerBk, e.GamingDate, e.StatType })
                    .HasName("PK_PatronDailyStatsRatings");

                entity.ToTable("PatronDailyStatsRatingTimes", "mdl");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.StatType).HasMaxLength(250);

                entity.Property(e => e.MaxDateTime).HasColumnType("datetime");

                entity.Property(e => e.MinDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PatronDailyStatsRedemption>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("PatronDailyStatsRedemptions", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.CompsRedeemed).HasColumnType("money");

                entity.Property(e => e.Crcredemptions).HasColumnName("CRCRedemptions");

                entity.Property(e => e.DollarsRedeemed).HasColumnType("money");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.PointsRedeemed).HasColumnType("money");
            });

            modelBuilder.Entity<PatronDailyStatsRevenue>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("PatronDailyStatsRevenue", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.ActualWin).HasColumnType("money");

                entity.Property(e => e.AverageBet).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BonusBucksEarned).HasColumnType("money");

                entity.Property(e => e.CashIn).HasColumnType("money");

                entity.Property(e => e.CashOut).HasColumnType("money");

                entity.Property(e => e.CompEarned).HasColumnType("money");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.DollarsEarned).HasColumnType("money");

                entity.Property(e => e.FreePlayPlayed).HasColumnType("money");

                entity.Property(e => e.FreePlayTheo).HasColumnType("money");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.Jackpot).HasColumnType("money");

                entity.Property(e => e.MaxRatingDateTime).HasColumnType("datetime");

                entity.Property(e => e.MinRatingDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.PromoDollarsEarned).HasColumnType("money");

                entity.Property(e => e.TheoWin).HasColumnType("money");
            });

            modelBuilder.Entity<PatronLifecycle>(entity =>
            {
                entity.ToTable("PatronLifecycle", "change");

                entity.Property(e => e.PatronLifecycleId).ValueGeneratedNever();

                entity.Property(e => e.ActualWin).HasColumnType("money");

                entity.Property(e => e.Ada).HasColumnName("ADA");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Adt).HasColumnName("ADT");

                entity.Property(e => e.CardLevel).HasMaxLength(250);

                entity.Property(e => e.CellPhone).HasMaxLength(250);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.CoinIn).HasColumnType("money");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.CurrentCardLevel).HasMaxLength(250);

                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.Property(e => e.FirstDayOfPlay).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.Frequency).HasMaxLength(250);

                entity.Property(e => e.FrequencyColor).HasMaxLength(250);

                entity.Property(e => e.HomePhone).HasMaxLength(250);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastDayOfPlay).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.NextCardLevel).HasMaxLength(250);

                entity.Property(e => e.PreviousCardLevel).HasMaxLength(250);

                entity.Property(e => e.State).HasMaxLength(250);

                entity.Property(e => e.TheoWin).HasColumnType("money");

                entity.Property(e => e.ZipCode).HasMaxLength(250);
            });

            modelBuilder.Entity<PatronLifecycle1>(entity =>
            {
                entity.HasKey(e => e.PatronLifecycleId);

                entity.ToTable("PatronLifecycle", "report");

                entity.Property(e => e.ActualWin).HasColumnType("money");

                entity.Property(e => e.Ada).HasColumnName("ADA");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Adt).HasColumnName("ADT");

                entity.Property(e => e.CardLevel).HasMaxLength(250);

                entity.Property(e => e.CellPhone).HasMaxLength(250);

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.CoinIn).HasColumnType("money");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.CurrentCardLevel).HasMaxLength(250);

                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.Property(e => e.FirstDayOfPlay).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.Frequency).HasMaxLength(250);

                entity.Property(e => e.FrequencyColor).HasMaxLength(250);

                entity.Property(e => e.HomePhone).HasMaxLength(250);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastDayOfPlay).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.NextCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PreviousCardLevel).HasMaxLength(250);

                entity.Property(e => e.State).HasMaxLength(250);

                entity.Property(e => e.TheoWin).HasColumnType("money");

                entity.Property(e => e.ZipCode).HasMaxLength(250);
            });

            modelBuilder.Entity<PatronTripCount>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("PatronTripCount", "mdl");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerBk }, "IDX_PropertyId_PlayerBK")
                    .IsUnique();

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.MaxDate).HasColumnType("datetime");

                entity.Property(e => e.MinDate).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<PatronTripSummary>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("PatronTripSummary", "mdl");

                entity.Property(e => e.Average3Days)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Average4Days)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Average5Days)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DaysCount3Days).HasDefaultValueSql("((0))");

                entity.Property(e => e.DaysCount4Days).HasDefaultValueSql("((0))");

                entity.Property(e => e.DaysCount5Days).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.ProcessedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TheoWin3Days)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TheoWin4Days)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TheoWin5Days)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PatronTripSummaryUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PatronTripSummaryUpdate", "mdl");

                entity.Property(e => e.Average3Days).HasColumnType("money");

                entity.Property(e => e.Average4Days).HasColumnType("money");

                entity.Property(e => e.Average5Days)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DaysCount5Days).HasDefaultValueSql("((0))");

                entity.Property(e => e.TheoWin3Days).HasColumnType("money");

                entity.Property(e => e.TheoWin4Days).HasColumnType("money");

                entity.Property(e => e.TheoWin5Days)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Player90DayStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Player90DayStats", "Reporting");

                entity.Property(e => e.BonBuckErnd).HasColumnType("money");

                entity.Property(e => e.CoinIn).HasColumnType("money");

                entity.Property(e => e.CoinOut).HasColumnType("money");

                entity.Property(e => e.CompErnd).HasColumnType("money");

                entity.Property(e => e.DollErnd).HasColumnType("money");

                entity.Property(e => e.FreePlay).HasColumnType("money");

                entity.Property(e => e.Jackpots).HasColumnType("money");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.ProDollErnd).HasColumnType("money");

                entity.Property(e => e.Theo).HasColumnType("money");

                entity.Property(e => e.Win).HasColumnType("money");
            });

            modelBuilder.Entity<PlayerPeriodStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PlayerPeriodStats", "Reporting");

                entity.Property(e => e.ActualWin).HasColumnType("money");

                entity.Property(e => e.Ada)
                    .HasColumnType("money")
                    .HasColumnName("ADA");

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.BonusBucksEarned).HasColumnType("money");

                entity.Property(e => e.CashIn).HasColumnType("money");

                entity.Property(e => e.CashOut).HasColumnType("money");

                entity.Property(e => e.CompEarned).HasColumnType("money");

                entity.Property(e => e.CompsAdjusted).HasColumnType("money");

                entity.Property(e => e.CompsRedeemed).HasColumnType("money");

                entity.Property(e => e.Crcadjustments).HasColumnName("CRCAdjustments");

                entity.Property(e => e.Crcredemptions).HasColumnName("CRCRedemptions");

                entity.Property(e => e.DollarsAdjusted).HasColumnType("money");

                entity.Property(e => e.DollarsEarned).HasColumnType("money");

                entity.Property(e => e.DollarsRedeemed).HasColumnType("money");

                entity.Property(e => e.FreePlayPlayed).HasColumnType("money");

                entity.Property(e => e.Jackpot).HasColumnType("money");

                entity.Property(e => e.Period).HasMaxLength(20);

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.PointsAdjusted).HasColumnType("money");

                entity.Property(e => e.PointsRedeemed).HasColumnType("money");

                entity.Property(e => e.PromoDollarsEarned).HasColumnType("money");

                entity.Property(e => e.TheoWin).HasColumnType("money");
            });

            modelBuilder.Entity<PlayerUnderSpotlightAlert>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_[PlayerUnderSpotlightAlert");

                entity.ToTable("PlayerUnderSpotlightAlert", "mdl");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<PlayersUnderSpotlight>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.Acitivy })
                    .HasName("PK_HostUnderSpotlight");

                entity.ToTable("PlayersUnderSpotlight", "mdl");

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.Acitivy).HasMaxLength(50);
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Properties", "security");

                entity.Property(e => e.Property1)
                    .HasMaxLength(250)
                    .HasColumnName("Property");

                entity.Property(e => e.UserAd)
                    .HasMaxLength(501)
                    .HasColumnName("UserAD");
            });

            modelBuilder.Entity<ReportAudit>(entity =>
            {
                entity.ToTable("ReportAudit", "rpt");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ActionSp)
                    .HasMaxLength(500)
                    .HasColumnName("ActionSP");

                entity.Property(e => e.ActionTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("IPAddress");
            });

            modelBuilder.Entity<ReportMaster>(entity =>
            {
                entity.ToTable("ReportMaster", "rpt");

                entity.Property(e => e.ReportCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ReportToPdf).HasColumnName("ReportToPDF");

                entity.Property(e => e.ReportType).HasMaxLength(1);

                entity.Property(e => e.ReportVersion).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportParameter>(entity =>
            {
                entity.ToTable("ReportParameters", "rpt");

                entity.Property(e => e.ParameterDescription).HasMaxLength(250);

                entity.Property(e => e.ParameterSp)
                    .HasMaxLength(250)
                    .HasColumnName("ParameterSP");

                entity.Property(e => e.ParameterTextValue).HasMaxLength(250);
            });

            modelBuilder.Entity<ReportProduct>(entity =>
            {
                entity.ToTable("ReportProduct", "rpt");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ReportProperty>(entity =>
            {
                entity.ToTable("ReportProperty", "rpt");

                entity.Property(e => e.PropertyDomain).HasMaxLength(250);

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ReportSubscription>(entity =>
            {
                entity.ToTable("ReportSubscription", "rpt");

                entity.Property(e => e.ExportToPdf).HasColumnName("ExportToPDF");

                entity.Property(e => e.FrequencyOccurs).HasMaxLength(1);
            });

            modelBuilder.Entity<ReportSubscriptionArchive>(entity =>
            {
                entity.ToTable("ReportSubscriptionArchive", "rpt");

                entity.Property(e => e.DateTimeSent).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).IsRequired();

                entity.Property(e => e.EmailMessage).IsRequired();
            });

            modelBuilder.Entity<ReportUser>(entity =>
            {
                entity.ToTable("ReportUser", "rpt");

                entity.Property(e => e.NetworkUserName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ReportUserFavorite>(entity =>
            {
                entity.ToTable("ReportUserFavorite", "rpt");
            });

            modelBuilder.Entity<ReportUserSecurity>(entity =>
            {
                entity.ToTable("ReportUserSecurity", "rpt");

                entity.Property(e => e.ExportToPdf).HasColumnName("ExportToPDF");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<SecurityRole>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_RoleName")
                    .IsUnique();

                entity.Property(e => e.ActiveDirectoryGroup).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RoleLevel).HasDefaultValueSql("((3))");
            });

            modelBuilder.Entity<SecurityRoleClaim>(entity =>
            {
                entity.HasKey(e => new { e.Resource, e.Action, e.RoleId })
                    .HasName("PK_dbo.SecurityRoleClaim");

                entity.ToTable("SecurityRoleClaim");

                entity.HasIndex(e => e.RoleId, "IX_RoleId");

                entity.Property(e => e.Resource).HasMaxLength(250);

                entity.Property(e => e.Action).HasMaxLength(250);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SecurityRoleClaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.SecurityRoleClaim_dbo.SecurityRoles_RoleId");
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt");

                entity.HasIndex(e => e.Key, "IX_HangFire_Set_Key");

                entity.HasIndex(e => new { e.Key, e.Value }, "UX_HangFire_Set_KeyAndValue")
                    .IsUnique();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<SlotMachineUnderSpotlight>(entity =>
            {
                entity.HasKey(e => e.SlotMachineId);

                entity.ToTable("SlotMachineUnderSpotlight", "mdl");

                entity.Property(e => e.SlotMachineId)
                    .ValueGeneratedNever()
                    .HasColumnName("SlotMachineID");

                entity.Property(e => e.BankId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SlotArea)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SlotSection)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SourceAccountStatus>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_changeSourceAccountStatus");

                entity.ToTable("SourceAccountStatus", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.StatusBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("StatusBK");

                entity.Property(e => e.StatusName).HasMaxLength(250);
            });

            modelBuilder.Entity<SourceAccountStatus1>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourceAccountStatus");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.StatusBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("StatusBK");

                entity.Property(e => e.StatusName).HasMaxLength(250);
            });

            modelBuilder.Entity<SourceComp>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_changeSourceComps");

                entity.ToTable("SourceComps", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.CasinoId).HasColumnName("Casino_ID");

                entity.Property(e => e.Comp).HasColumnType("money");

                entity.Property(e => e.CompDescription).HasMaxLength(250);

                entity.Property(e => e.CompDescription2).HasMaxLength(250);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.IssueDateTime).HasColumnType("datetime");

                entity.Property(e => e.IssueGamingDate).HasColumnType("datetime");

                entity.Property(e => e.IssueUserId).HasColumnName("IssueUser_ID");

                entity.Property(e => e.OriginalComp).HasColumnType("money");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.PrizeId).HasColumnName("Prize_ID");

                entity.Property(e => e.RedeemingOriginalComp).HasColumnType("money");

                entity.Property(e => e.RedemptionId).HasColumnName("Redemption_ID");

                entity.Property(e => e.SettleDateTime).HasColumnType("datetime");

                entity.Property(e => e.SettleGamingDate).HasColumnType("datetime");

                entity.Property(e => e.SettleUserId).HasColumnName("SettleUser_ID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.VoidDateTime).HasColumnType("datetime");

                entity.Property(e => e.VoidGamingDate).HasColumnType("datetime");

                entity.Property(e => e.VoidSupervisorId).HasColumnName("VoidSupervisor_ID");

                entity.Property(e => e.VoidUserId).HasColumnName("VoidUser_ID");
            });

            modelBuilder.Entity<SourceComp1>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourceComps");

                entity.HasIndex(e => new { e.PropertyId, e.CasinoId, e.IssueGamingDate, e.IssueUserId }, "IDX_PropertyId_Casino_ID_IssueGamingDate_IssueUser_ID");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerBk, e.RedeemingOriginalComp }, "IDX_PropertyId_PlayerBK_RedeemingOriginalComp");

                entity.HasIndex(e => new { e.PropertyId, e.VoidUserId }, "IX_PropertyId_VoidUser_ID");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerBk }, "IX_SourceComps");

                entity.HasIndex(e => new { e.PropertyId, e.SettleDateTime, e.VoidDateTime, e.IssueGamingDate, e.IssueUserId }, "IX_SourceComps_PropertyId_SettleDateTime_VoidDateTime_IssueGamingDate_IssueUser_ID");

                entity.HasIndex(e => new { e.PropertyId, e.VoidDateTime, e.CasinoId, e.IssueGamingDate, e.IssueUserId }, "IX_SourceComps_PropertyId_VoidDateTime_Casino_ID_IssueGamingDate_IssueUser_ID");

                entity.Property(e => e.CasinoId).HasColumnName("Casino_ID");

                entity.Property(e => e.Comp).HasColumnType("money");

                entity.Property(e => e.CompDescription).HasMaxLength(250);

                entity.Property(e => e.CompDescription2).HasMaxLength(250);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiryGamingDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDateTime).HasColumnType("datetime");

                entity.Property(e => e.IssueGamingDate).HasColumnType("datetime");

                entity.Property(e => e.IssueUserId).HasColumnName("IssueUser_ID");

                entity.Property(e => e.OriginalComp).HasColumnType("money");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.PrizeId).HasColumnName("Prize_ID");

                entity.Property(e => e.RedeemingOriginalComp).HasColumnType("money");

                entity.Property(e => e.RedemptionId).HasColumnName("Redemption_ID");

                entity.Property(e => e.SettleDateTime).HasColumnType("datetime");

                entity.Property(e => e.SettleGamingDate).HasColumnType("datetime");

                entity.Property(e => e.SettleUserId).HasColumnName("SettleUser_ID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.VoidDateTime).HasColumnType("datetime");

                entity.Property(e => e.VoidGamingDate).HasColumnType("datetime");

                entity.Property(e => e.VoidSupervisorId).HasColumnName("VoidSupervisor_ID");

                entity.Property(e => e.VoidUserId).HasColumnName("VoidUser_ID");

                entity.HasOne(d => d.SourceEmployee1)
                    .WithMany(p => p.SourceComp1s)
                    .HasForeignKey(d => new { d.PropertyId, d.VoidUserId })
                    .HasConstraintName("FK_dbo.SourceComps_dbo.SourceEmployee_PropertyId_VoidUser_ID");
            });

            modelBuilder.Entity<SourceCompAdjustment>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.RedemptionId, e.CasinoId })
                    .HasName("PK_ChangeSourceCompAdjustments");

                entity.ToTable("SourceCompAdjustments", "change");

                entity.Property(e => e.RedemptionId).HasColumnName("Redemption_ID");

                entity.Property(e => e.CasinoId).HasColumnName("Casino_ID");

                entity.Property(e => e.Comp).HasColumnType("money");

                entity.Property(e => e.CompDescription).HasMaxLength(250);

                entity.Property(e => e.CompDescription2).HasMaxLength(250);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.IssueDateTime).HasColumnType("datetime");

                entity.Property(e => e.IssueGamingDate).HasColumnType("datetime");

                entity.Property(e => e.IssueUserId).HasColumnName("IssueUser_ID");

                entity.Property(e => e.OriginalComp).HasColumnType("money");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.PrizeId).HasColumnName("Prize_ID");

                entity.Property(e => e.RedeemingOriginalComp).HasColumnType("money");

                entity.Property(e => e.SettleDateTime).HasColumnType("datetime");

                entity.Property(e => e.SettleGamingDate).HasColumnType("datetime");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.VoidDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SourceEmployee>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_dbo.SourceEmployee");

                entity.ToTable("SourceEmployee", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.EmployeeBk).HasColumnName("EmployeeBK");

                entity.Property(e => e.EmployeeNumber).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.Initials).HasMaxLength(3);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.MiddleInitial).HasMaxLength(1);

                entity.Property(e => e.NameSuffix).HasMaxLength(10);

                entity.Property(e => e.PropertyFk).HasColumnName("PropertyFK");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(250);
            });

            modelBuilder.Entity<SourceEmployee1>(entity =>
            {
                entity.HasKey(e => new { e.PropertyFk, e.EmployeeBk })
                    .HasName("PK_dbo.SourceEmployee");

                entity.ToTable("SourceEmployee");

                entity.HasIndex(e => e.Active, "IDX_Active_Include");

                entity.HasIndex(e => new { e.PropertyFk, e.EmployeeBk }, "IDX_PropertyFK_EmployeeBK");

                entity.HasIndex(e => e.RecId, "IDX_RecId_Include");

                entity.HasIndex(e => e.EmployeeBk, "IDX_SourceEmployee_EmployeeBK");

                entity.Property(e => e.PropertyFk).HasColumnName("PropertyFK");

                entity.Property(e => e.EmployeeBk).HasColumnName("EmployeeBK");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.EmployeeNumber).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.Initials).HasMaxLength(3);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.MiddleInitial).HasMaxLength(1);

                entity.Property(e => e.NameSuffix).HasMaxLength(10);

                entity.Property(e => e.RecId).ValueGeneratedOnAdd();

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(250);
            });

            modelBuilder.Entity<SourceFavorite>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PK_change_SourceFavorites");

                entity.ToTable("SourceFavorites", "change");

                entity.Property(e => e.PlayerId)
                    .ValueGeneratedNever()
                    .HasColumnName("PlayerID");

                entity.Property(e => e.FavoriteActivity)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FavoriteGame)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FavoriteLocation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SourceHostReferral>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.PlayerId });

                entity.ToTable("SourceHostReferral");

                entity.Property(e => e.Referral).HasMaxLength(250);
            });

            modelBuilder.Entity<SourceHotelActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SourceHotelActivity");

                entity.Property(e => e.Message).HasMaxLength(250);

                entity.Property(e => e.Ocr)
                    .HasMaxLength(10)
                    .HasColumnName("OCR");

                entity.Property(e => e.PlayerId)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<SourceNextCardLevel>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourceNextCardLevel");

                entity.Property(e => e.ActualWin).HasColumnType("money");

                entity.Property(e => e.CardLevelBk)
                    .HasMaxLength(250)
                    .HasColumnName("CardLevelBK");

                entity.Property(e => e.CardLevelName).HasMaxLength(250);

                entity.Property(e => e.CardLevelStatType).HasMaxLength(250);

                entity.Property(e => e.CompDollarEarned).HasColumnType("money");

                entity.Property(e => e.DurationEndDate).HasColumnType("datetime");

                entity.Property(e => e.DurationStartDate).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.TheoreticalWin).HasColumnType("money");

                entity.Property(e => e.TotalIn).HasColumnType("money");

                entity.Property(e => e.TotalOut).HasColumnType("money");
            });

            modelBuilder.Entity<SourceOffersDay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SourceOffersDay");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.GroupName).HasMaxLength(250);

                entity.Property(e => e.HasRefused).HasMaxLength(1);

                entity.Property(e => e.HasSubscribed).HasMaxLength(1);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SourcePatron>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_changeSourcePatrons");

                entity.ToTable("SourcePatrons", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.AlternativePhone).HasMaxLength(250);

                entity.Property(e => e.AnniversaryDate).HasColumnType("datetime");

                entity.Property(e => e.Banned).HasMaxLength(50);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CellPhone).HasMaxLength(250);

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.Country).HasMaxLength(250);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.CustomFlag1).HasMaxLength(50);

                entity.Property(e => e.CustomFlag2).HasMaxLength(50);

                entity.Property(e => e.CustomFlag3).HasMaxLength(50);

                entity.Property(e => e.CustomFlag4).HasMaxLength(50);

                entity.Property(e => e.CustomFlag5).HasMaxLength(50);

                entity.Property(e => e.DateTimeUpdated).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.Property(e => e.Ethnicity).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.Gender).HasMaxLength(250);

                entity.Property(e => e.HomePhone).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.MiddleInitial).HasMaxLength(1);

                entity.Property(e => e.Nickname).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.Referral).HasMaxLength(250);

                entity.Property(e => e.State).HasMaxLength(250);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasMaxLength(50);

                entity.Property(e => e.StreetAddress1).HasMaxLength(250);

                entity.Property(e => e.StreetAddress2).HasMaxLength(250);

                entity.Property(e => e.UniversalId).HasMaxLength(250);

                entity.Property(e => e.WeddingAnniversaryDate).HasColumnType("datetime");

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<SourcePatron1>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.PlayerBk })
                    .HasName("PK_SourcePatrons_1");

                entity.ToTable("SourcePatrons");

                entity.HasIndex(e => e.Banned, "IDX_Banned_Include");

                entity.HasIndex(e => new { e.BirthMonth, e.BirthDay }, "IDX_BirthMonth_BirthDay_Include");

                entity.HasIndex(e => e.CustomFlag2, "IDX_CustomFlag2_Include");

                entity.HasIndex(e => e.Ethnicity, "IDX_Ethnicity_Include");

                entity.HasIndex(e => e.PlayerBk, "IDX_PlayerBK_Include");

                entity.HasIndex(e => new { e.PropertyId, e.NextTier }, "IDX_PropertyId_NextTier_Include");

                entity.HasIndex(e => e.RecId, "IDX_RecId_Include");

                entity.HasIndex(e => new { e.PropertyId, e.AnniversaryDate }, "IX_PropertyAnniversaryDate");

                entity.HasIndex(e => e.UniversalId, "IX_SourcePatrons");

                entity.HasIndex(e => new { e.PropertyId, e.HostUserId }, "IX_SourcePatrons_Host");

                entity.HasIndex(e => new { e.PropertyId, e.AnniversaryDate }, "IX_SourcePatrons_PropertyId_AnniversaryDate");

                entity.HasIndex(e => new { e.PropertyId, e.ReferralHostUserId }, "IX_SourcePatrons_Referral");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.ActualWinToday).HasColumnType("money");

                entity.Property(e => e.ActualWinYesterday).HasColumnType("money");

                entity.Property(e => e.Ada)
                    .HasColumnType("money")
                    .HasColumnName("ADA");

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.AlternativePhone).HasMaxLength(250);

                entity.Property(e => e.AnniversaryDate).HasColumnType("datetime");

                entity.Property(e => e.Average5TripTheo).HasColumnName("average5TripTheo");

                entity.Property(e => e.Banned).HasMaxLength(50);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CardLevel).HasMaxLength(250);

                entity.Property(e => e.CellPhone).HasMaxLength(250);

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.Country).HasMaxLength(250);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.CustomFlag1).HasMaxLength(50);

                entity.Property(e => e.CustomFlag2).HasMaxLength(50);

                entity.Property(e => e.CustomFlag3).HasMaxLength(50);

                entity.Property(e => e.CustomFlag4).HasMaxLength(50);

                entity.Property(e => e.CustomFlag5).HasMaxLength(50);

                entity.Property(e => e.DateTimeAdded).HasColumnType("datetime");

                entity.Property(e => e.DateTimeUpdated).HasColumnType("datetime");

                entity.Property(e => e.DollarsBalance).HasColumnType("money");

                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.Property(e => e.Ethnicity).HasMaxLength(250);

                entity.Property(e => e.FavoriteActivity).HasMaxLength(250);

                entity.Property(e => e.FavoriteGame).HasMaxLength(250);

                entity.Property(e => e.FavoriteLocation).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.FreePlayBalance).HasColumnType("money");

                entity.Property(e => e.Frequency).HasMaxLength(250);

                entity.Property(e => e.FrequencyColor)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('#000000')");

                entity.Property(e => e.Gender).HasMaxLength(250);

                entity.Property(e => e.HomePhone).HasMaxLength(250);

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.LastVisit).HasColumnType("datetime");

                entity.Property(e => e.MergedAccount).HasMaxLength(250);

                entity.Property(e => e.MiddleInitial).HasMaxLength(1);

                entity.Property(e => e.Nickname).HasMaxLength(250);

                entity.Property(e => e.RecId).ValueGeneratedOnAdd();

                entity.Property(e => e.Referral).HasMaxLength(250);

                entity.Property(e => e.ReferralHostFirstName).HasMaxLength(250);

                entity.Property(e => e.ReferralHostLastName).HasMaxLength(250);

                entity.Property(e => e.State).HasMaxLength(250);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasMaxLength(50);

                entity.Property(e => e.StreetAddress1).HasMaxLength(250);

                entity.Property(e => e.StreetAddress2).HasMaxLength(250);

                entity.Property(e => e.TheoWinToday).HasColumnType("money");

                entity.Property(e => e.TheoWinYesterday).HasColumnType("money");

                entity.Property(e => e.UniversalId).HasMaxLength(250);

                entity.Property(e => e.UpdateFlag).HasMaxLength(1);

                entity.Property(e => e.Used).HasMaxLength(1);

                entity.Property(e => e.WeddingAnniversaryDate).HasColumnType("datetime");

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<SourcePatronAvg5Day>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.PlayerBk })
                    .HasName("PK_SourcePatrons_Avg");

                entity.ToTable("SourcePatronAvg5Day", "change");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.Average5TripTheo).HasColumnName("average5TripTheo");
            });

            modelBuilder.Entity<SourcePatronBalance>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronBalance", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.DollarsBalance).HasColumnType("money");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SourcePatronBalance1>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronBalance");

                entity.Property(e => e.DollarsBalance).HasColumnType("money");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SourcePatronBanned>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronBanned");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerBk }, "IDX_PropertyId_PlayerBK");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SourcePatronCard>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.PlayerBk })
                    .HasName("PK_change_SourcePatronCard");

                entity.ToTable("SourcePatronCard", "change");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.ClubLevel).HasMaxLength(250);
            });

            modelBuilder.Entity<SourcePatronClubLevel>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronClubLevel", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.ClubLevel).HasMaxLength(250);

                entity.Property(e => e.Crc).HasColumnName("CRC");
            });

            modelBuilder.Entity<SourcePatronClubLevel1>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronClubLevel");

                entity.Property(e => e.ClubLevel).HasMaxLength(250);

                entity.Property(e => e.Crc).HasColumnName("CRC");
            });

            modelBuilder.Entity<SourcePatronDailyStat>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.ActualWin).HasColumnType("money");

                entity.Property(e => e.Ada)
                    .HasColumnType("money")
                    .HasColumnName("ADA");

                entity.Property(e => e.Adt)
                    .HasColumnType("money")
                    .HasColumnName("ADT");

                entity.Property(e => e.AverageBet).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BonusBucksEarned).HasColumnType("money");

                entity.Property(e => e.CashIn).HasColumnType("money");

                entity.Property(e => e.CashOut).HasColumnType("money");

                entity.Property(e => e.CompEarned).HasColumnType("money");

                entity.Property(e => e.CompsAdjusted).HasColumnType("money");

                entity.Property(e => e.CompsRedeemed).HasColumnType("money");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.Crcadjustments).HasColumnName("CRCAdjustments");

                entity.Property(e => e.Crcredemptions).HasColumnName("CRCRedemptions");

                entity.Property(e => e.DateTimeAdded).HasColumnType("datetime");

                entity.Property(e => e.DollarsAdjusted).HasColumnType("money");

                entity.Property(e => e.DollarsEarned).HasColumnType("money");

                entity.Property(e => e.DollarsRedeemed).HasColumnType("money");

                entity.Property(e => e.FreePlayPlayed).HasColumnType("money");

                entity.Property(e => e.FreePlayTheo).HasColumnType("money");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.Jackpot).HasColumnType("money");

                entity.Property(e => e.MaxRatingDateTime).HasColumnType("datetime");

                entity.Property(e => e.MinRatingDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.PointsAdjusted).HasColumnType("money");

                entity.Property(e => e.PointsRedeemed).HasColumnType("money");

                entity.Property(e => e.PromoDollarsEarned).HasColumnType("money");

                entity.Property(e => e.StatType)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TheoWin).HasColumnType("money");
            });

            modelBuilder.Entity<SourcePatronDailyStat1>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_tempSourcePatronDailyStats");

                entity.ToTable("SourcePatronDailyStats", "temp");

                entity.Property(e => e.FreePlayTheo).HasColumnType("money");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.StatType)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<SourcePatronDailyStatsAvgBet>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_SourcePatronDailyStatsAvg");

                entity.ToTable("SourcePatronDailyStatsAvgBet", "change");

                entity.Property(e => e.AverageBet).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SourcePatronEthnicity>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.PlayerBk })
                    .HasName("PK_SourcePatrons_1");

                entity.ToTable("SourcePatronEthnicity", "mdl");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.Ethnicity).HasMaxLength(250);
            });

            modelBuilder.Entity<SourcePatronFavorite>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_SourcePatronsFavorites");

                entity.ToTable("SourcePatronFavorites", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.FavoriteActivity).HasMaxLength(250);

                entity.Property(e => e.FavoriteGame).HasMaxLength(250);

                entity.Property(e => e.FavoriteLocation).HasMaxLength(250);
            });

            modelBuilder.Entity<SourcePatronFreePlayBalance>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronFreePlayBalance", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.FreePlayBalance).HasColumnType("money");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SourcePatronFreePlayBalance1>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronFreePlayBalance");

                entity.Property(e => e.FreePlayBalance).HasColumnType("money");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SourcePatronFrequency>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronFrequency");

                entity.HasIndex(e => e.DateTimeAdded, "IDX_DateTimeAdded");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.DateTimeAdded).HasColumnType("datetime");

                entity.Property(e => e.Frequency).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SourcePatronFrequency6Month>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.HasIndex(e => e.DateTimeAdded, "IDX_DateTimeAdded");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.DateTimeAdded).HasColumnType("datetime");

                entity.Property(e => e.Frequency).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SourcePatronFrequency6MonthsHistory>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronFrequency6MonthsHistory");

                entity.HasIndex(e => e.DateTimeAdded, "IDX_DateTimeAdded");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerBk, e.DateTimeAdded }, "IDX_PropertyId_PlayerBK_DateTimeAdded_DESC");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.DateTimeAdded).HasColumnType("datetime");

                entity.Property(e => e.Frequency).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SourcePatronFrequencyHistory>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronFrequencyHistory");

                entity.HasIndex(e => e.DateTimeAdded, "IDX_DateTimeAdded");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerBk, e.DateTimeAdded }, "IDX_PropertyId_PlayerBK_DateTimeAdded_DESC");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.DateTimeAdded).HasColumnType("datetime");

                entity.Property(e => e.Frequency).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SourcePatronHostReferral>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.PlayerBk })
                    .HasName("PK_changeSourcePatronHostReferral");

                entity.ToTable("SourcePatronHostReferral", "change");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.ReferralUserId)
                    .HasMaxLength(250)
                    .HasColumnName("ReferralUserID");

                entity.Property(e => e.ReferrralUserIdTimestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<SourcePatronHostReferral1>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.PlayerBk });

                entity.ToTable("SourcePatronHostReferral");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.HostUserId)
                    .HasMaxLength(250)
                    .HasColumnName("HostUserID");

                entity.Property(e => e.HostUserIdTimestamp).HasColumnType("datetime");

                entity.Property(e => e.ReferralUserId)
                    .HasMaxLength(250)
                    .HasColumnName("ReferralUserID");

                entity.Property(e => e.ReferrralUserIdTimestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<SourcePatronLastPosition>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_changeSourcePatronLastPosition");

                entity.ToTable("SourcePatronLastPosition", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.Activity).HasMaxLength(250);

                entity.Property(e => e.ActivityDateTime).HasColumnType("datetime");

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SourcePatronLastPosition1>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronLastPosition");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerBk }, "IDX_PropertyId_PlayerBK");

                entity.HasIndex(e => e.PropertyId, "IX_LastPosition");

                entity.Property(e => e.Activity).HasMaxLength(250);

                entity.Property(e => e.ActivityDateTime).HasColumnType("datetime");

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SourcePatronMerge>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronMerge", "mdl");

                entity.Property(e => e.FromPlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("FromPlayerBK");

                entity.Property(e => e.MergeDateTime).HasColumnType("datetime");

                entity.Property(e => e.ProcessedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ToPlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ToPlayerBK");
            });

            modelBuilder.Entity<SourcePatronNameAddress>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_changeSourcePatronNameAddress");

                entity.ToTable("SourcePatronNameAddress", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.Country).HasMaxLength(250);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.State).HasMaxLength(250);

                entity.Property(e => e.StreetAddress1).HasMaxLength(250);

                entity.Property(e => e.StreetAddress2).HasMaxLength(250);

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<SourcePatronNameAddress1>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourcePatronNameAddress");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.Country).HasMaxLength(250);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.State).HasMaxLength(250);

                entity.Property(e => e.StreetAddress1).HasMaxLength(250);

                entity.Property(e => e.StreetAddress2).HasMaxLength(250);

                entity.Property(e => e.ZipCode).HasMaxLength(50);
            });

            modelBuilder.Entity<SourcePatronReinvestment>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_changePatronReinvestment");

                entity.ToTable("SourcePatronReinvestment", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.ActualWin).HasColumnType("money");

                entity.Property(e => e.CompsRedeemed).HasColumnType("money");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.DollarsRedeemed).HasColumnType("money");

                entity.Property(e => e.FreePlayAdjusted).HasColumnType("money");

                entity.Property(e => e.FreePlayRedeemed).HasColumnType("money");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.PlayerWorth).HasColumnType("money");

                entity.Property(e => e.TotalReinvestment).HasColumnType("money");
            });

            modelBuilder.Entity<SourcePatronReinvestment1>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_PatronReinvestment");

                entity.ToTable("SourcePatronReinvestment");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerBk }, "IDX_PropertyId_PlayerBK");

                entity.Property(e => e.ActualWin).HasColumnType("money");

                entity.Property(e => e.CompsRedeemed).HasColumnType("money");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.DollarsRedeemed).HasColumnType("money");

                entity.Property(e => e.FreePlayAdjusted).HasColumnType("money");

                entity.Property(e => e.FreePlayRedeemed).HasColumnType("money");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.PlayerWorth).HasColumnType("money");

                entity.Property(e => e.TotalReinvestment).HasColumnType("money");
            });

            modelBuilder.Entity<SourcePitActivity>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.RecordNum });

                entity.ToTable("SourcePitActivity");

                entity.Property(e => e.Ocr)
                    .HasMaxLength(10)
                    .HasColumnName("OCR");

                entity.Property(e => e.PlayerId)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerID");

                entity.Property(e => e.TableId)
                    .HasMaxLength(250)
                    .HasColumnName("TableID");

                entity.Property(e => e.TablePos).HasMaxLength(250);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<SourcePokerActivity>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.RecordNum });

                entity.ToTable("SourcePokerActivity");

                entity.Property(e => e.Ocr)
                    .HasMaxLength(10)
                    .HasColumnName("OCR");

                entity.Property(e => e.PlayerId)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerID");

                entity.Property(e => e.TableId)
                    .HasMaxLength(250)
                    .HasColumnName("TableID");

                entity.Property(e => e.TablePos).HasMaxLength(250);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<SourceReferral>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.PlayerBk, e.ReferrralTimestamp })
                    .HasName("PK_changeSourceReferral");

                entity.ToTable("SourceReferral", "change");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.ReferrralTimestamp).HasColumnType("datetime");

                entity.Property(e => e.ReferralUserId)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ReferralUserID");
            });

            modelBuilder.Entity<SourceSlotActivity>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.RecordNum });

                entity.ToTable("SourceSlotActivity");

                entity.Property(e => e.Ocr)
                    .HasMaxLength(10)
                    .HasColumnName("OCR");

                entity.Property(e => e.PlayerId)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerID");

                entity.Property(e => e.SlotMastId)
                    .HasMaxLength(250)
                    .HasColumnName("SlotMastID");

                entity.Property(e => e.Status).HasMaxLength(250);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<SourceSlotMachine>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_changeSourceSlotMachines");

                entity.ToTable("SourceSlotMachines", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.BankId)
                    .HasMaxLength(50)
                    .HasColumnName("BankID");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.Denomination).HasColumnType("money");

                entity.Property(e => e.Game).HasMaxLength(100);

                entity.Property(e => e.SlotArea).HasMaxLength(250);

                entity.Property(e => e.SlotFloor).HasMaxLength(250);

                entity.Property(e => e.SlotMachineId)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("SlotMachineID");

                entity.Property(e => e.SlotMachineName).HasMaxLength(250);

                entity.Property(e => e.SlotNumber).HasMaxLength(250);

                entity.Property(e => e.SlotRevision).HasMaxLength(250);

                entity.Property(e => e.SlotSection).HasMaxLength(250);

                entity.Property(e => e.VendorName).HasMaxLength(100);
            });

            modelBuilder.Entity<SourceSlotMachine1>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourceSlotMachines");

                entity.HasIndex(e => e.PropertyId, "IDX_PropertyId_Include");

                entity.Property(e => e.BankId)
                    .HasMaxLength(50)
                    .HasColumnName("BankID");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.Denomination).HasColumnType("money");

                entity.Property(e => e.Game).HasMaxLength(100);

                entity.Property(e => e.SlotArea).HasMaxLength(250);

                entity.Property(e => e.SlotFloor).HasMaxLength(250);

                entity.Property(e => e.SlotMachineId)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("SlotMachineID");

                entity.Property(e => e.SlotMachineName).HasMaxLength(250);

                entity.Property(e => e.SlotNumber).HasMaxLength(250);

                entity.Property(e => e.SlotRevision).HasMaxLength(250);

                entity.Property(e => e.SlotSection).HasMaxLength(250);

                entity.Property(e => e.VendorName).HasMaxLength(100);
            });

            modelBuilder.Entity<SourceSlotMachineRevision>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_changeSourceSlotMachineRevisions");

                entity.ToTable("SourceSlotMachineRevisions", "change");

                entity.Property(e => e.RecId).ValueGeneratedNever();

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.CasinoCode).HasMaxLength(50);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.Denomination).HasColumnType("money");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.LocationString).HasMaxLength(50);

                entity.Property(e => e.RevisionEndDate).HasColumnType("datetime");

                entity.Property(e => e.RevisionStartDate).HasColumnType("datetime");

                entity.Property(e => e.Section).HasMaxLength(50);

                entity.Property(e => e.SlotMachineId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SlotMachineID");

                entity.Property(e => e.SlotNumber).HasMaxLength(50);

                entity.Property(e => e.SlotRevision).HasMaxLength(50);
            });

            modelBuilder.Entity<SourceSlotMachineRevision1>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SourceSlotMachineRevisions");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.CasinoCode).HasMaxLength(50);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.Denomination).HasColumnType("money");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.LocationString).HasMaxLength(50);

                entity.Property(e => e.RevisionEndDate).HasColumnType("datetime");

                entity.Property(e => e.RevisionStartDate).HasColumnType("datetime");

                entity.Property(e => e.Section).HasMaxLength(50);

                entity.Property(e => e.SlotMachineId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SlotMachineID");

                entity.Property(e => e.SlotNumber).HasMaxLength(50);

                entity.Property(e => e.SlotRevision).HasMaxLength(50);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State", "HangFire");

                entity.HasIndex(e => e.JobId, "IX_HangFire_State_JobId");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<StreakBuyoutAlert>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("StreakBuyoutAlert", "mdl");

                entity.Property(e => e.CurrentTier)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FirstAlertSent).HasColumnType("datetime");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LastAlertSent).HasColumnType("datetime");

                entity.Property(e => e.ParticipatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.PlayerName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.StreakAmount).HasColumnType("money");

                entity.Property(e => e.StreakTier)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<StreakBuyoutException>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("StreakBuyoutExceptions", "mdl");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SummaryByPeriod>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SummaryByPeriod", "mdl");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerBk, e.PeriodId }, "IDX_PropertyId_PlayerBK_PeriodId")
                    .IsUnique();

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<SummaryByTrip>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SummaryByTrip", "mdl");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerBk, e.PeriodId }, "IDX_PropertyId_PlayerBK_PeriodId")
                    .IsUnique();

                entity.Property(e => e.ActualWin).HasColumnType("money");

                entity.Property(e => e.CashIn).HasColumnType("money");

                entity.Property(e => e.CompsAdjusted).HasColumnType("money");

                entity.Property(e => e.CompsRedeemed).HasColumnType("money");

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.DollarsAdjusted).HasColumnType("money");

                entity.Property(e => e.DollarsRedeemed).HasColumnType("money");

                entity.Property(e => e.FreePlayPlayed).HasColumnType("money");

                entity.Property(e => e.PeriodAda)
                    .HasColumnType("money")
                    .HasColumnName("PeriodADA");

                entity.Property(e => e.PeriodAdt)
                    .HasColumnType("money")
                    .HasColumnName("PeriodADT");

                entity.Property(e => e.PeriodDesc).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.Redemptions).HasColumnType("money");

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.TheoWin).HasColumnType("money");
            });

            modelBuilder.Entity<SurveillanceAlert>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SurveillanceAlert", "mdl");

                entity.HasIndex(e => e.PlayerBk, "IX_SurveillanceAlert");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.UniversalId).HasMaxLength(250);
            });

            modelBuilder.Entity<SurveillanceAlertEmail>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("SurveillanceAlertEmails", "mdl");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TaxRate>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("TaxRates", "mdl");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.StatType)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TaxRate1).HasColumnName("TaxRate");
            });

            modelBuilder.Entity<Top20LogPoker>(entity =>
            {
                entity.HasKey(e => e.Top20LogId)
                    .HasName("PK_changeTop20LogPoker");

                entity.ToTable("Top20LogPoker", "change");

                entity.Property(e => e.Top20LogId).ValueGeneratedNever();

                entity.Property(e => e.LatestEntry).HasColumnType("datetime");
            });

            modelBuilder.Entity<Top20LogPoker1>(entity =>
            {
                entity.HasKey(e => e.Top20LogId);

                entity.ToTable("Top20LogPoker");

                entity.Property(e => e.EarliestEntry).HasColumnType("datetime");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.LatestEntry).HasColumnType("datetime");

                entity.Property(e => e.PlayerId).HasMaxLength(250);
            });

            modelBuilder.Entity<Top20LogSlot>(entity =>
            {
                entity.HasKey(e => e.Top20LogId)
                    .HasName("PK_changeTop20LogSlot");

                entity.ToTable("Top20LogSlot", "change");

                entity.Property(e => e.Top20LogId).ValueGeneratedNever();

                entity.Property(e => e.LatestEntry).HasColumnType("datetime");
            });

            modelBuilder.Entity<Top20LogSlot1>(entity =>
            {
                entity.HasKey(e => e.Top20LogId);

                entity.ToTable("Top20LogSlot");

                entity.Property(e => e.EarliestEntry).HasColumnType("datetime");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.LatestEntry).HasColumnType("datetime");

                entity.Property(e => e.PlayerId).HasMaxLength(250);
            });

            modelBuilder.Entity<Top20LogTable>(entity =>
            {
                entity.HasKey(e => e.Top20LogId)
                    .HasName("PK_changeTop20LogTable");

                entity.ToTable("Top20LogTable", "change");

                entity.Property(e => e.Top20LogId).ValueGeneratedNever();

                entity.Property(e => e.LatestEntry).HasColumnType("datetime");
            });

            modelBuilder.Entity<Top20LogTable1>(entity =>
            {
                entity.HasKey(e => e.Top20LogId);

                entity.ToTable("Top20LogTable");

                entity.Property(e => e.EarliestEntry).HasColumnType("datetime");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.LatestEntry).HasColumnType("datetime");

                entity.Property(e => e.PlayerId).HasMaxLength(250);
            });

            modelBuilder.Entity<TransactionIndex21ad9499C1a84722B3695e34c23a0851>(entity =>
            {
                entity.ToTable("_TransactionIndex_21ad9499-c1a8-4722-b369-5e34c23a0851");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TransactionIndex77b58f20Fd424d4dA99cF1aec513bc29>(entity =>
            {
                entity.ToTable("_TransactionIndex_77b58f20-fd42-4d4d-a99c-f1aec513bc29");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<ViewAllComp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAllComps");

                entity.Property(e => e.CompAmount).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.IssuedBy).HasMaxLength(501);

                entity.Property(e => e.IssuedDate).HasColumnType("date");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.SettledBy).HasMaxLength(501);

                entity.Property(e => e.SettledDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.VoidDate).HasColumnType("date");

                entity.Property(e => e.VoidedBy).HasMaxLength(501);
            });

            modelBuilder.Entity<ViewConfigAlert>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewConfigAlerts");

                entity.Property(e => e.AlertName).HasMaxLength(100);

                entity.Property(e => e.Fri).HasColumnName("FRI");

                entity.Property(e => e.Mon).HasColumnName("MON");

                entity.Property(e => e.Sat).HasColumnName("SAT");

                entity.Property(e => e.SubTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sun).HasColumnName("SUN");

                entity.Property(e => e.Thu).HasColumnName("THU");

                entity.Property(e => e.Tue).HasColumnName("TUE");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Wed).HasColumnName("WED");
            });

            modelBuilder.Entity<ViewConfigAlertAmlthreshold>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewConfigAlertAMLThresholds");

                entity.Property(e => e.DayOfWeek).HasMaxLength(2);

                entity.Property(e => e.SubTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewConfigAlertCalendarReminder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewConfigAlertCalendarReminders");

                entity.Property(e => e.DayOfWeek).HasMaxLength(2);

                entity.Property(e => e.SubTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewConfigAlertContactThreshold>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewConfigAlertContactThresholds");

                entity.Property(e => e.DayOfWeek).HasMaxLength(2);

                entity.Property(e => e.SubTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewConfigAlertCtrthreshold>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewConfigAlertCTRThresholds");

                entity.Property(e => e.DayOfWeek).HasMaxLength(2);

                entity.Property(e => e.SubTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewConfigAlertCustomerServiceThreshold>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewConfigAlertCustomerServiceThresholds");

                entity.Property(e => e.DayOfWeek).HasMaxLength(2);

                entity.Property(e => e.SubTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewConfigAlertJackpotThreshold>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewConfigAlertJackpotThresholds");

                entity.Property(e => e.DayOfWeek).HasMaxLength(2);

                entity.Property(e => e.SubTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewConfigAlertSlotReferral>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewConfigAlertSlotReferrals");

                entity.Property(e => e.DayOfWeek).HasMaxLength(2);

                entity.Property(e => e.SubTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewConfigAlertSlotThreshold>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewConfigAlertSlotThresholds");

                entity.Property(e => e.DayOfWeek).HasMaxLength(2);

                entity.Property(e => e.SubTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewConfigAlertTableThreshold>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewConfigAlertTableThresholds");

                entity.Property(e => e.DayOfWeek).HasMaxLength(2);

                entity.Property(e => e.SubTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewConfigAlertWhosHere>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewConfigAlertWhosHere");

                entity.Property(e => e.DayOfWeek).HasMaxLength(2);

                entity.Property(e => e.SubTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewConfigAlertsWithId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewConfigAlertsWithIds");

                entity.Property(e => e.AlertName).HasMaxLength(100);

                entity.Property(e => e.Fri).HasColumnName("FRI");

                entity.Property(e => e.Mon).HasColumnName("MON");

                entity.Property(e => e.Sat).HasColumnName("SAT");

                entity.Property(e => e.SubTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sun).HasColumnName("SUN");

                entity.Property(e => e.Thu).HasColumnName("THU");

                entity.Property(e => e.Tue).HasColumnName("TUE");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Wed).HasColumnName("WED");
            });

            modelBuilder.Entity<ViewHostReferralCurrent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewHostReferralCurrent");

                entity.Property(e => e.AuthorizedBy).HasMaxLength(250);

                entity.Property(e => e.DateTimeChanged).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SourceSystem).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewHostedReferredPatron>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewHostedReferredPatrons");

                entity.Property(e => e.CardLevel).HasMaxLength(250);

                entity.Property(e => e.CellPhone)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Frequency).HasMaxLength(250);

                entity.Property(e => e.FrequencyColor).HasMaxLength(10);

                entity.Property(e => e.HomePhone).HasMaxLength(250);

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.RecId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewLastContactDateTime>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.PatronId })
                    .HasName("PK_dbo.viewLastContactDateTime");

                entity.ToTable("viewLastContactDateTime");

                entity.Property(e => e.PatronId).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewLastContactDateTimeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewLastContactDateTime-view");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LastContactDateTime).HasColumnType("datetime");

                entity.Property(e => e.PatronId).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewPatronsIn24Hour>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewPatronsIn24Hours");

                entity.Property(e => e.PlayerBk)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");
            });

            modelBuilder.Entity<ViewReportSecurity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewReportSecurity");

                entity.Property(e => e.ReportName).HasMaxLength(250);

                entity.Property(e => e.UserName).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewSourceCompsAdjusted>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSourceCompsAdjusted");

                entity.Property(e => e.CompAmount).HasColumnType("money");

                entity.Property(e => e.CompDescription).HasMaxLength(250);

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.RecType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSourceCompsComp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSourceCompsComps");

                entity.Property(e => e.CompAmount).HasColumnType("money");

                entity.Property(e => e.CompDescription).HasMaxLength(250);

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.RecType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SettleDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewSourceCompsExpired>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSourceCompsExpired");

                entity.Property(e => e.CompAmount).HasColumnType("money");

                entity.Property(e => e.CompDescription).HasMaxLength(250);

                entity.Property(e => e.ExpiryDateTime).HasColumnType("datetime");

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.RecType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSourceCompsVoid>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSourceCompsVoids");

                entity.Property(e => e.CompAmount).HasColumnType("money");

                entity.Property(e => e.CompDescription).HasMaxLength(250);

                entity.Property(e => e.GamingDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlayerBk)
                    .HasMaxLength(250)
                    .HasColumnName("PlayerBK");

                entity.Property(e => e.RecType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VoidDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewWhosHereLastPosition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewWhosHereLastPosition");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityDateTime).HasColumnType("datetime");

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.Location).HasMaxLength(501);

                entity.Property(e => e.PlayerId).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewWhosHerePokerMostRecent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewWhosHerePokerMostRecent");

                entity.Property(e => e.Pit).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.TableId).HasMaxLength(250);

                entity.Property(e => e.TablePosition).HasMaxLength(250);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewWhosHereSlotMostRecent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewWhosHereSlotMostRecent");

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDescription).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewWhosHereTableMostRecent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewWhosHereTableMostRecent");

                entity.Property(e => e.Pit).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.TableId).HasMaxLength(250);

                entity.Property(e => e.TablePosition).HasMaxLength(250);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwHostWithPlayerHosted>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_HostWithPlayerHosted");

                entity.Property(e => e.ActiveFlag).HasMaxLength(1);

                entity.Property(e => e.Administrator).HasMaxLength(1);

                entity.Property(e => e.Adtflag).HasColumnName("ADTFlag");

                entity.Property(e => e.AllHostsFlag).HasMaxLength(1);

                entity.Property(e => e.AllowSelect).HasMaxLength(1);

                entity.Property(e => e.ChangeHostFlag).HasMaxLength(1);

                entity.Property(e => e.ChangeReferralFlag).HasMaxLength(1);

                entity.Property(e => e.Crc).HasColumnName("CRC");

                entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");

                entity.Property(e => e.HostEmail).HasMaxLength(250);

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.HostPassword).HasMaxLength(50);

                entity.Property(e => e.HostUserName).HasMaxLength(250);

                entity.Property(e => e.HostsId).ValueGeneratedOnAdd();

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChange).HasColumnType("datetime");

                entity.Property(e => e.LdapuserName)
                    .HasMaxLength(255)
                    .HasColumnName("LDAPUserName");

                entity.Property(e => e.SendAlerts).HasMaxLength(1);

                entity.Property(e => e.SendVvipalerts).HasColumnName("SendVVIPAlerts");

                entity.Property(e => e.Sqlsearch)
                    .HasMaxLength(3000)
                    .HasColumnName("SQLSearch");

                entity.Property(e => e.SystemAdministrator).HasMaxLength(1);

                entity.Property(e => e.TemporaryPassword).HasMaxLength(250);
            });

            modelBuilder.Entity<WhosHereHotel>(entity =>
            {
                entity.HasKey(e => e.WhosHereId)
                    .HasName("PK_changeWhosHereHotel");

                entity.ToTable("WhosHereHotel", "change");

                entity.Property(e => e.WhosHereId).ValueGeneratedNever();

                entity.Property(e => e.ActualCheckInDate).HasColumnType("datetime");

                entity.Property(e => e.ActualCheckOutDate).HasColumnType("datetime");

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.ConfirmationNo).HasMaxLength(250);

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.Hotel).HasMaxLength(250);

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(250);

                entity.Property(e => e.ReservationCheckInDate).HasColumnType("datetime");

                entity.Property(e => e.ReservationCheckOutDate).HasColumnType("datetime");

                entity.Property(e => e.ReservationId).HasMaxLength(250);

                entity.Property(e => e.ReservationStatus).HasMaxLength(250);

                entity.Property(e => e.RoomId).HasMaxLength(250);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<WhosHereHotel1>(entity =>
            {
                entity.HasKey(e => e.WhosHereId);

                entity.ToTable("WhosHereHotel");

                entity.HasIndex(e => new { e.PropertyId, e.PatronId }, "IX_PropertyId_PatronId");

                entity.Property(e => e.ActualCheckInDate).HasColumnType("datetime");

                entity.Property(e => e.ActualCheckOutDate).HasColumnType("datetime");

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.ConfirmationNo).HasMaxLength(250);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.Hotel).HasMaxLength(250);

                entity.Property(e => e.PatronId).HasMaxLength(250);

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(250);

                entity.Property(e => e.ReservationCheckInDate).HasColumnType("datetime");

                entity.Property(e => e.ReservationCheckOutDate).HasColumnType("datetime");

                entity.Property(e => e.ReservationId).HasMaxLength(250);

                entity.Property(e => e.ReservationStatus).HasMaxLength(250);

                entity.Property(e => e.RoomId).HasMaxLength(250);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.WhosHereHotel1s)
                    .HasForeignKey(d => new { d.PropertyId, d.PatronId })
                    .HasConstraintName("FK_dbo.WhosHereHotel_dbo.SourcePatrons_PropertyId_PatronId");
            });

            modelBuilder.Entity<WhosHerePoker>(entity =>
            {
                entity.HasKey(e => e.WhosHereId)
                    .HasName("PK_changeWhosHerePoker");

                entity.ToTable("WhosHerePoker", "change");

                entity.Property(e => e.WhosHereId).ValueGeneratedNever();

                entity.Property(e => e.AlertContactDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertJackpotDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertThresholdDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertWhosHereDateTime).HasColumnType("datetime");

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.JackpotAmount).HasColumnType("money");

                entity.Property(e => e.Pit).HasMaxLength(250);

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(250);

                entity.Property(e => e.TableId).HasMaxLength(250);

                entity.Property(e => e.TablePosition).HasMaxLength(250);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.UniversalId).HasMaxLength(250);

                entity.Property(e => e._24hourActualWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourActualWin");

                entity.Property(e => e._24hourLastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("24HourLastUpdate");

                entity.Property(e => e._24hourTheoWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourTheoWin");

                entity.Property(e => e._24hourTimePlayed).HasColumnName("24HourTimePlayed");

                entity.Property(e => e._24hourTotalIn)
                    .HasColumnType("money")
                    .HasColumnName("24HourTotalIn");

                entity.Property(e => e._24hourTotalOut)
                    .HasColumnType("money")
                    .HasColumnName("24HourTotalOut");
            });

            modelBuilder.Entity<WhosHerePoker1>(entity =>
            {
                entity.HasKey(e => e.WhosHereId);

                entity.ToTable("WhosHerePoker");

                entity.HasIndex(e => e.PlayerActive, "IDX_PlayerActive_Include");

                entity.HasIndex(e => new { e.PropertyId, e.HostUserId }, "IDX_PropertyId_HostUserId_Include");

                entity.HasIndex(e => e.PropertyId, "IDX_PropertyId_Include");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerActive, e.HostUserId }, "IDX_PropertyId_PlayerActive_HostUserId");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerActive }, "IDX_PropertyId_PlayerActive_Include");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerId }, "IDX_PropertyId_PlayerId_Include");

                entity.HasIndex(e => e.PropertyId, "IX_WhosHerePoker_PropertyId");

                entity.HasIndex(e => e.UniversalId, "IX_WhosHerePoker_UniversalID");

                entity.HasIndex(e => e.PlayerId, "NonClusteredIndex-20210714-193028");

                entity.Property(e => e.AlertContactDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertJackpotDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertThresholdDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertWhosHereDateTime).HasColumnType("datetime");

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.JackpotAmount).HasColumnType("money");

                entity.Property(e => e.Pit).HasMaxLength(250);

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(250);

                entity.Property(e => e.TableId).HasMaxLength(250);

                entity.Property(e => e.TablePosition).HasMaxLength(250);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.UniversalId).HasMaxLength(250);

                entity.Property(e => e._24hourActualWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourActualWin");

                entity.Property(e => e._24hourLastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("24HourLastUpdate");

                entity.Property(e => e._24hourTheoWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourTheoWin");

                entity.Property(e => e._24hourTimePlayed).HasColumnName("24HourTimePlayed");

                entity.Property(e => e._24hourTotalIn)
                    .HasColumnType("money")
                    .HasColumnName("24HourTotalIn");

                entity.Property(e => e._24hourTotalOut)
                    .HasColumnType("money")
                    .HasColumnName("24HourTotalOut");
            });

            modelBuilder.Entity<WhosHereSlot>(entity =>
            {
                entity.HasKey(e => e.WhosHereId)
                    .HasName("PK_ChangeWhosHereSlot");

                entity.ToTable("WhosHereSlot", "change");

                entity.Property(e => e.WhosHereId).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(10);

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.CasinoId).HasMaxLength(10);

                entity.Property(e => e.Game).HasMaxLength(250);

                entity.Property(e => e.JackpotAmount).HasColumnType("money");

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.LocationId).HasMaxLength(10);

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.SectionId).HasMaxLength(10);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDescription).HasMaxLength(250);

                entity.Property(e => e._24hourActualWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourActualWin");

                entity.Property(e => e._24hourCashIn)
                    .HasColumnType("money")
                    .HasColumnName("24HourCashIn");

                entity.Property(e => e._24hourCashOut)
                    .HasColumnType("money")
                    .HasColumnName("24HourCashOut");

                entity.Property(e => e._24hourJackpot)
                    .HasColumnType("money")
                    .HasColumnName("24HourJackpot");

                entity.Property(e => e._24hourLastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("24HourLastUpdate");

                entity.Property(e => e._24hourTheoWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourTheoWin");

                entity.Property(e => e._24hourTimePlayed).HasColumnName("24HourTimePlayed");
            });

            modelBuilder.Entity<WhosHereSlot1>(entity =>
            {
                entity.HasKey(e => e.WhosHereId);

                entity.ToTable("WhosHereSlot");

                entity.HasIndex(e => new { e.PlayerActive, e.TransactionDate, e.TransactionCode }, "IDX_PlayerActive_TransactionDate_TransactionCode_Include");

                entity.HasIndex(e => new { e.PropertyId, e.HostUserId }, "IDX_PropertyId_HostUserId_Include");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerActive, e.HostUserId }, "IDX_PropertyId_PlayerActive_HostUserId_Include");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerId, e.PlayerActive }, "IDX_PropertyId_PlayerId_PlayerActive_Include");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerActive }, "IX_WhosHereSlot");

                entity.Property(e => e.AlertContactDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertJackpotDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertThresholdDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertWhosHereDateTime).HasColumnType("datetime");

                entity.Property(e => e.AreaId).HasMaxLength(10);

                entity.Property(e => e.Asset).HasMaxLength(250);

                entity.Property(e => e.CasinoId).HasMaxLength(10);

                entity.Property(e => e.Game).HasMaxLength(250);

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.JackpotAmount).HasColumnType("money");

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.LocationId).HasMaxLength(10);

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(250);

                entity.Property(e => e.SectionId).HasMaxLength(10);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDescription).HasMaxLength(250);

                entity.Property(e => e._24hourActualWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourActualWin");

                entity.Property(e => e._24hourCashIn)
                    .HasColumnType("money")
                    .HasColumnName("24HourCashIn");

                entity.Property(e => e._24hourCashOut)
                    .HasColumnType("money")
                    .HasColumnName("24HourCashOut");

                entity.Property(e => e._24hourJackpot)
                    .HasColumnType("money")
                    .HasColumnName("24HourJackpot");

                entity.Property(e => e._24hourLastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("24HourLastUpdate");

                entity.Property(e => e._24hourTheoWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourTheoWin");

                entity.Property(e => e._24hourTimePlayed).HasColumnName("24HourTimePlayed");
            });

            modelBuilder.Entity<WhosHereTable>(entity =>
            {
                entity.HasKey(e => e.WhosHereId);

                entity.ToTable("WhosHereTable", "change");

                entity.Property(e => e.WhosHereId).ValueGeneratedNever();

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.JackpotAmount).HasColumnType("money");

                entity.Property(e => e.Pit).HasMaxLength(250);

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(250);

                entity.Property(e => e.TableId).HasMaxLength(250);

                entity.Property(e => e.TablePosition).HasMaxLength(250);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e._24hourActualWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourActualWin");

                entity.Property(e => e._24hourLastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("24HourLastUpdate");

                entity.Property(e => e._24hourTheoWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourTheoWin");

                entity.Property(e => e._24hourTimePlayed).HasColumnName("24HourTimePlayed");

                entity.Property(e => e._24hourTotalIn)
                    .HasColumnType("money")
                    .HasColumnName("24HourTotalIn");

                entity.Property(e => e._24hourTotalOut)
                    .HasColumnType("money")
                    .HasColumnName("24HourTotalOut");
            });

            modelBuilder.Entity<WhosHereTable1>(entity =>
            {
                entity.HasKey(e => e.WhosHereId);

                entity.ToTable("WhosHereTable");

                entity.HasIndex(e => e.PlayerActive, "IDX_PlayerActive_Include");

                entity.HasIndex(e => new { e.PropertyId, e.HostUserId }, "IDX_PropertyId_HostUserId_Include");

                entity.HasIndex(e => e.PropertyId, "IDX_PropertyId_Include");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerActive, e.HostUserId }, "IDX_PropertyId_PlayerActive_HostUserId_Include");

                entity.HasIndex(e => new { e.PropertyId, e.PlayerId }, "IDX_PropertyId_PlayerId_Include");

                entity.Property(e => e.AlertContactDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertJackpotDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertThresholdDateTime).HasColumnType("datetime");

                entity.Property(e => e.AlertWhosHereDateTime).HasColumnType("datetime");

                entity.Property(e => e.HostFirstName).HasMaxLength(250);

                entity.Property(e => e.HostLastName).HasMaxLength(250);

                entity.Property(e => e.JackpotAmount).HasColumnType("money");

                entity.Property(e => e.Pit).HasMaxLength(250);

                entity.Property(e => e.PlayerCardLevel).HasMaxLength(250);

                entity.Property(e => e.PlayerId).HasMaxLength(250);

                entity.Property(e => e.PlayerName).HasMaxLength(250);

                entity.Property(e => e.TableId).HasMaxLength(250);

                entity.Property(e => e.TablePosition).HasMaxLength(250);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e._24hourActualWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourActualWin");

                entity.Property(e => e._24hourLastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("24HourLastUpdate");

                entity.Property(e => e._24hourTheoWin)
                    .HasColumnType("money")
                    .HasColumnName("24HourTheoWin");

                entity.Property(e => e._24hourTimePlayed).HasColumnName("24HourTimePlayed");

                entity.Property(e => e._24hourTotalIn)
                    .HasColumnType("money")
                    .HasColumnName("24HourTotalIn");

                entity.Property(e => e._24hourTotalOut)
                    .HasColumnType("money")
                    .HasColumnName("24HourTotalOut");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
