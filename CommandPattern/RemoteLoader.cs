using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CommandPattern
{
    public class Light
    {
        readonly string lightName;

        public Light(string lightName)
        {
            this.lightName = lightName;
        }

        public void On()
        {
            WriteLine($"{lightName} light is on!");
        }

        public void Off()
        {
            WriteLine($"{lightName} light is off!");
        }
    }

    public class Stereo
    {
        readonly string stereoName;

        public Stereo(string stereoName)
        {
            this.stereoName = stereoName;
        }

        public void On()
        {
            WriteLine($"{stereoName} stereo is on!");
        }

        public void Off()
        {
            WriteLine($"{stereoName} stereo is off!");
        }

        public void SetCD()
        {
            WriteLine($"{stereoName} stereo is set for CD input!");
        }

        public void OutCD()
        {
            WriteLine($"{stereoName} stereo is set for CD Output!");
        }

        public void SetVolume(int volume)
        {
            WriteLine($"{stereoName} stereo volume set to {volume.ToString()}!");
        }

        public void MuteVolume()
        {
            WriteLine($"{stereoName} stereo volume set to Mute!");
        }
    }

    public class GarageDoor
    {
        readonly string garagedoorName;

        public GarageDoor(string garagedoorName)
        {
            this.garagedoorName = garagedoorName;
        }

        public void Up()
        {
            WriteLine($"{garagedoorName} garagedoor is up!");
        }

        public void Down()
        {
            WriteLine($"{garagedoorName} garagedoor is down!");
        }
    }

    public class CeilingFan
    {
        readonly string ceilingfanName;

        public CeilingFan(string ceilingfanName)
        {
            this.ceilingfanName = ceilingfanName;
        }

        public void On()
        {
            WriteLine($"{ceilingfanName} ceiling fan is on!");
        }

        public void Off()
        {
            WriteLine($"{ceilingfanName} ceiling fan is off!");
        }
    }
}
