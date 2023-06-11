internal class Program
{
    private static void Main(string[] args)
    {
        int size;
        size = int.Parse(Console.ReadLine());
        finobocci(size);

    }
    static void finobocci(int size)
    {
        int a, b, c;
        a = 0;
        b = 1;
        c = 0;
        Console.Write("{0} {1} ", a, b);

        for (int i = 2; i < size; i++)
        {
            c = a + b;
            Console.Write("{0} ", c);
            a = b;
            b = c;
        }
        return;
    }
}