using CollectionHierarchy.Core.Interfacess;
using CollectionHierarchy.Models;
using CollectionHierarchy.Models.Interfacess;
using System;
using System.Collections.Generic;
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

            for (int i = 0; i < enter.Length; i++)
            {
                listAdd.Add(enter[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < enter.Length; i++)
            {
                listAdddRemove.Add(enter[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < enter.Length; i++)
            {
                myList.Add(enter[i]);
            }
            Console.WriteLine();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                listAdddRemove.Remove();
                myList.Remove();
            }

            Console.WriteLine(String.Join(" ", listAdddRemove));
            Console.WriteLine(String.Join(" ", myList));

        }
    }
}
