using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CrowdfundingPlatform.Models
{
    public class PlatformDBContext : IdentityDbContext<User>
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Contribution> Contributions { get; set; }

        public PlatformDBContext(DbContextOptions<PlatformDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProjectTag>()
                .HasKey(t => new { t.ProjectId, t.TagId });

            modelBuilder.Entity<ProjectTag>()
                .HasOne(sc => sc.Project)
                .WithMany(s => s.ProjectTags)
                .HasForeignKey(sc => sc.ProjectId);

            modelBuilder.Entity<ProjectTag>()
                .HasOne(sc => sc.Tag)
                .WithMany(c => c.ProjectTags)
                .HasForeignKey(sc => sc.TagId);
        }
    }
}
