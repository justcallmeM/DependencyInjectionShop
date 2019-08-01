using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Utilities
{
    public class Hand : IHand
    {
        public List<int> Picking(List<string> products)
        {
            List<int> choosings = new List<int>();
            int counter = 0, itemsChosen = 0, number = 0;
            string endInner = String.Empty;
            bool continueOuter = true;

            Console.WriteLine("Choose products that you'd like to buy:\n");
            foreach(var item in products)
            {
                Console.WriteLine("{0}: {1} {2}", counter, item, Environment.NewLine);
                counter++;
            }
            Console.WriteLine(Environment.NewLine);

            while (continueOuter)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 2);
                Console.WriteLine("{0} Items chosen", itemsChosen);

                while (!Int32.TryParse(endInner = Console.ReadLine(), out number) || number > products.Count)
                {
                    if (endInner == String.Empty)
                    {
                        continueOuter = false;
                        break;
                    }

                    Console.SetCursorPosition(0, Console.CursorTop - 2);
                    Console.WriteLine("Invalid choice");
                }
                choosings.Add(number);
                itemsChosen++;
            }

            return choosings;
        }
    }
}
