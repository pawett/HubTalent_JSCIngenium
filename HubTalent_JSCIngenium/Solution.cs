using System.Collections.Generic;
using System.Linq;

namespace HubTalent_JSCIngenium
{
    public class Solution
    {
        private List<int> _peaks = null;
        private Stack<int> _solution = new Stack<int>();

        private int  getMaxPeaksPossible(int totalDistance, int peaks)
        {
            peaks++;
            while ((totalDistance / --peaks) + 1 < peaks);
    
            return peaks;
        }


        public int solution(int[] a)
        {
            _peaks = PeakExtractor.GetPeaks(a).ToList();
            var totalDistance = _peaks.Last() - _peaks.First();
            var goal = getMaxPeaksPossible(totalDistance, _peaks.Count);

            do
            {
                _solution.Clear();
                _solution.Push(_peaks[0]);
                var nodesLeft = _peaks.Count - 2;

                for (int i = 1; i < _peaks.Count; i++)
                {
                    var lastPosition = _solution.Peek();
                    var distanceToLastPosition = _peaks[i] - lastPosition;
                    if (distanceToLastPosition >= goal)
                    {
                        _solution.Push(_peaks[i]);
                    }
                    
                    var nodesToGoal = goal - _solution.Count;
                    if (nodesLeft < nodesToGoal)
                    {
                        break;
                    }
                    nodesLeft--;
                }

                if (_solution.Count < goal)
                {
                    goal--;
                }
            } while (_solution.Count < goal);


            return goal;
        }
    }
}
