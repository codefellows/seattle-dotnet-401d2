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
* Student Introductions
* TA Introductions
* Instructor

**C# Basics**
* What is C#
* What is ASP.NET Core

* Microsoft Platform:
* Introduction to Visual Studio 2017 Community

## **Exception Handling**
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
	- Here is an example of a catch statement:
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

```
Main() calls MethodA() <br />
MethodA() calls MethodB() <br />
MethodB() calls MethodC() <br />
MethodC() throws an exception -> No catch in MethodC(); <br />
Looks in MethodB() -> No catch in B either <br />
Looks in MethodA() -> No catch found <br />
Looks in Main() -> No catch <br />
Program Terminates. 

## **Setting Up a Debugger:**
- Why do you need a debugger
- How do you set up a debugger?
- How do you use a debugger?
  - Step through
  - Step over
  - Step into


### Error Handling in Lab:
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


# Assignments

## Readings
- C# 7.0 in a Nutshell - pg. 158 - 166 (start @ �try Statements and Exceptions)
	- Try/Catch & Exceptions excerpt from assigned book (introduction)
- [Try/Catch Blocks](https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-use-the-try-catch-block-to-catch-exceptions)
- [Exception Handling](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/exception-handling-statements)

## Lab

About Me Quiz

## Coding Challenge

Write a method that takes one number as an argument. Iterate up to that number, with the output displayed as:

1. For multiples of three return “Fizz”
1. For multiples of five return “Buzz”.
1. For numbers which are multiples of both three and five return “FizzBuzz”
1. For all other cases return the number.