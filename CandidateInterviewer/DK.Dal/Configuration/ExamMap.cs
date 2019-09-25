using DK.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DK.DataAccess.Configuration
{
    public class ExamMap : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.ToTable("Exam");

            builder.HasKey(ci => ci.Id);
            builder.Property(ci => ci.Id)
                       .ForSqlServerUseSequenceHiLo("question_hilo")
                       .IsRequired();

            builder.Property(a => a.Name)
                .HasMaxLength(100);

            builder.Property(a => a.Description)
                .HasMaxLength(180);

            builder.Property(a => a.Logo)
                .IsRequired();

            builder.Property(a => a.Type)
                .IsRequired();

            builder.HasOne(ci => ci.Category)
                .WithMany()
                .HasForeignKey(ci => ci.CategoryId);
        }
    }
}
