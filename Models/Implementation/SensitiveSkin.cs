using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaceSkinBridge.Models.Implementation
{
    [Serializable]
    public class SensitiveSkin : TypeSkin
    {
        public override SensitivityLevels SensitivityLevel
        {
            get
            {
                return SensitivityLevels.Sensitive;
            }
        }

        public override string Description
        {
            get
            {
                return "Sensitive skin is a skin condition in which skin is prone to itching and irritation experienced as a subjective sensation when using cosmetics and toiletries";
            }
        }
      
    }
}