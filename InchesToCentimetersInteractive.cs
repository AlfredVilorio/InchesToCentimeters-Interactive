using System;

class Program {
  public static void Main (string[] args) {
  
    //1 inch = 2.54 centimeters
      Double c = 2.54;
      
  
    Console.WriteLine("Enter number of inches:  ");
    
    string inches = Console.ReadLine();

    if (double.TryParse(inches, out double inchesinput))
    {
     // Double c = 2.54;
    Double cm = c * inchesinput;
     
    string result = (inches + " * " + c + " centimeters equals to " +  cm  + " centimeters"); 
    
    Console.WriteLine(result);
   
 


      } }
}