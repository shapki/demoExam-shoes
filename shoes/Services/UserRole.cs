using System;
using System.ComponentModel;

namespace shoes.Services
{
    public enum UserRole
    {
        [Description("Администратор")]
        Administrator, // 0
        
        [Description("Менеджер")]
        Manager // 1
    }

    public static class EnumExtensions
    {
        public static string GetDescription(this System.Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null) return value.ToString();

            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));

            return attribute != null ? attribute.Description : value.ToString();
        }
    }

}
