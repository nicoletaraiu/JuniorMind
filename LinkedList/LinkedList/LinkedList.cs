using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T> : ICollection<T>, IEnumerable<T>
    {
        private Node<T> head;
        private int count;

        public LinkedList()
        {
            head = new Node<T>(default(T));
            head.Next = head;
            head.Previous = head;
            this.count = 0;

        }

       
        public int Count
        {
            get
            {
               return this.count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        } 

       

        public void Add(T item)
        {
            var currentNode = new Node<T>(item) { Previous = head.Previous, Next = head };
            Node<T> aux = head.Previous;
            head.Previous = currentNode;
            aux.Next = currentNode;
            count++;
        }

        public void AddFirst(T item)
        {
            var currentNode = new Node<T>(item) { Previous = head, Next = head.Next };
            Node<T> aux = head.Next;
            head.Next = currentNode;
            aux.Previous = currentNode;
            count++;
        }

        public void Clear()
        {
            this.head = null;
            this.count = 0; 
        }

        public bool Contains(T item)
        {
            Node<T> node = Find(item);
            if (!node.Equals(head))
                return true;
            return false;
          
        }

        public Node<T> Find (T value)
        {
            Node<T> iNode = head.Next;
            while (iNode != head)
            {
                if (iNode.Data.Equals(value))
                    return iNode;
                iNode = iNode.Next;
            }
            return head;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Node<T> iNode = head.Next;
            for(int i = arrayIndex; i < array.Length; i++)
            {
                if (!iNode.Equals(head))
                {
                    array.SetValue(iNode.Data, i);
                    iNode = iNode.Next;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = head.Next;
            while (!node.Equals(head))
            {
                yield return node.Data;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Remove(T item)
        {
            Node<T> toRemove = Find(item);
            if (toRemove.Equals(head))
                return false;
            RemoveNode(toRemove);
            return true;
        }
       


        public int IndexOf(T item)
        {
            var node = Find(item);
            var iNode = head.Next;
            int index = 0;
            while (!iNode.Equals(head))
            {
                if (iNode.Data.Equals(node.Data))
                    return index;
                iNode = iNode.Next;
                index++;
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            var iNode = head.Next;
            for (int i = 0; i < index; i++)
            {
                iNode = iNode.Next;
            }
            RemoveNode(iNode);
        }

        public void RemoveNode(Node<T> toBeRemoved)
        {
            Node<T> before = toBeRemoved.Previous;
            Node<T> after = toBeRemoved.Next;
            before.Next = after;
            after.Previous = before;
            count--;
        }
    }
}
