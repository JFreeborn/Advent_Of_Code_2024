﻿// See https://aka.ms/new-console-template for more information

using Advent2024.Day_1;
using Advent2024.Day_2;
using Advent2024.Helpers;

Console.WriteLine("Hello, World!");

#region Day One

// var getFileContent = new GetFileContent();
// var x = getFileContent.GetListsFromFile();
// var dayOneClass = new DayOne();
// var dayOnePartOneResult = dayOneClass.RunPartOne(x.Item1, x.Item2);
// Console.WriteLine($"Day 1 Part 1: {dayOnePartOneResult}");
// var dayOnePartTwoResult = dayOneClass.RunPartTwo(x.Item1, x.Item2);
// Console.WriteLine($"Day 1 Part 2: {dayOnePartTwoResult}");

#endregion

var dayTwoClass = new DayTwo();
var dayTwoPartOneResult = dayTwoClass.RunPartOne();
Console.WriteLine("Total Safe Count {0}", dayTwoPartOneResult);
