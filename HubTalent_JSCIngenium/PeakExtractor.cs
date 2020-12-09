using System;
using System.Collections.Generic;
using System.Text;

namespace HubTalent_JSCIngenium
{
    public class PeakExtractor
    {
        public static IEnumerable<int> GetPeaks(int[] a)
        {
            for (int i = 1; i < a.Length - 1; i++) //Last element cannot be a peak, so skip it and also avoid out of range when a[int+1]
            {
                if ((a[i - 1] < a[i]) && (a[i] > a[i + 1]))
                {
                    yield return i;
                    i++;
                }
            }

        }

        public static IEnumerable<int> GetPeaksDistances(int[] a)
        {
            int previousPeak = -1;
            for (int i = 1; i < a.Length - 1; i++) //Last element cannot be a peak, so skip it and also avoid out of range when a[int+1]
            {
                if ((a[i - 1] < a[i]) && (a[i] > a[i + 1]))
                {
                    if (previousPeak == -1)
                    {
                        previousPeak = i;
                    }
                    else
                    {
                        yield return Math.Abs(i - previousPeak);
                    }

                    previousPeak = i;
                    i++;//Next element can't never be a peak(min distance 2) so skip it
                }
            }

        }
    }
}
