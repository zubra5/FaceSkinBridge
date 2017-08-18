using FaceSkinBridge.Models.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaceSkinBridge.Models.Abstraction
{
    [Serializable]
    public class Cream
    {
        public SensitivityLevels SensitivityLevel { get; set; }

        public ColorEnum ColorSkin { get; set; }

        public string Name { get; set; }
    }
}