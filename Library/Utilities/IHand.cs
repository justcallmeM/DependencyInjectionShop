using System.Collections.Generic;

namespace Library.Utilities
{
    public interface IHand
    {
        List<int> Picking(List<string> products);
    }
}