namespace _3_LiskovSubstitution.CorrectAplication;

internal interface IAnimal
{
    void Eat();
    void Sleep();
}

internal class Dog : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Dog eats.");
    }

    public void Sleep()
    {
        Console.WriteLine("Dog sleeps.");
    }

    public void Bark()
    {
        Console.WriteLine("Dog barks.");
    }
}

internal class Fish : IAnimal
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Sleep()
    {
        throw new NotImplementedException();
    }

    public void Swim()
    {
        Console.WriteLine("Fish swims.");
    }
}
