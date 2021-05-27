using System;
using System.Collections.Generic;
using System.Text;


namespace CommandPattern
{
    class RemoteControl //遥控器
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();  //使用接口时可以考虑设置什么也不做的实例，减少判断接口实例是否为null
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void setCommand(int slot, ICommand onCommand, ICommand offCommand) //插槽位置，开命令，关命令
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void undoButtonWasPushed()
        {
            undoCommand.Undo();//此处撤销当前回到上一步，如果想撤销所有动作，需要将所有动作插入  线程池  ，已后进先出的方式撤销
        }

        public string toString()
        {
            StringBuilder stringBuild = new StringBuilder();
            stringBuild.Append("\n----- Remote Control ------\n");
            for(int i = 0; i < onCommands.Length; i++)
            {
                stringBuild.Append("[slot " + i + "] " + onCommands[i].GetType().FullName
                     + "   " + offCommands[i].GetType().FullName + "\n");
            }
            return stringBuild.ToString();
        }
    }
}
