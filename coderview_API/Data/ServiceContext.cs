using Data;
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
        public DbSet<UserRol> UserRols { get; set; }
        public DbSet<FileItem> Files { get; set; }
        public DbSet<SkillsItem> Skills { get; set; }
        public DbSet<EvaluationItem> Evaluations { get; set; }
        public DbSet<EvaluationType> EvaluationTypes { get; set; }
        public DbSet<EvaluationState>EvaluationStates { get; set; }
        public DbSet<EvaluationValue> EvaluationValues { get; set; }
        public DbSet<Bootcamp_Content> Bootcamp_Contents { get; set; }
        public DbSet<Evaluation_Content> Evaluation_Contents { get; set; }
        public DbSet<ContentItem> Contents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<UserItem>(user =>
            {
                user.ToTable("t_users");
                user.HasOne<UserRol>().WithMany().HasForeignKey(u => u.UserRolId);

            });
            builder.Entity<FileItem>(file =>
            {
                file.ToTable("t_files");
            });

            builder.Entity<SkillsItem>(skills =>
            {
                skills.ToTable("t_skills");
            });
           
            builder.Entity<EvaluationItem>(e =>
            {
                e.ToTable("t_evaluations");
                e.HasOne<UserItem>().WithMany().HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);
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
            builder.Entity<EvaluationValue>(v =>
            {
                v.ToTable("t_evaluationValues");
            });
            builder.Entity<UserRol>(r =>
            {
                r.ToTable("t_userRols");
                r.Property(r => r.Id).ValueGeneratedNever();
            });
            builder.Entity<Evaluation_Content>(ec =>
            {
                ec.ToTable("t_evaluationContents");
                ec.HasOne<EvaluationItem>().WithMany().HasForeignKey(ec => ec.EvaluationId);
            });
            builder.Entity<Bootcamp_Content>(bc =>
            {
                bc.ToTable("t_bootcampContents");
                //bc.HasOne<BootcampItem>().WithMany().HasForeignKey(bc => bc.BootcampId);
            });
            builder.Entity<ContentItem>(c =>
            {
                c.ToTable("t_contents");
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