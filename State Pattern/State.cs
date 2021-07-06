using System;
using System.Collections.Generic;
using System.Text;

namespace State_Pattern
{
    interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}
