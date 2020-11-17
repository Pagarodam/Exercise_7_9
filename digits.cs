/*Program that calculates how many numbers
 *  of 1, 2, 3 or more digits are entered by the
 *  user until he/she types “end”
Patrick Galán Rodriguez */
 
using System;

class digits
{
    static void Main()
    {
       
        int units = 0,  tens= 0, hundreds = 0, more = 0;
        string input;
        
// do/while or repeat the next sentence for gain understandability ?       
        Console.WriteLine("Insert numbers or type \"end\" to finish:");
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

