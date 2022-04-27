namespace AlgorithmsAndDataStructures.Algorithms
{
    public class MergeSort
    {
        // Takes overall O(n log n) time
        public int[] Sort( int[] source)
        {

            if (source.Length <= 1)
                return source;

            var (left_half, right_half) = Split(source);
            var left = Sort(left_half);
            var right = Sort(right_half);

            return Merge(left, right);
        }

        // Takes overall O(log n) time
        private (int[], int[]) Split(int[] source)
        {
            int mid = source.Length / 2;
            int[] left = source.Take(mid).ToArray();
            int[] right = source.Skip(mid).ToArray();

            return (left, right);
        }

        // Takes overall O(n) time
        private int[] Merge(int[] left, int[] right)
        {
            List<int> result = new List<int>();
            var i = 0;
            var j = 0;

            if (left == null || right == null)
                return left ?? right ?? new int[0];

            while (i < left.Length && j < right.Length)
            {
                if ( left[i]  < right[j] )
                {
                    result.Add(left[i]);
                    i++;
                }
                else 
                { 
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Length) { 
                result.Add(left[i]);
                i++;
            }

            while (j < right.Length)
            {
                result.Add(right[j]);
                j++;
            }

            return result.ToArray();
        }
    
    }


}