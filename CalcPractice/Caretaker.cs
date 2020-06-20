using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

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
 
        static void Main(string[] args)
        {
            bool _continue = true;

            StringBuilder runtotal = new StringBuilder();


            decimal rtSum = 0;

            Stack<Calc.Memento> savedStates = new Stack<Calc.Memento>();


            Calc calculator = new Calc();


            while (_continue)
            {


                decimal enteredNumber1;
                Console.WriteLine("Please enter a number");
                string enteredNumb = Console.ReadLine();

                if (!decimal.TryParse(enteredNumb, out enteredNumber1))
                {
                    Console.WriteLine("Please restart the program and enter a legitimate first number for the operation");

                    break;
              

                }
          

                Console.WriteLine("Please type the corresponding symbol of which operation you want to perform on the number: ");

                Console.WriteLine("\t+ - Add");
                Console.WriteLine("\t- - Subtract");
                Console.WriteLine("\t* - Multiply");
                Console.WriteLine("\t/ - Divide");
              

                string enteredOperation = Console.ReadLine();

               

                if (!Regex.IsMatch(enteredOperation, "^[-+/*]$"))

                {
                    Console.WriteLine("Please restart the program and enter one of the symbols + - * / for the operation you want to complete");
                    break;
                }
               
           


                decimal enteredNumber2;
                Console.WriteLine("Please enter a second number for the operation");
                string enteredNumb2 = Console.ReadLine();

                if (!decimal.TryParse(enteredNumb2, out enteredNumber2))
                {
                    Console.WriteLine("Please restart the program and enter a legitimate number for the second operation");

                    break;
              
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



                rtSum = rtSum + calculator.GetOutput();
                calculator.SetOutput(localOutput);
                Console.WriteLine();
                Console.WriteLine($"  Calculations: {enteredNumber1} {enteredOperation} {enteredNumber2} = {calculator.GetOutput()}");
                calculator.Set($"{calculator.GetOutput()}");
                savedStates.Push(calculator.SaveToMemento());
                Console.WriteLine();
              
                Console.WriteLine();
                
                runtotal.Append("+" + calculator.GetOutput().ToString());
               
                Console.WriteLine($"Running Total: {rtSum}");
                Console.WriteLine();
            
               

                    Console.WriteLine("Please type the corresponding symbol of which function you would like to perform next: ");

                Console.WriteLine("\tc - Continue with program");
                Console.WriteLine("\tu - Undo");
                Console.WriteLine("\tr - Clear");
                Console.WriteLine("\tx - Exit");
               
               
                string enteredSecondFunction = Console.ReadLine();


                if (!Regex.IsMatch(enteredSecondFunction, "^[curx]*$"))
                {
                    Console.WriteLine("Please restart the program and enter one of the letters c u or e for the operation you want to complete");
                    break;
                }


              
                {
               
                    if (enteredSecondFunction == "c")
                    {
                        _continue = EnterAgainPrompt();
                        Console.WriteLine();

                    }
                    else if (enteredSecondFunction == "u")
                    {
                      

                        calculator.RestoreFromMemento(savedStates.Peek());
                      
                        UndoAgainPrompt();
                        Console.WriteLine();

                   

                    }
                   
                    else if (enteredSecondFunction == "r")
                    {

                        rtSum = 0;
                        Console.WriteLine($"Running Total after Clear: {rtSum}");
                    }
                    else if (enteredSecondFunction == "x")
                    {

                        calculator.ExitCalculator();
                    }

                }
                }
               

            }
        }
   

    }

