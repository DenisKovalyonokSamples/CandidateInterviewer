using DK.Core.Base;
using DK.Core.Interfaces;

namespace DK.DataAccess.Entities
{
    public class Candidate : BaseEntity, IAggregateRoot
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
