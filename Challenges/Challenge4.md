# Challenge 4

 *Without using Visual Studio* - Writeout the output of this method.

## Directions
1. Create a new C# gist (NameOfChallenge.cs).
2. copy the code from the Challenge into the gist
3. Complete the challenge
4. Comment your code.....
5. Under the code snippet provide the output

```csharp

       static void Main(string[] args)
       {
       int[] myArray = new int{4,-8,15,-16, 23, 100, 42, 5,0,-5}
        DebugChallenge(muyArray);
        
       }

        static void DebugChallenge(int[] myArray)
        {
            int temp = 0;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i; j < myArray.Length - 1; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                        temp = 0;
                    }
                }
                Console.WriteLine(myArray[i]);
            }
        } 
```
