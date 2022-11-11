class Bird : Animal, IFly
{
    public double taleLength;
    public Bird(string name, double length, string color, double taleLength) : base(name, length, color)
    {
        this.taleLength = taleLength;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Bird makes sound");
    }

    public void Fly()
    {
        Console.WriteLine("Bird can fly");
    }
}
