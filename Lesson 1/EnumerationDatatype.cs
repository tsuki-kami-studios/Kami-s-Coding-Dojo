using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    public class EnumerationDatatype
    {
        public static void Datatypes()
        {
            //SET : A set is a collection of unique items.
            //ARRAY : An array is a collection of items of the same type. The size of the array is fixed.
            //LIST : A List is a dynamic array, meaning items can be added and removed.
            //COLLECTION : A Collection is a generic list of items that can be accessed by index.
            //DICTIONARY : A Dictionary is a collection of key-value pairs. Each key must be unique.
            //QUEUE : A Queue is a First-In-First-Out (FIFO) collection.
            //STACK : A Stack is a Last-In-First-Out (LIFO) collection.
            //LINKED : A doubly-linked list. Each item points to both the next item and the previous item.
            //SORTED : A collection of key-value pairs that are sorted by the keys and are accessible by key and by index.
            //IMMUTABLE : A collection that is immutable after creation.
            //CONCURRENT : A collection that is thread-safe.
            //BLOCKING : A collection class which ensures thread safety by making sure that only one thread can access the collection at a time.
            //ENUMERATION : A collection that can be enumerated.
            //READONLY : A collection that is read-only.


            int[] myArray; // An array is a collection of items of the same type. The size of the array is fixed.
            List<int> myList; // A List is a dynamic array, meaning items can be added and removed.
            Dictionary<string, int> myDictionary; // A Dictionary is a collection of key-value pairs. Each key must be unique.
            Collection<int> myCollection; // A Collection is a generic list of items that can be accessed by index.

            ReadOnlyCollection<int> myReadOnlyCollection; // A ReadOnlyCollection is a generic list of items that can be accessed by index, but cannot be modified.


            Queue<int> myQueue; // A Queue is a First-In-First-Out (FIFO) collection.
            Stack<int> myStack; // A Stack is a Last-In-First-Out (LIFO) collection.
            HashSet<int> myHashSet; // A HashSet is a collection of unique items.
            LinkedList<int> myLinkedList; // A LinkedList is a doubly-linked list. Each item points to both the next item and the previous item.
            SortedList<string, int> mySortedList; // A SortedList is a collection of key-value pairs that are sorted by the keys and are accessible by key and by index.
            SortedDictionary<string, int> mySortedDictionary; // A SortedDictionary is a collection of key-value pairs that are sorted on the basis of the key.
            SortedSet<int> mySortedSet; // A SortedSet is a collection of unique elements that are sorted.

            ObservableCollection<int> myObservableCollection; // An ObservableCollection is a dynamic collection that provides notifications when items get added, removed, or when the whole collection is refreshed.
            ConcurrentQueue<int> myConcurrentQueue; // A ConcurrentQueue is a thread-safe FIFO (First-In-First-Out) collection.
            ConcurrentStack<int> myConcurrentStack; // A ConcurrentStack is a thread-safe LIFO (Last-In-First-Out) collection.
            ConcurrentBag<int> myConcurrentBag; // A ConcurrentBag is a thread-safe unordered collection of objects.
            ConcurrentDictionary<string, int> myConcurrentDictionary; // A ConcurrentDictionary is a thread-safe collection of key-value pairs.
            BlockingCollection<int> myBlockingCollection; // A BlockingCollection is a collection class which ensures thread safety by making sure that only one thread can access the collection at a time.
            ImmutableArray<int> myImmutableArray; // An ImmutableArray is a fixed-size array that is immutable after creation.
            ImmutableList<int> myImmutableList; // An ImmutableList is a list that is immutable after creation.
            ImmutableQueue<int> myImmutableQueue; // An ImmutableQueue is a queue that is immutable after creation.
            ImmutableStack<int> myImmutableStack; // An ImmutableStack is a stack that is immutable after creation.
            ImmutableHashSet<int> myImmutableHashSet; // An ImmutableHashSet is a set that is immutable after creation.
            ImmutableSortedSet<int> myImmutableSortedSet; // An ImmutableSortedSet is a sorted set that is immutable after creation.
            ImmutableDictionary<string, int> myImmutableDictionary; // An ImmutableDictionary is a dictionary that is immutable after creation.
            ImmutableSortedDictionary<string, int> myImmutableSortedDictionary; // An ImmutableSortedDictionary is a sorted dictionary that is immutable after creation.

            IEnumerable<int> myIEnumerable; // An IEnumerable is a collection that can be enumerated.
            IList<int> myIList; // An IList is a collection that can be accessed by index.
            ICollection<int> myICollection; // An ICollection is a collection that can be accessed by index and can be modified.
            IQueryable<int> myIQueryable; // An IQueryable is a collection that can be queried.
            IGrouping<string, int> myIGrouping; // An IGrouping is a collection that can be grouped.
            ILookup<string, int> myILookup; // An ILookup is a collection that can be looked up.
            IOrderedEnumerable<int> myIOrderedEnumerable; // An IOrderedEnumerable is a collection that can be ordered.
            IOrderedQueryable<int> myIOrderedQueryable; // An IOrderedQueryable is a collection that can be queried and ordered.

            //Assign Values 
            myArray = new int[5] { 4, 3, 2, 5, 1  };
            myList = new List<int>(myArray);
            myDictionary = new Dictionary<string, int>() { { "A", 1 }, { "B", 2 }, { "C", 3 }, {"C", 4}, {"D", 5} };
            myCollection = new Collection<int>(myArray);
            myReadOnlyCollection = new ReadOnlyCollection<int>(myArray);
            myQueue = new Queue<int>(myArray);
            myStack = new Stack<int>(myArray);
            myHashSet = new HashSet<int>(myArray);
            myLinkedList = new LinkedList<int>(myArray);
            mySortedList = new SortedList<string, int>(myDictionary);
            mySortedDictionary = new SortedDictionary<string, int>(myDictionary);
            mySortedSet = new SortedSet<int>(myArray);
            myObservableCollection = new ObservableCollection<int>(myArray);
            myConcurrentQueue = new ConcurrentQueue<int>(myArray);
            myConcurrentStack = new ConcurrentStack<int>(myArray);
            myConcurrentBag = new ConcurrentBag<int>(myArray);
            myConcurrentDictionary = new ConcurrentDictionary<string, int>(myDictionary);
            myBlockingCollection = new BlockingCollection<int>();
            myImmutableArray = ImmutableArray.Create<int>(myArray);
            myImmutableList = ImmutableList.Create<int>(myArray);
            myImmutableQueue = ImmutableQueue.Create<int>(myArray);
            myImmutableStack = ImmutableStack.Create<int>(myArray);
            myImmutableHashSet = ImmutableHashSet.Create<int>(myArray);
            myImmutableSortedSet = ImmutableSortedSet.Create<int>(myArray);

            //Print values
            Console.WriteLine("myArray                 : " +string.Join(',', myArray));
            Console.WriteLine("myList                  : " + string.Join(',', myList));
            Console.WriteLine("myDictionary            : " + string.Join(',', myDictionary));
            Console.WriteLine("myCollection            : " + string.Join(',', myCollection));
            Console.WriteLine("myReadOnlyCollection    : " + string.Join(',', myReadOnlyCollection));
            Console.WriteLine("myQueue                 : " + string.Join(',', myQueue));
            Console.WriteLine("myStack                 : " + string.Join(',', myStack));
            Console.WriteLine("myHashSet               : " + string.Join(',', myHashSet));
            Console.WriteLine("myLinkedList            : " + string.Join(',', myLinkedList));
            Console.WriteLine("mySortedList            : " + string.Join(',', mySortedList));
            Console.WriteLine("mySortedDictionary      : " + string.Join(',', mySortedDictionary));
            Console.WriteLine("mySortedSet             : " + string.Join(',', mySortedSet));
            Console.WriteLine("myObservableCollection  : " + string.Join(',', myObservableCollection));
            Console.WriteLine("myConcurrentQueue       : " + string.Join(',', myConcurrentQueue));
            Console.WriteLine("myConcurrentStack       : " + string.Join(',', myConcurrentStack));
            Console.WriteLine("myConcurrentBag         : " + string.Join(',', myConcurrentBag));
            Console.WriteLine("myConcurrentDictionary  : " + string.Join(',', myConcurrentDictionary));
            Console.WriteLine("myBlockingCollection    : " + string.Join(',', myBlockingCollection));
            Console.WriteLine("myImmutableArray        : " + string.Join(',', myImmutableArray));
            Console.WriteLine("myImmutableList         : " + string.Join(',', myImmutableList));
            Console.WriteLine("myImmutableQueue        : " + string.Join(',', myImmutableQueue));
            Console.WriteLine("myImmutableStack        : " + string.Join(',', myImmutableStack));
            Console.WriteLine("myImmutableHashSet      : " + string.Join(',', myImmutableHashSet));
            Console.WriteLine("myImmutableSortedSet    : " + string.Join(',', myImmutableSortedSet));





        }
    }
}
