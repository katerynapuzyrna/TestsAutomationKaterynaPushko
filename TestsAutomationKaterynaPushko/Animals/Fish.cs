class Fish : Animal
{
    public double depth;
    public Fish(string name, double length, string color, int depth=0) : base(name, length, color)
    {
        this.depth = depth;
    }
    public void Dive(double depth)
    {
       this.depth += depth;
    }
}
