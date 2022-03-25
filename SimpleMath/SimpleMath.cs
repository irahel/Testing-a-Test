namespace SimpleMath;
public class SimpleMathClass
{
    public static int Add(int number1, int number2)
    {
        if (number1 >= number2)
        {
            return number1 + number2;
        }
        else
        {
            return number2 + number1;
        }
    }
    public static int Subtract(int number1, int number2) => number1 - number2; 
}
