using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace State_Pattern
{
    public class GumballMachine
    {
        readonly IState soldOutState;
        readonly IState noQuarterState;
        readonly IState hasQuarterState;
        readonly IState soldState;
        readonly IState winnerState;

        IState state;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            state = soldOutState;
            noQuarterState = new NoQuarterState(this);
            soldOutState = new SoldOutState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);

            this.count = numberGumballs;
            if (numberGumballs > 0)
            {
                state = noQuarterState;
            }
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public void Refill(int count)
        {
            this.count = count;
            state = noQuarterState;
        }

        internal void SetState(IState state)
        {
            this.state = state;
        }

        internal void ReleaseBall()
        {
            WriteLine("A gumball comes rolling out the slot...");
            if (count != 0)
            {
                count--;
            }
        }

        internal IState GetNoQuarterState()
        {
            return noQuarterState;
        }

        internal IState GetSoldOutState()
        {
            return soldOutState;
        }

        internal IState GetHasQuarterState()
        {
            return hasQuarterState;
        }

        internal IState GetSoldState()
        {
            return soldState;
        }

        internal IState GetWinnerState()
        {
            return winnerState;
        }

        internal int GetCount()
        {
            return count;
        }

    }
}

