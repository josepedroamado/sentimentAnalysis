using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SentimentAnalysisContext : DbContext
    {
        public SentimentAnalysisContext () : base("name=SentimentAnalysisConnString")
        {

        }

        public DbSet<EntityDto> Entities { get; set; }
        public DbSet<AuthorDto> Authors { get; set; }
        public DbSet<SentimentDto> Sentiments { get; set; }
        public DbSet<PublicationDto> Publications { get; set; }
        public DbSet<RelationDto> Relations { get; set; }
        public DbSet<AlarmDto> Alarms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityDto>().ToTable("Entities");
            modelBuilder.Entity<EntityDto>().Property(p => p.EntityDtoId).HasColumnName("EntityId");
            modelBuilder.Entity<EntityDto>().Property(p => p.Name).IsRequired();

            modelBuilder.Entity<AuthorDto>().ToTable("Authors");
            modelBuilder.Entity<AuthorDto>().Property(p => p.AuthorDtoId).HasColumnName("AuthorId");
            modelBuilder.Entity<AuthorDto>().Property(p => p.BirthDate).IsRequired();
            modelBuilder.Entity<AuthorDto>().Property(p => p.FirstName).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<AuthorDto>().Property(p => p.LastName).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<AuthorDto>().Property(p => p.UserName).IsRequired().HasMaxLength(10);

            modelBuilder.Entity<SentimentDto>().ToTable("Sentiments");
            modelBuilder.Entity<SentimentDto>().Property(p => p.SentimentDtoId).HasColumnName("SentimentId");

            modelBuilder.Entity<PositiveSentimentDto>().ToTable("PositiveSentiments");
            modelBuilder.Entity<PositiveSentimentDto>().Property(p => p.SentimentDtoId).HasColumnName("SentimentId");
            modelBuilder.Entity<PositiveSentimentDto>().Property(p => p.Text).HasColumnName("Text");
            modelBuilder.Entity<PositiveSentimentDto>().Property(p => p.Text).IsRequired();

            modelBuilder.Entity<NegativeSentimentDto>().ToTable("NegativeSentiments");
            modelBuilder.Entity<NegativeSentimentDto>().Property(p => p.SentimentDtoId).HasColumnName("SentimentId");
            modelBuilder.Entity<NegativeSentimentDto>().Property(p => p.Text).HasColumnName("Text");
            modelBuilder.Entity<NegativeSentimentDto>().Property(p => p.Text).IsRequired();

            modelBuilder.Entity<PublicationDto>().ToTable("Publications");
            modelBuilder.Entity<PublicationDto>().Property(p => p.PublicationDtoId).HasColumnName("PublicationId");
            modelBuilder.Entity<PublicationDto>().Property(p => p.Phrase).IsRequired();
            modelBuilder.Entity<PublicationDto>().Property(p => p.Date).IsRequired();

            modelBuilder.Entity<RelationDto>().ToTable("Relations");
            modelBuilder.Entity<RelationDto>().Property(p => p.RelationDtoId).HasColumnName("RelationId");

            modelBuilder.Entity<AlarmDto>().ToTable("Alarms");
            modelBuilder.Entity<AlarmDto>().Property(p => p.AlarmDtoId).HasColumnName("AlarmId");

            modelBuilder.Entity<PositiveAlarmDto>().ToTable("PositiveAlarms");
            modelBuilder.Entity<PositiveAlarmDto>().Property(p => p.AlarmDtoId).HasColumnName("AlarmId");
            modelBuilder.Entity<PositiveAlarmDto>().Property(p => p.RequiredPostQuantity).IsRequired();
            modelBuilder.Entity<PositiveAlarmDto>().Property(p => p.TimeFrame).IsRequired();

            modelBuilder.Entity<NegativeAlarmDto>().ToTable("NegativeAlarms");
            modelBuilder.Entity<NegativeAlarmDto>().Property(p => p.AlarmDtoId).HasColumnName("AlarmId");
            modelBuilder.Entity<NegativeAlarmDto>().Property(p => p.RequiredPostQuantity).IsRequired();
            modelBuilder.Entity<NegativeAlarmDto>().Property(p => p.TimeFrame).IsRequired();

            modelBuilder.Entity<AuthorAlarmDto>().ToTable("AuthorAlarms");
            modelBuilder.Entity<AuthorAlarmDto>().Property(p => p.AlarmDtoId).HasColumnName("AlarmId");
            modelBuilder.Entity<AuthorAlarmDto>().Property(p => p.RequiredPostQuantity).IsRequired();
            modelBuilder.Entity<AuthorAlarmDto>().Property(p => p.TimeFrame).IsRequired();
            modelBuilder.Entity<AuthorAlarmDto>().Property(p => p.PhrasesType).IsRequired();
        }
    }
}
