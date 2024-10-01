// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
DateTime today = DateTime.Today;
DateTime CHRISTMAS = new DateTime(today.Year,12,25);
TimeSpan difference = CHRISTMAS - today;
int days_to_christmas = (int)difference.TotalDays;

Console.WriteLine($"Only {days_to_christmas} days until Christmas!");
