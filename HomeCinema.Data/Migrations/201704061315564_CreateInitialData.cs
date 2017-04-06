namespace HomeCinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateInitialData : DbMigration
    {
        public override void Up()
        {
            Sql(MigrationHelper.ReadSqlFile("InitialDataHomeCinema.sql"));
        }
        
        public override void Down()
        {
        }
    }
}
