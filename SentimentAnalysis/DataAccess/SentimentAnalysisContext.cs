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
        public DbSet<PublicationDto> Publications { get; set; }
        public DbSet<SentimentDto> Sentiments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityDto>().ToTable("Entities");
            modelBuilder.Entity<EntityDto>().Property(p => p.EntityDtoId).HasColumnName("EntityId");
            modelBuilder.Entity<EntityDto>().Property(p => p.Name).IsRequired();

            modelBuilder.Entity<PublicationDto>().ToTable("Publications");
            modelBuilder.Entity<PublicationDto>().Property(p => p.PublicationDtoId).HasColumnName("PublicationId");
            modelBuilder.Entity<PublicationDto>().Property(p => p.Phrase).IsRequired();
            modelBuilder.Entity<PublicationDto>().Property(p => p.Date).IsRequired();


            modelBuilder.Entity<SentimentDto>().ToTable("Sentiments");
            modelBuilder.Entity<SentimentDto>().Property(p => p.SentimentDtoId).HasColumnName("SentimentId");

            modelBuilder.Entity<PositiveSentimentDto>().ToTable("PositiveSentiments");
            modelBuilder.Entity<PositiveSentimentDto>().Property(p => p.SentimentDtoId).HasColumnName("SentimentId");
            modelBuilder.Entity<PositiveSentimentDto>().Property(p => p.Text).HasColumnName("Text");
            modelBuilder.Entity<PositiveSentimentDto>().Property(p => p.Text).IsRequired();

            modelBuilder.Entity<NegativeSentimentDto>().ToTable("NegativeSentiment");
            modelBuilder.Entity<NegativeSentimentDto>().Property(p => p.SentimentDtoId).HasColumnName("SentimentId");
            modelBuilder.Entity<NegativeSentimentDto>().Property(p => p.Text).HasColumnName("Text");
            modelBuilder.Entity<NegativeSentimentDto>().Property(p => p.Text).IsRequired();
        }
    }
}
