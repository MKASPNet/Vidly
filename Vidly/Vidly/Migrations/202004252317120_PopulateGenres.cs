namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres (Id, Name)" +
                "Values" +
                "(1, 'Comedy')," +
                "(2, 'Action')," +
                "(3, 'Family')," +
                "(4, 'Romance')" +
                "");
        }
        
        public override void Down()
        {
        }
    }
}
