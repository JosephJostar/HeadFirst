using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }

    public class NoCommand : ICommand
    {
        public void Execute()
        {

        }

        public void Undo()
        {
            
        }
    }

    public class LightOnCommand : ICommand
    {
        readonly Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }

    public class LightOffCommand : ICommand
    {
        readonly Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }
    }

    public class SterorOnWithCDCommand: ICommand
    {
        readonly Stereo stereo;

        public SterorOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.MuteVolume();
            stereo.OutCD();
            stereo.Off();
        }
    }

    public class SterorOffCommand: ICommand
    {
        readonly Stereo stereo;

        public SterorOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
        }
    }

    public class GarageDoorUpCommand : ICommand
    {
        readonly GarageDoor garagedoor;

        public GarageDoorUpCommand(GarageDoor garagedoor)
        {
            this.garagedoor = garagedoor;
        }

        public void Execute()
        {
            garagedoor.Up();
        }

        public void Undo()
        {
            garagedoor.Down();
        }
    }

    public class GarageDoorDownCommand : ICommand
    {
        readonly GarageDoor garagedoor;

        public GarageDoorDownCommand(GarageDoor garagedoor)
        {
            this.garagedoor = garagedoor;
        }

        public void Execute()
        {
            garagedoor.Down();
        }

        public void Undo()
        {
            garagedoor.Up();
        }
    }


    public class CeilingFanOnCommand : ICommand
    {
        readonly CeilingFan ceilingfan;

        public CeilingFanOnCommand(CeilingFan ceilingfan)
        {
            this.ceilingfan = ceilingfan;
        }

        public void Execute()
        {
            ceilingfan.On();
        }

        public void Undo()
        {
            ceilingfan.Off();
        }
    }

    public class CeilingFanOffCommand : ICommand
    {
        readonly CeilingFan ceilingfan;

        public CeilingFanOffCommand(CeilingFan ceilingfan)
        {
            this.ceilingfan = ceilingfan;
        }

        public void Execute()
        {
            ceilingfan.Off();
        }

        public void Undo()
        {
            ceilingfan.On();
        }
    }
}
