using System.Data.Entity;
using OelCheckLims.Model;

namespace OelCheckLims.LimsDbContext
{
    public class LimsContext : DbContext
    {

        public LimsContext(string connectionString = "LimsDbConnectionString")
           : base(connectionString)
        {

        }
        public DbSet<Batch> Batchs { get; set; }
        public DbSet<Sample> Samples { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BatchConfig());
            modelBuilder.Configurations.Add(new SampleConfig());
        }

    }
}
