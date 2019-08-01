using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Utilities
{
    public class Cart : ICart
    {
        public List<string> AddToCart(List<string> products, List<int> choosings)
        {
            List<string> bag = new List<string>();

            foreach(int item in choosings)
            {
                bag.Add(products[item]);
            }

            return bag;
        }
    }
}
