using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models.Interfacess
{
    public interface MyList : IAddRemoveCollection
    {
        public int Used { get; }
    }
}
