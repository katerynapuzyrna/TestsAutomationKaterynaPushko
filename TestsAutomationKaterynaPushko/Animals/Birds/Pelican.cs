     class Pelican : IFly, ISwim, IRun
    {
    public void Run()
    {
        Console.WriteLine("Pelican can run clumsily ");
    }
    public void Fly()
    {
        Console.WriteLine("Pelican can fly");
    }

    public void Swim()
    {
        Console.WriteLine("Pelican can swim");
    }
}

