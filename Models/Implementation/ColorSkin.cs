using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaceSkinBridge.Models.Implementation
{
    [Serializable]
    public abstract class ColorSkin
    {
        public virtual ColorEnum Color { get; set; }

        public virtual string  Description { get; set; }
    }
}