using System;
using System.ComponentModel;

namespace shoes.Services
{
    /// <summary>
    /// PKGH: Список ролей пользователей
    /// </summary>
    public enum UserRole
    {
        [Description("Администратор")]
        Administrator, // 0
        
        [Description("Менеджер")]
        Manager // 1
    }

    public static class EnumExtensions
    {
        /// <summary>
        /// PKGH: Получение описания значения из Description
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns>Описание значения или его строчный вид</returns>
        public static string GetDescription(this System.Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null) return value.ToString();

            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));

            return attribute != null ? attribute.Description : value.ToString();
        }
    }

}
