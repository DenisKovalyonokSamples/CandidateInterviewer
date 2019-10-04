using DK.DataAccess.Enums;

namespace DK.Web.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public AreaType Type { get; set; }
    }
}
