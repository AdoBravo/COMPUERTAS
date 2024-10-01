namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
class Program
{
    static void Main(string[] args)
    {
        GarageGate gate = new GarageGate();
        Console.WriteLine(gate.AbrirPuerta(0, 0, 1)); 
        Console.WriteLine(gate.AbrirPuerta(1, 1, 1)); 
        Console.WriteLine(gate.AbrirPuerta(1, 0, 0)); 
    }
}
