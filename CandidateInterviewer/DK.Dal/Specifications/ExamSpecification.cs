using DK.Core.Base;
using DK.DataAccess.Entities;
using DK.DataAccess.Enums;

namespace DK.DataAccess.Specifications
{
    public sealed class ExamSpecification : BaseSpecification<Exam>
    {
        public ExamSpecification(int categoryId, ExamType type)
            : base(e => e.CategoryId == categoryId && e.Type == type)
        {
            AddInclude(x => x.Category);
        }
    }
}
