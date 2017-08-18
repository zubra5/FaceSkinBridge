using FaceSkinBridge.Models.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaceSkinBridge.Models.Abstraction
{
    public class ChooseCreamByType : IChooseCream
    {
        public TypeSkin TypeSkin { get; set; }

        public ChooseCreamByType(TypeSkin typeskin)
        {
            TypeSkin = typeskin;
        }
        public List<Cream> GetSuitableCream(List<Cream> creams)
        {
            return creams.Where(x => x.SensitivityLevel == TypeSkin.SensitivityLevel).ToList();
        }
    }
}