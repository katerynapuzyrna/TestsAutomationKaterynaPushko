using static System.Math;
using TestsAutomationKaterynaPushko;
using TestsAutomationKaterynaPushko.University;

#region HW#3 T1

Console.WriteLine("HW#3 T1");

void PrintSum(int a, int b)
{
    Console.WriteLine(a + b);
}

PrintSum(5, 7);

#endregion

#region HW#3 T2 and HW#4 T1

Console.WriteLine("HW#3 T2 and HW#4 T1");

Person person1 = new();
Person person2 = new("Kateryna", "Pushko", 27);
person1.Introduce();
person2.Introduce();

#endregion

#region HW#4 T2

Console.WriteLine("HW#4 T2");

void PrintSqrtOfBiggerNumber(int a, int b)
{
    if (a < 0 && b < 0)
        Console.WriteLine("Both numbers are <0, cannot show sqrt (the program is working with real numbers only");
    else if (a >= b)
        Console.WriteLine($"{Sqrt(a)}; -{Sqrt(a)}");
    else
        Console.WriteLine($"{Sqrt(b)}; -{Sqrt(b)}");
}

PrintSqrtOfBiggerNumber(9, 4);
PrintSqrtOfBiggerNumber(-9, -4);

#endregion

#region HW#4 T3

Console.WriteLine("HW#4 T3");

int a = 5;
int b = 3;
Console.WriteLine($"{a}, {b}");

//1 way
a = a + b;
b = a - b;
a = a - b;
Console.WriteLine($"{a}, {b}");

//2 way
a = a + b;
b = b + a;
a = b - a;
b = b - a - a;
Console.WriteLine($"{a}, {b}");

#endregion

#region HW#5 T1

Console.WriteLine("HW#5 T1");

void SeasonPrint(int a)
{
    switch (a)
        {
        case 1:
        case 2:
        case 12:
            Console.WriteLine("Winter");
            break;
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Spring");
            break;
        case 6:
        case 7:
        case 8:
            Console.WriteLine("Summer");
            break;
        case 9:
        case 10:
        case 11:
            Console.WriteLine("Autumn");
            break;
        default:
            Console.WriteLine("Undefined");
            break;
    }
}

SeasonPrint(12);

#endregion

#region HW#5 T2

Console.WriteLine("HW#5 T2");

try
{
    Person person3 = new("Kate", "P", 120);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

try
{
    Person person4 = new("K", "Pushko", 120);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

try
{
    Person person5 = new("Kate", "Pushko", 121);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

#endregion

#region HW#5 T3

Console.WriteLine("HW#5 T3");

Bird bird=new("Kesha", 20, "green", 10.5);
Fish fish = new("Shark", 1000, "gray");
Dog dog = new("Sharik", 100, "gray");
bird.MakeSound();
bird.Fly();
Console.WriteLine($"Bird tale length is {bird.taleLength}");
fish.Dive(5);
Console.WriteLine($"Fish can dive {fish.depth} meters");

#endregion

#region HW#6 T1

Console.WriteLine("HW#6 T1");

for (int i = 0; i < 100; i++)
{
    if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
        Console.Write("FizzBuzz ");
    else if ((i + 1) % 3 == 0)
        Console.Write("Fizz ");
    else if ((i + 1) % 5 == 0)
        Console.Write("Buzz ");
    else Console.Write($"{i+1} ");
}

Console.WriteLine("");

#endregion

#region HW#6 T2

Console.WriteLine("HW#6 T2");

int[] array1 = new int[10] { 4, 5, 6, -4, 56, 8, 1, 45, 23, 5 };
int maxVal = array1[0];
for (int i = 0; i < array1.Length; i++)
{
    if (maxVal < array1[i]) maxVal = array1[i];
}
Console.WriteLine(maxVal);

#endregion

#region HW#6 T3

Console.WriteLine("HW#6 T3");

int[] array2 = new int[10] { 4, 5, 6, -4, 56, 8, 1, 45, 23, 5 };
int sumVal = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i] % 2 == 0) sumVal += array1[i];
}
Console.WriteLine(sumVal);

#endregion

#region HW#6 T4

Console.WriteLine("HW#6 T4");

int[] array3 = new int[10] { 4, 5, 6, -4, 56, 8, 1, 45, 23, 5 };
int minVal = array1[1];
for (int i = 1; i < array1.Length; i++)
{
    if (minVal > array1[i] && i % 2 == 1) minVal = array1[i];
}
Console.WriteLine(minVal);

#endregion

#region HW#6 T5

Console.WriteLine("HW#6 T5");

void PrintStringAsChars(string str)
{
    foreach (char c in str)
    Console.WriteLine(c);
}

PrintStringAsChars("Hello");

#endregion

#region HW#7 T1

Console.WriteLine("HW#7 T1");

Pelican pelican = new();
Sparrow sparrow = new();
Ostrich ostrich = new();

pelican.Fly();
pelican.Run();
pelican.Swim();

sparrow.Fly();
sparrow.Run();

ostrich.Run();
ostrich.Swim();

#endregion

#region HW#7 T2

Console.WriteLine("HW#7 T2");

int firstNum = 1001;
int secondNum = 10;

try
{
    Console.WriteLine(MathOperations.Multiply(firstNum, secondNum));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

#endregion

#region HW#12 T1

Console.WriteLine("HW#12 T1");

Student student1 = new Student("Kateryna", "Pushko", "Economic Cybernetics", 1);
Student student2 = new Student("Ivan", "Ivanov", "History", 1);
Student student3 = new Student("Taras", "Berezko", "Economic Cybernetics", 1);
Student student4 = new Student("Oksana", "Koval", "Economic Cybernetics", 1);
Student student5 = new Student("Diana", "Vlasenko", "Economic Cybernetics", 1);
Student student6 = new Student("Alla", "Tymoshenko", "Economic Cybernetics", 1);

Lector lector1 = new Lector("Serhii", "Topolya", "Economic Cybernetics");
Lector lector2 = new Lector("Anastasiia", "Lysenko", "History");

lector1.addCandidates(new List<Student> { student1, student2, student3, student4 } );
lector1.addCandidate(student5);
student6.RequestForLectorGroup(lector1);
lector2.addCandidate(student2);

lector1.showCandidatesList();
lector1.showMembersList();
lector2.showCandidatesList();
lector2.showMembersList();

#endregion

#region HW#12 T2

Console.WriteLine("HW#12 T2");

int numberOfLampsAndFrogs = 100;

Lamp[] arrayOfLamps = new Lamp[numberOfLampsAndFrogs];

for (int i = 0; i < numberOfLampsAndFrogs; i++)
{
    arrayOfLamps[i] = new Lamp(i + 1, false);
}

for (int j = 0; j < numberOfLampsAndFrogs; j++)
{
    Press(j+1);
}

for (int i = 0; i < numberOfLampsAndFrogs; i++)
{
    Console.WriteLine($"{arrayOfLamps[i].id} {arrayOfLamps[i].state}");
}

void Press(int x)
{
    for (int i = 0; i < numberOfLampsAndFrogs; i++)
    {
        if (arrayOfLamps[i].id % x == 0)
        {
            if (arrayOfLamps[i].state == true)
                arrayOfLamps[i].state = false;
            else arrayOfLamps[i].state = true;
        }
    }

}

#endregion

Console.ReadKey();