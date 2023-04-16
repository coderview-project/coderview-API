﻿using Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }
        public DbSet<UserItem> Users { get; set; }
        public DbSet<FileItem> Files { get; set; }
        public DbSet<EvaluationItem> Evaluations { get; set; }
        public DbSet<EvaluationType> EvaluationTypes { get; set; }
        public DbSet<EvaluationState>EvaluationStates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<UserItem>(user =>
            {
                user.ToTable("t_users");

            });
            builder.Entity<FileItem>(file =>
            {
                file.ToTable("t_files");
            });
            builder.Entity<EvaluationItem>(e =>
            {
                e.ToTable("t_evaluations");
                e.HasOne<UserItem>().WithMany().HasForeignKey(e => e.UserId);
                e.HasOne<UserItem>().WithMany().HasForeignKey(e => e.EvaluateeUserId);
                e.HasOne<EvaluationType>().WithMany().HasForeignKey(e => e.TypeId);
                e.HasOne<EvaluationState>().WithMany().HasForeignKey(e => e.StateId);
                e.HasOne<EvaluationValue>().WithMany().HasForeignKey(e => e.ValueId);
            });
            builder.Entity<EvaluationType>(t =>
            {
                t.ToTable("t_evaluationTypes");
            });
            builder.Entity<EvaluationState>(s =>
            {
                s.ToTable("t_evaluationStates");
            });
            

        }
    }
    public class ServiceContextFactory : IDesignTimeDbContextFactory<ServiceContext>
    {
        public ServiceContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", false, true);
            var config = builder.Build();
            var connectionString = config.GetConnectionString("ServiceContext");
            var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("ServiceContext"));

            return new ServiceContext(optionsBuilder.Options);
        }
    }
}