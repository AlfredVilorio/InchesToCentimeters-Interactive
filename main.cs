using System;

class Program {
  public static void Main (string[] args) {
     
    Console.WriteLine("Enter number of inches:  ");
    string inchestyped = Console.ReadLine();

 
    if (double.TryParse(inchestyped, out double inches))
     {
     var x = inches * 2.54;  
    Console.WriteLine($"{inches} inches is equal to {x} centimeters.");}
    
   
    else {
      Console.WriteLine("Invalid");


      } }
}