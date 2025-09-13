using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150;

public class InsertDeleteGetRandom
{
    public class RandomizedSet
    {
        private HashSet<int> values { get; set; }
        private Random Generator { get; set; }
        public RandomizedSet()
        {
            values = new HashSet<int>();
            Generator = new Random();
        }

        public bool Insert(int val)
        {
            if (values.Contains(val)) return false;

            values.Add(val);

            return true;
        }

        public bool Remove(int val)
        {
            if(!values.Contains(val)) return false;

            values.Remove(val);

            return true;
        }

        public int GetRandom()
        {
            int random = Generator.Next(values.Count);
            return values.ElementAt(random);
        }
    }

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
