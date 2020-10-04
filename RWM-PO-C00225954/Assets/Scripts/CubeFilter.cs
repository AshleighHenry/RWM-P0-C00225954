public class CubeFilter
{
    public static int cube(int x)
    {
        return x * x * x;
    }

    public static int[] cubes(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = cube(xs[i]);
        }
        return result;
    }

    //Name: FizzBuzz
    //Replace integers that divide by 3 with 3, numbers that divide by 5 with 5 and numbers that divide by 3 AND 5 with 0. Leave all other numbers unchanged.
    //Sample Input: 4 3 6 30 10 12
    //Sample Output: 4 3 3 0 5 3
    public static int[] FizzBuzz(int[] input)
    {
        int[] Output = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            
           if (input[i] % 3 == 0 && input[i] % 5 == 0)
            {
                Output[i] = 0;
            }
           else if (input[i] % 3 == 0)
            {
                Output[i] = 3;
            }
            else if (input[i] % 5 == 0)
            {
                Output[i] = 5;
            }
            else
            {
                Output[i] = input[i];
            }
        }
        return Output;
    }
}


