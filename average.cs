// Program to calculate the average of the data inserted by the user
// Patrick Galán Rodriguez

using System;

class Average
{
    static void Main()
    {
        double sumResult = 0, number, counter =  0, average;
        string input;
        
        Console.WriteLine("Insert a number or type \"end\" to see average");
        input = Console.ReadLine();
        Console.WriteLine();	
        	 
        while(input != "end")
        {  
            number = Convert.ToDouble(input);
            counter++;   
            sumResult += number;  
            Console.WriteLine("Insert a number or type \"end\" to see average");
            input = Console.ReadLine();
            Console.WriteLine();
        }
        
        if(counter != 0)
        {
            average = sumResult / counter;  
            Console.WriteLine("The average is {0}.",average);
        }
    }
}
