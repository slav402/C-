using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models.Interfacess
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private const int inputIndex = 0;

        private List<string> listOfItems;

        public AddRemoveCollection()
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
            Console.Write($"{listOfItems[listOfItems.Count - 1]} ");

            listOfItems.RemoveAt(listOfItems.Count - 1);
        }
    }
}
