using System.ComponentModel.DataAnnotations;

namespace DK.DataAccess.Enums
{
    public enum ApprovalType : int
    {
        [Display(Name = "Unknown")]
        Unknown = 0,

        [Display(Name = "Automatical")]
        Automatical = 1,

        [Display(Name = "Manual")]
        Manual = 2,

        [Display(Name = "Rejected")]
        Rejected = 3
    }
}
