using FaceSkinBridge.Models.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaceSkinBridge.Models.Abstraction
{
    public static class CreamRepository
    {
        public static  List<Cream> GetCreams() {
            List<Cream> creams = new List<Cream>();

            foreach (ColorEnum color in Enum.GetValues(typeof(ColorEnum)))
            {
                foreach (SensitivityLevels sLevel in Enum.GetValues(typeof(SensitivityLevels)))
                {
                    creams.Add(new Cream() { SensitivityLevel= sLevel, ColorSkin=color, Name=$"Cream for {sLevel} with color {color}" });
                }
            }

            return creams;
        }
    }
}