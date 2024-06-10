//var settings = GC.GetConfigurationVariables();

//foreach (var setting in settings)
//{
//    Console.WriteLine($"{setting.Key}: {setting.Value}");
//}   

using System.Runtime.InteropServices;

var a = new byte[95005];


Console.WriteLine(GC.GetGeneration(a));





Console.ReadLine();