using DK.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DK.DataAccess.Configuration
{
    public class AnswerMap : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.ToTable("Answer");

            builder.HasKey(ci => ci.Id);
            builder.Property(ci => ci.Id)
                       .ForSqlServerUseSequenceHiLo("answer_hilo")
                       .IsRequired();

            builder.Property(a => a.Value)
                .IsRequired();

            builder.Property(a => a.IsCorrect)
                .IsRequired();

            builder.HasOne(ci => ci.Question)
                .WithMany()
                .HasForeignKey(ci => ci.QuestionId);
        }
    }
}
