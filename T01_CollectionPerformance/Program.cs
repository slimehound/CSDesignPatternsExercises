using MoreLinq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

// See https://aka.ms/new-console-template for more information

const int count = 1_000_000;
const int searchIndex = 551_467;

//List<Pair> baseList = new();

//for (int i = 0; i < count; i++)
//{
//    baseList.Add(new() { Index = i, Text = i.ToString() });
//}

//baseList = baseList.Shuffle().ToList();



//Pair[] array = baseList.ToArray();
Pair[] array = new Pair[count];

var sw = Stopwatch.StartNew();

for (int i = 0; i < count; i++)
{
    array[i] = new() { Index = i, Text = i.ToString() };
}

Console.WriteLine($"Array created in {sw.ElapsedTicks:N0} ticks");

sw.Restart();

var value = array.Where(x => x.Index == searchIndex).Select(x => x.Text).FirstOrDefault();

Console.WriteLine($"Array item {value} found in {sw.ElapsedTicks:N0} ticks");

sw.Restart();

value = array[searchIndex].Text;

Console.WriteLine($"Array item {value} indexed in {sw.ElapsedTicks:N0} ticks");
Console.WriteLine();
Console.WriteLine();



//List<Pair> list = baseList.ToList();
List<Pair> list = new();

sw.Restart();

for (int i = 0; i < count; i++)
{
    list.Add(new() { Index = i, Text = i.ToString() });
}

Console.WriteLine($"List created in {sw.ElapsedTicks:N0} ticks");

sw.Restart();

value = list.Where(x => x.Index == searchIndex).Select(x => x.Text).FirstOrDefault();

Console.WriteLine($"List item {value} found in {sw.ElapsedTicks:N0} ticks");

sw.Restart();

value = list[searchIndex].Text;

Console.WriteLine($"List item {value} indexed in {sw.ElapsedTicks:N0} ticks");
Console.WriteLine();
Console.WriteLine();




//Dictionary<int, string> dict = baseList.ToDictionary(x => x.Index, x => x.Text);
Dictionary<int, string> dict = new();

sw.Restart();

for (int i = 0; i < count; i++)
{
    dict[i] = i.ToString();
}

Console.WriteLine($"Dictionary created in {sw.ElapsedTicks:N0} ticks");

sw.Restart();

value = dict.Where(x => x.Key == searchIndex).Select(x => x.Value).FirstOrDefault();

Console.WriteLine($"Dictionary item {value} found in {sw.ElapsedTicks:N0} ticks");

sw.Restart();

value = dict[searchIndex];

Console.WriteLine($"Dictionary item {value} indexed in {sw.ElapsedTicks:N0} ticks");
Console.WriteLine();
Console.WriteLine();




Console.ReadKey();


public struct Pair
{
    public int Index;
    public string Text;
}