namespace TestsAutomationKaterynaPushko;

public class MathOperations
{
    public static int Multiply(int firstNumber, int secondNumber)
    {
        if (firstNumber <= 1000 && secondNumber <= 1000 && firstNumber >= -1000 && secondNumber >= -1000)
            return firstNumber * secondNumber;
        else throw new Exception($"Both numbers should be between -1000 and 1000, but entered {firstNumber} and {secondNumber}");
    }
}