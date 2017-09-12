﻿using NAControl.Domain.Models;
using NAControl.Infraestructure.Data.Map;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NAControl.Infraestructure.Data
{
    public class AppDataContext: DbContext
    {
        public AppDataContext() : base("AppConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Meeting> Meetings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
           .Where(p => p.Name == p.ReflectedType.Name + "Id")
           .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
            .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new MeetingMap());

        }
    }
}
