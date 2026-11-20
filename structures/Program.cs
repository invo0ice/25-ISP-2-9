//DayTime dayTime = DayTime.Morning;
//if (dayTime == DayTime.Morning)
//    Console.WriteLine("Доброе утро!");
//else
//    Console.WriteLine("Привет!");

//DoOperation(10, 5, Operation.Add);          // 15
//DoOperation(10, 5, Operation.Sub);     // 5
//DoOperation(10, 5, Operation.Mult);     // 50
//DoOperation(10, 5, Operation.Div);       // 2
//void DoOperation(double x, double y, Operation op)
//{
//    double result = op switch
//    {
//        Operation.Add => x + y,
//        Operation.Sub => x - y,
//        Operation.Mult => x * y,
//        Operation.Div => x / y
//    };
//    Console.WriteLine(result);
//}
//enum DayTime
//{
//    Morning,
//    Afternoon,
//    Evening,
//    Night
//}

//enum Operation
//{
//    Add,
//    Sub,
//    Mult,
//    Div
//}

//Person tom = new Person();
//tom.name = "Vasia";
//tom.age = 10;
//Console.WriteLine(tom.name);
//Console.WriteLine(tom.age);
//struct Person
//{
//    public string name;
//    public int age;
//}

Comp[] comps = new Comp[2];
for (int i = 0; i < comps.Length; i++)
{
    Console.Write("Введите название компьютера: ");
    comps[i].name = Console.ReadLine()!;
    Console.Write("Введите частоту : ");
    comps[i].frecuancy = int.Parse(Console.ReadLine()!);
    Console.Write("Введите память : ");
    comps[i].memory = int.Parse(Console.ReadLine()!);
    Console.Writew3 ("Введите наличие DVD: Да/Нет");
    string dvd = Console.ReadLine()!;
    if (dvd == "Да") comps[i].DVD = true;
    else comps[i].DVD = false;
    Console.Write("Введите цену : ");
    comps[i].price = decimal.Parse(Console.ReadLine()!);
}
for (int i = 0;i < comps.Length; i++)
{
    if (comps[i].DVD) comps[i].Print();
}
struct Comp
{
    public string name;
    public int frecuancy;
    public int memory;
    public bool DVD;
    public decimal price;
    public void Print()
    {
        Console.WriteLine($"Название:{name}, частота:{frecuancy}, память:{memory}, {((DVD)?"DVD":"")}, цена:{price:F2}");
    }
}