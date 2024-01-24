using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarduriMeniu.Arbore.interfaces
{
    public interface IArbore<T> where T : Button
    {

        TreeNode<T> getNode();

        void afisare(TreeNode<T> node);

        List<T> getTsByChildren(TreeNode<T> node);

        TreeNode<T> findByValue(TreeNode<T> node, T value);

        void Add(T parinte, T value);

        TreeNode<T> findByChild(TreeNode<T> node, T value);

        void Delete(T value);

    }
}
