using DK.Dal.Entities.Base;

namespace DK.Dal.Entities
{
    public class Exam : BaseEntity
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }
    }
}
