using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;
using System;
using System.Text;

namespace CommandPattern.Classes
{
    internal class RemoteControl
    {
        Command[] onCommands = new Command[7];
        Command[] offCommands = new Command[7];
        Command undoCommand;

        public RemoteControl()
        {
            Command noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            if (slot < 0 || slot >= onCommands.Length) return;
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            if (slot < 0 || slot >= onCommands.Length) return;
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            if (slot < 0 || slot >= offCommands.Length) return;
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----- Remote Control ----- \n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append("[slot " + i + "] " + onCommands[i].GetType().Name + " \t" + offCommands[i].GetType().Name + "\n");
            }
            return sb.ToString();
        }
    }
}
