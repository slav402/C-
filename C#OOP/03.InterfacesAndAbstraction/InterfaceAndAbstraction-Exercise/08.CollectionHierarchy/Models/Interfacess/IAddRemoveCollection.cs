using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models.Interfacess
{
    public interface IAddRemoveCollection : IAddCollection
    {
        int Remove(string item);
    }
}
