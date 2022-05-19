namespace city.district.ward.street; // .NET6 (giống package trong java)


public class Program
{
    public static void Main(string[] main)
    {   
        int x = 1;
        int y = 2;
        string name;
        var salary = 10.5// gọi tới các A PIS (xml/json)
        Console.WriteLine(salary.GetType());

        dynamic fullName = 10;
        fullName = "String";


        int age = int.Parse("30");
        Console.WriteLine($"Sum of a = {x} and b ={y} is : { Sum(x, y)}");
    }


    public static int Sum(int a, int b)
    {
        return a + b;
    }
    
}


