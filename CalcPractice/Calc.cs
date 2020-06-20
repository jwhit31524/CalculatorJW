using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CalcPractice
{
    class Calc
    {
        private string state;

        public void Set(string state)
        {
            Console.WriteLine("Calculator: Setting state to " + state);
            this.state = state;
        }

        public Memento SaveToMemento()
        {
            Console.WriteLine("Calculator: Saving to Memento.");
            return new Memento(state);
        }

        public void RestoreFromMemento(Memento memento)
        {
            state = memento.SavedState;
            Console.WriteLine("Calculator: State after restoring from Memento: " + state);
        }
    

        public class Memento
        {
            public readonly string SavedState;

            public Memento(string stateToSave)
            {
                SavedState = stateToSave;
            }

        }
        private decimal output;
       


        public Calc()
        {
           
        }
        public void SetOutput(decimal op)
        {
            this.output = op;
        }
        public decimal GetOutput()
        {
            return output;
        }
        public decimal AddNumbers(decimal enteredNumber1, decimal enteredNumber2)
        {
            

            output = enteredNumber1 + enteredNumber2;
           


            return output;

        }

        public decimal SubtractNumbers(decimal enteredNumber1, decimal enteredNumber2)
        {

           


            output = enteredNumber1 - enteredNumber2;
           

            return output;

        }


        public decimal MultiplyNumbers(decimal enteredNumber1, decimal enteredNumber2)
        {
           
            output = enteredNumber1 * enteredNumber2;
          
            return output;

        }
        public decimal DivideNumbers(decimal enteredNumber1, decimal enteredNumber2)
        {
          
            output = enteredNumber1 / enteredNumber2;
            
            return output;

        }
        public void ExitCalculator()
        {
            Environment.Exit(0);

        }

       
    }
}
       








