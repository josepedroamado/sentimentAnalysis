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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //use this for TPT
            //modelBuilder.Entity<PositiveSentiment>().ToTable("PositiveSentiments");
            //modelBuilder.Entity<NegativeSentiment>().ToTable("NegativeSentiment");

            //Configure domain classes using modelBuilder here..
            modelBuilder.Entity<EntityDto>().ToTable("Entities");
            modelBuilder.Entity<EntityDto>().Property(p => p.EntityDtoId).HasColumnName("EntityId");
            modelBuilder.Entity<EntityDto>().Property(p => p.Name).IsRequired();
        }
    }
}
