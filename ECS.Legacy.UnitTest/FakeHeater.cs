using System;


namespace ECS.Legacy.UnitTest
{
    class FakeHeater:IHeater
    {
        public FakeHeater()
        {
            Log = new Logger();
        }
       public bool SelfTest { get; set; }
       public Logger Log;
        public void TurnOn()
        {
            Log.Log = "Turned On\n";
        }

        public void TurnOff()
        {
            Log.Log = "Turned Off\n";
        }

        public bool RunSelfTest()
        {
            return SelfTest;
        }
    }
}
