using Library.Utilities;
using System;
using System.Collections.Generic;

namespace Library
{
    public class BusinessLogic : IBusinessLogic
    {
        IMarketplace _marketplace;
        IHand _hand;
        ICart _cart;

        //ctor - tab, tab;
        public BusinessLogic(IMarketplace marketplace, IHand hand, ICart cart)
        {
            _marketplace = marketplace;
            _hand = hand;
            _cart = cart;
        }

        public void Shopping()
        {
            List<string> products = _marketplace.Products();
            List<int> choosings = _hand.Picking(products);
            List<string> cart = _cart.AddToCart(products, choosings);

            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("Your bag consists of: ");
            foreach(string item in cart)
            {
                Console.WriteLine(item);
            }

        }
    }
}
