namespace gamestation.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<gamestation.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "gamestation.Models.ApplicationDbContext";
        }

        protected override void Seed(gamestation.Models.ApplicationDbContext context)
        {
         
        }
    }
}
