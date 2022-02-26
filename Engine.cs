public class Engine
{
    private readonly string _engineType;
    private readonly string _engineSize;
    public Engine(string engineSize, string engineType)
    {
        _engineSize = engineSize;
        _engineType = engineType;
    }
    
    public void BuildEngine()
    {
        WriteLine($"Building engine with type: {_engineType}, & size: {_engineSize}");
    }
}