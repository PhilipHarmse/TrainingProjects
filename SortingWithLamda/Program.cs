using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWithLamda
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public IEnumerable<T> Sorting<T>(IEnumerable<T> collectionToBeSorted, Func<(T newItem,T toComapreWith), bool> sortingMethod)
        {
            for (int i = 0; i < collectionToBeSorted.Count(); i++)
            {
                var PosnewItem = collectionToBeSorted.ElementAt(i + 1) ;
                var PosItemToCompareWith = collectionToBeSorted.ElementAt(i);




                do while (PosnewItem > PosItemToCompareWith)
                    {
                        collectionToBeSorted.indexOf(i) = PosnewItem;
                        collectionToBeSorted.(i + 1) = PosItemToCompareWith;
                    }

            }
        }
    }
}
