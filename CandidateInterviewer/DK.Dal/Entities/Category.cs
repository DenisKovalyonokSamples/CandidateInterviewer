using DK.Core.Base;

namespace DK.DataAccess.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
    }
}
