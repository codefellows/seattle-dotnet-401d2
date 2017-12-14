# ![cf](http://i.imgur.com/7v5ASc8.png) Class 04


## Learning Objectives
1. The Student will understand the basic coponents of a class
2. The student will know how to instantiate an object and how it is different from a class
1. The Student will be introduced to the Object Oriented Pillars and know how and when to identify inheritance and abstraction behavior.

## Lecture Outline


### **Introduction to Classes**
   1. **What is a Class?**
      1. A class is a 'blueprint' it defines the data and behavior of a type. 

   1. **What is an Object?**
      1. An object is a concrete entity based on a class, and is referred to as an instance of a class
      1. Use the `new` keyword to create an object
        ```csharp
        Customer amanda = new Customer();
        ```

   1. What are constructors?
      1. A constructor is defined like a method, except that the method name and return type are reduced to the name of the enclosing type:
      
   
    1. Object Initializers

```csharp
public class Bunny
{
  public string Name;
  public bool LikesCarrots;
  public bool LikesHumans;

  public Bunny () {}
  public Bunny (string n) { Name = n; }
}


// Using object initializers, you can instantiate Bunny objects as follows:
// Note parameterless constructors can omit empty parentheses
Bunny b1 = new Bunny { Name="Bo", LikesCarrots=true, LikesHumans=false };
Bunny b2 = new Bunny ("Bo")     { LikesCarrots=true, LikesHumans=false };

```

   1. What are properties?
        1. Properties look like fields from the outside, but internally they contain logic, like methods do.
        1. A property is declared like a field, but with a get/set block added
        1. A `get` property accessor is used to return the property value, and a `set` property accessor is used to assign a new value.
        2. The value keyword is used to define the value being assigned by the `set` accessor.
        3. Properties can be read-write (they have both a `get` and a `set` accessor), read-only (they have a `get` accessor but no `set` accessor), or write-only (they have a `set` accessor, but no `get` accessor). Write-only properties are rare and are most commonly used to restrict access to sensitive data.
    
        ```csharp
        class Person
        {
            private string name;  // the name field (called a 'backing store' note how it is private)
            public string Name    // the Name property
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
        }

        Person person = new Person();
        person.Name = "Joe";  // the set accessor is invoked here                

        System.Console.Write(person.Name);  // the get accessor is invoked here
        ```

        1. Logic can exist in the Get/Set accessors. 
         - This is OK
            ```csharp
            public class Date
            {
                private int month = 7;  // Backing store

                public int Month
                {
                    get
                    {
                        return month;
                    }
                    set
                    {
                        if ((value > 0) && (value < 13))
                        {
                            month = value;
                        }
                    }
                }
            }
            ```


        ***This is NOT good practice:***

        ```csharp
        private int number;
        public int Number
        {
            get
            {
                return number++;   // Don't do this
            }
        }
        ```

   1. OOPs Principles Pt.1 
      1. Inheritance
         - What is Inheritance?
           - Enables you to create new classes that reuse, extend, and modify the behavior in other classes
           - Base Class: class whose members are inherited (Animals is the base class of Cat)
           - Derived Class: class that inherits those members (i.e. Cat is derived from Animals)

### DEMO:
   - Build out a dinner party!
     
1. Abstraction
    - What is abstraction?
    - Sealed Classes
    - Requirements for an abstract class?

# Assignments

## Readings
- [Inheritance](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/inheritance)
- [Abstract](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members)
- [Constructors](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors)
- [Properties](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)

## Lab
- Build a Zoo

## Code Challenge 4
1. Write a function that will take in a string and return the acronym of that string. Words that cannot go in the acronym: ['a', 'for', 'an', 'and', 'of', 'or', 'the', 'to', 'with']

Examples: <br />

`acronym('The Federal Bureau of Investigation') -> 'FBI'
acronym('') -> null`
