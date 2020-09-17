using System;


namespace ECS.Legacy.UnitTest
{
    class FakeHeater:IHeater
    {
       public bool SelfTest { get; set; }
        
        public void TurnOn()
        {
            
        }

        public void TurnOff()
        {
            
        }

        public bool RunSelfTest()
        {
            return SelfTest;
        }
    }
}
