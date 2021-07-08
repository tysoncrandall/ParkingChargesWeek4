using System;

class MainClass{ 

    //define function
    public static double CalculateCharges(double hours)
    {
      double cost = 0.0;

      if (hours <= 3)
        cost = 2.00;
      else if (hours == 24)
        cost = 10;
      else
        cost = 2.00 + (0.50*hours);

      return cost;
    }
    
    public static void Main (string[] args) {

      int counter = 0;
      double cost = 0.0;
     
      Console.WriteLine("Enter the number of of customers: ");
      int customers = Convert.ToInt32(Console.ReadLine());
      
      while(counter < customers)
      {
        Console.Write("Enter the hours parked for customer" + (counter + 1) + " : ");
        double hours = Convert.ToDouble(Console.ReadLine());

        cost = CalculateCharges(hours);

        Console.WriteLine("The parking cost for customer " + (counter+1) + " is " + cost);
        counter++;
      }
    
    }  

  }