
using NUnit.Framework;
using UnityEngine;

//Name: FizzBuzz
//Replace integers that divide by 3 with 3, numbers that divide by 5 with 5 and numbers that divide by 3 AND 5 with 0. Leave all other numbers unchanged.
//Sample Input: 4 3 6 30 10 12
//Sample Output: 4 3 3 0 5 3


namespace Tests
{
    public class CubeFilterTest
    {
        [Test] // this tells system this is a test function and it needs to be ran
        public void CubeFilterSimple()
        {



            int[] input = { 1, 3, 5, 7, 9, 999 };
            int[] output = CubeFilter.cubes(input);
            int[] expected = { 1, 27, 125, 343, 729, 997002999 };


            CollectionAssert.AreEqual(expected, output); // this checks output with the input to make sure they are the same
                                                         // collection assert - tells test runner this is a check that needs to pass otherwise unit test fails.

            // convention in most libraries -  is expected first then output second.
            // due to language of report. avoid error when reading the debug output.
        }


        [Test]
        public void FizzBuzzSimple()
        {
            int[] input = { 4, 3, 6, 30, 10, 12 };
            int[] output = CubeFilter.FizzBuzz(input);
            int[] expected = { 4,3, 3, 0, 5, 3 };

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
    }
}
