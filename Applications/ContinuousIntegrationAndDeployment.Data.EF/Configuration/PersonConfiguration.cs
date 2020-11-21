using ContinuousIntegrationAndDeployment.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContinuousIntegrationAndDeployment.Data.EF.Configuration
{
  public class PersonConfiguration : IEntityTypeConfiguration<Person>
  {
    public void Configure(EntityTypeBuilder<Person> builder)
    {
//      builder.ToTable("People");
      builder.HasKey(x => x.Id);
      builder.Property(x => x.FirstName).HasMaxLength(20);
      builder.Property(x => x.LastName).HasMaxLength(20);
    }
  }
}
