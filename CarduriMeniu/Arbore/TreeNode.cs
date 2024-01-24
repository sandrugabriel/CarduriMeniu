using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarduriMeniu.Arbore
{
    public class TreeNode<T>
    {
        public List<TreeNode<T>> Children { get; set; }

        public T Value { get; set; }

        public bool IsExpend { get; set; }

    }
}
