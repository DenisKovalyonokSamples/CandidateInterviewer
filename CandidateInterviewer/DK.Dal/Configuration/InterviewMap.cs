using DK.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DK.Dal.Configuration
{
    public class InterviewMap : IEntityTypeConfiguration<Interview>
    {
        public void Configure(EntityTypeBuilder<Interview> builder)
        {
            builder.ToTable("Interview");

            builder.HasKey(ci => ci.Id);
            builder.Property(ci => ci.Id)
                .ForSqlServerUseSequenceHiLo("question_hilo")
                .IsRequired();

            builder.Property(a => a.Date)
                .IsRequired();

            builder.Property(a => a.Score)
                .IsRequired();

            builder.HasOne(ci => ci.Candidate)
                .WithMany()
                .HasForeignKey(ci => ci.CandidateId);

            builder.HasOne(ci => ci.Exam)
                .WithMany()
                .HasForeignKey(ci => ci.ExamId);
        }
    }
}
