namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTables : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Pop')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Indie')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Classic')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4, 5, 6)");
        }
    }
}
