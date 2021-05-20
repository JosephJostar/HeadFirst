using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Strategy
{
    public class duckcall: Call
    {
        public duckcall()
        {
            vc = new Noize();
        }
    }

    public abstract class Call
    {
       public IVoice vc;

        public void SetVoice(IVoice ivc)
        {
            vc = ivc;
        }
    }

    public interface IVoice
    {
        public void voice();
    }

    public class Noize: IVoice
    {
        public void voice()
        {
            WriteLine("Make some noize");
        }
    }
}
