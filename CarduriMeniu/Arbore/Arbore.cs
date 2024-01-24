using CarduriMeniu.Arbore.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarduriMeniu.Arbore
{
    public class Arbore<T> : IArbore<T> where T : Button
    {

        private TreeNode<T> _root = null;

        public TreeNode<T> getNode()
        {
            return _root;
        }

        public void afisare(TreeNode<T> node)
        {
            if (node != null)
            {
                MessageBox.Show(node.Value.ToString());

                if (node.Children != null)
                {
                    for (int i = 0; i < node.Children.Count; i++)
                    {
                        afisare(node.Children[i]);
                    }
                }

            }
        }

        public TreeNode<T> findByValue(TreeNode<T> node, T value)
        {
            if (node != null)
            {
                if (node.Value == value)
                {
                    return node;
                }

                for (int i = 0; i < node.Children.Count; i++)
                {
                    if (node.Children[i].Value == value) return node.Children[i];

                    if (i >= node.Children.Count - 1)
                        return findByValue(node.Children[i], value);
                }

            }

            return null;
        }

        public List<T> findByNode(TreeNode<T> node, TreeNode<T> parent)
        {
            if (node != null)
            {
                if (node == parent)
                {
                    List<T> list = new List<T>();
                    for (int i = 0; i < parent.Children.Count; i++)
                        list.Add(parent.Children[i].Value);
                    return list;
                }

                for (int i = 0; i < node.Children.Count; i++)
                {
                    return findByNode(node.Children[i], parent);
                }
            }

            return null;
        }

        public void Add(T parinte, T value)
        {

            if (_root == null || parinte == null)
            {
                _root = new TreeNode<T>();
                _root.Value = value;
                _root.Children = new List<TreeNode<T>>();
            }
            else
            {
                TreeNode<T> aux = findByValue(_root, parinte);
                TreeNode<T> nou = new TreeNode<T>();
                nou.Value = value;
                nou.Children = new List<TreeNode<T>>();

                if (aux.Children != null)
                    aux.Children.Add(nou);
                else
                    aux.Children = new List<TreeNode<T>>() { nou };
            }

        }

        public TreeNode<T> findByChild(TreeNode<T> node, T value)
        {
            if (node != null)
            {
                for (int i = 0; i < node.Children.Count; i++)
                {
                    if (node.Children[i].Value.Text == value.Text)
                    {
                        return node;
                    }
                }

                for (int i = 0; i < node.Children.Count; i++)
                {

                    return findByChild(node.Children[i], value);
                }
            }

            return null;
        }

        public void Delete(T value)
        {

            TreeNode<T> parinte = findByChild(_root, value);

            for (int i = 0; i < parinte.Children.Count; i++)
            {
                if (parinte.Children[i].Value.Text == value.Text)
                {
                    parinte.Children.RemoveAt(i);
                }
            }


        }

        public TreeNode<T> findByValue1(TreeNode<T> node, T value)
        {
            if (node != null)
            {
                if (node.Value == value)
                {
                    return node;
                }

                for (int i = 0; i < node.Children.Count; i++)
                {
                    return findByValue1(node.Children[i], value);
                }
            }

            return null;
        }

        public List<T> getTsByChildren(TreeNode<T> node)
        {
            List<T> ts = new List<T>();

            if (node.Children != null)
                for (int i = 0; i < node.Children.Count; i++)
                {
                    ts.Add(node.Children[i].Value);
                }

            return ts;
        }

        public List<T> getTsByAllChildren(TreeNode<T> node)
        {
            List<T> ts = new List<T>();

            if (node.Children != null)
                for (int i = 0; i < node.Children.Count; i++)
                {
                    ts.Add(node.Children[i].Value);
                    for (int k = 0; k < node.Children[i].Children.Count; k++)
                    {
                        ts.Add(node.Children[i].Children[k].Value);
                    }
                }

            return ts;
        }

        public TreeNode<T> findNode(TreeNode<T> node, T btn)
        {
            if (node.Children != null)
                for (int i = 0; i < node.Children.Count; i++)
                {
                    if (node.Children[i].Value == btn) return node.Children[i];
                    else
                        for (int k = 0; k < node.Children[i].Children.Count; k++)
                        {
                            if (node.Children[i].Children[k].Value == btn)
                            {
                                return node.Children[i].Children[k];
                            }
                        }
                }

            return null;
        }


    }
}
