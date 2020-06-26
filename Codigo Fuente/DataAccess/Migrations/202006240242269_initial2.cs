namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NeutralSentiments",
                c => new
                    {
                        SentimentId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.SentimentId)
                .ForeignKey("dbo.Sentiments", t => t.SentimentId)
                .Index(t => t.SentimentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NeutralSentiments", "SentimentId", "dbo.Sentiments");
            DropIndex("dbo.NeutralSentiments", new[] { "SentimentId" });
            DropTable("dbo.NeutralSentiments");
        }
    }
}
