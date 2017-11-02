using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NineYi.BurgerShop.Commons.Helpers
{
    /// <summary>
    /// 列舉協助程式。
    /// </summary>
    public class EnumHelper
    {
        /// <summary>
        /// 取得列舉描述集合。
        /// </summary>
        /// <typeparam name="TEnum">列舉型別。</typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentException">TEnum</exception>
        public static IDictionary<TEnum, string> GetDescriptions<TEnum>()
            where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            var enumType = typeof(TEnum);
            if (enumType.IsEnum == false)
            {
                throw new ArgumentException(nameof(TEnum));
            }

            var descriptions = new Dictionary<TEnum, string>();

            foreach (TEnum enumValue in Enum.GetValues(enumType))
            {
                var enumName = enumValue.ToString();

                var descriptionAttributes =
                    enumValue.GetType().GetField(enumName)
                    .GetCustomAttributes(typeof(DescriptionAttribute), false);

                var description = descriptionAttributes.Length > 0
                    ? ((DescriptionAttribute)descriptionAttributes[0]).Description
                    : enumName;

                descriptions.Add(enumValue, description);
            }

            return descriptions;
        }
    }
}