using DK.Core.Base;
using DK.Core.Interfaces;

namespace DK.DataAccess.Entities
{
    public class Category : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
    }
}
