using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace CalcPractice
{
    class Caretaker
    {
       // decimal enteredNumber1;
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
        private static bool UndoAgainPrompt()
        {


            Console.WriteLine("Undo Another Calculation? \n \n Type: 'Y' for yes or 'N' for no");
            string answerToEnterAgain = (Console.ReadLine());
            if (answerToEnterAgain.ToLower() != "y")
            {
                return false;
            }
            return true;
        }
      /*  private static void PromptForFirstNumber()
        {
            bool isLegitNumber = true;
            Console.WriteLine("Please enter a number");

            while (isLegitNumber)
            {

                try
                {
                    decimal enteredNumber1 = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
           
        }
            private static void PromptForOperation()
            {
                Console.WriteLine("Please type the corresponding symbol of which operation you want to perform on the number: ");

                Console.WriteLine("\t+ - Add");
                Console.WriteLine("\t- - Subtract");
                Console.WriteLine("\t* - Multiply");
                Console.WriteLine("\t/ - Divide");
                // Console.WriteLine("\te - Equals");

                string enteredOperation = Console.ReadLine();
            }
        private static void PromptForSecondNumber()
        {
            Console.WriteLine("Please enter a second number for the operation");
            decimal enteredNumber2 = decimal.Parse(Console.ReadLine());

        
        }
        */
        static void Main(string[] args)
        {
            bool _continue = true;

            StringBuilder runtotal = new StringBuilder();


            decimal rtSum = 0;

            Stack<Calc.Memento> savedStates = new Stack<Calc.Memento>();


            Calc calculator = new Calc();


            while (_continue)
            {

                /* List<Originator.Memento> savedStates = new List<Originator.Memento>();

                 Originator originator = new Originator();
                 originator.Set("State1");
                 originator.Set("State2");
                 savedStates.Add(originator.SaveToMemento());
                 originator.Set("State3");
                 // We can request multiple mementos, and choose which one to roll back to.
                 savedStates.Add(originator.SaveToMemento());
                 originator.Set("State4");

                 originator.RestoreFromMemento(savedStates[1]);

         */



                //savedStates.Push(calculator.SaveToMemento());
                //calculator.Set(3);
                // We can request multiple mementos, and choose which one to roll back to.
                //savedStates.Push(calculator.SaveToMemento());
                //calculator.Set(4);

                //calculator.RestoreFromMemento(savedStates.Peek());



                // PromptForFirstNumber();

                //  PromptForOperation();

                //  PromptForSecondNumber();



                // string enteredNumb = Console.ReadLine();

                //  decimal enteredNumber1;


                /* if (!Regex.IsMatch(enteredNumber1,"^[0-9]\\\\d{0,9}(\\\\.\\\\d{1,3})?%?$"))
                 {
                     Console.WriteLine("Numbers only");
                 }
                 */

                /*    if (!decimal.TryParse(enteredNumb, out enteredNumber1))
                    {
                        Console.WriteLine("Numbers only");

                    }
                    */






                //else
                // Console.WriteLine("Unable to convert '{0}'.", enteredNumber1);


                //try
                // {


                // }
                //catch (FormatException formatException)
                // {
                //  Console.WriteLine($"\n {formatException.Message}");
                // Console.WriteLine("You must enter a number");
                // }




                // Use a switch statement to do the math.

                // bool isLegitNumber = true;
                //  Console.WriteLine("Please enter a number");

                //  while (isLegitNumber)
                //  {

                //   try
                //    {
                decimal enteredNumber1;
                Console.WriteLine("Please enter a number");
                string enteredNumb = Console.ReadLine();

                if (!decimal.TryParse(enteredNumb, out enteredNumber1))
                {
                    Console.WriteLine("Please restart the program and enter a legitimate first number for the operation");

                    break;
                   // Console.WriteLine("Please enter a legitimate number");
                  //  Console.WriteLine("Please enter a number");
                  //  enteredNumb = Console.ReadLine();

                }
                //  break;
                // }
                //  catch
                //  {
                //      Console.WriteLine("Please enter a valid number");
                //  }
                //  }

                Console.WriteLine("Please type the corresponding symbol of which operation you want to perform on the number: ");

                Console.WriteLine("\t+ - Add");
                Console.WriteLine("\t- - Subtract");
                Console.WriteLine("\t* - Multiply");
                Console.WriteLine("\t/ - Divide");
                // Console.WriteLine("\te - Equals");

                string enteredOperation = Console.ReadLine();

                // if (!Regex.IsMatch(enteredOperation, "^[a-zA-Z]*$"))

                if (!Regex.IsMatch(enteredOperation, "^(?=.*\\+).{1}$ || ^(?=.*\\-).{1}$ || ^(?=.*\\*).{1}$ || ^(?=.*\\/).{1}$")) 
                {
                    Console.WriteLine("Please restart the program and enter one of the symbols + - * / for the operation you want to complete");
                    break;
                }
              /*  else if (!Regex.IsMatch(enteredOperation, "^(?=.*\\-).{1}$"))
                {
                    Console.WriteLine("Please restart the program and enter one of the symbols + - * / for the operation you want to complete");
                    break;
                }
                else if(!Regex.IsMatch(enteredOperation, "^(?=.*\\*).{1}$"))
                {
                    Console.WriteLine("Please restart the program and enter one of the symbols + - * / for the operation you want to complete");
                    break;
                }
                else if (!Regex.IsMatch(enteredOperation, "^(?=.*\\/).{1}$"))
                {
                    Console.WriteLine("Please restart the program and enter one of the symbols + - * / for the operation you want to complete");
                    break;
                }
                */




                decimal enteredNumber2;
                Console.WriteLine("Please enter a second number for the operation");
                string enteredNumb2 = Console.ReadLine();

                if (!decimal.TryParse(enteredNumb2, out enteredNumber2))
                {
                    Console.WriteLine("Please restart the program and enter a legitimate number for the second operation");

                    break;
                   // Console.WriteLine("Please enter a second number for the operation");
                   // enteredNumb2 = Console.ReadLine();

                }

                decimal localOutput = 0;
                if (enteredOperation == "+")
                {
                    localOutput = calculator.AddNumbers(enteredNumber1, enteredNumber2);
                }
                else if (enteredOperation == "-")
                {

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



                //savedStates = savedStates + calculator.GetOutput();
                rtSum = rtSum + calculator.GetOutput();
                calculator.SetOutput(localOutput);
                Console.WriteLine();
                Console.WriteLine($"  Calculations: {enteredNumber1} {enteredOperation} {enteredNumber2} = {calculator.GetOutput()}");
                calculator.Set($"{calculator.GetOutput()}");
                savedStates.Push(calculator.SaveToMemento());
                Console.WriteLine();
                // Console.WriteLine($"Running Total : {calculator.runningTotal}");
                Console.WriteLine();
                //runtotal.Append(calculator.GetOutput().ToString());
                runtotal.Append("+" + calculator.GetOutput().ToString());
                // Console.WriteLine($"Running Total: {runtotal} + "+"");
                Console.WriteLine($"Running Total: {rtSum}");
                Console.WriteLine();
                /*
                Stack<MyClass> stacky = new Stack<MyClass>();

                foreach (MyClass item in stacky)
                {
                    // this is as fast as you're going to get.
                }
                */
                /* foreach (Calc.Memento calcSum in savedStates)
                 {

                 } */
                // calculator.Set($"{calculator.GetOutput()}");
                // savedStates.Push(calculator.SaveToMemento());
               

                    Console.WriteLine("Please type the corresponding symbol of which function you would like to perform next: ");

                Console.WriteLine("\tc - Continue with program");
                Console.WriteLine("\tu - Undo");
                //Console.WriteLine("\tc - Clear");
                Console.WriteLine("\tex - Exit");
               
                // Console.WriteLine("\te - Equals");

                string enteredSecondFunction = Console.ReadLine();

               // bool _continueUndo = true;

                //while (_continueUndo)
                {
                    // decimal localOutput = 0;
                    if (enteredSecondFunction == "c")
                    {
                        _continue = EnterAgainPrompt();
                        Console.WriteLine();

                    }
                    else if (enteredSecondFunction == "u")
                    {
                        //bool _continueUndo = true;

                        //  while (_continueUndo)
                        //  {

                        calculator.RestoreFromMemento(savedStates.Peek());
                        //_continueUndo = UndoAgainPrompt();
                        UndoAgainPrompt();
                        Console.WriteLine();

                        //  }
                        // _continue = EnterAgainPrompt();
                        // Console.WriteLine();

                    }
                    /*  else if (enteredSecondFunction == "c")
                      {
                          calculator.ClearCalculations(savedStates.Peek());

                      }
                      */
                    else if (enteredSecondFunction == "ex")
                    {

                        calculator.ExitCalculator();
                    }

                }
                }
                // calculator.ClearStack(savedStates.Clear());
                // _continue = EnterAgainPrompt();
                // Console.WriteLine();


            }
        }
   

    }

        /*
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            calc.Add(4);        // result 4
            calc.Add(3);        // result 7
            calc.Subtract(1);   // result 6

            CalculatorMemento checkPoint1 = calc.CreateMemento();
            calc.Add(1);        // result 7
            calc.Print();       // print 7

            calc.SetMemento(checkPoint1);
            calc.Print();       // result 6
        }
    }
}
*/
/* private static bool EnterAgainPrompt()
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
     */

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

/*
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
*/

