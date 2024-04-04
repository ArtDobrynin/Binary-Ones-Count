using BinaryFunction;

Console.WriteLine("Введи число");
var number = Convert.ToInt32(Console.ReadLine());
var byteNumber = BinaryCount.BinaryCountForNumber(number);
Console.WriteLine(byteNumber);
