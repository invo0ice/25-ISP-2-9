Console.WriteLine("Текущие системное время: ");
Console.WriteLine(DateTime.Now);

Console.WriteLine("Введите полное время начала звонка: ");
TimeSpan start = TimeSpan.Parse(Console.ReadLine()!);
Console.WriteLine("Введите время окончания звонка: ");
TimeSpan end = TimeSpan.Parse(Console.ReadLine()!);
Console.WriteLine("Введите стоимость одной минуты в копейках: ");
int price = int.Parse(Console.ReadLine()!);
TimeSpan duration = end  - start;
if (duration < TimeSpan.Zero)
{
    duration = duration.Add(TimeSpan.FromDays(1));
}
decimal seconds = (decimal)duration.TotalSeconds;
decimal money = seconds * price / 60 / 100;
Console.WriteLine("Продолжительность звонка: " + seconds + " секунд");
Console.WriteLine("Стоимость звонка: " + money.ToString("F2") + " грн");