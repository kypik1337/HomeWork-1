Console.WriteLine("Write number;#");
int a = int.Parse(Console.ReadLine());
 while (a >= 0) 
    {
        if (a % 2 ==0)
        {
        Console.WriteLine(a+ "");
        a = a - 2;
        }
         if (a % 2 !=0)
        {
            a = a -1;
        Console.WriteLine(a+ "");
        a = a - 2;
        }
    }
 