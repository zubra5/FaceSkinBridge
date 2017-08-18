
using System;

namespace FaceSkinBridge.Models.Implementation
{
    [Serializable]
    abstract public class TypeSkin
    {
        public virtual SensitivityLevels SensitivityLevel {  get; set; }

        public virtual string Description { get; set; }
    
    }
}