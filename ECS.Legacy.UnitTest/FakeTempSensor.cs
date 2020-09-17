namespace ECS.Legacy.UnitTest
{
    class FakeTempSensor:ITempSensor
    {
        public int Temp { get; set; }
        public bool SelfTest { get; set; }

        public int GetTemp()
        {
            return Temp;
        }

        public bool RunSelfTest()
        {
            return SelfTest;
        }
    }
}
