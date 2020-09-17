using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ECS.Legacy;

namespace ECS.Legacy.UnitTest
{
    public class ECSLegacyUnitTest
    {
        ECS uut;

        [SetUp]
        public void SetUp()
        {
            FakeHeater _fakeHeater = new FakeHeater();
            FakeTempSensor _fakeTempSensor = new FakeTempSensor();
            int threshold = 28;
            uut = new ECS(threshold, _fakeTempSensor, _fakeHeater); 

            // Test of ECS

            [Test]
            

            // Test of TempSensor

            // Test of Heater
        }
    }
}
