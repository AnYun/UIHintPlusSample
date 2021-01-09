using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIHintPlusSample
{
    /// <summary>
    /// HtmlHelper Extension
    /// </summary>
    public static class HtmlHelperExtension
    {
        /// <summary>
        /// 用指定的 key 去抓 AdditionalValues 中的Value
        /// </summary>
        public static string GetAdditionalValue(this IHtmlHelper helper, string key)
        {
            return GetAdditionalValue<string>(helper, key, default);
        }
        /// <summary>
        /// 用指定的 key 去抓 AdditionalValues 中的Value
        /// </summary>
        public static T GetAdditionalValue<T>(this IHtmlHelper helper, string key)
        {
            return GetAdditionalValue<T>(helper, key, default);
        }
        /// <summary>
        /// 用指定的 key 去抓 AdditionalValues 中的Value
        /// 並在沒有設定時傳回預設值
        /// </summary>
        public static T GetAdditionalValue<T>(this IHtmlHelper helper, string key, T defaultValue)
        {
            var dic = helper.ViewContext.ViewData.ModelMetadata.AdditionalValues;
            if (dic != null && dic.ContainsKey(key))
            {
                var value = dic[key].ToConvertOrDefault<T>(defaultValue);
                return value;
            }
            return defaultValue;
        }
    }
}
