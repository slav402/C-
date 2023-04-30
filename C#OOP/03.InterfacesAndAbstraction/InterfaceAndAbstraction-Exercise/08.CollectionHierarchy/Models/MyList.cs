using CollectionHierarchy.Models.Interfacess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CollectionHierarchy.Models
{
    public class MyList : IMyList
    {
        private const int addIndex = 0;
        private const int removeIndex = 0;

        private List<string> listOfItems;

        public MyList()
        {
            listOfItems = new List<string>();
        }

        public void Add(string item)
        {
            listOfItems.Insert(addIndex, item);

            Console.Write($"{addIndex} ");
        }

        public void Remove()
        {
            Console.Write(listOfItems[removeIndex] + " ");
            listOfItems.RemoveAt(removeIndex);
        }

        public void Used()
        {
            Console.WriteLine(listOfItems.Count);
        }
    }
}
