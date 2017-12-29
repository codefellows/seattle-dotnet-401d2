![cf](http://i.imgur.com/7v5ASc8.png) Lab 7 : Collections
=====================================

## Learning Objectives
1.The student will understand and implement their own enums into their programs and classes.
1. The student will be able to identify and implement their own generic collection.
 
## Lecture Outline

### Enums

1. What are enums?
   1. Enumeration types ("also called enums"), provide an efficient way to define a set of named integral constants that may be assigned to a variable. 

        ```csharp
            enum Days 
            { 
                Sunday,
                Monday, 
                Tuesday, 
                Wednesday, 
                Thursday, 
                Friday, 
                Saturday 
            };

            Days today = Days.Monday;  
            int dayNumber =(int)today;  
            Console.WriteLine("{0} is day number #{1}.", today, dayNumber);  

            Months thisMonth = Months.Dec;  
            byte monthNumber = (byte)thisMonth;  
            Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);  

            // Output:  
            // Monday is day number #1.  
            // Dec is month number #11.  

            ```

### Collections

1. There are two ways to create and manage a group of related objects
    1. Create an array of objects
    2. creating a collection of objects

2. If your collection contains elements of only one data type, you can use a Generic. 

#### Generics
   1. One type of generic collection is a List\<T>; 
   2. Example of a List:

        ```csharp 
        var princesses = new List<string>();

        princesses.Add("Snow White");
        princesses.Add("Cinderella");
        princesses.Add("Aurora");
        princesses.Add("Repunzel");
        princesses.Add("Ariel");

        foreach(var princess in princesses)
        {
            Console.WriteLine($"Princess: {princess}");
        }


        ```

        -using a `foreach` loop to iterate through a list once items have been added

        ```csharp
        var princes = new List<string>{"Eric", "Charming", "Aladdin"};

        foreach(var p in prince)
        {
           Console.WriteLine($"Prince: {p}");
        }


        ```
        - This one uses a *collection initializer*



        ```csharp
        var princess = new List<strings> {"Jasmine","Moana","Merida", "Anna", "Elsa"}

        for (var index = 0; index < princess.Count; index++)  
        {  
            Console.Write(princess[index] + " ");  
        } 
        ```


        - Using the 'Remove` list function

        ```csharp
        var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };  

        // Remove odd numbers.  
        for (var index = numbers.Count - 1; index >= 0; index--)  
        {  
            if (numbers[index] % 2 == 1)  
            {  
                // Remove the element by specifying  
                // the zero-based index in the list.  
                numbers.RemoveAt(index);  
            }  
        }  

        // Iterate through the list.  
        // A lambda expression is placed in the ForEach method  
        // of the List(T) object.  
        numbers.ForEach(  
            number => Console.Write(number + " "));  
        // Output: 0 2 4 6 8  
        ```
        -Use a `for` loop by decramenting 
        - Why would you decrament?

#### Demo 
  - Let's create own own Generic Collection (List\<T>):*

  - What is `GetEnumerator()`?
      - You need your class iterate through with a for loop. 

- *Enumerable* - means it can be iterated through
- *Enumerator* - that actual 'thing' that walkthroughs and sequences through the list

- What is IEnumerable?

**Yield Return**

-You use a `yield return` statement to return each element one at a time.
- 'pauses' and returns the next value

**Yield Break**

You use a `yield break` statement to end an iteration
    -Clean way to end a loop from executing


### Generics vs. Non-Generics

#### Generics
- List< T>
- Dictionary< T>
- SortedList< T>
- Queue< T>
- IEnumerable< T>
- IList< T>
- Collection< T>
- LinkedList< T>

#### Non-Generics
*are not really used much anymore*

- ArrayList
- Hastable
- SortedList
- Queue
- Stack
- IEnumerable
- ICollection

# Assignments

## Readings
1. C# .0 In a Nutshell - Ch. 7 Collections(pg. 301-313, pg 324-327,)
	- If you have time to read the whole chapter -- I recommend it. 
1. C# 7.0 in a Nutshell: Pg 118-124
1. [Collections](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections)
1. [Enums](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum)

     
## Coding Challenge
Find the middle of a linked list
- Find Middle of Linked List

-Using your "data-structures" repository
  - add a folder and label it `Linked Lists`
  - add the code on a branch from this challenge into this repo
  - Describe your approach in the strings folder readme document
  - Spend no more than 90 minutes on this challenge
  - Submit a link to your repo PR in canvas

## Weekend Assignment
### Read
- [Big O](http://computationaltales.blogspot.com/2011/04/understanding-big-o-notation-and.html)
- [Beginners Guide to Big O](https://rob-bell.net/2009/06/a-beginners-guide-to-big-o-notation/)
- [Podcast - Season1,Episode6 : Friendly Intro to Big O Notatation](https://www.codenewbie.org/basecs)

### Code
- Complete a total of 4 Code War problems. 2 of the problems should be a 6kyu. 2 of the problems should be 5kyu. problems should be completed in C#.