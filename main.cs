using System;

class Program {
  public static void Main (string[] args) {
     //Input "Enter inches"
    Console.WriteLine("Enter number of inches:  ");
    
    string inchestyped = Console.ReadLine();

   // If input is decimal form, it gives the output and continues
    if (double.TryParse(inchestyped, out double inches))
     {
     var x = inches * 2.54; 
    //Displays conversion of inches to centimeters//
    Console.WriteLine($"{inches} inches is equal to {x} centimeters.");}
    // If input is not decimal form, output is invalid
   
    else {
      Console.WriteLine("Invalid");


      } }
}