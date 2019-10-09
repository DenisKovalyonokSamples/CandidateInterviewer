using DK.DataAccess.Enums;

namespace DK.Web.Managers
{
    public static class MediaManager
    {
        private const string BASE_TYPE_ICO = "ic-relationships.png";
        private const string INTERMEDIATE_TYPE_ICO = "ic-management.png";
        private const string ADVANCED_TYPE_ICO = "ic-knowleage.png";
        private const string UNKNOWN_TYPE_ICO = "ic-work.png";

        public static string GetIconForExamType(ExamType type)
        {
            string result = string.Empty;

            switch (type)
            {
                case ExamType.Base:
                    result = BASE_TYPE_ICO;
                    break;
                case ExamType.Intermediate:
                    result = INTERMEDIATE_TYPE_ICO;
                    break;
                case ExamType.Advanced:
                    result = ADVANCED_TYPE_ICO;
                    break;
                default:
                    result = UNKNOWN_TYPE_ICO;
                    break;
            }

            return result;
        }
    }
}
