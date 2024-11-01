using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            // Instantieer de apparaatklassen
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan livingroomCeilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor(new Light("Garage Door"));
            Stereo stereo = new Stereo();

            // Instantieer commando-objecten voor elk apparaat
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(livingroomCeilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(livingroomCeilingFan);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            // Stel commando's in op de slots van de afstandsbediening
            remoteControl.SetCommand(1, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(2, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(3, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(4, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(5, stereoOnWithCd, stereoOff);

            // Test de knoppen op de afstandsbediening
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);

            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);

            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);

            remoteControl.OnButtonWasPushed(4); 
            remoteControl.OffButtonWasPushed(4);

            remoteControl.OnButtonWasPushed(5);
            remoteControl.OffButtonWasPushed(5);

            // Test de Undo-knop als deze is geïmplementeerd
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);

            Console.WriteLine(remoteControl);
        }
    }
}
