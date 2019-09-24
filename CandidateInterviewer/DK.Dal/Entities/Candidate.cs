using DK.Dal.Entities.Base;

namespace DK.Dal.Entities
{
    public class Candidate : BaseEntity
    {
        public int InterviewId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }

        public Interview Interview { get; set; }

    }
}
