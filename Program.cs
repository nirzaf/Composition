// See https://aka.ms/new-console-template for more information

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Press any key to continue...");
        
        Car c = new Car();
        c.NewCar();
        
        Console.ReadKey(true);
    }
}


public class Vehicle
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
    public string Plate { get; set; }
    
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
