using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
public interface IBinaryTree<TItem> where TItem:IComparable<TItem>
    {
        /// <summary></summary>
        /// <param name="newItem"</param>
        void Add(TItem newItem);
        /// <summary>
        /// </summary>
        /// <param name="itemToRemove"></param>
        void Remove(TItem itemToRemove);

        /// <summary>
        /// </summary>
        void WalkTree();
    }
    
}
