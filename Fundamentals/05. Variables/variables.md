# C# Variables
A typical program uses various values that may change during its execution. For example, a program that performs some operations on the values entered by the user. The values entered by one user may differ from those entered by another user. Hence this makes it necessary to use variables as another user may not use the same values. When a user enters a new value that will be used in the process of operation, can store temporarily in the Random Access Memory of computer and these values in this part of memory vary throughout the execution and hence another term for this came which is known as Variables. So basically, a Variable is a placeholder of the information which can be changed at runtime. And variables allows to Retrieve and Manipulate the stored information.
***
## Syntax
<blockquote>
type variable_name = value;<br>
or<br>
type variable_names;
</blockquote>

> char var = 'h'; // Declaring and Initializing character variable<br>
> int a, b, c; // Declaring variables a, b and c of int type<br>

### Characteristics of Variables:

* name : It must be a valid identifier. In above example, var is a valid identifier.
* type : It defines the types of information which is to be stored into the variable. In above example char is a type.
* value : It is the actual data which is to be stored in the variable. In above example ‘h’ is the value.
***
### Rules for Naming Variables
* Variable names can contain the letters ‘a-z’ or ’A-Z’ or digits 0-9 as well as the character ‘_’.
* The name of the variables cannot be started with a digit.
* The name of the variable cannot be any C# keyword say int, float, null, String, etc
***
### Two Ways for Initialization:

1. Compile time initialization
2. Run time initialization

