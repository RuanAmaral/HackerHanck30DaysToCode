using System;
public interface AdvancedArithmetic{
    int divisorSum(int n);
}

public class Day19Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int result = 0;
        for(int i = 1; i <= n; i++){
            if(n%i == 0){
                result += i;
            }
        }
        return result;
    }
}

class day19Solution{
    static void Main(string[] args){
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Day19Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
    }
}