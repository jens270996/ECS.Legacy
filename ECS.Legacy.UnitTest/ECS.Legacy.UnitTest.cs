using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ECS.Legacy;

namespace ECS.Legacy.UnitTest
{
    public class ECSLegacyUnitTest
    {
        private ECS uut;
        private FakeTempSensor _fakeTempSensor;
        private FakeHeater _fakeHeater;
        [SetUp]
        public void SetUp()
        {
            _fakeHeater = new FakeHeater();
            _fakeTempSensor = new FakeTempSensor();
            int threshold = 28;
            uut = new ECS(threshold, _fakeTempSensor, _fakeHeater); 

            
        }
        // Test of ECS
        [TestCase(9,7, "Turned On\n")]
        public void Regulate_CorrectLogRes(int thresh, int temp,string logRes)
        {
            uut.SetThreshold(thresh);
            _fakeTempSensor.Temp = temp;

            uut.Regulate();
            Assert.That(_fakeHeater.Log.Log,Is.EqualTo(logRes));
        }


        
    }
}
