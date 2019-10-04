using System.ComponentModel.DataAnnotations;

namespace DK.DataAccess.Enums
{
    public enum AreaType : int
    {
        [Display(Name = "Unknown")]
        Unknown = 0,

        [Display(Name = "Mobile Development")]
        MobileDevelopment = 1,

        [Display(Name = "Web Development")]
        WebDevelopment = 2,

        [Display(Name = "Quality Assurance")]
        QualityAssurance = 3,

        [Display(Name = "Management")]
        Management = 4
    }
}
