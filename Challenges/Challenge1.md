## Debug Challenge 1

There are multiple things "wrong" with this method below. Identify as many as you can.
- *Do Not* use an IDE to solve this. (Hint - in an interview, you will not have an IDE to cheat from);
- Comment the whole code block with both an understanding of what is happening along with specific 
adjustments you would make to the code

## Directions
1. Create a new C# gist (NameOfChallenge.cs).
2. copy the code from the Challenge into the gist
3. Within your comments in the code snippet identify the errors


```csharp
        public string MyThing(int favoriteNumber)
        {
            int count = 0;
            string firstcat = "JosieCat";
            string myOtherCat = "BelleKitty";

            char[] myCats = new char[];

            myCats[1] = "JosieCat";
            myCats[5] = "BelleKitty";

            return count;
        }
```