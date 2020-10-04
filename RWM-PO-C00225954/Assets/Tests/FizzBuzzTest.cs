
using NUnit.Framework;
using UnityEngine;


   namespace Tests
{
    public class FizzBuzzTest
    {
        [Test]
        public void FizzBuzzSimple()
        {
            int[] input = { 4, 3, 6, 30, 10, 12 };
            int[] output = CubeFilter.FizzBuzz(input);
            int[] expected = { 4, 3, 3, 0, 5, 3 };

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void FizzBuzzNegative()
        {
            int[] input = { -4, -3, -6, -30, -10, -12 };
            int[] output = CubeFilter.FizzBuzz(input);
            int[] expected = { -4, 3, 3, 0, 5, 3 };

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void FizzBuzzZero()
        {
            int[] input = { 0};
            int[] output = CubeFilter.FizzBuzz(input);
            int[] expected = {0};

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
