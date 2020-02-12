using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebITYard.Repositories.Models;

namespace WebITYard.DAL.Configurations
{
    // see https://www.learnentityframeworkcore.com/configuration/fluent-api
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(t => t.Age)
                .IsRequired();

            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);
        }

    }
}
