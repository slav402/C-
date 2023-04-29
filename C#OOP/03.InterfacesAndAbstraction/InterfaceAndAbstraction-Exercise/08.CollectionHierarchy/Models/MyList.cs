using CollectionHierarchy.Models.Interfacess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CollectionHierarchy.Models
{
    public class MyList : IMyList
    {
        const int inputIndex = 0;

        private List<string> listOfItems;

        public MyList()
        {
            listOfItems = new List<string>();
        }

        public void Add(string item)
        {
            listOfItems.Insert(inputIndex, item);

            Console.Write($"{inputIndex} ");
        }

        public void Remove()
        {
            Console.Write(listOfItems[inputIndex] + " ");
            listOfItems.RemoveAt(inputIndex);
        }

        public void Used()
        {
            Console.WriteLine(listOfItems.Count);
        }
    }
}
