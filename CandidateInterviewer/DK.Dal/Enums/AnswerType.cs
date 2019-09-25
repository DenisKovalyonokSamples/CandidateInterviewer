using System.ComponentModel.DataAnnotations;

namespace DK.DataAccess.Enums
{
    public enum AnswerType : int
    {
        [Display(Name = "Unknown")]
        Unknown = 0,

        [Display(Name = "Text")]
        Text = 1,

        [Display(Name = "Radio")]
        Radio = 2,

        [Display(Name = "Collection")]
        Collection = 3
    }
}
