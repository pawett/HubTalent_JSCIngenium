using NUnit.Framework;
using System;
using HubTalent_JSCIngenium;

namespace R2D2Test
{
    public class TestsCannons
    {
        private Solution _solution;
        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [Test]
        public void K3()
        {
            var array = new int[] { 1, 6, 4, 5, 4, 5, 1, 2, 3, 4, 7, 2 };
            var cannons = _solution.solution(array);

            Assert.AreEqual(3, cannons);
        }
        [Test]
        public void K3_2()
        {
            var array = new int[] { 1, 0, 0, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1 };
            var cannons = _solution.solution(array);

            Assert.AreEqual(3, cannons);
        }

        [Test]
        public void K4()
        {
            var array = new int[] { 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1 };
            var cannons = _solution.solution(array);

            Assert.AreEqual(4, cannons);
        }

        [Test]
        public void K4_2()
        {
            var array = new int[] { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1 };
            var cannons = _solution.solution(array);

            Assert.AreEqual(4, cannons);
        }

        [Test]
        public void K5()
        {
            var array = new int[] { 5, 6, 5, 6, 5, 4, 4, 5, 4, 4, 3, 3, 4, 3, 3, 4, 5, 6, 5, 5, 4, 5, 4, 5, 4 };
            var cannons = _solution.solution(array);

            Assert.AreEqual(5, cannons);
        }
        [Test]
        public void K5_2()
        {
            var array = new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0 };
            var cannons = _solution.solution(array);

            Assert.AreEqual(5, cannons);

        }
        [Test]
        public void K5_3()
        {
            var array = new int[] { 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0 };
            var cannons = _solution.solution(array);

            Assert.AreEqual(5, cannons);
        }

        [Test]
        public void K6()
        {
            var array = new int[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 };
            var cannons = _solution.solution(array);

            Assert.AreEqual(6, cannons);
        }


        [Test]
        public void K6_2()
        {
            var array = new int[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 };
            var cannons = _solution.solution(array);

            Assert.AreEqual(6, cannons);
        }

        [Test]
        public void K7()
        {
            var array = new int[] { 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0};
            var cannons = _solution.solution(array);

            Assert.AreEqual(7, cannons);
        }


        private int[] getRandomArrayOfSize(int size)
        {
            int arraySize = size;
            var array = new int[arraySize];
            var rand = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = rand.Next(1, 100000);
            }
            return array;
        }

        [Test]
        public void TestRandom25000()
        {
            var cannons = _solution.solution(getRandomArrayOfSize(25000));
        }

        [Test]
        public void TestRandom50000()
        {
            var cannons = _solution.solution(getRandomArrayOfSize(50000));
        }

        
        [Test]
        public void TestRandom75000()
        {
            _solution.solution(getRandomArrayOfSize(75000));
        }

        [Test]
        public void TestRandom100000()
        {
            _solution.solution(getRandomArrayOfSize(100000));
        }

        [Test]
        public void TestRandom125000()
        {
            _solution.solution(getRandomArrayOfSize(125000));
        }

        [Test]
        public void TestRandom150000()
        {
            _solution.solution(getRandomArrayOfSize(15000));
        }

        [Test]
        public void TestRandom175000()
        {
            _solution.solution(getRandomArrayOfSize(175000));
        }

        [Test]
        public void TestRandom200000()
        {
            _solution.solution(getRandomArrayOfSize(200000));
        }

        [Test]
        public void TestRandom225000()
        {
            _solution.solution(getRandomArrayOfSize(225000));
        }

        [Test]
        public void TestRandom250000()
        {
            _solution.solution(getRandomArrayOfSize(250000));
        }

        [Test]
        public void TestRandom275000()
        {
            _solution.solution(getRandomArrayOfSize(275000));
        }

        [Test]
        public void TestRandom300000()
        {
            _solution.solution(getRandomArrayOfSize(300000));
        }

        [Test]
        public void TestRandom325000()
        {
            _solution.solution(getRandomArrayOfSize(325000));
        }

        [Test]
        public void TestRandom350000()
        {
            _solution.solution(getRandomArrayOfSize(350000));
        }
        [Test]
        public void TestRandom375000()
        {
            _solution.solution(getRandomArrayOfSize(375000));
        }

        [Test]
        public void TestRandom400000()
        {
            _solution.solution(getRandomArrayOfSize(400000));
        }
    }
}