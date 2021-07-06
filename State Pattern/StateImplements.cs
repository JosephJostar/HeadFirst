using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace State_Pattern
{
    public class NoQuarterState : IState
    {
        readonly GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            WriteLine("You need to pay first!");
        }

        public void EjectQuarter()
        {
            WriteLine("You haven't inserted a quarter");
        }

        public void InsertQuarter()
        {
            WriteLine("You inserted a quarter");
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
        }

        public void TurnCrank()
        {
            WriteLine("You turned, but there's no quarter");
        }
    }


    public class HasQuarterState : IState
    {
        private static readonly long timeStamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        //static int timeStamp = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds);
        readonly Random randomWinner = new Random(Convert.ToInt32(timeStamp));
        readonly GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            WriteLine("Quarter returned");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            WriteLine("You can't insert another quarter");
        }

        public void TurnCrank()
        {
            WriteLine("You turned...");

            int winner = randomWinner.Next(10);
            if ((winner == 0) && (gumballMachine.GetCount() > 1))
            {
                gumballMachine.SetState(gumballMachine.GetWinnerState());
            }
            else
            {
                gumballMachine.SetState(gumballMachine.GetSoldState());
            }
        }
    }



    public class SoldState : IState
    {
        readonly GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            gumballMachine.ReleaseBall();
            if (gumballMachine.GetCount() > 0)
            {
                gumballMachine.SetState(gumballMachine.GetNoQuarterState());
            }
            else
            {
                WriteLine("Oops, out of gumballs!");
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
        }

        public void EjectQuarter()
        {
            WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            WriteLine("Please wait, we're already giving you a gumball");
        }

        public void TurnCrank()
        {
            WriteLine("Truning twice doesn't get you another gumball!");
        }
    }



    public class SoldOutState : IState
    {
        readonly GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            WriteLine("gumball was sold out!");
        }

        public void EjectQuarter()
        {
            WriteLine("gumball was sold out!");
        }

        public void InsertQuarter()
        {
            WriteLine("gumball was sold out!");
        }

        public void TurnCrank()
        {
            WriteLine("gumball was sold out!");
        }
    }


    public class WinnerState : IState
    {
        readonly GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            WriteLine("YOU'RE A WINNER! You get two gumballs for your quarter");
            gumballMachine.ReleaseBall();
            if (gumballMachine.GetCount() == 0)
            {
                WriteLine("Oops, out fo gumballs!");
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
            else
            {
                gumballMachine.ReleaseBall();
                if (gumballMachine.GetCount() > 0)
                {
                    gumballMachine.SetState(gumballMachine.GetNoQuarterState());
                }
                else
                {
                    WriteLine("Oops, out fo gumballs!");
                    gumballMachine.SetState(gumballMachine.GetSoldOutState());
                }
            }
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void InsertQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }

}
