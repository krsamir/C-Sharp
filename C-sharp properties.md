# C# Properties (Get and Set)
## Properties and Encapsulation
### Encapsulation
The meaning of `Encapsulation`, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:

* declare fields/variables as private
* provide public get and set methods, through properties, to access and update the value of a private field

## Properties
`private` variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.<br>
A property is like a combination of a variable and a method, and it has two methods: a get and a set method.
<blockquote>
class Person<br>
{<br>
  private string name; // field<br>

  public string Name   // property<br>
  {<br>
    get { return name; }   // get method<br>
    set { name = value; }  // set method<br>
  }<br>
}<br>
</blockquote>

### Example explained
The Name property is associated with the name field. It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.<br>

The get method returns the value of the variable name.<br>

The set method assigns a value to the name variable. The value keyword represents the value we assign to the property.<br>

# Automatic Properties (Short Hand)
C# also provides a way to use short-hand / automatic properties, where you do not have to define the field for the property, and you only have to write `get;` and `set;` inside the property.<br>
