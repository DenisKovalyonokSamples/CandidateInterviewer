using DK.Core.Base;
using DK.Core.Interfaces;
using DK.DataAccess.Enums;

namespace DK.DataAccess.Entities
{
    public class Exam : BaseEntity, IAggregateRoot
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public ExamType Type { get; set; }

        public Category Category { get; set; }
    }
}
