using System;

namespace HubTalent_JSCIngenium
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 400000;
            var array = new int[arraySize];
            var rand = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = rand.Next(1, 100000);
            }
            int cannons = new Solution().solution(array);
        }
    }
}
