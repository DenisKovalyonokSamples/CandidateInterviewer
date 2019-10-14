using DK.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DK.DataAccess.Configuration
{
    public class ResponseMap : IEntityTypeConfiguration<Response>
    {
        public void Configure(EntityTypeBuilder<Response> builder)
        {
            builder.ToTable("Response");

            builder.HasKey(ci => ci.Id);
            builder.Property(ci => ci.Id)
                       .ForSqlServerUseSequenceHiLo("response_hilo")
                       .IsRequired();

            builder.Property(a => a.Value)
                .IsRequired();

            builder.Property(a => a.IsApproved)
                .IsRequired();

            builder.Property(a => a.ApprovalType)
                .IsRequired();

            builder.HasOne(ci => ci.Interview)
                .WithMany()
                .HasForeignKey(ci => ci.InterviewId);

            builder.HasOne(ci => ci.Question)
                .WithMany()
                .HasForeignKey(ci => ci.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
