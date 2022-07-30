using tic_tac_toe.two_sum;

namespace tic_tac_toe
{
    class Program {
        private static void Main() {
           int[] twoSum = new TwoSum().Init();
           Console.Write($"{twoSum.GetValue(0)},{twoSum.GetValue(1)}");
        }
    }
}
