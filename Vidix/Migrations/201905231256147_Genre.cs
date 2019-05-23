namespace Vidix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Id, Name) values(1, 'Action')");
            Sql("Insert into Genres (Id, Name) values(2, 'Adventure')");
            Sql("Insert into Genres (Id, Name) values(3, 'Comedy')");
            Sql("Insert into Genres (Id, Name) values(4, 'Family')");
            Sql("Insert into Genres (Id, Name) values(5, 'Romance')");
            Sql("Insert into Genres (Id, Name) values(6, 'Thriller')");

        }

        public override void Down()
        {
        }
    }
}
