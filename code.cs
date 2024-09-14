using System;
public class A
{
    public static void Main()
    {
        int num1, num2, num3, num4, num5;
        num1 = 5;
        num2 = 3;
        num3 = A.strange(num1, num2);
        num4 = A.strange(num3, num1);
        num5 = A.strange(num2, num3);
        string str = "num3= " + num3 + " and num4= " + num4;
        Console.Write(str);
    }

    public static int strange(int a, int y)
    {
        return y + a;
    }
      public static int randomizer(int x, int y)
    {
        return y * y;
    }
}
