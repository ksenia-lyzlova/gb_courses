using System;

class Lab64
{
    static int printNatural(int number)
    {
    	if (number < 1)
    	{
    	    return 1;
    	}
    
    	Console.Write("{0} ",number);
    		number--;
    	return printNatural(number);
    }
    
    static void Main()
    {
    	Console.Write("Введите число :\n");
    	int number = Convert.ToInt32(Console.ReadLine());
    	printNatural(number);
    }
}