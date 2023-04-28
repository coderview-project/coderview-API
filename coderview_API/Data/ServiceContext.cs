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
        public DbSet<EvaluationItem> Evaluations { get; set; }
        public DbSet<BootcampItem> Bootcamps { get; set; }
        public DbSet<BootcampStudent> BootCampStudents { get; set; }
        public DbSet<EvaluationValue> EvaluationValues { get; set; }
        public DbSet<EvaluationContent> EvaluationContents { get; set; }
        public DbSet<SkillsItem> Skills { get; set; }
        public DbSet<ContentItem> Contents { get; set; }
        public DbSet<EvaluationData> EvaluationDatas { get; set; }

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
            builder.Entity<EvaluationItem>(e =>
            {
                e.ToTable("t_evaluations");
                e.HasOne<UserItem>().WithMany().HasForeignKey(e => e.EvaluatorId).OnDelete(DeleteBehavior.Restrict);
                e.HasOne<UserItem>().WithMany().HasForeignKey(e => e.EvaluateeUserId);
            });
            builder.Entity<EvaluationContent>(ec =>
            {
                ec.ToTable("t_evaluationContents");
                ec.HasOne<EvaluationItem>().WithMany().HasForeignKey(ec => ec.EvaluationId);
                ec.HasOne<ContentItem>().WithMany().HasForeignKey(ec => ec.ContentId);

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
            builder.Entity<BootcampItem>(b =>
            {
                b.ToTable("t_bootcamps");
                b.HasOne<UserItem>().WithMany().HasForeignKey(b => b.CreatorId);
            });
            builder.Entity<BootcampStudent>(bs =>
            {
                bs.ToTable("t_bootcampStudents");
                bs.HasOne<BootcampItem>().WithMany().HasForeignKey(bs => bs.BootcampId);

            });
            builder.Entity<SkillsItem>(skills =>
            {
                skills.ToTable("t_skills");
            });

            builder.Entity<ContentItem>(c =>
            {
                c.ToTable("t_contents");
                c.HasOne<SkillsItem>().WithMany().HasForeignKey(c => c.SkillId);
            });
            builder.Entity<EvaluationData>(ed =>
            {
                ed.ToTable("t_evaluationDatas");
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