data[] datas = new data[3];
for (int i = 0; i < datas.Length; i++)
{
    Console.Write("Введите фамилию: ");
    datas[i].surname = Console.ReadLine()!;
    Console.Write("Введите имя: ");
    datas[i].name = Console.ReadLine()!;
    Console.Write("Введите отчество: ");
    datas[i].secondname = Console.ReadLine()!;
    Console.Write("Введите должность: ");
    datas[i].position = Console.ReadLine()!;
    Console.Write("Введите пол: ");
    datas[i].gender = Console.ReadLine()!;
    Console.Write("Введите дату приёма на работу: ");
    datas[i].employment = DateTime.Parse(Console.ReadLine()!);
}
double sum = 0;
for (int i = 0;i < datas.Length; i++)
{
    sum += (DateTime.Now - datas[i].employment).TotalDays / 365.25;
}
double average = sum / datas.Length;
Console.WriteLine("\nСредний стаж: " + average.ToString("F2") + " лет");
for (int i = 0; i < datas.Length; i++)
{
    double experience = (DateTime.Now - datas[i].employment).TotalDays / 365.25;
    if (experience > average)
    {
        Console.WriteLine("Фамилия: " + datas[i].surname);
        Console.WriteLine("Имя: " + datas[i].name);
        Console.WriteLine("Отчество: " + datas[i].secondname);
        Console.WriteLine("Должность: " + datas[i].position);
        Console.WriteLine("Пол: " + datas[i].gender);
        Console.WriteLine("Дата приема: " + datas[i].employment);
        Console.WriteLine("Стаж: " + experience.ToString("F2") + "Лет");
    }
}

struct data
{
    public string surname;
    public string name;
    public string secondname;
    public string position;
    public string gender;
    public DateTime employment;
}
