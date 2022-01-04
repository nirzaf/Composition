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

public class Car
{
    public void NewCar()
    {
        Console.WriteLine("This is a new car.........!");
    }
}
