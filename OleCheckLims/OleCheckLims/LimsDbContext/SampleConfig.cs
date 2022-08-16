using System.Data.Entity.ModelConfiguration;
using OelCheckLims.Model;

namespace OelCheckLims.LimsDbContext
{
   public class SampleConfig : EntityTypeConfiguration<Sample>
    {
        #region Create Sample Table in Sql Server LimsDB database
        public SampleConfig()
        {
            HasKey(batch => batch.SampleId);
            HasRequired(p => p.Batch).WithMany(batch => batch.Samples).WillCascadeOnDelete(false);
            Property(sample => sample.TestClass).IsRequired().HasMaxLength(50);
            Property(sample => sample.Hint).IsOptional().HasMaxLength(50);
            Property(sample => sample.ReceivedDate).HasColumnType("datetime").IsRequired();
            Property(sample => sample.Position).IsRequired();
            Property(sample => sample.Col).IsRequired();
            Property(sample => sample.Row).IsRequired();
            ToTable("Sample");
        }
        #endregion

    }
}
