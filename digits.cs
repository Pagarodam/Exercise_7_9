using System;

class digits
{
    static void Main()
    {
       
        int units = 0,  tens= 0, hundreds = 0, more = 0;
        string input;
        
        Console.WriteLine("Insert a number:");
        input = Console.ReadLine();
        
        while(input != "end")
        {
            int number = Convert.ToInt32(input);
            
            if(number != 0 && number / 10 == 0)
            {
                units ++;
            }
               
            else if (number / 100 == 0)
            {
                tens++;
            }
                 
            else if (number / 1000 == 0)
            {
                hundreds ++;  
            }
            else
            {
                more++; 
            } 
                
            input = Console.ReadLine();
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}",
            units, tens, hundreds, more); 
    }
}

