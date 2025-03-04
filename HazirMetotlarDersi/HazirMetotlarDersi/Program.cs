﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMonths(5));
Console.WriteLine(DateTime.Now.AddYears(10));

//Datetime Format

Console.WriteLine(DateTime.Now.ToString("dd")); //01
Console.WriteLine(DateTime.Now.ToString("ddd")); //Sun
Console.WriteLine(DateTime.Now.ToString("dddd")); //Sunday

Console.WriteLine(DateTime.Now.ToString("MM")); //05
Console.WriteLine(DateTime.Now.ToString("MMM")); //May
Console.WriteLine(DateTime.Now.ToString("MMMM")); //Mayıs

Console.WriteLine(DateTime.Now.ToString("yy")); //22
Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

//Math Kütüphanesi
Console.WriteLine(Math.Abs(-25)); //Mod
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));
Console.WriteLine(Math.Tan(10));

Console.WriteLine(Math.Ceiling(22.3)); //23
Console.WriteLine(Math.Round(22.3)); //22
Console.WriteLine(Math.Round(22.7)); //23
Console.WriteLine(Math.Floor(22.3)); // 22








