using System;

namespace CalcPractice
{
    class Caretaker
    {
        private static bool EnterAgainPrompt()
        {
            Console.WriteLine("Enter Another Calculation? \n \n Type: 'Y' for yes or 'N' for no");
            string answerToEnterAgain = (Console.ReadLine());
            if (answerToEnterAgain.ToLower() != "y")
            {
                return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {
            bool _continue = true;


            while (_continue)
            {
               
           /* Stack<Calculator.Memento> savedStates = new Stack<Calculator.Memento>();


            Calculator calculator = new Calculator();
            calculator.Set(1);
            calculator.Set(2);
            //savedStates.Push(calculator.SaveToMemento());
            //calculator.Set(3);
            // We can request multiple mementos, and choose which one to roll back to.
            savedStates.Push(calculator.SaveToMemento());
            calculator.Set(4);

            calculator.RestoreFromMemento(savedStates.Peek());
            */


/*
Calculator calculator = new Calculator();
calculator.Push(5);
calculator.Add(10);
calculator.Subtract(10);
Memento checkPoint = calculator.CreateMemento();
calculator.Add(100);
Console.WriteLine(“The value of the result variable is: “+calculator.GetResult());
calculator.SaveState(checkPoint);
Console.WriteLine(“The value of the result variable at first checkpoint is: “ +calculator.GetResult());
Console.Read();
*/

Calc calculator = new Calc();



Console.WriteLine("Please enter a number");
decimal enteredNumber1 = decimal.Parse(Console.ReadLine());


Console.WriteLine("Please type the corresponding symbol of which operation you want to perform on the number: ");

Console.WriteLine("\t+ - Add");
Console.WriteLine("\t- - Subtract");
Console.WriteLine("\t* - Multiply");
Console.WriteLine("\t/ - Divide");
// Console.WriteLine("\te - Equals");

string enteredOperation = Console.ReadLine();

Console.WriteLine("Please enter a second number for the operation");
decimal enteredNumber2 = decimal.Parse(Console.ReadLine());


// Use a switch statement to do the math.
decimal localOutput = 0;
if (enteredOperation == "+")
{
    localOutput = calculator.AddNumbers(enteredNumber1, enteredNumber2);
}
else if (enteredOperation == "-") {

    localOutput = calculator.SubtractNumbers(enteredNumber1, enteredNumber2);
}
else if (enteredOperation == "*")
{

    localOutput = calculator.MultiplyNumbers(enteredNumber1, enteredNumber2);
}
else if (enteredOperation == "/")
{

    localOutput = calculator.DivideNumbers(enteredNumber1, enteredNumber2);
}
calculator.SetOutput(localOutput);
Console.WriteLine();
Console.WriteLine($"  Calculations: {enteredNumber1} {enteredOperation} {enteredNumber2} = {calculator.GetOutput()}");
Console.WriteLine();
Console.WriteLine($"Running Total : {calculator.runningTotal}");
Console.WriteLine();
_continue = EnterAgainPrompt();
Console.WriteLine();
}
}
}
}
