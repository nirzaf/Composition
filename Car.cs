using Composition;

public class Car
{
    private Engine eng = new Engine("QWER","Auto");
    public void NewCar()
    {
        WriteLine("This is a new car.........!");
        eng.BuildEngine();
    }
}