using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaceSkinBridge.Models.Implementation
{
    [Serializable]
    public class VanillaSkin : ColorSkin
    {
        public override ColorEnum Color
        {
            get
            {
                return ColorEnum.Vanilla;
            }
        }

        public override string Description
        {
            get
            {
                return "The color vanilla is a rich tint of off-white as well as a medium pale tint of yellow";
            }
        }
    }
}