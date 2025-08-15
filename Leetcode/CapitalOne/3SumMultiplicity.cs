using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne;

public class _3SumMultiplicity
{
    public int ThreeSumMulti(int[] arr, int target)
    {
        int MOD = 1_000_000_007;
        Array.Sort(arr);
        int n = arr.Length;
        long ans = 0;

        for (int i = 0; i < n; i++)
        {
            int T = target - arr[i];
            int j = i + 1;
            int k = n - 1;

            while(j < k)
            {
                int s = arr[j] + arr[k];
                if (s < T)
                {
                    j++;
                }
                else if(s > T)
                {
                    k--;
                }
                else
                {
                    if (arr[j] != arr[k])
                    {
                        int leftVal = arr[j], rightVal = arr[k];
                        long L = 1, R = 1;
                        while (j + L <= k && arr[j + L] == leftVal) L++;
                        while (k - R >= j && arr[k - R] == rightVal) R++;
                        ans += L * R;
                        ans %= MOD;
                        j += (int)L;
                        k -= (int)R;
                    }
                    else
                    {
                        long m = k - j + 1;
                        ans += m * (m - 1) / 2;
                        ans %= MOD;
                        break;
                    }
                }
            }
        }
        return (int)ans;
    }
}
