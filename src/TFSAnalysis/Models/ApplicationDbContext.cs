using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace TFSAnalysis.Models
{
    public class ApplicationDbContext : DbContext
    {
        //Table
        public virtual DbSet<DimChangeset> DimChangeset { get; set; }
        public virtual DbSet<DimPerson> DimPerson { get; set; }
        public virtual DbSet<DimTeamProject> DimTeamProject { get; set; }
        public virtual DbSet<DimBuild> DimBuild { get; set; }
        public virtual DbSet<DimBuildFlavor> DimBuildFlavor { get; set; }
        public virtual DbSet<DimBuildPlatform> DimBuildPlatform { get; set; }
        public virtual DbSet<DimTestResult> DimTestResult { get; set; }
        public virtual DbSet<FactBuildChangeset> FactBuildChangeset { get; set; }
        public virtual DbSet<FactBuildCoverage> FactBuildCoverage { get; set; }
        public virtual DbSet<FactTestResult> FactTestResult { get; set; }
        //View
        public virtual DbSet<BuildDetailsView> BuildDetailsView { get; set; }
        public virtual DbSet<BuildProjectView> BuildProjectView { get; set; }
        public virtual DbSet<User_BuildOverView> User_BuildOverView { get; set; }
        public virtual DbSet<User_BuildEveryDay> User_BuildEveryDay { get; set; }
        public virtual DbSet<User_BuildDefinition> User_BuildDefinition { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationHelper.ApplicationConfiguration["Data:DefaultConnection:ConnectionString"]);
        }

        private static ApplicationDbContext _context; 
        public static ApplicationDbContext AppDBContext
        {
            get
            {
                //if (_context == null)
                //{
                    _context = new ApplicationDbContext();
                //}
                return _context;
            }
        }
    }
}
