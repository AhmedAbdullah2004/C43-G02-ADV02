using System;

namespace Assignment
{
    internal class Program
    {
        // 1
        //static void CountGreaterNumbers()
        //{
        //    int[] arr = { 11, 5, 3 };
        //    int[] queries = { 1, 5, 13 };

        //    foreach (int x in queries)
        //    {
        //        int count = arr.Count(num => num > x);
        //        Console.WriteLine(count);
        //    }
        //}

        //2
        //static void CheckPalindrome()
        //{
        //    int[] arr = { 1, 3, 2, 3, 1 };
        //    Console.WriteLine(arr.SequenceEqual(arr.Reverse()) ? "YES" : "NO");
        //}

        // 3
        //static void ReverseQueue<T>(Queue<T> queue)
        //{
        //    Stack<T> stack = new Stack<T>(queue);
        //    queue.Clear();
        //    foreach (T item in stack)
        //    {
        //        queue.Enqueue(item);
        //    }
        //}

        // 4
        //static bool IsBalanced(string str)
        //{
        //    Stack<char> stack = new Stack<char>();

        //    foreach (char ch in str)
        //    {

        //        if (ch == '(' || ch == '{' || ch == '[')
        //        {
        //            stack.Push(ch);
        //        }
        //        else if (ch == ')' || ch == '}' || ch == ']')
        //        {
        //            if (stack.Count == 0)
        //            {
        //                return false; 
        //            }
        //            char top = stack.Pop();
        //            if ((ch == ')' && top != '(') ||
        //                (ch == '}' && top != '{') ||
        //                (ch == ']' && top != '['))
        //            {
        //                return false;
        //            }
        //        }
        //    }

        //    return stack.Count == 0;
        //}

        // 5
        //public static int[] RemoveDuplicates(int[] inputArray)
        //{
        //    return inputArray.Distinct().ToArray();
        //}

        // 6
        //static int[] RemoveOddNumbers(int[] arr)
        //{
        //    return arr.Where(x => x % 2 == 0).ToArray();
        //}

        // 7
        static void GenericQueue()
        {
            Queue<object> queue = new Queue<object>();
            queue.Enqueue(1);
            queue.Enqueue("Apple");
            queue.Enqueue(5.28);
            foreach (var item in queue)
                Console.WriteLine(item);
        }


        static void Main(string[] args)
        {
            #region 1-Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
            //CountGreaterNumbers();
            #endregion

            #region 2-Given a number N and an array of N numbers. Determine if it's palindrome or not.
            //CheckPalindrome();
            #endregion

            #region 3-Given a Queue, implement a function to reverse the elements of a queue using a stack.
            //Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });

            //Console.WriteLine("Original Queue:");
            //Console.WriteLine(string.Join(" ", queue));

            //ReverseQueue(queue);

            //Console.WriteLine("Reversed Queue:");
            //Console.WriteLine(string.Join(" ", queue));
            #endregion

            #region 4-Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            //string input = "[()]{})";

            //if (IsBalanced(input))
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //}
            #endregion

            #region 5- Given an array, implement a function to remove duplicate elements from an array.
            //int[] arr = { 1, 2, 3, 4, 4, 5, 5, 6 };
            //int[] result = RemoveDuplicates(arr);

            //Console.WriteLine("Array after removing duplicates:");
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region 6- Given an array list , implement a function to remove all odd numbers from it.
            //Console.WriteLine(string.Join(", ", RemoveOddNumbers(arr)));
            #endregion

            #region 7-mplement a queue that can hold different data types. And insert the following data:
            //GenericQueue();
            #endregion

            #region 8-Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).
            //Stack<int> stack = new Stack<int>(new[] { 10, 20, 30, 40, 50 });

            //Console.Write("Enter the num: ");
            //int target = int.Parse(Console.ReadLine());

            //int count = 0;
            //bool found = false;

            //foreach (var item in stack)
            //{
            //    count++;
            //    if (item == target)
            //    {
            //        found = true;
            //        Console.WriteLine($"num is found , checked count = {count}");
            //        break;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("num is not found");
            //}
            #endregion

            #region 9-Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
            //    int[] array1 = { 1, 2, 3, 4, 4 };
            //    int[] array2 = { 10, 4, 4 };

            //    var result = FindIntersection(array1, array2);
            //    Console.WriteLine("[" + string.Join(", ", result) + "]");

            //static List<int> FindIntersection(int[] array1, int[] array2)
            //    {
            //        List<int> list1 = new List<int>(array1);
            //        List<int> intersection = new();

            //        foreach (var num in array2)
            //        {
            //            if (list1.Contains(num))
            //            {
            //                intersection.Add(num);
            //                list1.Remove(num);
            //            }
            //        }
            //        return intersection;
            //    }
            #endregion

            #region 10-Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.
            //    List<int> numbers = new() { 1, 2, 3, 7, 5 };
            //    int targetSum = 12;

            //    var result = FindSubList(numbers, targetSum);
            //    Console.WriteLine(result.Count > 0 ? "[" + string.Join(", ", result) + "]" : "No sublist found");

            //static List<int> FindSubList(List<int> numbers, int target)
            //    {
            //        int sum = 0, start = 0;
            //        for (int end = 0; end < numbers.Count; end++)
            //        {
            //            sum += numbers[end];

            //            while (sum > target)
            //                sum -= numbers[start++];

            //            if (sum == target)
            //                return numbers.GetRange(start, end - start + 1);
            //        }
            //        return new List<int>();
            //    }
            #endregion

            #region 11- Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 
            //    Queue<int> queue = new(new[] { 1, 2, 3, 4, 5 });
            //    int K = 3;

            //    Queue<int> result = ReverseFirstK(queue, K);
            //    Console.WriteLine("[" + string.Join(", ", result) + "]");

            //static Queue<int> ReverseFirstK(Queue<int> queue, int K)
            //    {
            //        List<int> tempList = new();

            //        for (int i = 0; i < K; i++)
            //            tempList.Add(queue.Dequeue());

            //        tempList.Reverse();

            //        foreach (var item in tempList)
            //            queue.Enqueue(item);

            //        for (int i = 0; i < queue.Count - K; i++)
            //            queue.Enqueue(queue.Dequeue());

            //        return queue;
            //    }
            #endregion
        }
    }
}



