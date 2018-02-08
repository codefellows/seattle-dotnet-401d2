# Challenge 2 : Converting Time

Without using an IDE, complete this codebase.  <br />

## Directions
1. Create a new C# gist (NameOfChallenge.cs).
2. copy the code from the Challenge into the gist
3. Complete the challenge
4. Comment your code.....
<br />
A few things to note:
1. You should conitnue to work with the DateTime object being brough into TimeConversion method.
2. Notice the output in the main Method...What does .ToShortDateString() mean? 



```chsarp
 /// <summary>
        /// Main Method. Main entry point to a program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Using PST as the baseline time zone. 
            // create  a program that will help a traveler convert the time from one timezone to another.

            DateTime newTime = TimeConversion(DateTime.Now, "PST", "CST");

            Console.WriteLine(newTime.ToShortDateString());

        }

        /// <summary>
        /// Converts the time to the new Timezone time
        /// </summary>
        /// <param name="TZ1">The Timezome they are currently in</param>
        /// <param name="TZ2">The Timezone they are visiting</param>
        /// <returns>the converted time in a string format</returns>
        public static DateTime TimeConversion(DateTime time, string tz1, string tz2)
        {
            //EST - 3 from PST
            //CST - 2 from PST
            //MTN - 1 from PST
            //PST- 0 from PST

            return time;
        }

```