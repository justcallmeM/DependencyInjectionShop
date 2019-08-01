using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Utilities
{
    class BetterMarketplace : IMarketplace
    {
        public List<string> Products()
        {
            //galimas papildomas metodas sukurti produktu list'a dinamiskai. 

            List<string> products = new List<string>() {
                "ananasai",
                "obuoliai",
                "silauoges",
                "svogunai",
                "vista",
                "kukuruzai",
                "saldainis",
                "farsas"
            };

            return products;
        }
    }
}
