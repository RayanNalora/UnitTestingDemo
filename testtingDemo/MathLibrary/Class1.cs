namespace MathLibrary;

public class Class1
{
   public static int Multiply(int a,int b)
    {
        return a*b;
    }

    public static int Divide(int a ,int b)
    {
        if(b == 0)
           throw new DivideByZeroException("لايمكن القسمة على 0")
        return a / b;
    }

     public static bool IsEven(int a)
    {
        return a % 2 == 0;
    }
}
