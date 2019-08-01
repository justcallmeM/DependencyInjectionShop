using System.Collections.Generic;

namespace Library.Utilities
{
    public interface ICart
    {
        List<string> AddToCart(List<string> products, List<int> choosings);
    }
}