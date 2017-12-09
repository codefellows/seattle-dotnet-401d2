![cf](http://i.imgur.com/7v5ASc8.png) Class 01: Intro to C#
=====================================

## Learning Objectives
* The student will successfully request user input and output a response to the console.
* The student will implement try-catch statements as a form of exception handling within their code.
* Set-up a debugger within Visual Studio 2017
* Understand and be comfortable with debugging through code to identify potential bugs and errors. 

# Lecture Outline

**Kickoff**
* Welcome to Code 401

**C# Basics**
* What is C#
* What is ASP.NET Core
* Introduction to Visual Studio 2017 Community
	

### Exception Handling
* Why do we need it?
 
     #### Try
	 ```csharp
		string number = "twenty";
		try
		{
			int twenty = Convert.ToInt32(number); //Error
		}
	```

#### Catch
	
```csharp
	catch(InvalidCastException e)
	{
		Console.WriteLine(e);
		//You can also handle the exception however you choose to here
	}
```

   - `throw` rethrows the exception or you can throw your own exception

```csharp
catch (InvalidCastException e)   
{  
 // Perform some action here, and then throw a new exception.  
 throw new YourCustomException("Put your error message here.", e);  
} 
```


```csharp
    catch (Exception e)
    {
        //Do something with e here
    }
```

```csharp
    catch (WebException ex)
    {
       //code specifically for a WebException
    }
 ```

#### Finally
  - Examples of the Finally statement
  - The finally statement executes regardless if the catch was hit or not
```csharp
    public static void Main()
    {
        int[] array1 = {0, 0};
        int[] array2 = {0, 0};

        try
        {
            Array.Copy(array1, array2, -1);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Error: {0}", e);
        }
        finally
        {
            Console.WriteLine("This statement is always executed.");
        }
    }
```
#### Callstack
- What is the Callstack?
- Exception Handling outside of methods

#### throw
- What is a throw?
- You can only throw an exception object or descendent from an exception.
- When you write a method that catches an exception, your method does not have to handle it. You can let the calling method handle the exception. 


## **Setting Up a Debugger:**
- Why do you need a debugger
- How do you set up a debugger?
- How do you use a debugger?
  - Step through
  - Step over
  - Step into

### Error Handling:
   - What do you do if you encounter an error (whiteboard // draw it)
   - 15 min rule
   - Take a deep breath, step away, break it down
   - documentation
   - look at the lecture
   - Online Research
   - ask a TA
   - Ask the instructor


### How to ask a question:

   - How do you ask a question?
		- What Have you done (summarize in 1-2 sentances)
		- What *specific* error are you encountering
		- Where have you looked to find a solution for the error?
			- Example: MS Documentaion, "Bing" the error?

# Resources

* [C# Guide](https://docs.microsoft.com/en-us/dotnet/csharp/index)

# Assignments


## Readings
- C# 7.0 in a Nutshell - pg. 158 - 166 (start @ “try Statements and Exceptions)
	- Try/Catch & Exceptions excerpt from assigned book (introduction)
- [Try/Catch Blocks](https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-use-the-try-catch-block-to-catch-exceptions)
- [Exception Handling](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/exception-handling-statements)

## Lab

Lab01 - About Me Quiz

## Coding Challenge

* FizzBuzz Game
