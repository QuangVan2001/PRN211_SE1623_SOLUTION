namespace Prn.Se1623;
public class Program
{
    public static void Main()
    {
        //PrintNumbers();
        //2. Tao ra 3 luon, moi luong thuc thi 1 viec
        Thread t1 = new Thread(() => PrintNumbers(1));
        t1.Start());
    }

    public static void PrintNumbers()
    {
        for (int i = 0; i <= 3; i++)
            Thread.Sleep(1000);
            Console.WriteLine($"Thread {}: {1}"); 
    }

}