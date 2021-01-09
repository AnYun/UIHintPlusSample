using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIHintPlusSample
{
    /// <summary>
    /// Object Extension
    /// </summary>
    public static class ObjectExtension
    {
        /// <summary>
        /// 轉型或取得預設值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static T ToConvertOrDefault<T>(this object obj, T defaultValue)
        {
            try
            {
                return (T)Convert.ChangeType(obj, typeof(T));
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
