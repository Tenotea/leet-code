using System.Collections;

namespace tic_tac_toe.two_sum;

public class TwoSum
{
    private int[] SearchList { get; set; }
    private int Target { get; set; }

    public TwoSum() {
        this.SearchList = new int[] { 1, 2, 3, 4, 5 };
        this.Target = 8;
    }

    private void Log(object message) {
        Console.WriteLine(message);
    }
    
    public int[] Init() {
        int[] targetNumbers = new int[1];
        for (int firstItem = 0; firstItem < this.SearchList.Length; firstItem++) {
            for (int secondItem = 0; secondItem < this.SearchList.Length; secondItem++) {
                if ((this.SearchList[secondItem] + this.SearchList[firstItem]).Equals(this.Target)) {
                    targetNumbers = new int[]{secondItem, firstItem};
                }
            }
        }
        return targetNumbers;
    }
}
