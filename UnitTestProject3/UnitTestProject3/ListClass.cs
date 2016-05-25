using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List<T> : IList<T>
    {
        T[] objectsList = new T[5];
        int counter = 0;
        
        public T this[int index]
        {
            get
            {
                return objectsList[index];
            }
            set
            {
                objectsList[index] = value; 
            }
    
        }
        public int Count
        {
            get
            {
                return counter;
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
            ExtendListSize();
            objectsList[counter] = item;
            counter++;
            
        }

        public void Clear()
        {
            Array.Resize(ref objectsList, 0);
            counter = 0;
        }

        public int IndexOf(T item)
        {
            for(int i = 0; i< objectsList.Length; i++)
            {
                if (objectsList[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            ExtendListSize();
           
            for(int i = counter; i < index; i--)
            {
                objectsList[i] = objectsList[i - 1];
            }
            objectsList[index] = item;
            counter++;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < counter - 1; i++)
                objectsList[i] = objectsList[i+1];
            counter--;
            Array.Resize(ref objectsList, counter + 1);
        }

       

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void ExtendListSize()
        {
            if (counter == objectsList.Length - 1)
                Array.Resize(ref objectsList, objectsList.Length * 2);
        }
    }
}
