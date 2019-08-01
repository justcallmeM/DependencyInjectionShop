using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Utilities
{
    public class Marketplace : IMarketplace
    {
        public List<string> Products()
        {
            //galimas papildomas metodas sukurti produktu list'a dinamiskai. 

            List<string> products = new List<string>() {
                "Kopustas",
                "Kecupas",
                "Makaronai",
                "Pomidorai",
                "Mesa",
                "Prieskoniai"
            };

            return products;
        }
    }
}
