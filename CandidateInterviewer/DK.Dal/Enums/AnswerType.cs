using System.ComponentModel.DataAnnotations;

namespace DK.DataAccess.Enums
{
    public enum AnswerType : int
    {
        [Display(Name = "Unknown")]
        Unknown = 0,

        [Display(Name = "Text")]
        Text = 1,

        [Display(Name = "Single")]
        Single = 2,

        [Display(Name = "Multiple")]
        Multiple = 3
    }
}
