public class Handler
{
    public static int Calculator(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Merci de donner une valeur superieur à 0 à b");
        }

        return (a / b);
    }
}