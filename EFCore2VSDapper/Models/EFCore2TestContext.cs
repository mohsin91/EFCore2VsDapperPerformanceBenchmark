using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NowMobRep.Models;

namespace EFCore2VSDapper.Models
{
    public partial class EFCore2TestContext : DbContext
    {
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersGeneral> UsersGeneral { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=192.168.112.64\SQLEXPRESS;Database=NowMobileRepTest;User Id=sa;Password=Now12345;Trusted_Connection=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsersGeneral>(entity =>
            {
                entity.HasKey(e => e.Account);

                entity.ToTable("users_general");

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .ValueGeneratedNever();

                entity.Property(e => e.BalanceNotifyMethod)
                    .HasColumnName("balance_notify_method")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CallBarring)
                    .HasColumnName("call_barring")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Callback)
                    .HasColumnName("callback")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CallerScreeningEnabled)
                    .HasColumnName("caller_screening_enabled")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CbOnCli)
                    .HasColumnName("cb_on_cli")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargePolicyAccruedUserCharges)
                    .HasColumnName("charge_policy_accrued_user_charges")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargePolicyUserPreferredDom)
                    .HasColumnName("charge_policy_user_preferred_dom")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CliPin)
                    .HasColumnName("cli_pin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClimapAccessCode)
                    .HasColumnName("climap_access_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConferenceControlMode)
                    .HasColumnName("conference_control_mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpeId)
                    .HasColumnName("cpe_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpePackageName)
                    .HasColumnName("cpe_package_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreDate)
                    .HasColumnName("cre_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DailyCharge)
                    .HasColumnName("daily_charge")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DailyRoamingSpend)
                    .HasColumnName("daily_roaming_spend")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DailyRoamingSpendLimit)
                    .HasColumnName("daily_roaming_spend_limit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DailyRoamingSpendNotified)
                    .HasColumnName("daily_roaming_spend_notified")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DailyRoamingSpendReserved)
                    .HasColumnName("daily_roaming_spend_reserved")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DailyRoamingSpendReset)
                    .HasColumnName("daily_roaming_spend_reset")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplaySipPassword)
                    .HasColumnName("display_sip_password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoNotDisturb)
                    .HasColumnName("do_not_disturb")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstDate)
                    .HasColumnName("first_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InUse)
                    .HasColumnName("in_use")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastActivatedDate)
                    .HasColumnName("last_activated_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastCallerCli)
                    .HasColumnName("last_caller_cli")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastCallerDate)
                    .HasColumnName("last_caller_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastCallerRestricted)
                    .HasColumnName("last_caller_restricted")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastCli)
                    .HasColumnName("last_cli")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastDate)
                    .HasColumnName("last_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastDeactivatedDate)
                    .HasColumnName("last_deactivated_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lnr)
                    .HasColumnName("lnr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxDailyCharge)
                    .HasColumnName("max_daily_charge")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxMonthlyCharge)
                    .HasColumnName("max_monthly_charge")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageSettingsId)
                    .HasColumnName("message_settings_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyCharge)
                    .HasColumnName("monthly_charge")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Opts)
                    .HasColumnName("opts")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pin)
                    .HasColumnName("pin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PresentSubscriberCli)
                    .HasColumnName("present_subscriber_cli")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecurringChargeFirstDate)
                    .HasColumnName("recurring_charge_first_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecurringChargeLastDate)
                    .HasColumnName("recurring_charge_last_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RingPreference)
                    .HasColumnName("ring_preference")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RingTimer)
                    .HasColumnName("ring_timer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoamingDataSpend)
                    .HasColumnName("roaming_data_spend")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoamingDataSpendLimit)
                    .HasColumnName("roaming_data_spend_limit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoamingDataSpendReserved)
                    .HasColumnName("roaming_data_spend_reserved")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoamingDataSpendReset)
                    .HasColumnName("roaming_data_spend_reset")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoamingNotifyMethod)
                    .HasColumnName("roaming_notify_method")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RowTimestamp)
                    .HasColumnName("row_timestamp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScreenWithheldCaller)
                    .HasColumnName("screen_withheld_caller")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SentRoamingDataLimitSms)
                    .HasColumnName("sent_roaming_data_limit_sms")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Serial)
                    .HasColumnName("serial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimActivated)
                    .HasColumnName("sim_activated")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimExtendedLifecycle)
                    .HasColumnName("sim_extended_lifecycle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimFailedTopupAttempts)
                    .HasColumnName("sim_failed_topup_attempts")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimFailedTopupBars)
                    .HasColumnName("sim_failed_topup_bars")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimFormFactor)
                    .HasColumnName("sim_form_factor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimImsi)
                    .HasColumnName("sim_imsi")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimLastFailedTopupAttempt)
                    .HasColumnName("sim_last_failed_topup_attempt")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimLastUsed)
                    .HasColumnName("sim_last_used")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimPin1)
                    .HasColumnName("sim_pin_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimPin2)
                    .HasColumnName("sim_pin_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimPin3)
                    .HasColumnName("sim_pin_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimProfile)
                    .HasColumnName("sim_profile")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimPuk1)
                    .HasColumnName("sim_puk_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimPuk2)
                    .HasColumnName("sim_puk_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimSerial)
                    .HasColumnName("sim_serial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimServiceProviderId)
                    .HasColumnName("sim_service_provider_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimSpid)
                    .HasColumnName("sim_spid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimState)
                    .HasColumnName("sim_state")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimStateUpdated)
                    .HasColumnName("sim_state_updated")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SipPassword)
                    .HasColumnName("sip_password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SipUserName)
                    .HasColumnName("sip_user_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TopupNotifyMethod)
                    .HasColumnName("topup_notify_method")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TraceRef)
                    .HasColumnName("trace_ref")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TraceStatus)
                    .HasColumnName("trace_status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UaPersonalCallsRoutingOption)
                    .HasColumnName("ua_personal_calls_routing_option")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Used)
                    .HasColumnName("used")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoicemailNotifyMethod)
                    .HasColumnName("voicemail_notify_method")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoicemailPin)
                    .HasColumnName("voicemail_pin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WelcomeMessageSent)
                    .HasColumnName("welcome_message_sent")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdCli)
                    .HasColumnName("withhold_cli")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}