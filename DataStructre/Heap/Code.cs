using System;

namespace DataStructure.Heap
{
    class Code
    {
        public class PriorityQueue1<T> where T : IComparable<T>
        {
            private const int Capacity = 32;
            private int _count; // Number of elements in Heap
            private T[] arr; // The Heap array
            private readonly bool isMinHeap;
            public PriorityQueue1(bool isMin = true)
            {
                arr = new T[Capacity];
                _count = 0;
                isMinHeap = isMin;
            }
            public PriorityQueue1(T[] array, bool isMin = true)
            {
                _count = array.Length;
                arr = array;
                isMinHeap = isMin;
                for (int i = (_count / 2); i >= 0; i--)
                    ProclateDown(i);
            }
            private bool Compare(T[] arr, int first, int second)
            {
                if (isMinHeap)
                    return arr[first].CompareTo(arr[second])
                    > 0;
                return arr[first].CompareTo(arr[second])
                       < 0;
            }
            private void ProclateDown(int parent)
            {
                int lChild = 2 * parent + 1;
                int rChild = lChild + 1;
                int child = -1;

                if (lChild < _count)
                    child = lChild;
                if (rChild < _count && Compare(arr, lChild, rChild))
                    child = rChild;

                if (child != -1 && Compare(arr, parent, child))
                {
                    var temp = arr[parent];
                    arr[parent] = arr[child];
                    arr[child] = temp;
                    ProclateDown(child);
                }
            }
            private void ProclateUp(int child)
            {
                int parent = (child - 1) / 2;
                if (parent < 0)
                    return;
                if (Compare(arr, parent, child))
                {
                    var temp = arr[child];
                    arr[child] = arr[parent];
                    arr[parent] = temp;
                    ProclateUp(parent);
                }
            }
            public void Add(T value)
            {
                if (_count == arr.Length)
                    DoubleSize();
                arr[_count++] = value;
                ProclateUp(_count - 1);
            }
            private void DoubleSize()
            {
                T[] old = arr;
                arr = new T[arr.Length * 2];
                Array.Copy(old, 0, arr, 0, _count);
            }
            public T Remove()
            {
                if (_count == 0)
                    throw new System.InvalidOperationException();
                T value = arr[0];
                arr[0] = arr[_count - 1];
                _count--;
                ProclateDown(0);
                return value;
            }
            public void Print()
            {
                for (int i = 0; i < _count; i++)
                    Console.Write(arr[i] + " ");
            }
            public bool IsEmpty()
            {
                return (_count == 0);
            }
            public int Size() => _count;

            public T Peek()
            {
                if (_count == 0) throw new System.InvalidOperationException();
                return arr[0];
            }
            public static void HeapSort(int[] array, bool inc)
            {
                PriorityQueue1<int> hp = new
                PriorityQueue1<int>(array, !inc);
                for (int i = 0; i < array.Length; i++)
                    array[array.Length - i - 1] = hp.Remove();
            }
        }
        public class PQDemo
        {
            public static void Main1(string[] args)
            {
                int[] a = { 1, 9, 6, 7, 8, 0, 2, 4, 5, 3 };
                PriorityQueue1<int> hp = new
                PriorityQueue1<int>(a, true);
                hp.Print();
                Console.WriteLine();
                while (hp.IsEmpty() == false)
                    Console.Write(hp.Remove() + " ");
            }
        }
    }
}
