using DK.Core;
using DK.DataAccess.Enums;

namespace DK.Web.Managers
{
    public static class MediaManager
    {
        public static string GetIconForExamType(ExamType type)
        {
            string result = string.Empty;

            switch (type)
            {
                case ExamType.Base:
                    result = Constants.BASE_TYPE_ICO;
                    break;
                case ExamType.Intermediate:
                    result = Constants.INTERMEDIATE_TYPE_ICO;
                    break;
                case ExamType.Advanced:
                    result = Constants.ADVANCED_TYPE_ICO;
                    break;
                default:
                    result = Constants.UNKNOWN_TYPE_ICO;
                    break;
            }

            return result;
        }
    }
}
