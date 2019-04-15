namespace MyMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Musics", "Song", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Musics", "Artist", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Musics", "Album", c => c.String(maxLength: 60));
            AlterColumn("dbo.Musics", "Genre", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Musics", "Genre", c => c.String());
            AlterColumn("dbo.Musics", "Album", c => c.String());
            AlterColumn("dbo.Musics", "Artist", c => c.String());
            AlterColumn("dbo.Musics", "Song", c => c.String());
        }
    }
}
