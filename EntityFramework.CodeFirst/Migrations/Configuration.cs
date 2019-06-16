namespace EntityFramework.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramework.CodeFirst.Data.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFramework.CodeFirst.Data.EFContext context)
        {
            context.Tags.AddOrUpdate(a => a.Name, new Models.Tag()
            {
                Name = "Tag 1"
            });

            context.Tags.AddOrUpdate(a => a.Name, new Models.Tag()
            {
                Name = "Tag 2"
            });
            context.Tags.AddOrUpdate(a => a.Name, new Models.Tag()
            {
                Name = "Tag 3"
            });

            context.Tags.AddOrUpdate(a => a.Name, new Models.Tag()
            {
                Name = "Tag 3"
            });
            context.Tags.AddOrUpdate(a => a.Name, new Models.Tag()
            {
                Name = "Tag 4"
            });
        }
    }
}
