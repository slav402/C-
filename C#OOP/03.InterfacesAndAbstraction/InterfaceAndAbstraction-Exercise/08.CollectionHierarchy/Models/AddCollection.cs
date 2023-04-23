using CollectionHierarchy.Models.Interfacess;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class AddCollection : IAddCollection
    {
        private List<string> listOfItems;

        public AddCollection()
        {
            listOfItems = new List<string>();
        }

        public int Add(string item)
        {
            listOfItems.Add(item);

            return listOfItems.Count-1;
        }
    }
}
