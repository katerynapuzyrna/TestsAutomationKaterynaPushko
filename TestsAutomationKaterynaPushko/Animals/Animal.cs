    abstract class Animal
    {
        public string name;
        public double length;
        public string color;
        public Animal(string name, double length, string color)
        {
            this.name = name;
            this.length = length;
            this.color = color;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes sound");
        }
}
