using System;

class Program {
  public static void Main (string[] args) {
    //Fixed decimal conversion
    //1 inch = 2.54 centimeters
    const double centimeters = 2.54;
    //Input a number
    Console.WriteLine("Enter number of inches:  ");
    
    string inchestyped = Console.ReadLine();

   // If input is decimal form, it gives the output and continues
    if (double.TryParse(inchestyped, out double inches))
     {
    
     var x = inches * centimeters; 
    //Displays conversion of inches to centimeters//
    Console.WriteLine($"{inches} inches is {x} centimeters.");}
    // If input is not decimal form, output is invalid
   
    else {
      Console.WriteLine("Invalid");


      } }
}