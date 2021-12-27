// See https://aka.ms/new-console-template for more information

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Press any key to continue...");
        
        var c = new Car();
        c.NewCar();
        
        Console.ReadKey(true);
    }
}


public class Vehicle
{
    private long Id { get; set; }
    private string Name { get; set; }
    private string Type { get; set; }
    private string Color { get; set; }
    private string Make { get; set; }
    private string Model { get; set; }
    private string Year { get; set; }
    private string Plate { get; set; }
    
    public Vehicle()
    {
    }

    public Vehicle(long id, string name, string type, string color, string make, string model, string year, string plate)
    {
        Id = id;
        Name = name;
        Type = type;
        Color = color;
        Make = make;
        Model = model;
        Year = year;
        Plate = plate;
    }

    public void Drive()
    {
        Console.WriteLine("The vehicle is driving");
    }
}

public class Car : Vehicle
{
    public void NewCar()
    {
        Console.WriteLine("The car is new");
    }
}
