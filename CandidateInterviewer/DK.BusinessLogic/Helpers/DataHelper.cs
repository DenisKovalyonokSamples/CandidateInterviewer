using DK.Core;
using DK.DataAccess.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DK.BusinessLogic.Helpers
{
    public static class DataHelper
    {
        #region Public Methods

        /// <summary>
        /// Gets an attribute dislay name on an enum field value
        /// </summary>        
        /// <param name="enumeration">The enum value</param>
        /// <returns>The Display attribute (Name), or the underlying value if no annotation is present</returns>
        public static string GetEnumDisplayName(this Enum enumeration)
            => enumeration.DisplayName();

        /// <summary>
        /// Gets an attribute dislay color class on an enum field value
        /// </summary>        
        /// <param name="enumeration">ExamType enum value</param>
        /// <returns>The Dislay Color Class</returns>
        public static string GetEnumDisplayColorClass(this ExamType enumeration)
            => enumeration.DisplayColorClass();

        #endregion

        #region Private Methods

        private static string DisplayName(this Enum value)
        {
            if (value == null)
            {
                return String.Empty;
            }

            var enumType = value.GetType();
            var enumValue = Enum.GetName(enumType, value);
            if (enumValue == null)
            {
                return String.Empty;
            }

            var members = enumType.GetMember(enumValue);

            if (!members.Any())
            {
                return String.Empty;
            }

            var member = members[0];

            var attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);
            var attr = attrs.FirstOrDefault() as DisplayAttribute;
            var outString = attr?.Name;

            if (attr?.ResourceType != null)
            {
                outString = attr.GetName();
            }

            return outString ?? enumValue;
        }

        private static string DisplayColorClass(this ExamType value)
        {
            string colorClass = string.Empty;

            switch (value)
            {
                case ExamType.Base:
                    colorClass = Constants.BASE_TYPE_COLOR_CLASS;
                    break;
                case ExamType.Intermediate:
                    colorClass = Constants.INTERMEDIATE_TYPE_COLOR_CLASS;
                    break;
                case ExamType.Advanced:
                    colorClass = Constants.ADVANCED_TYPE_COLOR_CLASS;
                    break;
                default:
                    colorClass = Constants.UNKNOWN_TYPE_COLOR_CLASS;
                    break;
            }

            return colorClass;
        }

        #endregion
    }
}
