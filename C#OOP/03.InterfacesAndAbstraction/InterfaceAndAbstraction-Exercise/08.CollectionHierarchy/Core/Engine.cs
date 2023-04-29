using CollectionHierarchy.Core.Interfacess;
using CollectionHierarchy.Models;
using CollectionHierarchy.Models.Interfacess;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CollectionHierarchy.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            AddCollection listAdd = new AddCollection();
            AddRemoveCollection listAdddRemove = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] enter = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            AddToList(enter, listAdd);
            AddToList(enter, listAdddRemove);
            AddToList(enter, myList);

            int n = int.Parse(Console.ReadLine());

            RemoveFromList (listAdddRemove, n); 
            RemoveFromList (myList, n); 
        }

        private void RemoveFromList(IAddRemoveCollection someList, int n)
        {
            for (int i = 0; i < n; i++)
            {
                someList.Remove();
            }
            Console.WriteLine();
        }

        private void AddToList(string[] enter, IAddCollection soleList)
        {
            for (int i = 0; i < enter.Length; i++)
            {
                soleList.Add(enter[i]);
            }
            Console.WriteLine();
        }
    }
}
