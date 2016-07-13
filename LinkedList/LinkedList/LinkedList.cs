using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T> : IEnumerable<T>, ICollection<T>
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

        public void Clear()
        {
            this.head = null;
            this.count = 0; 
        }

        public bool Contains(T item)
        {
            Node<T> iNode = head.Next;
            while (iNode != head)
            {
                if (iNode.Data.Equals(item))
                    return true;
                iNode = iNode.Next;
            }
            return false;
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
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
