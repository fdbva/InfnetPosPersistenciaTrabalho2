using System.Collections.Generic;
using Infnet.Pos.Persistencia.Trabalho2.Domain.Entities;

namespace Infnet.Pos.Persistencia.Trabalho2.Infra.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Infnet.Pos.Persistencia.Trabalho2.Infra.MusicStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Infnet.Pos.Persistencia.Trabalho2.Infra.MusicStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var order = new Order
            {
                OrderId = 1,
                User = new User
                {
                    UserName = "User1",
                    Email = "user1@email1.com"
                },
                Albums = new List<Album>
                {
                    new Album
                    {
                        Title = "album1",
                        Description = "album1Description",
                        Genre = new Genre
                        {
                            Name = "genre1"
                        }
                    }
                }
            };
            context.Orders.AddOrUpdate(order);
        }
    }
}
