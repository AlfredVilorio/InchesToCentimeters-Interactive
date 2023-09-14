using System;

class Program {
  public static void Main (string[] args) {
  
    
      Double c = 2.54;
      
  
    Console.WriteLine("Enter number of inches:  ");
    
    string inches = Console.ReadLine(); // Interaction to type your number

    if (double.TryParse(inches, out double inchesinput)) 
    {
     //Calculation of the conversion to centimeters as cm
      
    Double cm = c * inchesinput;
      
      //1 inch = 2.54 centimeters
     //Written result based on the typed number multiply by (c) or 2.54  
    //how much cm is based on number of inches typed
      
    string result = $"{inchesinput} inches * {c}  centimeters is " +  cm  + " centimeters"; 
      
    //Written end result
    Console.WriteLine(result);
   
 


      } }
}