class Ostrich : IRun, ISwim
{
    public void Run()
    {
        Console.WriteLine("Ostrich can run");
    }

    public void Swim()
    {
        Console.WriteLine("Ostrich can swim, but usually lives in deserts");
    }
}
