using System;


namespace ITYardService
{
    public class Node<T>
    {
        public T Data { set; get; }
        public Node<T> Next;
        public Node(T data)
        {
            this.Data = data;
        }
    }

    public class LinkedList<T>
    {
        public Node<T> first;
        Node<T> last;
        /// <summary>
        ///  Gets the number of elements
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        ///  Adds an object to the end of the list 
        /// </summary>
        /// <param name="element"></param>
        public void Add(Node<T> element)
        {
            if (first == null)
            {
                first = element;
                last = element;
            }
            else
            {
                last.Next = element;
                last = element;
            }
            Count++;
        }
        /// <summary>
        /// Removes all elements from the list
        /// </summary>
        /// <returns></returns>
        public bool Clear()
        {
            if (first != null)
            {
                first = null;
                last = null;
                Count = 0;
                return true;
            }
            return false;

        }
        /// <summary>
        /// Removes the element Node
        /// </summary>
        /// <param name="data">element Node</param>
        /// <returns></returns>
        public bool Remove(T data)
        {
            Node<T> previous = null;
            Node<T> current = first;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {

                    if (previous != null)
                    {
                        previous.Next = current.Next; // move the list to -1 if the value in the first element

                        if (current.Next == null)
                        {
                            last = previous;
                        }
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
        /// <summary>
        /// Removes the first element
        /// </summary>
        /// <returns></returns>
        public bool RemoveFirst()
        {
            if (first != null)
            {
                first = first.Next; // move the list to -1 if the value in the first element
                if (first == null) // check whether items are on the list
                {
                    last = null; // reset the last element
                }
                Count--;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Searches for the specified object and returns the zero-based index of 
        /// the first element
        /// </summary>
        /// <param name="data">element Node</param>
        /// <returns></returns>
        public int IndexOf(T data)
        {
            int i = 0;
            Node<T> current = first;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return i;
                i++;
                current = current.Next;
            }
            return -1;
        }
        /// <summary>
        /// Remove an element into the list
        /// </summary>
        /// <param name="index">index element Node</param>
        /// <returns></returns>
        public bool RemoveByIndex(int index)
        {
            int i = 0;
            Node<T> previous = null;
            Node<T> current = first;

            while (current != null)
            {
                if (index == i)
                {
                    if (index != 0)
                    {
                        previous.Next = current.Next; // move the list to -1 if the value in the first element
                        if (current.Next == null)
                        {
                            last = previous;
                        }
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
                i++;
            }
            return false;
        }
        /// <summary>
        /// Inserts an element into the list
        /// </summary>
        /// <param name="data">element Node</param>
        /// <param name="index">index element Node</param>
        /// <returns></returns>
        public bool InsertInIndex(T data, int index)
        {
            int i = 0;
            Node<T> current = first;
            while (current != null)
            {
                if (index == i)
                {
                    current.Data = data;
                    return true;
                }
                i++;
                current = current.Next;
            }
            return false;
        }
        /// <summary>
        /// Get an element into the list by index
        /// </summary>
        /// <param name="index">index element Node</param>
        /// <returns></returns>
        public T GetByIndex(int index)
        {
            int i = 0;
            Node<T> current = first;
            while (current != null)
            {
                if (index == i)
                {
                    return current.Data;
                }
                i++;
                current = current.Next;
            }
            return default(T);
        }
        /// <summary>
        /// Chacks if the element in list
        /// </summary>
        /// <returns></returns>
        public bool Any()
        {
            if (first != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Convert list to array
        /// </summary>
        /// <returns>array</returns>
        public T[] ToArray()
        {
            if (first != null)
            {
                int i = 0;
                T[] array = new T[Count];
                Node<T> current = first;
                while (current != null)
                {
                    array[i] = current.Data;
                    current = current.Next;
                    i++;
                }
                return array;
            }
            return null;
        }

        /// <summary>
        /// Bubblesort the list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="head">first element in the list</param>
        public void Sort<T>(Node<T> head) where T : IComparable
        {
            Node<T> currentOuter = head; //Outer list

            while (currentOuter != null)
            {
                Node<T> min = currentOuter;
                Node<T> currentInner = currentOuter.Next; //Inner list

                while (currentInner != null)
                {
                    if (currentInner.Data.CompareTo(min.Data) < 0) //Compares the current instance with another object of the same type
                    {
                        min = currentInner;
                    }
                    currentInner = currentInner.Next;
                }
                if (!Object.ReferenceEquals(min, currentOuter))
                {
                    T temp = currentOuter.Data;
                    currentOuter.Data = min.Data;
                    min.Data = temp;
                }
                currentOuter = currentOuter.Next;
            }
        }

    }
}



