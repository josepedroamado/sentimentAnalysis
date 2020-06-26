namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alarms",
                c => new
                    {
                        AlarmId = c.Guid(nullable: false),
                        RequiredPostQuantity = c.Int(nullable: false),
                        TimeFrame = c.Long(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Entity_EntityDtoId = c.Guid(),
                    })
                .PrimaryKey(t => t.AlarmId)
                .ForeignKey("dbo.Entities", t => t.Entity_EntityDtoId)
                .Index(t => t.Entity_EntityDtoId);
            
            CreateTable(
                "dbo.Entities",
                c => new
                    {
                        EntityId = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EntityId);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 10),
                        FirstName = c.String(nullable: false, maxLength: 15),
                        LastName = c.String(nullable: false, maxLength: 15),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Publications",
                c => new
                    {
                        PublicationId = c.Guid(nullable: false),
                        Phrase = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Author_AuthorDtoId = c.Guid(),
                    })
                .PrimaryKey(t => t.PublicationId)
                .ForeignKey("dbo.Authors", t => t.Author_AuthorDtoId)
                .Index(t => t.Author_AuthorDtoId);
            
            CreateTable(
                "dbo.Relations",
                c => new
                    {
                        RelationId = c.Guid(nullable: false),
                        Entity_EntityDtoId = c.Guid(),
                        Publication_PublicationDtoId = c.Guid(),
                        Sentiment_SentimentDtoId = c.Guid(),
                    })
                .PrimaryKey(t => t.RelationId)
                .ForeignKey("dbo.Entities", t => t.Entity_EntityDtoId)
                .ForeignKey("dbo.Publications", t => t.Publication_PublicationDtoId)
                .ForeignKey("dbo.Sentiments", t => t.Sentiment_SentimentDtoId)
                .Index(t => t.Entity_EntityDtoId)
                .Index(t => t.Publication_PublicationDtoId)
                .Index(t => t.Sentiment_SentimentDtoId);
            
            CreateTable(
                "dbo.Sentiments",
                c => new
                    {
                        SentimentId = c.Guid(nullable: false),
                        Text = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SentimentId);
            
            CreateTable(
                "dbo.PositiveSentiments",
                c => new
                    {
                        SentimentId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.SentimentId)
                .ForeignKey("dbo.Sentiments", t => t.SentimentId)
                .Index(t => t.SentimentId);
            
            CreateTable(
                "dbo.NegativeSentiments",
                c => new
                    {
                        SentimentId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.SentimentId)
                .ForeignKey("dbo.Sentiments", t => t.SentimentId)
                .Index(t => t.SentimentId);
            
            CreateTable(
                "dbo.PositiveAlarms",
                c => new
                    {
                        AlarmId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.AlarmId)
                .ForeignKey("dbo.Alarms", t => t.AlarmId)
                .Index(t => t.AlarmId);
            
            CreateTable(
                "dbo.NegativeAlarms",
                c => new
                    {
                        AlarmId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.AlarmId)
                .ForeignKey("dbo.Alarms", t => t.AlarmId)
                .Index(t => t.AlarmId);
            
            CreateTable(
                "dbo.AuthorAlarms",
                c => new
                    {
                        AlarmId = c.Guid(nullable: false),
                        PhrasesType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AlarmId)
                .ForeignKey("dbo.Alarms", t => t.AlarmId)
                .Index(t => t.AlarmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AuthorAlarms", "AlarmId", "dbo.Alarms");
            DropForeignKey("dbo.NegativeAlarms", "AlarmId", "dbo.Alarms");
            DropForeignKey("dbo.PositiveAlarms", "AlarmId", "dbo.Alarms");
            DropForeignKey("dbo.NegativeSentiments", "SentimentId", "dbo.Sentiments");
            DropForeignKey("dbo.PositiveSentiments", "SentimentId", "dbo.Sentiments");
            DropForeignKey("dbo.Relations", "Sentiment_SentimentDtoId", "dbo.Sentiments");
            DropForeignKey("dbo.Relations", "Publication_PublicationDtoId", "dbo.Publications");
            DropForeignKey("dbo.Relations", "Entity_EntityDtoId", "dbo.Entities");
            DropForeignKey("dbo.Publications", "Author_AuthorDtoId", "dbo.Authors");
            DropForeignKey("dbo.Alarms", "Entity_EntityDtoId", "dbo.Entities");
            DropIndex("dbo.AuthorAlarms", new[] { "AlarmId" });
            DropIndex("dbo.NegativeAlarms", new[] { "AlarmId" });
            DropIndex("dbo.PositiveAlarms", new[] { "AlarmId" });
            DropIndex("dbo.NegativeSentiments", new[] { "SentimentId" });
            DropIndex("dbo.PositiveSentiments", new[] { "SentimentId" });
            DropIndex("dbo.Relations", new[] { "Sentiment_SentimentDtoId" });
            DropIndex("dbo.Relations", new[] { "Publication_PublicationDtoId" });
            DropIndex("dbo.Relations", new[] { "Entity_EntityDtoId" });
            DropIndex("dbo.Publications", new[] { "Author_AuthorDtoId" });
            DropIndex("dbo.Alarms", new[] { "Entity_EntityDtoId" });
            DropTable("dbo.AuthorAlarms");
            DropTable("dbo.NegativeAlarms");
            DropTable("dbo.PositiveAlarms");
            DropTable("dbo.NegativeSentiments");
            DropTable("dbo.PositiveSentiments");
            DropTable("dbo.Sentiments");
            DropTable("dbo.Relations");
            DropTable("dbo.Publications");
            DropTable("dbo.Authors");
            DropTable("dbo.Entities");
            DropTable("dbo.Alarms");
        }
    }
}
