using System;

class Average
{
    static void Main()
    {
        double sumResult = 0, newMark, counter =  0, average;
        string mark;
        
        Console.WriteLine("Insert a mark or type \"end\" to see average");
        mark = Console.ReadLine();	
        	 
        while(mark != "end")
        {  
            newMark = Convert.ToDouble(mark);
            counter++;   
            sumResult += newMark;  
            Console.WriteLine("Insert a mark or type \"end\" to see average");
            mark = Console.ReadLine();
        }
        
        if(counter != 0)
        {
            average = sumResult / counter;  
            Console.WriteLine("The average is {0}.",average);
        }
    }
}
