Console.WriteLine("Write number;#");
int a = int.Parse(Console.ReadLine());
int b = 0;
 while (b < a) 
     {
        if ( a % 2 == 0)
        {
       b = b + 2;
       Console.Write($"{b} , ");
        }
        if ( a % 2 != 0)
        {
            a = a - 1;
            b = b + 2;
            Console.Write($"{b} , ");
        }
     }