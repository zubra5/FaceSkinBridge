
using System.Collections.Generic;

namespace FaceSkinBridge.Models.Abstraction
{
    interface IChooseCream
    {

        List<Cream> GetSuitableCream(List<Cream> creams);
    }
}
