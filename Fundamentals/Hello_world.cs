// C# program to print Hello World
using System;
// namespace declaration
namespace HelloWorldApp{
    // class Declaration
    class Hello_world{
        static void Main(String[] args){
            // printing hello world
            Console.WriteLine("Hello World!");
            Console.ReadKey();      // To prevents the screen from  
            // running and closing quickly 
            
        }
    }
}
// Explanation:
//     using System: System is a namespace which contains the commonly used types. It is specified with a using System directive.
//     namespace HelloWorldApp: Here namespace is the keyword which is used to define the namespace. HelloWorldApp is the user-defined name given to namespace.
//     class Hello_world: Here class is the keyword which is used for the declaration of classes. Hello_world is the user-defined name of the class.
//     static void Main(string[] args): Here static keyword tells us that this method is accessible without instantiating the class. void keyword tells that this method will not return anything.
//     Main() method is the entry point of our application. In our program, Main() method specifies its behavior with the statement Console.WriteLine(“Hello World!”);.

//     Console.WriteLine(): Here WriteLine() is a method of the Console class defined in the System namespace.
//     Console.ReadKey(): This is for the VS.NET Users. This makes the program wait for a key press and prevents the screen from running and closing quickly.

// Namespaces:
// Namespaces are used to organize the classes. It helps to control the scope of methods and classes in larger .Net programming projects. 
// In simpler words you can say that it provides a way to keep one set of names(like class names) different from other sets of names.
// The biggest advantage of using namespace is that the class names which are declared in one namespace will not clash with the same 
// class names declared in another namespace. It is also referred as named group of classes having common features. The members of a 
// namespace can be namespaces, interfaces, structures, and delegates.