using System;
using System.Collections.Generic;
using System.Text;

namespace CalcPractice
{
    class Calc
    {
        private string state;
        // The class could also contain additional data that is not part of the
        // state saved in the memento.

        public void Set(string state)
        {
            Console.WriteLine("Originator: Setting state to " + state);
            this.state = state;
        }

        public Memento SaveToMemento()
        {
            Console.WriteLine("Originator: Saving to Memento.");
            return new Memento(state);
        }

        public void RestoreFromMemento(Memento memento)
        {
            state = memento.SavedState;
            Console.WriteLine("Originator: State after restoring from Memento: " + state);
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
        //public decimal runningTotal;



        public Calc()
        {
            //this.output = op;
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
            //Console.WriteLine($"Your result: {enteredNumber1} + {enteredNumber2} = " + (enteredNumber1 + enteredNumber2));

            output = enteredNumber1 + enteredNumber2;
            //  runningTotal = runningTotal + output;


            return output;

        }

        public decimal SubtractNumbers(decimal enteredNumber1, decimal enteredNumber2)
        {

            // Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));


            output = enteredNumber1 - enteredNumber2;
            // runningTotal = runningTotal + output;

            return output;

        }


        public decimal MultiplyNumbers(decimal enteredNumber1, decimal enteredNumber2)
        {
            //Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            output = enteredNumber1 * enteredNumber2;
            // runningTotal = runningTotal + output;
            return output;

        }
        public decimal DivideNumbers(decimal enteredNumber1, decimal enteredNumber2)
        {
            // Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            output = enteredNumber1 / enteredNumber2;
            // runningTotal = runningTotal + output;
            return output;

        }
        public void ExitCalculator()
        {
            Environment.Exit(0);

        }
    }
}
        /*
        private int result = 0;

        public int Add(int a)
        {
            this.result += a;
            return this.result;
        }

        public int Subtract(int a)
        {
            this.result -= a;
            return this.result;
        }

        public void Print()
        {
            Console.WriteLine("Result: " + this.result);
        }

        public CalculatorMemento CreateMemento()
        {
            CalculatorMemento calcMemento = new CalculatorMemento();
            calcMemento.SetState(this.result);
            return calcMemento;
        }

        public void SetMemento(CalculatorMemento memento)
        {
            this.result = memento.GetState();
        }
    }

    public class CalculatorMemento
    {
        private int state;

        public int GetState()
        {
            return this.state;
        }

        public void SetState(int state)
        {
            this.state = state;
        }
    }
}
*/
/*  public class Memento
  {
      public readonly decimal SavedState;

      public Memento(decimal stateToSave)
      {
          SavedState = stateToSave;
      }
      public decimal GetSavedState()
      {
          return SavedState;
      }
  }
  public Memento CreateMemento()
  {
      Memento memento = new Memento();
      memento.SetState(output);
      return memento;
  }
  public void SaveState(Memento memento)
  {
      output = memento.GetState();
  }
  */
/*

int result;
public Calculator(int i = 0)
{
    result = 0;
}
public void SetResult(int i = 0)
{
    this.result = 0;
}
public void Add(int x)
{
    result += x;
}
public void Subtract(int x)
{
    result -= x;
}
public int GetResult()
{
    return result;
}
public Memento CreateMemento()
{
    Memento memento = new Memento();
    memento.SetState(result);
    return memento;
}
public void SaveState(Memento memento)
{
    result = memento.GetState();
}
}



private decimal runningTotal;

private decimal state;
// The class could also contain additional data that is not part of the
// state saved in the memento.

public void Set(decimal state)
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
state = memento.GetSavedState();
Console.WriteLine("Calculator: State after restoring from Memento: " + state);
}
*/
/*
    private decimal output;
    public decimal runningTotal;



    public Calc()
    {
        //this.output = op;
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
        //Console.WriteLine($"Your result: {enteredNumber1} + {enteredNumber2} = " + (enteredNumber1 + enteredNumber2));

        output = enteredNumber1 + enteredNumber2;
        runningTotal = runningTotal + output;


        return output;

    }

    public decimal SubtractNumbers(decimal enteredNumber1, decimal enteredNumber2)
    {

        // Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));


        output = enteredNumber1 - enteredNumber2;
        runningTotal = runningTotal + output;

        return output;

    }


    public decimal MultiplyNumbers(decimal enteredNumber1, decimal enteredNumber2)
    {
        //Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        output = enteredNumber1 * enteredNumber2;
        runningTotal = runningTotal + output;
        return output;

    }
    public decimal DivideNumbers(decimal enteredNumber1, decimal enteredNumber2)
    {
        // Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        output = enteredNumber1 / enteredNumber2;
        runningTotal = runningTotal + output;
        return output;

    }
    public void ExitCalculator()
    {
        Environment.Exit(0);

    }


    /*
    public void UndoChanges()
    {
        //var _continue = true;
        //“UNDO IS NOT AVAILABLE” and request the user to enter a command or calculation request.   
        do
        {
            try
            {
                s.Pop();

                // _continue = false;
            }
            catch
            {
                Console.WriteLine("Undo is not available");
                Console.WriteLine("You must enter a command or calculation request");

            }
        } while (s.Count > 0);


    }
    public void ClearNumbers()
    {


    }
    public void ExitCalculator()
    {
        Environment.Exit(0);

    }

}
}

    */
/*

        s.Push("Bob");  // add Bob to the stack 



            s.Push("Amy");  // add Amy to the stack 



            String name = s.Peek();  // look at the top element in the stack

        name = s.Pop();  // remove the top element in the stack 



            name = s.Pop();  //remove the top element in the stack 
            */








