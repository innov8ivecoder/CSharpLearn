using System;

public class ProgramDoWhile
{
    static void Main()
    {
        string input = null; // 1. Variable is used to collect input. At first, input is 'null'.
        int loopCounter = 1; // 2. This variable keeps the loop going
        do
        {
            input += Console.ReadLine(); // 3. Needed to actually collect input as the loop runs
            loopCounter++; // 4. Loop counter is made to grow by 1 with ++
        } while (loopCounter <= 3); // 5. loopCounter <= 3 is the logical condition that makes the loop stop

        Console.WriteLine(input); // 6. Prints output back to user as a single string
    }
}
