namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNums = new int[] { 2, 2, 1 };
            Console.WriteLine(SingleNumber(arrNums));
        }

        static public int SingleNumber(int[] nums)
        {
            HashSet<int> multi = new HashSet<int>();
            HashSet<int> res = new HashSet<int>();

            foreach (int num in nums)
            {
                if (multi.Contains(num))
                    res.Remove(num);
                else
                {
                    multi.Add(num);
                    res.Add(num);
                }
            }

            return res.First();
            //Output: 1
        }
    }
}
