// C# program to demonstrate the  
// Compile Time Initialization 
using System; 
class compile_time{ 
      
        // only declaration, compiler will  
        // provide the default value 0 to it 
        int y; 
      
    // Main Method 
    public static void Main(String []args) 
    { 
          
        // Compile Time Initialization of variable 'x' 
        // Assigning value 32 to x 
        int x = 25;     
          
        // printing the value 
        Console.WriteLine("Value of x is "+x); 
          
        // creating object to access 
        // the variable y 
        compile_time obj = new compile_time();  
          
        // printing the value 
        Console.WriteLine("Value of y is "+obj.y); 
    } 
} 
