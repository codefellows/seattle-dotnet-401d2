# ![cf](http://i.imgur.com/7v5ASc8.png) Class 06 Interfaces

## Lecture Outline

### **Interfaces**
   1. why do you need them?
      - Sometimes you need to group your objects together based on the **things they can do** rather than the classes they inherit from.
   1. Any class that implements an interface must promise to 'fulfill it's obligations' or the compiler will get upset. 
      - Think of interfaces like 'actions' or 'protocols' that can be implemented on other classes
  
   1. You can't instantiate an interface, but you can **reference** an interface
        - This is not allowed:
            ```csharp
            ICatAttack kitcat = new ICatAttack();
            ```
        - the *is* allowed:
          ```csharp 
            KittyCat kitty = new KittyCat();
            ICatAttack kitcat = kitty;
           ```
            - A new reference is created using the variable ICatAttack.
            - This reference can point to an instance of **any class that implements ICatAttack**



### Interface Properties

- An interface has the following properties:
  - An interface is like an abstract base class. Any class or struct that implements the interface must implement all its members.
  - An interface can't be instantiated directly. Its members are implemented by any class or struct that implements the interface.
  - Interfaces can contain events, indexers, methods, and properties.
  - Interfaces contain no implementation of methods.
  - A class or struct can implement multiple interfaces. A class can inherit a base class and also implement one or more interfaces.
   

## Demo
- Show what Interfaces look like in code

### Linked Lists
  1. What is a linked list?
     1. at it's simplist layer - a linked list is an array with pointers referencing the preceeding and proceeding node.  
     2. 'Singly' referes to one reference to it's next
     3. 'Doubly' refers to its last and next
     4. each item is referred to as a 'node'
     

# Assignments 

## Readings
- [Interfaces](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/)
- [Interfaces #2](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)
- [Linked List](https://www.wikiwand.com/en/Linked_list)
- [Linked List #2](https://www.cs.cmu.edu/~adamchik/15-121/lectures/Linked%20Lists/linked%20lists.html)
   
## Code Challenge 06
Implement a singly linked list
- Add First
- Add Last
- Add Before
- Add After
- Remove

-Using your "data-structures" repository
  - add a folder and label it `Linked Lists`
  - add the code on a branch from this challenge into this repo
  - Describe your approach in the strings folder readme document
  - Spend no more than 90 minutes on this challenge
  - Submit a link to your repo PR in canvas