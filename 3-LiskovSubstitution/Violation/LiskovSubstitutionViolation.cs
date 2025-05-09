namespace _3_LiskovSubstitution.Violation;

internal interface IAnimal
{
    public void Walk();
    public void Fly();
    public void Swim();
}

internal class Dog : IAnimal
{
    public void Fly()
    {
        throw new NotImplementedException("Dog cannot fly.");
    }

    public void Swim()
    {
        Console.WriteLine("Dog can swim.");
    }

    public void Walk()
    {
        Console.WriteLine("Dog can walk.");
    }
}

internal class Fish : IAnimal
{
    public void Fly()
    {
        throw new NotImplementedException("Fish cannot fly.");
    }

    public void Swim()
    {
        Console.WriteLine("Fish can swim.");
    }

    public void Walk()
    {
        throw new NotImplementedException("Fish cannot walk.");
    }
}