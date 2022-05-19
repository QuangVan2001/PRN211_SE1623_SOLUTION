namespace PRN.SE1623;

public class Employee
{
    // fields/ data
    private int id;
    private string name;
    private int email;
    //private double salary;
    // properties/ attributes

    public double Salary { get; set; }
    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }


    //Contructor
    public Employee()
    {
    }

    public Employee(double salary, int id, string name)
    {
        Salary = salary;
        Id = id;
        Name = name;
    }

    public override string? ToString()
    {
        return $"id ={Id}, Name{Name}, Salary{Salary}"
    }
}
