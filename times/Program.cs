using System.Data;

DateTime data1 = new DateTime();
Console.WriteLine(data1);
DateTime data2 = DateTime.Now;
Console.WriteLine(data2);
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.UtcNow);
Console.WriteLine(DateTime.Today);
DateTime data3 = DateTime.Parse("2026-8-21");
Console.WriteLine(data3);


//операции
Console.WriteLine(data3.Add(new TimeSpan(34,12,22)));
Console.WriteLine(data3.AddDays(8));
Console.WriteLine(data3.AddHours(100));
//дата и время во всех форматах
Console.WriteLine($"D:{data3.ToString("D")}");
Console.WriteLine($"d:{data3.ToString("d")}");
Console.WriteLine($"F:{data3.ToString("F")}");

//DateOnly
DateOnly dateOnly = new DateOnly();
Console.WriteLine(dateOnly);
DateOnly d3 = new DateOnly(2026,11,21);
Console.WriteLine(d3);
Console.WriteLine(d3.DayOfYear);
Console.WriteLine(d3.Year);