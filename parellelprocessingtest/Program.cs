// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Net;

Console.WriteLine("Hello, World!");
List<int> numbers = new List<int>();
for(int i = 1; i < 1000; i++)
{
    numbers.Add(i);
}
Console.WriteLine(numbers);
bool Isodd(int number)
{
    try
    {
        using var client = new HttpClient();
        
        WebRequest request = HttpWebRequest.Create("https://www.facebook.com");
        WebResponse response = request.GetResponse();
        Console.WriteLine(number.ToString() + " " + response.ToString());
        
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message.ToString());
    }
    if (number % 2 == 0)
        return false;
    else
        return true;
}

DateTime d = DateTime.Now;

Parallel.ForEach(numbers, new ParallelOptions() { MaxDegreeOfParallelism =20 }, number =>
{
    if (Isodd(number))
    {
//Console.WriteLine(number);
    }
});
Console.WriteLine(DateTime.Now-d);
d = DateTime.Now;


foreach(int number  in numbers)
{
    if (Isodd(number))
    {
//Console.WriteLine(number);
    }
};

Console.WriteLine(DateTime.Now - d);

