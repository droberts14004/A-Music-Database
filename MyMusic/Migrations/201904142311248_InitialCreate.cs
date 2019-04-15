namespace MyMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musics",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Song = c.String(),
                        Artist = c.String(),
                        Album = c.String(),
                        Genre = c.String(),
                        ReleaseYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musics");
        }
    }
}
