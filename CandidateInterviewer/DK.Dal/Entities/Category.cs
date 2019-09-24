using DK.Dal.Entities.Base;

namespace DK.Dal.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
