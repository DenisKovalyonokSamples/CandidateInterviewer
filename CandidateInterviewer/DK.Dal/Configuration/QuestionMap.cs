using DK.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DK.DataAccess.Configuration
{
    public class QuestionMap : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Question");

            builder.HasKey(ci => ci.Id);
            builder.Property(ci => ci.Id)
                       .ForSqlServerUseSequenceHiLo("question_hilo")
                       .IsRequired();

            builder.Property(a => a.Title)
                .IsRequired();

            builder.Property(a => a.Notes)
                .IsRequired();

            builder.Property(a => a.Type)
                .IsRequired();

            builder.Property(a => a.Score)
                .IsRequired();

            builder.HasOne(ci => ci.Exam)
                .WithMany()
                .HasForeignKey(ci => ci.ExamId);
        }
    }
}
