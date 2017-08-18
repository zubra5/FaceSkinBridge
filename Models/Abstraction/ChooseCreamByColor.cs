
using System.Collections.Generic;
using System.Linq;
using FaceSkinBridge.Models.Implementation;

namespace FaceSkinBridge.Models.Abstraction
{
    public class ChooseCreamByColor : IChooseCream
    {
        public ColorSkin ColorSkin { get; set; }

        public ChooseCreamByColor(ColorSkin colorskin) {
            ColorSkin = colorskin;
        }
        public List<Cream> GetSuitableCream(List<Cream> creams)
        {
            return creams.Where(x => x.ColorSkin == ColorSkin.Color).ToList();
        }
    }
}