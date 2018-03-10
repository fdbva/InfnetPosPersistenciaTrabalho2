using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infnet.Pos.Persistencia.Trabalho2.Domain.Entities;
using Infnet.Pos.Persistencia.Trabalho2.Infra.Mappings;

namespace Infnet.Pos.Persistencia.Trabalho2.Infra
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext() : base("MusicStoreContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumConfig());
            modelBuilder.Configurations.Add(new GenreConfig());
            modelBuilder.Configurations.Add(new OrderConfig());
            modelBuilder.Configurations.Add(new UserConfig());
        }
    }
}
