using System.ComponentModel.DataAnnotations;

namespace DK.DataAccess.Enums
{
    public enum ExamType : int
    {
        [Display(Name = "Unknown")]
        Unknown = 0,

        [Display(Name = "Base")]
        Base = 1,

        [Display(Name = "Intermediate")]
        Intermediate = 2,

        [Display(Name = "Advanced")]
        Advanced = 3
    }
}
