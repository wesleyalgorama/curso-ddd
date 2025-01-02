namespace Kernel.Infra.Repositories.Mapping;

using Kernel.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SequenceConfiguration : IEntityTypeConfiguration<Sequence>
{
    public void Configure(EntityTypeBuilder<Sequence> builder)
    {
        builder.ToContainer("Kernel");
        builder.HasPartitionKey(x => x.Discriminator);
    }
}
