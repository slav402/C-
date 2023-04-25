using CollectionHierarchy.Core.Interfacess;
using CollectionHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            AddCollection list = new AddCollection();

            string[] enter = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < enter.Length; i++)
            {
                list.Add(enter[i]);
            }
        }
    }
}
