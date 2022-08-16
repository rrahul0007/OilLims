using System.Data.Entity.ModelConfiguration;
using OelCheckLims.Model;

namespace OelCheckLims.LimsDbContext
{
  public class BatchConfig : EntityTypeConfiguration<Batch>
    {
        #region Create Batch Table in Sql Server LimsDB database
        public BatchConfig()
        {
            HasKey(batch => batch.BatchId);
            ToTable("Batch");
        }

        #endregion
    }
}
