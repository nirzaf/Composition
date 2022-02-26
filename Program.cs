// See https://aka.ms/new-console-template for more information
global using static System.Console;
class program
{
    static void Main(string[] args)
    {
        WriteLine("Hello World!");
        WriteLine("Press any key to continue...");
        
        var c = new Car();
        c.NewCar();
        ReadKey(true);
    }
}

public class Car
{
    private Engine eng = new Engine("QWER","Auto");
    public void NewCar()
    {
        WriteLine("This is a new car.........!");
        eng.BuildEngine();
    }
}