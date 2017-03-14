namespace HomeCinema.Data.Migrations
{
    using HomeCinema.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeCinema.Data.HomeCinemaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HomeCinema.Data.HomeCinemaContext context)
        {
        }
    }
}
