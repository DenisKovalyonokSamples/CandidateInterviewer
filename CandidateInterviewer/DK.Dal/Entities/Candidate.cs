using DK.Core.Base;

namespace DK.DataAccess.Entities
{
    public class Candidate : BaseEntity
    {
        public int InterviewId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public Interview Interview { get; set; }

    }
}
