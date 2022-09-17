Console.WriteLine("Write number 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write number 2");
int b = int.Parse(Console.ReadLine());
int max = a;
if (a < b) max = b; 
   
Console.WriteLine($"MAX number = {max}");