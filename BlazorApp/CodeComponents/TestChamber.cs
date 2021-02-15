using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.CodeComponents
{
    public class TestChamber
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> list = new List<int>();

            foreach (var item in nums)
            {
                list.Add(item);
            }

            list.Sort();

            return list;
        }
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> st = new Stack<int>();
            int j = 0;

            foreach (var item in pushed)
            {
                st.Push(item);
                while (st.Count > 0 && st.Peek() == popped[j])
                {
                    st.Pop();
                    j++;
                }
            }
            return j == popped.Length;

        }
    }
}
