using ConsoleChartQuiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

Console.WindowWidth = 150;


List<Data> list = new List<Data>();
string input = Console.ReadLine();
input = Console.ReadLine();


while (input != null) {
    string[] newData = input.Split('\t');
    var data = new Data(newData[0], newData[1], newData[2], Convert.ToInt32(newData[3]));
    addWithArgs(data);
    input = Console.ReadLine();
}

list = list.OrderByDescending(v => v.Attacks).ToList();

int maxOutput = Convert.ToInt32(args[2]);
int currentLoopCount = 0;
double maxValue = 0;
bool isFirstEntry = true;

foreach (var item in list) {
    if (isFirstEntry) {
        maxValue = item.Attacks;
        isFirstEntry = !isFirstEntry;
    }

    if (currentLoopCount <= maxOutput) {
        if (args[0].ToLower() == "animal") {
            Console.Write($" {item.Animal,35} | ");
        } else if (args[0].ToLower() == "time_of_day") {
            Console.Write($" {item.TimeOfDay,35} | ");
        } else if (args[0].ToLower() == "country") {
            Console.Write($" {item.Country,35} | ");
        }

        ConsoleColor original = Console.BackgroundColor;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(new string(' ', (int)Math.Ceiling(item.Attacks * 100.0 / maxValue)));
        Console.BackgroundColor = original;
    }
    currentLoopCount++;
}

void addWithArgs(Data data) {
    bool isNew = true;
    if (args[0].ToLower() == "animal") {
        for (int i = 0; i < list.Count; i++) {
            Data item = list[i];
            if (data.Animal == item.Animal) {
                Data removedData = list[i];
                list.RemoveAt(i);
                removedData.Attacks += item.Attacks;
                list.Add(removedData);
                isNew = !isNew;
            }
        }
        if (isNew) {
            list.Add(data);
        }
        return;
    }
    if (args[0].ToLower() == "time_of_day") {
        for (int i = 0; i < list.Count; i++) {
            Data item = list[i];
            if (data.TimeOfDay == item.TimeOfDay) {
                Data removedData = list[i];
                list.RemoveAt(i);
                removedData.Attacks += item.Attacks;
                list.Add(removedData);
                isNew = !isNew;
            }
        }
        if (isNew) {
            list.Add(data);
        }
        return;
    }

    if (args[0].ToLower() == "country") {
        for (int i = 0; i < list.Count; i++) {
            Data item = list[i];
            if (data.Country == item.Country) {
                Data removedData = list[i];
                list.RemoveAt(i);
                removedData.Attacks += item.Attacks;
                list.Add(removedData);
                isNew = !isNew;
            }
        }
        if (isNew) {
            list.Add(data);
        }
        return;
    }
}

Console.WriteLine();