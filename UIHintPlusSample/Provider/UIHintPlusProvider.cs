using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UIHintPlusSample
{
    /// <summary>
    /// 加強 UIHint 功能
    /// </summary>
    public class UIHintPlusProvider : IDisplayMetadataProvider
    {
        public UIHintPlusProvider() { }

        public void CreateDisplayMetadata(DisplayMetadataProviderContext context)
        {
            if (context.PropertyAttributes != null)
            {
                foreach (object propAttr in context.PropertyAttributes)
                {
                    UIHintAttribute uiHintAttribute = propAttr as UIHintAttribute;
                    if (uiHintAttribute != null && uiHintAttribute.ControlParameters != null)
                    {
                        foreach (var item in uiHintAttribute.ControlParameters)
                        {
                            context.DisplayMetadata.AdditionalValues.Add(item.Key, item.Value);
                        }
                    }
                }
            }
        }
    }
}
