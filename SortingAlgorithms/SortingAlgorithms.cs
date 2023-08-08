using System.Diagnostics;

namespace Algorithms
{
    public static class SortingAlgorithms
    {
        static Stopwatch stopwatch = new Stopwatch();

        public static List<T> Merge_Sort<T>(List<T> arr)
        {
            Start_Timer();

            #region Method

            //Base Check
            if (arr.Count <= 1)
            {
                return arr;
            }

            List<T> left = new List<T>();
            List<T> right = new List<T>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (i < arr.Count / 2)
                {
                    left.Add(arr[i]);
                }
                else
                {
                    right.Add(arr[i]);
                }
            }

            left = Merge_Sort(left);
            right = Merge_Sort(right);

            List<T> tempList = Merge(left, right);
            #endregion

            Stop_Timer();
            Debug.WriteLine("Merge Sort executed in " + stopwatch.Elapsed.ToString());
            stopwatch.Restart();

            return tempList;
        }

        public static List<T> Merge<T>(List<T> _left, List<T> _right)
        {
            List<T> result = new List<T>();

            while (_left.Count != 0 && _right.Count != 0)
            {
                if (Convert.ToInt32(_left.First()) <= Convert.ToInt32(_right.First()))
                {
                    result.Add(_left.First());
                    _left.RemoveAt(0);

                }
                else
                {
                    result.Add(_right.First());
                    _right.RemoveAt(0);
                }
            }

            while (_left.Count != 0)
            {
                result.Add(_left.First());
                _left.RemoveAt(0);
            }

            while (_right.Count != 0)
            {
                result.Add(_right.First());
                _right.RemoveAt(0);
            }

            return result;
        }



        public static List<T>? Bubble_Sort<T>(List<T> arr)
        {
            Start_Timer();

            #region Method

            #endregion

            Stop_Timer();
            Debug.WriteLine("Bubble Sort executed in " + stopwatch.Elapsed.TotalSeconds + " SECONDS");
            stopwatch.Restart();
            return null;
        }

        public static List<T>? Insertion_Sort<T>(List<T> arr)
        {
            Start_Timer();

            #region Method

            #endregion

            Stop_Timer();
            Debug.WriteLine("Insertion Sort executed in " + stopwatch.Elapsed.TotalSeconds + " SECONDS");
            stopwatch.Restart();
            return null;
        }

        public static List<T>? Quick_Sort<T>(List<T> arr)
        {
            Start_Timer();

            #region Method

            #endregion

            Stop_Timer();
            Debug.WriteLine("Quick Sort executed in " + stopwatch.Elapsed.TotalSeconds + " SECONDS");
            stopwatch.Restart();
            return null;
        }

        public static List<T>? Selection_Sort<T>(List<T> arr)
        {
            Start_Timer();

            #region Method

            #endregion

            Stop_Timer();
            Debug.WriteLine("Selection Sort executed in " + stopwatch.Elapsed.TotalSeconds + " SECONDS");
            stopwatch.Restart();
            return null;
        }

        public static void Start_Timer()
        {
            stopwatch.Start();
        }

        public static void Stop_Timer()
        {
            stopwatch.Stop();
        }
    }
}
